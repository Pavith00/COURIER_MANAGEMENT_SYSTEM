namespace ProjectNew
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empCombo = new System.Windows.Forms.ComboBox();
            this.TrackingCombo = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delivered = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.delayDeliverd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.notDelivered = new System.Windows.Forms.RadioButton();
            this.deleteTextbox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tracking Code";
            // 
            // empCombo
            // 
            this.empCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empCombo.FormattingEnabled = true;
            this.empCombo.Location = new System.Drawing.Point(386, 76);
            this.empCombo.Name = "empCombo";
            this.empCombo.Size = new System.Drawing.Size(194, 32);
            this.empCombo.TabIndex = 2;
            // 
            // TrackingCombo
            // 
            this.TrackingCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackingCombo.FormattingEnabled = true;
            this.TrackingCombo.Location = new System.Drawing.Point(386, 151);
            this.TrackingCombo.Name = "TrackingCombo";
            this.TrackingCombo.Size = new System.Drawing.Size(194, 32);
            this.TrackingCombo.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(48, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 39);
            this.panel3.TabIndex = 149;
            // 
            // delivered
            // 
            this.delivered.AutoSize = true;
            this.delivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivered.Location = new System.Drawing.Point(244, 257);
            this.delivered.Name = "delivered";
            this.delivered.Size = new System.Drawing.Size(271, 28);
            this.delivered.TabIndex = 150;
            this.delivered.TabStop = true;
            this.delivered.Text = "Delivery Completed On Time";
            this.delivered.UseVisualStyleBackColor = true;
            this.delivered.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(500, 450);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 40);
            this.Save.TabIndex = 151;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // delayDeliverd
            // 
            this.delayDeliverd.AutoSize = true;
            this.delayDeliverd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayDeliverd.Location = new System.Drawing.Point(245, 302);
            this.delayDeliverd.Name = "delayDeliverd";
            this.delayDeliverd.Size = new System.Drawing.Size(298, 28);
            this.delayDeliverd.TabIndex = 152;
            this.delayDeliverd.TabStop = true;
            this.delayDeliverd.Text = "Delivery Completed But Delayed";
            this.delayDeliverd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 153;
            this.label4.Text = "Delivery Status";
            // 
            // notDelivered
            // 
            this.notDelivered.AutoSize = true;
            this.notDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notDelivered.Location = new System.Drawing.Point(244, 352);
            this.notDelivered.Name = "notDelivered";
            this.notDelivered.Size = new System.Drawing.Size(226, 28);
            this.notDelivered.TabIndex = 154;
            this.notDelivered.TabStop = true;
            this.notDelivered.Text = "Delivery Not Completed";
            this.notDelivered.UseVisualStyleBackColor = true;
            // 
            // deleteTextbox
            // 
            this.deleteTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTextbox.ForeColor = System.Drawing.Color.Silver;
            this.deleteTextbox.Location = new System.Drawing.Point(370, 518);
            this.deleteTextbox.Name = "deleteTextbox";
            this.deleteTextbox.Size = new System.Drawing.Size(224, 29);
            this.deleteTextbox.TabIndex = 156;
            this.deleteTextbox.Text = "Enter A Employee ID";
            this.deleteTextbox.TextChanged += new System.EventHandler(this.deleteTextbox_TextChanged);
            this.deleteTextbox.Enter += new System.EventHandler(this.deleteTextbox_enter);
            this.deleteTextbox.Leave += new System.EventHandler(this.deleteTextbox_leave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(232, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 35);
            this.btnDelete.TabIndex = 155;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(229, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 13);
            this.label5.TabIndex = 157;
            this.label5.Text = "* If you need to Update a delivery status... first you need to delete that record" +
    "";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteTextbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.notDelivered);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delayDeliverd);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.delivered);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TrackingCombo);
            this.Controls.Add(this.empCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Order";
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox empCombo;
        private System.Windows.Forms.ComboBox TrackingCombo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton delivered;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RadioButton delayDeliverd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton notDelivered;
        private System.Windows.Forms.TextBox deleteTextbox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
    }
}