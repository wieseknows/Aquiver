namespace Aquiver.Forms {
    partial class Form_LearnMoreTask {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.acceptedProgressBar_label = new System.Windows.Forms.Label();
            this.endTimeProgressBar_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.note_label = new System.Windows.Forms.Label();
            this.issuedIn_label = new System.Windows.Forms.Label();
            this.accepted_label = new System.Windows.Forms.Label();
            this.leadTime_label = new System.Windows.Forms.Label();
            this.done_label = new System.Windows.Forms.Label();
            this.difficulity_label = new System.Windows.Forms.Label();
            this.worker_label = new System.Windows.Forms.Label();
            this.titleValue_label = new System.Windows.Forms.Label();
            this.issuedInValue_label = new System.Windows.Forms.Label();
            this.acceptedValue_label = new System.Windows.Forms.Label();
            this.leadTimeValue_label = new System.Windows.Forms.Label();
            this.doneValue_label = new System.Windows.Forms.Label();
            this.difficulityValue_progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.workerValue_label = new System.Windows.Forms.Label();
            this.progress_panel = new MetroFramework.Controls.MetroPanel();
            this.noteValue_textBox = new System.Windows.Forms.RichTextBox();
            this.acceptTask_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.markAsDone_button = new MaterialSkin.Controls.MaterialFlatButton();
            this.progress_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Location = new System.Drawing.Point(6, 28);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(255, 23);
            this.metroProgressBar.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar.TabIndex = 2;
            this.metroProgressBar.Value = 60;
            // 
            // acceptedProgressBar_label
            // 
            this.acceptedProgressBar_label.AutoSize = true;
            this.acceptedProgressBar_label.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedProgressBar_label.Location = new System.Drawing.Point(3, 11);
            this.acceptedProgressBar_label.Name = "acceptedProgressBar_label";
            this.acceptedProgressBar_label.Size = new System.Drawing.Size(66, 14);
            this.acceptedProgressBar_label.TabIndex = 3;
            this.acceptedProgressBar_label.Text = "Accepted In";
            // 
            // endTimeProgressBar_label
            // 
            this.endTimeProgressBar_label.AutoSize = true;
            this.endTimeProgressBar_label.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeProgressBar_label.Location = new System.Drawing.Point(211, 11);
            this.endTimeProgressBar_label.Name = "endTimeProgressBar_label";
            this.endTimeProgressBar_label.Size = new System.Drawing.Size(54, 14);
            this.endTimeProgressBar_label.TabIndex = 3;
            this.endTimeProgressBar_label.Text = "End Time";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(44, 75);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(40, 18);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Title: ";
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.note_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_label.Location = new System.Drawing.Point(41, 100);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(43, 18);
            this.note_label.TabIndex = 3;
            this.note_label.Text = "Note: ";
            // 
            // issuedIn_label
            // 
            this.issuedIn_label.AutoSize = true;
            this.issuedIn_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issuedIn_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedIn_label.Location = new System.Drawing.Point(16, 169);
            this.issuedIn_label.Name = "issuedIn_label";
            this.issuedIn_label.Size = new System.Drawing.Size(68, 18);
            this.issuedIn_label.TabIndex = 3;
            this.issuedIn_label.Text = "Issued In: ";
            // 
            // accepted_label
            // 
            this.accepted_label.AutoSize = true;
            this.accepted_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accepted_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accepted_label.Location = new System.Drawing.Point(14, 194);
            this.accepted_label.Name = "accepted_label";
            this.accepted_label.Size = new System.Drawing.Size(70, 18);
            this.accepted_label.TabIndex = 3;
            this.accepted_label.Text = "Accepted: ";
            // 
            // leadTime_label
            // 
            this.leadTime_label.AutoSize = true;
            this.leadTime_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leadTime_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadTime_label.Location = new System.Drawing.Point(9, 219);
            this.leadTime_label.Name = "leadTime_label";
            this.leadTime_label.Size = new System.Drawing.Size(75, 18);
            this.leadTime_label.TabIndex = 3;
            this.leadTime_label.Text = "Lead TIme: ";
            // 
            // done_label
            // 
            this.done_label.AutoSize = true;
            this.done_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.done_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_label.Location = new System.Drawing.Point(39, 244);
            this.done_label.Name = "done_label";
            this.done_label.Size = new System.Drawing.Size(45, 18);
            this.done_label.TabIndex = 3;
            this.done_label.Text = "Done: ";
            // 
            // difficulity_label
            // 
            this.difficulity_label.AutoSize = true;
            this.difficulity_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.difficulity_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulity_label.Location = new System.Drawing.Point(13, 269);
            this.difficulity_label.Name = "difficulity_label";
            this.difficulity_label.Size = new System.Drawing.Size(71, 18);
            this.difficulity_label.TabIndex = 3;
            this.difficulity_label.Text = "Difficulity: ";
            // 
            // worker_label
            // 
            this.worker_label.AutoSize = true;
            this.worker_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.worker_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker_label.Location = new System.Drawing.Point(27, 294);
            this.worker_label.Name = "worker_label";
            this.worker_label.Size = new System.Drawing.Size(57, 18);
            this.worker_label.TabIndex = 3;
            this.worker_label.Text = "Worker: ";
            // 
            // titleValue_label
            // 
            this.titleValue_label.AutoSize = true;
            this.titleValue_label.BackColor = System.Drawing.SystemColors.Control;
            this.titleValue_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleValue_label.Location = new System.Drawing.Point(90, 76);
            this.titleValue_label.Name = "titleValue_label";
            this.titleValue_label.Size = new System.Drawing.Size(41, 17);
            this.titleValue_label.TabIndex = 3;
            this.titleValue_label.Text = "value ";
            // 
            // issuedInValue_label
            // 
            this.issuedInValue_label.AutoSize = true;
            this.issuedInValue_label.BackColor = System.Drawing.SystemColors.Control;
            this.issuedInValue_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedInValue_label.Location = new System.Drawing.Point(90, 170);
            this.issuedInValue_label.Name = "issuedInValue_label";
            this.issuedInValue_label.Size = new System.Drawing.Size(41, 17);
            this.issuedInValue_label.TabIndex = 3;
            this.issuedInValue_label.Text = "value ";
            // 
            // acceptedValue_label
            // 
            this.acceptedValue_label.AutoSize = true;
            this.acceptedValue_label.BackColor = System.Drawing.SystemColors.Control;
            this.acceptedValue_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedValue_label.Location = new System.Drawing.Point(90, 195);
            this.acceptedValue_label.Name = "acceptedValue_label";
            this.acceptedValue_label.Size = new System.Drawing.Size(41, 17);
            this.acceptedValue_label.TabIndex = 3;
            this.acceptedValue_label.Text = "value ";
            // 
            // leadTimeValue_label
            // 
            this.leadTimeValue_label.AutoSize = true;
            this.leadTimeValue_label.BackColor = System.Drawing.SystemColors.Control;
            this.leadTimeValue_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadTimeValue_label.Location = new System.Drawing.Point(90, 220);
            this.leadTimeValue_label.Name = "leadTimeValue_label";
            this.leadTimeValue_label.Size = new System.Drawing.Size(41, 17);
            this.leadTimeValue_label.TabIndex = 3;
            this.leadTimeValue_label.Text = "value ";
            // 
            // doneValue_label
            // 
            this.doneValue_label.AutoSize = true;
            this.doneValue_label.BackColor = System.Drawing.SystemColors.Control;
            this.doneValue_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneValue_label.Location = new System.Drawing.Point(90, 245);
            this.doneValue_label.Name = "doneValue_label";
            this.doneValue_label.Size = new System.Drawing.Size(41, 17);
            this.doneValue_label.TabIndex = 3;
            this.doneValue_label.Text = "value ";
            // 
            // difficulityValue_progressBar
            // 
            this.difficulityValue_progressBar.Depth = 0;
            this.difficulityValue_progressBar.Location = new System.Drawing.Point(93, 276);
            this.difficulityValue_progressBar.Maximum = 10;
            this.difficulityValue_progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.difficulityValue_progressBar.Name = "difficulityValue_progressBar";
            this.difficulityValue_progressBar.Size = new System.Drawing.Size(100, 5);
            this.difficulityValue_progressBar.Step = 1;
            this.difficulityValue_progressBar.TabIndex = 4;
            // 
            // workerValue_label
            // 
            this.workerValue_label.AutoSize = true;
            this.workerValue_label.BackColor = System.Drawing.SystemColors.Control;
            this.workerValue_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerValue_label.Location = new System.Drawing.Point(90, 295);
            this.workerValue_label.Name = "workerValue_label";
            this.workerValue_label.Size = new System.Drawing.Size(41, 17);
            this.workerValue_label.TabIndex = 3;
            this.workerValue_label.Text = "value ";
            // 
            // progress_panel
            // 
            this.progress_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progress_panel.Controls.Add(this.endTimeProgressBar_label);
            this.progress_panel.Controls.Add(this.acceptedProgressBar_label);
            this.progress_panel.Controls.Add(this.metroProgressBar);
            this.progress_panel.HorizontalScrollbarBarColor = true;
            this.progress_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.progress_panel.HorizontalScrollbarSize = 10;
            this.progress_panel.Location = new System.Drawing.Point(15, 326);
            this.progress_panel.Name = "progress_panel";
            this.progress_panel.Size = new System.Drawing.Size(278, 73);
            this.progress_panel.TabIndex = 5;
            this.progress_panel.VerticalScrollbarBarColor = true;
            this.progress_panel.VerticalScrollbarHighlightOnWheel = false;
            this.progress_panel.VerticalScrollbarSize = 10;
            // 
            // noteValue_textBox
            // 
            this.noteValue_textBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteValue_textBox.Location = new System.Drawing.Point(90, 102);
            this.noteValue_textBox.Name = "noteValue_textBox";
            this.noteValue_textBox.ReadOnly = true;
            this.noteValue_textBox.Size = new System.Drawing.Size(203, 65);
            this.noteValue_textBox.TabIndex = 6;
            this.noteValue_textBox.Text = "";
            // 
            // acceptTask_button
            // 
            this.acceptTask_button.AutoSize = true;
            this.acceptTask_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.acceptTask_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptTask_button.Depth = 0;
            this.acceptTask_button.Icon = global::Aquiver.Properties.Resources.forward;
            this.acceptTask_button.Location = new System.Drawing.Point(17, 331);
            this.acceptTask_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptTask_button.Name = "acceptTask_button";
            this.acceptTask_button.Primary = true;
            this.acceptTask_button.Size = new System.Drawing.Size(139, 36);
            this.acceptTask_button.TabIndex = 7;
            this.acceptTask_button.Text = "Accept Task";
            this.acceptTask_button.UseVisualStyleBackColor = true;
            this.acceptTask_button.Visible = false;
            this.acceptTask_button.Click += new System.EventHandler(this.acceptTask_button_Click);
            // 
            // markAsDone_button
            // 
            this.markAsDone_button.AutoSize = true;
            this.markAsDone_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.markAsDone_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markAsDone_button.Depth = 0;
            this.markAsDone_button.Icon = null;
            this.markAsDone_button.Location = new System.Drawing.Point(24, 382);
            this.markAsDone_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.markAsDone_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.markAsDone_button.Name = "markAsDone_button";
            this.markAsDone_button.Primary = false;
            this.markAsDone_button.Size = new System.Drawing.Size(120, 36);
            this.markAsDone_button.TabIndex = 8;
            this.markAsDone_button.Text = "Mark As done";
            this.markAsDone_button.UseVisualStyleBackColor = true;
            this.markAsDone_button.Visible = false;
            this.markAsDone_button.Click += new System.EventHandler(this.markAsDone_button_Click);
            // 
            // Form_LearnMoreTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 389);
            this.Controls.Add(this.markAsDone_button);
            this.Controls.Add(this.acceptTask_button);
            this.Controls.Add(this.noteValue_textBox);
            this.Controls.Add(this.progress_panel);
            this.Controls.Add(this.difficulityValue_progressBar);
            this.Controls.Add(this.worker_label);
            this.Controls.Add(this.difficulity_label);
            this.Controls.Add(this.done_label);
            this.Controls.Add(this.leadTime_label);
            this.Controls.Add(this.accepted_label);
            this.Controls.Add(this.issuedIn_label);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.workerValue_label);
            this.Controls.Add(this.doneValue_label);
            this.Controls.Add(this.leadTimeValue_label);
            this.Controls.Add(this.acceptedValue_label);
            this.Controls.Add(this.issuedInValue_label);
            this.Controls.Add(this.titleValue_label);
            this.Controls.Add(this.title_label);
            this.Name = "Form_LearnMoreTask";
            this.Text = "Learn More";
            this.Load += new System.EventHandler(this.Form_LearnMoreTask_Load);
            this.progress_panel.ResumeLayout(false);
            this.progress_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.Label acceptedProgressBar_label;
        private System.Windows.Forms.Label endTimeProgressBar_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label issuedIn_label;
        private System.Windows.Forms.Label accepted_label;
        private System.Windows.Forms.Label leadTime_label;
        private System.Windows.Forms.Label done_label;
        private System.Windows.Forms.Label difficulity_label;
        private System.Windows.Forms.Label worker_label;
        private System.Windows.Forms.Label titleValue_label;
        private System.Windows.Forms.Label issuedInValue_label;
        private System.Windows.Forms.Label acceptedValue_label;
        private System.Windows.Forms.Label leadTimeValue_label;
        private System.Windows.Forms.Label doneValue_label;
        private MaterialSkin.Controls.MaterialProgressBar difficulityValue_progressBar;
        private System.Windows.Forms.Label workerValue_label;
        private MetroFramework.Controls.MetroPanel progress_panel;
        private System.Windows.Forms.RichTextBox noteValue_textBox;
        public MaterialSkin.Controls.MaterialFlatButton markAsDone_button;
        public MaterialSkin.Controls.MaterialRaisedButton acceptTask_button;
    }
}