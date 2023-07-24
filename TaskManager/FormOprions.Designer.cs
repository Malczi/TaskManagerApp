namespace TaskManager
{
    partial class FormOprions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.brnMinimalize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlAddingNewData = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNewTaskCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNewNameWorker = new System.Windows.Forms.TextBox();
            this.tbNewSurnameWorker = new System.Windows.Forms.TextBox();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNewCategory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewLogin = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbNewSurname = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cbCategoryToDel = new System.Windows.Forms.ComboBox();
            this.cbWorkerToDel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.btnDelWorker = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAddingNewData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.brnMinimalize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskManager.Properties.Resources.control;
            this.pictureBox1.Location = new System.Drawing.Point(243, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 45);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ustawienia";
            // 
            // brnMinimalize
            // 
            this.brnMinimalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.brnMinimalize.FlatAppearance.BorderSize = 0;
            this.brnMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnMinimalize.Image = global::TaskManager.Properties.Resources.minimize;
            this.brnMinimalize.Location = new System.Drawing.Point(680, 0);
            this.brnMinimalize.Name = "brnMinimalize";
            this.brnMinimalize.Size = new System.Drawing.Size(60, 56);
            this.brnMinimalize.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(740, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 56);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAddingNewData
            // 
            this.pnlAddingNewData.Controls.Add(this.panel2);
            this.pnlAddingNewData.Controls.Add(this.label4);
            this.pnlAddingNewData.Controls.Add(this.label5);
            this.pnlAddingNewData.Controls.Add(this.tbNewCategory);
            this.pnlAddingNewData.Controls.Add(this.button1);
            this.pnlAddingNewData.Controls.Add(this.label3);
            this.pnlAddingNewData.Controls.Add(this.label2);
            this.pnlAddingNewData.Controls.Add(this.label1);
            this.pnlAddingNewData.Controls.Add(this.tbNewLogin);
            this.pnlAddingNewData.Controls.Add(this.tbNewName);
            this.pnlAddingNewData.Controls.Add(this.tbNewSurname);
            this.pnlAddingNewData.Controls.Add(this.btnAddTask);
            this.pnlAddingNewData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddingNewData.Location = new System.Drawing.Point(0, 56);
            this.pnlAddingNewData.Name = "pnlAddingNewData";
            this.pnlAddingNewData.Size = new System.Drawing.Size(800, 234);
            this.pnlAddingNewData.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbNewTaskCategory);
            this.panel2.Controls.Add(this.btnAddCategory);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbNewNameWorker);
            this.panel2.Controls.Add(this.tbNewSurnameWorker);
            this.panel2.Controls.Add(this.btnAddWorker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 234);
            this.panel2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 45);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dodawanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Kategoria:";
            // 
            // tbNewTaskCategory
            // 
            this.tbNewTaskCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewTaskCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewTaskCategory.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewTaskCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewTaskCategory.Location = new System.Drawing.Point(12, 166);
            this.tbNewTaskCategory.Multiline = true;
            this.tbNewTaskCategory.Name = "tbNewTaskCategory";
            this.tbNewTaskCategory.Size = new System.Drawing.Size(177, 37);
            this.tbNewTaskCategory.TabIndex = 23;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Image = global::TaskManager.Properties.Resources.addTask;
            this.btnAddCategory.Location = new System.Drawing.Point(496, 147);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(157, 74);
            this.btnAddCategory.TabIndex = 22;
            this.btnAddCategory.Text = "Dodaj kategorię";
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Imię:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nazwisko:";
            // 
            // tbNewNameWorker
            // 
            this.tbNewNameWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewNameWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewNameWorker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewNameWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewNameWorker.Location = new System.Drawing.Point(218, 87);
            this.tbNewNameWorker.Multiline = true;
            this.tbNewNameWorker.Name = "tbNewNameWorker";
            this.tbNewNameWorker.Size = new System.Drawing.Size(177, 37);
            this.tbNewNameWorker.TabIndex = 17;
            // 
            // tbNewSurnameWorker
            // 
            this.tbNewSurnameWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewSurnameWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewSurnameWorker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewSurnameWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewSurnameWorker.Location = new System.Drawing.Point(12, 87);
            this.tbNewSurnameWorker.Multiline = true;
            this.tbNewSurnameWorker.Name = "tbNewSurnameWorker";
            this.tbNewSurnameWorker.Size = new System.Drawing.Size(177, 37);
            this.tbNewSurnameWorker.TabIndex = 16;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddWorker.FlatAppearance.BorderSize = 0;
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Image = global::TaskManager.Properties.Resources.addTask;
            this.btnAddWorker.Location = new System.Drawing.Point(496, 68);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(157, 74);
            this.btnAddWorker.TabIndex = 15;
            this.btnAddWorker.Text = "Dodaj pracownika";
            this.btnAddWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 45);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dodawanie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kategoria:";
            // 
            // tbNewCategory
            // 
            this.tbNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewCategory.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewCategory.Location = new System.Drawing.Point(12, 166);
            this.tbNewCategory.Multiline = true;
            this.tbNewCategory.Name = "tbNewCategory";
            this.tbNewCategory.Size = new System.Drawing.Size(177, 37);
            this.tbNewCategory.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TaskManager.Properties.Resources.addTask;
            this.button1.Location = new System.Drawing.Point(631, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 74);
            this.button1.TabIndex = 22;
            this.button1.Text = "Dodaj kategorię";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "LoginStoart:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Imię:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nazwisko:";
            // 
            // tbNewLogin
            // 
            this.tbNewLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewLogin.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewLogin.Location = new System.Drawing.Point(427, 64);
            this.tbNewLogin.Multiline = true;
            this.tbNewLogin.Name = "tbNewLogin";
            this.tbNewLogin.Size = new System.Drawing.Size(177, 37);
            this.tbNewLogin.TabIndex = 18;
            // 
            // tbNewName
            // 
            this.tbNewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewName.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewName.Location = new System.Drawing.Point(218, 64);
            this.tbNewName.Multiline = true;
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(177, 37);
            this.tbNewName.TabIndex = 17;
            // 
            // tbNewSurname
            // 
            this.tbNewSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbNewSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewSurname.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbNewSurname.Location = new System.Drawing.Point(12, 64);
            this.tbNewSurname.Multiline = true;
            this.tbNewSurname.Name = "tbNewSurname";
            this.tbNewSurname.Size = new System.Drawing.Size(177, 37);
            this.tbNewSurname.TabIndex = 16;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Image = global::TaskManager.Properties.Resources.addTask;
            this.btnAddTask.Location = new System.Drawing.Point(631, 45);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(157, 74);
            this.btnAddTask.TabIndex = 15;
            this.btnAddTask.Text = "Dodaj pracownika";
            this.btnAddTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cbCategoryToDel);
            this.panel3.Controls.Add(this.cbWorkerToDel);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnDelCategory);
            this.panel3.Controls.Add(this.btnDelWorker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 234);
            this.panel3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Pracownik:";
            // 
            // cbCategoryToDel
            // 
            this.cbCategoryToDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbCategoryToDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoryToDel.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryToDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbCategoryToDel.FormattingEnabled = true;
            this.cbCategoryToDel.Location = new System.Drawing.Point(15, 173);
            this.cbCategoryToDel.Name = "cbCategoryToDel";
            this.cbCategoryToDel.Size = new System.Drawing.Size(301, 38);
            this.cbCategoryToDel.TabIndex = 31;
            // 
            // cbWorkerToDel
            // 
            this.cbWorkerToDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbWorkerToDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWorkerToDel.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerToDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbWorkerToDel.FormattingEnabled = true;
            this.cbWorkerToDel.Location = new System.Drawing.Point(15, 93);
            this.cbWorkerToDel.Name = "cbWorkerToDel";
            this.cbWorkerToDel.Size = new System.Drawing.Size(301, 38);
            this.cbWorkerToDel.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label12.Location = new System.Drawing.Point(8, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 45);
            this.label12.TabIndex = 27;
            this.label12.Text = "Usuwanie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Kategoria:";
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelCategory.FlatAppearance.BorderSize = 0;
            this.btnDelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCategory.Image = global::TaskManager.Properties.Resources.redbin;
            this.btnDelCategory.Location = new System.Drawing.Point(466, 152);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Size = new System.Drawing.Size(202, 74);
            this.btnDelCategory.TabIndex = 28;
            this.btnDelCategory.Text = "Usuń kategorię";
            this.btnDelCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelCategory.UseVisualStyleBackColor = true;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // btnDelWorker
            // 
            this.btnDelWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelWorker.FlatAppearance.BorderSize = 0;
            this.btnDelWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelWorker.Image = global::TaskManager.Properties.Resources.redbin;
            this.btnDelWorker.Location = new System.Drawing.Point(466, 72);
            this.btnDelWorker.Name = "btnDelWorker";
            this.btnDelWorker.Size = new System.Drawing.Size(202, 74);
            this.btnDelWorker.TabIndex = 25;
            this.btnDelWorker.Text = "Usuń pracownika";
            this.btnDelWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelWorker.UseVisualStyleBackColor = true;
            this.btnDelWorker.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormOprions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlAddingNewData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOprions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAddingNewData.ResumeLayout(false);
            this.pnlAddingNewData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button brnMinimalize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlAddingNewData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNewTaskCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNewNameWorker;
        private System.Windows.Forms.TextBox tbNewSurnameWorker;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNewCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewLogin;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.TextBox tbNewSurname;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelCategory;
        private System.Windows.Forms.Button btnDelWorker;
        private System.Windows.Forms.ComboBox cbWorkerToDel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCategoryToDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}