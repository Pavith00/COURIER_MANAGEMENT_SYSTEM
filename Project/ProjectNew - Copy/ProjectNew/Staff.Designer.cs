namespace ProjectNew
{
    partial class Staff
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
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label IdLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label BIdLabel;
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.BIdtextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.deleteTextbox = new System.Windows.Forms.TextBox();
            fnameLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            IdLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            BIdLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(70, 105);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(106, 24);
            fnameLabel.TabIndex = 109;
            fnameLabel.Text = "First Name:";
            fnameLabel.Click += new System.EventHandler(this.fnameLabel_Click);
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_numberLabel.Location = new System.Drawing.Point(70, 338);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(142, 24);
            phone_numberLabel.TabIndex = 111;
            phone_numberLabel.Text = "Phone number:";
            phone_numberLabel.Click += new System.EventHandler(this.phone_numberLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(70, 386);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 24);
            emailLabel.TabIndex = 113;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(70, 433);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 115;
            addressLabel.Text = "Address:";
            addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IdLabel.Location = new System.Drawing.Point(70, 58);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new System.Drawing.Size(27, 24);
            IdLabel.TabIndex = 122;
            IdLabel.Text = "ID";
            IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnameLabel.Location = new System.Drawing.Point(70, 157);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(104, 24);
            lnameLabel.TabIndex = 134;
            lnameLabel.Text = "Last Name:";
            lnameLabel.Click += new System.EventHandler(this.lnameLabel_Click);
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdateLabel.Location = new System.Drawing.Point(70, 201);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(83, 24);
            birthdateLabel.TabIndex = 136;
            birthdateLabel.Text = "Birthdate";
            birthdateLabel.Click += new System.EventHandler(this.birthdateLabel_Click);
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexLabel.Location = new System.Drawing.Point(70, 245);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(48, 24);
            sexLabel.TabIndex = 128;
            sexLabel.Text = "Sex:";
            sexLabel.Click += new System.EventHandler(this.sexLabel_Click);
            // 
            // BIdLabel
            // 
            BIdLabel.AutoSize = true;
            BIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BIdLabel.Location = new System.Drawing.Point(70, 292);
            BIdLabel.Name = "BIdLabel";
            BIdLabel.Size = new System.Drawing.Size(97, 24);
            BIdLabel.TabIndex = 138;
            BIdLabel.Text = "Branch ID:";
            BIdLabel.Click += new System.EventHandler(this.BIdLabel_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(545, 663);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(164, 36);
            this.btnDisplay.TabIndex = 121;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(84, 666);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 36);
            this.btnSearch.TabIndex = 120;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(84, 617);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 36);
            this.btnDelete.TabIndex = 118;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(727, 440);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(164, 36);
            this.btnInsert.TabIndex = 117;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.Location = new System.Drawing.Point(280, 102);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(292, 29);
            this.fnameTextBox.TabIndex = 110;
            this.fnameTextBox.TextChanged += new System.EventHandler(this.fnameTextBox_TextChanged);
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_numberTextBox.Location = new System.Drawing.Point(280, 335);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(292, 29);
            this.phone_numberTextBox.TabIndex = 112;
            this.phone_numberTextBox.TextChanged += new System.EventHandler(this.phone_numberTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(280, 383);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(292, 29);
            this.emailTextBox.TabIndex = 114;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(280, 433);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(292, 43);
            this.addressTextBox.TabIndex = 116;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(280, 55);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(292, 29);
            this.IdTextBox.TabIndex = 123;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.Location = new System.Drawing.Point(280, 154);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(292, 29);
            this.lnameTextBox.TabIndex = 135;
            this.lnameTextBox.TextChanged += new System.EventHandler(this.lnameTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 29);
            this.dateTimePicker1.TabIndex = 142;
            this.dateTimePicker1.Value = new System.DateTime(2023, 9, 21, 19, 13, 54, 0);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(139)))));
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(280, 245);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(69, 28);
            this.radioButtonMale.TabIndex = 143;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(376, 245);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(92, 28);
            this.radioButtonFemale.TabIndex = 144;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // BIdtextBox
            // 
            this.BIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIdtextBox.Location = new System.Drawing.Point(280, 289);
            this.BIdtextBox.Name = "BIdtextBox";
            this.BIdtextBox.Size = new System.Drawing.Size(292, 29);
            this.BIdtextBox.TabIndex = 139;
            this.BIdtextBox.TextChanged += new System.EventHandler(this.BIdtextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 39);
            this.panel3.TabIndex = 147;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ProjectNew.Properties.Resources.menu_icon_button_01;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 39);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 124);
            this.dataGridView1.TabIndex = 148;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchTextBox.Location = new System.Drawing.Point(283, 666);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(224, 29);
            this.SearchTextBox.TabIndex = 185;
            this.SearchTextBox.Text = "Enter A Employee ID";
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_leave);
            // 
            // deleteTextbox
            // 
            this.deleteTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTextbox.ForeColor = System.Drawing.Color.Silver;
            this.deleteTextbox.Location = new System.Drawing.Point(283, 620);
            this.deleteTextbox.Name = "deleteTextbox";
            this.deleteTextbox.Size = new System.Drawing.Size(224, 29);
            this.deleteTextbox.TabIndex = 184;
            this.deleteTextbox.Text = "Enter A Employee ID";
            this.deleteTextbox.TextChanged += new System.EventHandler(this.deleteTextbox_TextChanged);
            this.deleteTextbox.Enter += new System.EventHandler(this.deleteTextbox_enter);
            this.deleteTextbox.Leave += new System.EventHandler(this.deleteTextbox_leave);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1105, 788);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.deleteTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(BIdLabel);
            this.Controls.Add(this.BIdtextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.TextBox BIdtextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox deleteTextbox;
    }
}