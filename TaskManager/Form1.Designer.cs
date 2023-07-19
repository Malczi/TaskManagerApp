namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnConfirmed = new System.Windows.Forms.Button();
            this.btnTesting = new System.Windows.Forms.Button();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.btnAdded = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoginAs = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.brnMinimalize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlAddNewTask = new System.Windows.Forms.Panel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNewTaskPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNewTaskWorker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNewTaskCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewTaskDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTaskDetails = new System.Windows.Forms.Panel();
            this.btnDelTask = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSelectedStatus = new System.Windows.Forms.ComboBox();
            this.btnPushChanges = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTaskFrom = new System.Windows.Forms.Label();
            this.cbSelectedTaskPriority = new System.Windows.Forms.ComboBox();
            this.lblDateOfTask = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTaskNumber = new System.Windows.Forms.Label();
            this.cbSelectedTaskCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSelectedTaskDescription = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSearcgingTask = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSearchingPriority = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSearchingWorker = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlAddNewTask.SuspendLayout();
            this.pnlTaskDetails.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlSearcgingTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnConfirmed);
            this.pnlMenu.Controls.Add(this.btnTesting);
            this.pnlMenu.Controls.Add(this.btnInProgress);
            this.pnlMenu.Controls.Add(this.btnAdded);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(238, 977);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::TaskManager.Properties.Resources.control;
            this.btnSettings.Location = new System.Drawing.Point(0, 915);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(238, 62);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Options";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnConfirmed
            // 
            this.btnConfirmed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirmed.FlatAppearance.BorderSize = 0;
            this.btnConfirmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmed.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConfirmed.Image = global::TaskManager.Properties.Resources.approved;
            this.btnConfirmed.Location = new System.Drawing.Point(0, 393);
            this.btnConfirmed.Name = "btnConfirmed";
            this.btnConfirmed.Size = new System.Drawing.Size(238, 62);
            this.btnConfirmed.TabIndex = 1;
            this.btnConfirmed.Text = "Confirmed";
            this.btnConfirmed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmed.UseVisualStyleBackColor = true;
            this.btnConfirmed.Click += new System.EventHandler(this.btnConfirmed_Click);
            // 
            // btnTesting
            // 
            this.btnTesting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTesting.FlatAppearance.BorderSize = 0;
            this.btnTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesting.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTesting.Image = global::TaskManager.Properties.Resources.testing;
            this.btnTesting.Location = new System.Drawing.Point(0, 331);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(238, 62);
            this.btnTesting.TabIndex = 1;
            this.btnTesting.Text = "Testing";
            this.btnTesting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // btnInProgress
            // 
            this.btnInProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInProgress.FlatAppearance.BorderSize = 0;
            this.btnInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInProgress.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInProgress.Image = global::TaskManager.Properties.Resources.work_in_progress;
            this.btnInProgress.Location = new System.Drawing.Point(0, 269);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(238, 62);
            this.btnInProgress.TabIndex = 1;
            this.btnInProgress.Text = "In Progress";
            this.btnInProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInProgress.UseVisualStyleBackColor = true;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // btnAdded
            // 
            this.btnAdded.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdded.FlatAppearance.BorderSize = 0;
            this.btnAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdded.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAdded.Image = global::TaskManager.Properties.Resources.toDo;
            this.btnAdded.Location = new System.Drawing.Point(0, 207);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(238, 62);
            this.btnAdded.TabIndex = 1;
            this.btnAdded.Text = "Added";
            this.btnAdded.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHome.Image = global::TaskManager.Properties.Resources.home_button__2_;
            this.btnHome.Location = new System.Drawing.Point(0, 145);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(238, 62);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblAppName);
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(238, 145);
            this.pnlUser.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAppName.Location = new System.Drawing.Point(24, 90);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(143, 28);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Task Manager";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.AutoSize = true;
            this.lblLoginAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoginAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblLoginAs.Location = new System.Drawing.Point(6, 16);
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Size = new System.Drawing.Size(91, 20);
            this.lblLoginAs.TabIndex = 1;
            this.lblLoginAs.Text = "username";
            this.lblLoginAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblLoginAs);
            this.pnlTop.Controls.Add(this.brnMinimalize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(238, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1425, 56);
            this.pnlTop.TabIndex = 1;
            // 
            // brnMinimalize
            // 
            this.brnMinimalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.brnMinimalize.FlatAppearance.BorderSize = 0;
            this.brnMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnMinimalize.Image = global::TaskManager.Properties.Resources.minimize;
            this.brnMinimalize.Location = new System.Drawing.Point(1305, 0);
            this.brnMinimalize.Name = "brnMinimalize";
            this.brnMinimalize.Size = new System.Drawing.Size(60, 56);
            this.brnMinimalize.TabIndex = 2;
            this.brnMinimalize.UseVisualStyleBackColor = true;
            this.brnMinimalize.Click += new System.EventHandler(this.brnMinimalize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TaskManager.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1365, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 56);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAddNewTask
            // 
            this.pnlAddNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlAddNewTask.Controls.Add(this.btnAddTask);
            this.pnlAddNewTask.Controls.Add(this.label6);
            this.pnlAddNewTask.Controls.Add(this.cbNewTaskPriority);
            this.pnlAddNewTask.Controls.Add(this.label4);
            this.pnlAddNewTask.Controls.Add(this.cbNewTaskWorker);
            this.pnlAddNewTask.Controls.Add(this.label3);
            this.pnlAddNewTask.Controls.Add(this.cbNewTaskCategory);
            this.pnlAddNewTask.Controls.Add(this.label2);
            this.pnlAddNewTask.Controls.Add(this.tbNewTaskDescription);
            this.pnlAddNewTask.Controls.Add(this.label1);
            this.pnlAddNewTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddNewTask.Location = new System.Drawing.Point(238, 56);
            this.pnlAddNewTask.Name = "pnlAddNewTask";
            this.pnlAddNewTask.Size = new System.Drawing.Size(1425, 232);
            this.pnlAddNewTask.TabIndex = 2;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Image = global::TaskManager.Properties.Resources.addTask;
            this.btnAddTask.Location = new System.Drawing.Point(1132, 148);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(94, 73);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(857, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Priority:";
            // 
            // cbNewTaskPriority
            // 
            this.cbNewTaskPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbNewTaskPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNewTaskPriority.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewTaskPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbNewTaskPriority.FormattingEnabled = true;
            this.cbNewTaskPriority.Location = new System.Drawing.Point(862, 176);
            this.cbNewTaskPriority.Name = "cbNewTaskPriority";
            this.cbNewTaskPriority.Size = new System.Drawing.Size(192, 38);
            this.cbNewTaskPriority.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1080, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Worker:";
            // 
            // cbNewTaskWorker
            // 
            this.cbNewTaskWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbNewTaskWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNewTaskWorker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewTaskWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbNewTaskWorker.FormattingEnabled = true;
            this.cbNewTaskWorker.Location = new System.Drawing.Point(1085, 100);
            this.cbNewTaskWorker.Name = "cbNewTaskWorker";
            this.cbNewTaskWorker.Size = new System.Drawing.Size(192, 38);
            this.cbNewTaskWorker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(857, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Task category:";
            // 
            // cbNewTaskCategory
            // 
            this.cbNewTaskCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbNewTaskCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNewTaskCategory.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewTaskCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbNewTaskCategory.FormattingEnabled = true;
            this.cbNewTaskCategory.Location = new System.Drawing.Point(862, 100);
            this.cbNewTaskCategory.Name = "cbNewTaskCategory";
            this.cbNewTaskCategory.Size = new System.Drawing.Size(192, 38);
            this.cbNewTaskCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task description:";
            // 
            // tbNewTaskDescription
            // 
            this.tbNewTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewTaskDescription.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewTaskDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewTaskDescription.Location = new System.Drawing.Point(10, 100);
            this.tbNewTaskDescription.Multiline = true;
            this.tbNewTaskDescription.Name = "tbNewTaskDescription";
            this.tbNewTaskDescription.Size = new System.Drawing.Size(822, 114);
            this.tbNewTaskDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Task";
            // 
            // pnlTaskDetails
            // 
            this.pnlTaskDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(127)))));
            this.pnlTaskDetails.Controls.Add(this.btnDelTask);
            this.pnlTaskDetails.Controls.Add(this.label10);
            this.pnlTaskDetails.Controls.Add(this.cbSelectedStatus);
            this.pnlTaskDetails.Controls.Add(this.btnPushChanges);
            this.pnlTaskDetails.Controls.Add(this.label7);
            this.pnlTaskDetails.Controls.Add(this.lblTaskFrom);
            this.pnlTaskDetails.Controls.Add(this.cbSelectedTaskPriority);
            this.pnlTaskDetails.Controls.Add(this.lblDateOfTask);
            this.pnlTaskDetails.Controls.Add(this.label8);
            this.pnlTaskDetails.Controls.Add(this.lblTaskNumber);
            this.pnlTaskDetails.Controls.Add(this.cbSelectedTaskCategory);
            this.pnlTaskDetails.Controls.Add(this.label5);
            this.pnlTaskDetails.Controls.Add(this.tbSelectedTaskDescription);
            this.pnlTaskDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskDetails.Location = new System.Drawing.Point(238, 288);
            this.pnlTaskDetails.Name = "pnlTaskDetails";
            this.pnlTaskDetails.Size = new System.Drawing.Size(1425, 207);
            this.pnlTaskDetails.TabIndex = 3;
            // 
            // btnDelTask
            // 
            this.btnDelTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelTask.FlatAppearance.BorderSize = 0;
            this.btnDelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTask.Image = global::TaskManager.Properties.Resources.deleteTask;
            this.btnDelTask.Location = new System.Drawing.Point(639, 127);
            this.btnDelTask.Name = "btnDelTask";
            this.btnDelTask.Size = new System.Drawing.Size(86, 70);
            this.btnDelTask.TabIndex = 15;
            this.btnDelTask.UseVisualStyleBackColor = true;
            this.btnDelTask.Click += new System.EventHandler(this.btnDelTask_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1080, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Status:";
            // 
            // cbSelectedStatus
            // 
            this.cbSelectedStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSelectedStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedStatus.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectedStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSelectedStatus.FormattingEnabled = true;
            this.cbSelectedStatus.Location = new System.Drawing.Point(1085, 83);
            this.cbSelectedStatus.Name = "cbSelectedStatus";
            this.cbSelectedStatus.Size = new System.Drawing.Size(192, 38);
            this.cbSelectedStatus.TabIndex = 13;
            // 
            // btnPushChanges
            // 
            this.btnPushChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPushChanges.FlatAppearance.BorderSize = 0;
            this.btnPushChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushChanges.Image = global::TaskManager.Properties.Resources.push_white;
            this.btnPushChanges.Location = new System.Drawing.Point(1305, 64);
            this.btnPushChanges.Name = "btnPushChanges";
            this.btnPushChanges.Size = new System.Drawing.Size(97, 71);
            this.btnPushChanges.TabIndex = 9;
            this.btnPushChanges.UseVisualStyleBackColor = true;
            this.btnPushChanges.Click += new System.EventHandler(this.btnPushChanges_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(857, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Priority:";
            // 
            // lblTaskFrom
            // 
            this.lblTaskFrom.AutoSize = true;
            this.lblTaskFrom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTaskFrom.Location = new System.Drawing.Point(960, 13);
            this.lblTaskFrom.Name = "lblTaskFrom";
            this.lblTaskFrom.Size = new System.Drawing.Size(65, 28);
            this.lblTaskFrom.TabIndex = 9;
            this.lblTaskFrom.Text = "From:";
            this.lblTaskFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectedTaskPriority
            // 
            this.cbSelectedTaskPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSelectedTaskPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedTaskPriority.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectedTaskPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSelectedTaskPriority.FormattingEnabled = true;
            this.cbSelectedTaskPriority.Location = new System.Drawing.Point(862, 83);
            this.cbSelectedTaskPriority.Name = "cbSelectedTaskPriority";
            this.cbSelectedTaskPriority.Size = new System.Drawing.Size(192, 38);
            this.cbSelectedTaskPriority.TabIndex = 11;
            // 
            // lblDateOfTask
            // 
            this.lblDateOfTask.AutoSize = true;
            this.lblDateOfTask.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblDateOfTask.Location = new System.Drawing.Point(531, 13);
            this.lblDateOfTask.Name = "lblDateOfTask";
            this.lblDateOfTask.Size = new System.Drawing.Size(134, 28);
            this.lblDateOfTask.TabIndex = 8;
            this.lblDateOfTask.Text = "Date of task:";
            this.lblDateOfTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(634, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Task category:";
            // 
            // lblTaskNumber
            // 
            this.lblTaskNumber.AutoSize = true;
            this.lblTaskNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTaskNumber.Location = new System.Drawing.Point(278, 13);
            this.lblTaskNumber.Name = "lblTaskNumber";
            this.lblTaskNumber.Size = new System.Drawing.Size(138, 28);
            this.lblTaskNumber.TabIndex = 2;
            this.lblTaskNumber.Text = "Task number:";
            this.lblTaskNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectedTaskCategory
            // 
            this.cbSelectedTaskCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSelectedTaskCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedTaskCategory.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectedTaskCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSelectedTaskCategory.FormattingEnabled = true;
            this.cbSelectedTaskCategory.Location = new System.Drawing.Point(639, 83);
            this.cbSelectedTaskCategory.Name = "cbSelectedTaskCategory";
            this.cbSelectedTaskCategory.Size = new System.Drawing.Size(192, 38);
            this.cbSelectedTaskCategory.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selected Task";
            // 
            // tbSelectedTaskDescription
            // 
            this.tbSelectedTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbSelectedTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSelectedTaskDescription.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSelectedTaskDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbSelectedTaskDescription.Location = new System.Drawing.Point(10, 47);
            this.tbSelectedTaskDescription.Multiline = true;
            this.tbSelectedTaskDescription.Name = "tbSelectedTaskDescription";
            this.tbSelectedTaskDescription.Size = new System.Drawing.Size(608, 147);
            this.tbSelectedTaskDescription.TabIndex = 7;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblTime);
            this.pnlBottom.Controls.Add(this.pictureBox2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(238, 921);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1425, 56);
            this.pnlBottom.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.lblTime.Location = new System.Drawing.Point(1281, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 23);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TaskManager.Properties.Resources.clock31;
            this.pictureBox2.Location = new System.Drawing.Point(1369, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlSearcgingTask
            // 
            this.pnlSearcgingTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.pnlSearcgingTask.Controls.Add(this.label11);
            this.pnlSearcgingTask.Controls.Add(this.cbSearchingPriority);
            this.pnlSearcgingTask.Controls.Add(this.label9);
            this.pnlSearcgingTask.Controls.Add(this.cbSearchingWorker);
            this.pnlSearcgingTask.Controls.Add(this.btnSearch);
            this.pnlSearcgingTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearcgingTask.Location = new System.Drawing.Point(238, 495);
            this.pnlSearcgingTask.Name = "pnlSearcgingTask";
            this.pnlSearcgingTask.Size = new System.Drawing.Size(1425, 91);
            this.pnlSearcgingTask.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(300, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "Priority:";
            // 
            // cbSearchingPriority
            // 
            this.cbSearchingPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSearchingPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchingPriority.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchingPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSearchingPriority.FormattingEnabled = true;
            this.cbSearchingPriority.Location = new System.Drawing.Point(305, 44);
            this.cbSearchingPriority.Name = "cbSearchingPriority";
            this.cbSearchingPriority.Size = new System.Drawing.Size(192, 38);
            this.cbSearchingPriority.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(76, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Worker:";
            // 
            // cbSearchingWorker
            // 
            this.cbSearchingWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSearchingWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchingWorker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchingWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSearchingWorker.FormattingEnabled = true;
            this.cbSearchingWorker.Location = new System.Drawing.Point(81, 45);
            this.cbSearchingWorker.Name = "cbSearchingWorker";
            this.cbSearchingWorker.Size = new System.Drawing.Size(192, 38);
            this.cbSearchingWorker.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::TaskManager.Properties.Resources.search_glas;
            this.btnSearch.Location = new System.Drawing.Point(524, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToOrderColumns = true;
            this.dgvTasks.AllowUserToResizeColumns = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasks.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTasks.EnableHeadersVisualStyles = false;
            this.dgvTasks.Location = new System.Drawing.Point(238, 586);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(1425, 336);
            this.dgvTasks.TabIndex = 7;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1663, 977);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.pnlSearcgingTask);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTaskDetails);
            this.Controls.Add(this.pnlAddNewTask);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlAddNewTask.ResumeLayout(false);
            this.pnlAddNewTask.PerformLayout();
            this.pnlTaskDetails.ResumeLayout(false);
            this.pnlTaskDetails.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlSearcgingTask.ResumeLayout(false);
            this.pnlSearcgingTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblLoginAs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnConfirmed;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button brnMinimalize;
        private System.Windows.Forms.Panel pnlAddNewTask;
        private System.Windows.Forms.Panel pnlTaskDetails;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewTaskDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNewTaskCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNewTaskWorker;
        private System.Windows.Forms.Label lblTaskNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSelectedTaskDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNewTaskPriority;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTaskFrom;
        private System.Windows.Forms.ComboBox cbSelectedTaskPriority;
        private System.Windows.Forms.Label lblDateOfTask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSelectedTaskCategory;
        private System.Windows.Forms.Panel pnlSearcgingTask;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnPushChanges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSelectedStatus;
        private System.Windows.Forms.Button btnDelTask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSearchingWorker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSearchingPriority;
    }
}

