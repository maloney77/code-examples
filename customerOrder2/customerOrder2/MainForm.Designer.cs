namespace customerOrder2
{
    partial class MainForm
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
            this.custNameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.custNumLabel = new System.Windows.Forms.Label();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.custCMB = new System.Windows.Forms.ComboBox();
            this.custNumsDS = new System.Data.DataSet();
            this.zipCMB = new System.Windows.Forms.ComboBox();
            this.zipDS = new System.Data.DataSet();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.phoneNumTB = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.emailAddressTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.custNumsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipDS)).BeginInit();
            this.SuspendLayout();
            // 
            // custNameTB
            // 
            this.custNameTB.Location = new System.Drawing.Point(114, 119);
            this.custNameTB.Name = "custNameTB";
            this.custNameTB.ReadOnly = true;
            this.custNameTB.Size = new System.Drawing.Size(100, 20);
            this.custNameTB.TabIndex = 1;
            this.custNameTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(114, 151);
            this.addressTB.Name = "addressTB";
            this.addressTB.ReadOnly = true;
            this.addressTB.Size = new System.Drawing.Size(276, 20);
            this.addressTB.TabIndex = 2;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(114, 194);
            this.cityTB.Name = "cityTB";
            this.cityTB.ReadOnly = true;
            this.cityTB.Size = new System.Drawing.Size(100, 20);
            this.cityTB.TabIndex = 3;
            // 
            // custNumLabel
            // 
            this.custNumLabel.AutoSize = true;
            this.custNumLabel.Location = new System.Drawing.Point(135, 60);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(96, 13);
            this.custNumLabel.TabIndex = 4;
            this.custNumLabel.Text = "Customer Numbers";
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(60, 122);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(38, 13);
            this.custNameLabel.TabIndex = 5;
            this.custNameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(60, 154);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(64, 201);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(255, 197);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(427, 197);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 9;
            this.zipLabel.Text = "Zip:";
            // 
            // stateTB
            // 
            this.stateTB.Location = new System.Drawing.Point(296, 194);
            this.stateTB.Name = "stateTB";
            this.stateTB.ReadOnly = true;
            this.stateTB.Size = new System.Drawing.Size(100, 20);
            this.stateTB.TabIndex = 10;
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(63, 345);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(215, 345);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(393, 345);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // custCMB
            // 
            this.custCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custCMB.FormattingEnabled = true;
            this.custCMB.Location = new System.Drawing.Point(248, 57);
            this.custCMB.Name = "custCMB";
            this.custCMB.Size = new System.Drawing.Size(121, 21);
            this.custCMB.TabIndex = 15;
            this.custCMB.SelectedIndexChanged += new System.EventHandler(this.custCMB_SelectedIndexChanged);
            // 
            // custNumsDS
            // 
            this.custNumsDS.DataSetName = "NewDataSet";
            // 
            // zipCMB
            // 
            this.zipCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zipCMB.Enabled = false;
            this.zipCMB.FormattingEnabled = true;
            this.zipCMB.Location = new System.Drawing.Point(458, 193);
            this.zipCMB.Name = "zipCMB";
            this.zipCMB.Size = new System.Drawing.Size(121, 21);
            this.zipCMB.TabIndex = 16;
            this.zipCMB.SelectedIndexChanged += new System.EventHandler(this.zipCMB_SelectedIndexChanged);
            // 
            // zipDS
            // 
            this.zipDS.DataSetName = "NewDataSet";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(60, 251);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumLabel.TabIndex = 17;
            this.phoneNumLabel.Text = "Phone Number:";
            // 
            // phoneNumTB
            // 
            this.phoneNumTB.Location = new System.Drawing.Point(145, 248);
            this.phoneNumTB.Name = "phoneNumTB";
            this.phoneNumTB.ReadOnly = true;
            this.phoneNumTB.Size = new System.Drawing.Size(245, 20);
            this.phoneNumTB.TabIndex = 18;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(60, 295);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(80, 13);
            this.emailAddressLabel.TabIndex = 19;
            this.emailAddressLabel.Text = "E-Mail Address:";
            // 
            // emailAddressTB
            // 
            this.emailAddressTB.Location = new System.Drawing.Point(146, 292);
            this.emailAddressTB.Name = "emailAddressTB";
            this.emailAddressTB.ReadOnly = true;
            this.emailAddressTB.Size = new System.Drawing.Size(245, 20);
            this.emailAddressTB.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 390);
            this.Controls.Add(this.emailAddressTB);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.phoneNumTB);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.zipCMB);
            this.Controls.Add(this.custCMB);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.stateTB);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.custNumLabel);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.custNameTB);
            this.Name = "MainForm";
            this.Text = "Customer Update Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custNumsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox custNameTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox custCMB;
        private System.Data.DataSet custNumsDS;
        private System.Windows.Forms.ComboBox zipCMB;
        private System.Data.DataSet zipDS;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox phoneNumTB;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox emailAddressTB;
    }
}

