using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquiver.Classes;
using MetroFramework.Components;

namespace Aquiver.Forms {
    public partial class Form_Storage : MaterialSkin.Controls.MaterialForm {

        MetroToolTip noResults_toolTip = new MetroToolTip();

        public Form_Storage() {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();

            string sqlQuery = "select * from storage ";

            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommmand.ExecuteReader();

            if (reader.HasRows) {
                storage.Rows.Clear();
                while (reader.Read()) {
                    int i = storage.Rows.Add();
                    Worker worker = new Worker();
                    worker.experience = reader.GetString("worker_experience");
                    worker.mobile_number = reader.GetString("worker_mobile_number");

                    storage.Rows[i].Cells[0].Value = reader.GetString("worker_name");
                    storage.Rows[i].Cells[1].Value = worker.GetExperience();
                    storage.Rows[i].Cells[2].Value = worker.mobile_number;
                    storage.Rows[i].Cells[3].Value = reader.GetString("task_title");
                    storage.Rows[i].Cells[4].Value = reader.GetString("done_in") == Globals.Analysis.DefaultDateTime.ToString() ? "No" : reader.GetString("done_in");
                }
            }
            connection.Close();
        }
        
        private void search_textBox_TextChanged(object sender, EventArgs e) {
            bool result = false;
            if (String.IsNullOrEmpty(search_textBox.Text)) {
                foreach (DataGridViewRow row in storage.Rows)
                    row.DefaultCellStyle.BackColor = Color.White;
                return;
            }
            foreach (DataGridViewRow row in storage.Rows) {
                row.DefaultCellStyle.BackColor = Color.White;
                foreach (DataGridViewCell cell in row.Cells)
                    if (!string.IsNullOrEmpty(cell.Value as string))
                        if (cell.Value.ToString().IndexOf(search_textBox.Text, StringComparison.OrdinalIgnoreCase) >= 0) {
                            row.DefaultCellStyle.BackColor = Color.SpringGreen;
                            result = true;
                        }
            }
            if (!result) noResults_toolTip.Show("No results", search_pictureBox);
            else noResults_toolTip.Hide(search_pictureBox);
        }
    }
}