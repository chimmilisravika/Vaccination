
namespace Vaccination
{
    partial class formRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistration));
            this.lblUserName = new System.Windows.Forms.Label();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSpuntnik = new System.Windows.Forms.RadioButton();
            this.rbCovaxin = new System.Windows.Forms.RadioButton();
            this.rbCovishield = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddressProof = new System.Windows.Forms.Label();
            this.txtAddressProof = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBoxGender.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rbMale);
            this.grpBoxGender.Controls.Add(this.rbFemale);
            this.grpBoxGender.Location = new System.Drawing.Point(12, 64);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(620, 81);
            this.grpBoxGender.TabIndex = 2;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Select Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(423, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 29);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(188, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(93, 29);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(13, 167);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(143, 25);
            this.lblContactNum.TabIndex = 3;
            this.lblContactNum.Text = "Contact Number";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(151, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(481, 31);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(162, 175);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(274, 31);
            this.txtContactNumber.TabIndex = 4;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_KeyPress);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(454, 167);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 25);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(505, 175);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(128, 31);
            this.txtAge.TabIndex = 6;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSpuntnik);
            this.groupBox2.Controls.Add(this.rbCovaxin);
            this.groupBox2.Controls.Add(this.rbCovishield);
            this.groupBox2.Location = new System.Drawing.Point(13, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Vaccine ";
            // 
            // rbSpuntnik
            // 
            this.rbSpuntnik.AutoSize = true;
            this.rbSpuntnik.Location = new System.Drawing.Point(441, 41);
            this.rbSpuntnik.Name = "rbSpuntnik";
            this.rbSpuntnik.Size = new System.Drawing.Size(113, 29);
            this.rbSpuntnik.TabIndex = 7;
            this.rbSpuntnik.TabStop = true;
            this.rbSpuntnik.Text = "Sputnik V";
            this.rbSpuntnik.UseVisualStyleBackColor = true;
            // 
            // rbCovaxin
            // 
            this.rbCovaxin.AutoSize = true;
            this.rbCovaxin.Location = new System.Drawing.Point(274, 41);
            this.rbCovaxin.Name = "rbCovaxin";
            this.rbCovaxin.Size = new System.Drawing.Size(99, 29);
            this.rbCovaxin.TabIndex = 6;
            this.rbCovaxin.TabStop = true;
            this.rbCovaxin.Text = "Covaxin";
            this.rbCovaxin.UseVisualStyleBackColor = true;
            // 
            // rbCovishield
            // 
            this.rbCovishield.AutoSize = true;
            this.rbCovishield.Location = new System.Drawing.Point(99, 41);
            this.rbCovishield.Name = "rbCovishield";
            this.rbCovishield.Size = new System.Drawing.Size(120, 29);
            this.rbCovishield.TabIndex = 5;
            this.rbCovishield.TabStop = true;
            this.rbCovishield.Text = "CoviShield";
            this.rbCovishield.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 367);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(77, 25);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(151, 367);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(481, 31);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.Adrress_txt_TextChanged);
            // 
            // lblAddressProof
            // 
            this.lblAddressProof.AutoSize = true;
            this.lblAddressProof.Location = new System.Drawing.Point(12, 429);
            this.lblAddressProof.Name = "lblAddressProof";
            this.lblAddressProof.Size = new System.Drawing.Size(121, 25);
            this.lblAddressProof.TabIndex = 10;
            this.lblAddressProof.Text = "AddressProof";
            // 
            // txtAddressProof
            // 
            this.txtAddressProof.FormattingEnabled = true;
            this.txtAddressProof.Location = new System.Drawing.Point(151, 429);
            this.txtAddressProof.Name = "txtAddressProof";
            this.txtAddressProof.Size = new System.Drawing.Size(481, 33);
            this.txtAddressProof.TabIndex = 11;
            this.txtAddressProof.SelectedIndexChanged += new System.EventHandler(this.Adres_prf_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(435, 499);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 46);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(100, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(86, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(125, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "*";
            // 
            // formRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddressProof);
            this.Controls.Add(this.lblAddressProof);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formRegistration";
            this.Load += new System.EventHandler(this.reg_form_Load);
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSpuntnik;
        private System.Windows.Forms.RadioButton rbCovaxin;
        private System.Windows.Forms.RadioButton rbCovishield;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddressProof;
        private System.Windows.Forms.ComboBox txtAddressProof;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

