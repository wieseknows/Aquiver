select tasks.*, workers.fname, workers.lname
from tasks join workers on tasks.worker_id = workers.id
           join users on workers.chief_id = users.id
           