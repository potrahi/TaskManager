namespace TaskProjectVSB
{
    partial class TaskProject
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.userNameLable = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveFileasXMLbutton = new System.Windows.Forms.Button();
            this.loadProjectFileFromXML = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.typeLable = new System.Windows.Forms.Label();
            this.taskDetailsLable = new System.Windows.Forms.Label();
            this.addEditTaskDetailsLable = new System.Windows.Forms.Label();
            this.deadlineLable = new System.Windows.Forms.Label();
            this.startlineLable = new System.Windows.Forms.Label();
            this.taskNameLable = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.completeCheckBox = new System.Windows.Forms.CheckBox();
            this.minutesLable = new System.Windows.Forms.Label();
            this.startLineDateTime = new System.Windows.Forms.DateTimePicker();
            this.deadLineDateTime = new System.Windows.Forms.DateTimePicker();
            this.todayDate = new System.Windows.Forms.Label();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(185, 77);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(201, 33);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(559, 77);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(201, 33);
            this.typeTextBox.TabIndex = 3;
            this.typeTextBox.TextChanged += new System.EventHandler(this.typeTextBox_TextChanged);
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.AutoSize = true;
            this.todayDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDateLabel.Location = new System.Drawing.Point(49, 28);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(114, 25);
            this.todayDateLabel.TabIndex = 4;
            this.todayDateLabel.Text = "Today Date :";
            this.todayDateLabel.Click += new System.EventHandler(this.todayDateLable_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(363, 280);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 32);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(257, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 32);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLable.Location = new System.Drawing.Point(49, 80);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(114, 25);
            this.userNameLable.TabIndex = 9;
            this.userNameLable.Text = "User Name :";
            this.userNameLable.Click += new System.EventHandler(this.userNameLable_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.minutes,
            this.Column1,
            this.Column3,
            this.Complite});
            this.dataGridView.Location = new System.Drawing.Point(17, 318);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(796, 160);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_2);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.Width = 250;
            // 
            // minutes
            // 
            this.minutes.HeaderText = "Minutes";
            this.minutes.Name = "minutes";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Startline";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deadline";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Complite
            // 
            this.Complite.HeaderText = "Complite";
            this.Complite.Name = "Complite";
            // 
            // saveFileasXMLbutton
            // 
            this.saveFileasXMLbutton.Location = new System.Drawing.Point(13, 484);
            this.saveFileasXMLbutton.Name = "saveFileasXMLbutton";
            this.saveFileasXMLbutton.Size = new System.Drawing.Size(132, 44);
            this.saveFileasXMLbutton.TabIndex = 11;
            this.saveFileasXMLbutton.Text = "Save File As XML";
            this.saveFileasXMLbutton.UseVisualStyleBackColor = true;
            this.saveFileasXMLbutton.Click += new System.EventHandler(this.saveFileasXMLButton_Click);
            // 
            // loadProjectFileFromXML
            // 
            this.loadProjectFileFromXML.Location = new System.Drawing.Point(631, 484);
            this.loadProjectFileFromXML.Name = "loadProjectFileFromXML";
            this.loadProjectFileFromXML.Size = new System.Drawing.Size(182, 44);
            this.loadProjectFileFromXML.TabIndex = 12;
            this.loadProjectFileFromXML.Text = "Load Project File From XML";
            this.loadProjectFileFromXML.UseVisualStyleBackColor = true;
            this.loadProjectFileFromXML.Click += new System.EventHandler(this.loadProjectFileFromXMLButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(477, 280);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 32);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLable.Location = new System.Drawing.Point(461, 80);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(60, 25);
            this.typeLable.TabIndex = 14;
            this.typeLable.Text = "Type :";
            this.typeLable.Click += new System.EventHandler(this.typeLable_Click);
            // 
            // taskDetailsLable
            // 
            this.taskDetailsLable.AutoSize = true;
            this.taskDetailsLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDetailsLable.Location = new System.Drawing.Point(374, 129);
            this.taskDetailsLable.Name = "taskDetailsLable";
            this.taskDetailsLable.Size = new System.Drawing.Size(109, 25);
            this.taskDetailsLable.TabIndex = 16;
            this.taskDetailsLable.Text = "Task Details";
            this.taskDetailsLable.Click += new System.EventHandler(this.taskDetailsLable_Click);
            // 
            // addEditTaskDetailsLable
            // 
            this.addEditTaskDetailsLable.AutoSize = true;
            this.addEditTaskDetailsLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditTaskDetailsLable.Location = new System.Drawing.Point(350, 154);
            this.addEditTaskDetailsLable.Name = "addEditTaskDetailsLable";
            this.addEditTaskDetailsLable.Size = new System.Drawing.Size(158, 20);
            this.addEditTaskDetailsLable.TabIndex = 17;
            this.addEditTaskDetailsLable.Text = "Add / Edit Task Details";
            this.addEditTaskDetailsLable.Click += new System.EventHandler(this.addEditTaskDetailsLable_Click);
            // 
            // deadlineLable
            // 
            this.deadlineLable.AutoSize = true;
            this.deadlineLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLable.Location = new System.Drawing.Point(450, 238);
            this.deadlineLable.Name = "deadlineLable";
            this.deadlineLable.Size = new System.Drawing.Size(76, 20);
            this.deadlineLable.TabIndex = 18;
            this.deadlineLable.Text = "Deadline :";
            this.deadlineLable.Click += new System.EventHandler(this.deadlineLable_Click);
            // 
            // startlineLable
            // 
            this.startlineLable.AutoSize = true;
            this.startlineLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlineLable.Location = new System.Drawing.Point(450, 195);
            this.startlineLable.Name = "startlineLable";
            this.startlineLable.Size = new System.Drawing.Size(71, 20);
            this.startlineLable.TabIndex = 19;
            this.startlineLable.Text = "Startline :";
            this.startlineLable.Click += new System.EventHandler(this.startlineLable_Click);
            // 
            // taskNameLable
            // 
            this.taskNameLable.AutoSize = true;
            this.taskNameLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLable.Location = new System.Drawing.Point(58, 195);
            this.taskNameLable.Name = "taskNameLable";
            this.taskNameLable.Size = new System.Drawing.Size(87, 20);
            this.taskNameLable.TabIndex = 20;
            this.taskNameLable.Text = "Task Name :";
            this.taskNameLable.Click += new System.EventHandler(this.taskNameLable_Click);
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameTextBox.Location = new System.Drawing.Point(164, 188);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(193, 33);
            this.taskNameTextBox.TabIndex = 21;
            this.taskNameTextBox.TextChanged += new System.EventHandler(this.taskNameTextBox_TextChanged);
            // 
            // completeCheckBox
            // 
            this.completeCheckBox.AutoSize = true;
            this.completeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeCheckBox.Location = new System.Drawing.Point(622, 284);
            this.completeCheckBox.Name = "completeCheckBox";
            this.completeCheckBox.Size = new System.Drawing.Size(109, 24);
            this.completeCheckBox.TabIndex = 24;
            this.completeCheckBox.Text = "Complete ?";
            this.completeCheckBox.UseVisualStyleBackColor = true;
            this.completeCheckBox.CheckedChanged += new System.EventHandler(this.compite_CheckedChanged);
            // 
            // minutesLable
            // 
            this.minutesLable.AutoSize = true;
            this.minutesLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLable.Location = new System.Drawing.Point(58, 245);
            this.minutesLable.Name = "minutesLable";
            this.minutesLable.Size = new System.Drawing.Size(68, 20);
            this.minutesLable.TabIndex = 26;
            this.minutesLable.Text = "Minutes :";
            this.minutesLable.Click += new System.EventHandler(this.minutesLable_Click);
            // 
            // startLineDateTime
            // 
            this.startLineDateTime.Location = new System.Drawing.Point(547, 195);
            this.startLineDateTime.Name = "startLineDateTime";
            this.startLineDateTime.Size = new System.Drawing.Size(213, 20);
            this.startLineDateTime.TabIndex = 28;
            this.startLineDateTime.ValueChanged += new System.EventHandler(this.startLineDateTime_ValueChanged);
            // 
            // deadLineDateTime
            // 
            this.deadLineDateTime.Location = new System.Drawing.Point(547, 238);
            this.deadLineDateTime.Name = "deadLineDateTime";
            this.deadLineDateTime.Size = new System.Drawing.Size(213, 20);
            this.deadLineDateTime.TabIndex = 29;
            this.deadLineDateTime.ValueChanged += new System.EventHandler(this.deadLineDateTime_ValueChanged);
            // 
            // todayDate
            // 
            this.todayDate.AutoSize = true;
            this.todayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.todayDate.Location = new System.Drawing.Point(207, 28);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(0, 29);
            this.todayDate.TabIndex = 30;
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Location = new System.Drawing.Point(185, 245);
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(120, 20);
            this.minutesUpDown.TabIndex = 31;
            this.minutesUpDown.ValueChanged += new System.EventHandler(this.minutesUpDown_ValueChanged);
            // 
            // TaskProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 540);
            this.Controls.Add(this.minutesUpDown);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.deadLineDateTime);
            this.Controls.Add(this.startLineDateTime);
            this.Controls.Add(this.minutesLable);
            this.Controls.Add(this.completeCheckBox);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.taskNameLable);
            this.Controls.Add(this.startlineLable);
            this.Controls.Add(this.deadlineLable);
            this.Controls.Add(this.addEditTaskDetailsLable);
            this.Controls.Add(this.taskDetailsLable);
            this.Controls.Add(this.typeLable);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadProjectFileFromXML);
            this.Controls.Add(this.saveFileasXMLbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.userNameLable);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.todayDateLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "TaskProject";
            this.Text = "TaskViewer";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button saveFileasXMLbutton;
        private System.Windows.Forms.Button loadProjectFileFromXML;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.Label taskDetailsLable;
        private System.Windows.Forms.Label addEditTaskDetailsLable;
        private System.Windows.Forms.Label deadlineLable;
        private System.Windows.Forms.Label startlineLable;
        private System.Windows.Forms.Label taskNameLable;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.CheckBox completeCheckBox;
        private System.Windows.Forms.Label minutesLable;
        private System.Windows.Forms.DateTimePicker startLineDateTime;
        private System.Windows.Forms.DateTimePicker deadLineDateTime;
        private System.Windows.Forms.Label todayDate;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Complite;
    }
}

