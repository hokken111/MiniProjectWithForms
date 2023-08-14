namespace WindowsFormsApp3
{
    partial class Employee
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
            this.empId = new System.Windows.Forms.Label();
            this.depId = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.salary1 = new System.Windows.Forms.Label();
            this.gender1 = new System.Windows.Forms.Label();
            this.emp_Id = new System.Windows.Forms.TextBox();
            this.emp_Name = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.getAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Location = new System.Drawing.Point(86, 86);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(53, 16);
            this.empId.TabIndex = 0;
            this.empId.Text = "Emp_Id";
            // 
            // depId
            // 
            this.depId.AutoSize = true;
            this.depId.Location = new System.Drawing.Point(86, 130);
            this.depId.Name = "depId";
            this.depId.Size = new System.Drawing.Size(51, 16);
            this.depId.TabIndex = 1;
            this.depId.Text = "Dep_Id";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(84, 215);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(79, 16);
            this.empName.TabIndex = 2;
            this.empName.Text = "Emp_Name";
            // 
            // salary1
            // 
            this.salary1.AutoSize = true;
            this.salary1.Location = new System.Drawing.Point(84, 256);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(46, 16);
            this.salary1.TabIndex = 3;
            this.salary1.Text = "Salary";
            // 
            // gender1
            // 
            this.gender1.AutoSize = true;
            this.gender1.Location = new System.Drawing.Point(84, 302);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(52, 16);
            this.gender1.TabIndex = 4;
            this.gender1.Text = "Gender";
            // 
            // emp_Id
            // 
            this.emp_Id.Location = new System.Drawing.Point(191, 83);
            this.emp_Id.Name = "emp_Id";
            this.emp_Id.Size = new System.Drawing.Size(100, 22);
            this.emp_Id.TabIndex = 5;
            // 
            // emp_Name
            // 
            this.emp_Name.Location = new System.Drawing.Point(192, 215);
            this.emp_Name.Name = "emp_Name";
            this.emp_Name.Size = new System.Drawing.Size(100, 22);
            this.emp_Name.TabIndex = 7;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(192, 256);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 22);
            this.salary.TabIndex = 8;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(192, 296);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 22);
            this.gender.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(191, 394);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(300, 394);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(413, 394);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // getAll
            // 
            this.getAll.Location = new System.Drawing.Point(519, 394);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(75, 23);
            this.getAll.TabIndex = 15;
            this.getAll.Text = "Get All";
            this.getAll.UseVisualStyleBackColor = true;
            this.getAll.Click += new System.EventHandler(this.getAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 198);
            this.dataGridView1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(191, 346);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Role_Id";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(191, 169);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.emp_Name);
            this.Controls.Add(this.emp_Id);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.depId);
            this.Controls.Add(this.empId);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.Label depId;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label salary1;
        private System.Windows.Forms.Label gender1;
        private System.Windows.Forms.TextBox emp_Id;
        private System.Windows.Forms.TextBox emp_Name;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button getAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}