
namespace Vaccination
{
    partial class reg_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_form));
            this.user_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Male_Rbtn = new System.Windows.Forms.RadioButton();
            this.Female_Rbtn = new System.Windows.Forms.RadioButton();
            this.contact_lbl = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.ContactNum_txt = new System.Windows.Forms.TextBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Spuntnik_Rbtn = new System.Windows.Forms.RadioButton();
            this.Covaxin_Rbtn = new System.Windows.Forms.RadioButton();
            this.covishield_Rbtn = new System.Windows.Forms.RadioButton();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Adrress_txt = new System.Windows.Forms.TextBox();
            this.Adrees_proof = new System.Windows.Forms.Label();
            this.Adres_prf = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(12, 27);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(94, 25);
            this.user_lbl.TabIndex = 1;
            this.user_lbl.Text = "UserName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Male_Rbtn);
            this.groupBox1.Controls.Add(this.Female_Rbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Gender";
            // 
            // Male_Rbtn
            // 
            this.Male_Rbtn.AutoSize = true;
            this.Male_Rbtn.Location = new System.Drawing.Point(423, 30);
            this.Male_Rbtn.Name = "Male_Rbtn";
            this.Male_Rbtn.Size = new System.Drawing.Size(75, 29);
            this.Male_Rbtn.TabIndex = 4;
            this.Male_Rbtn.TabStop = true;
            this.Male_Rbtn.Text = "Male";
            this.Male_Rbtn.UseVisualStyleBackColor = true;
            // 
            // Female_Rbtn
            // 
            this.Female_Rbtn.AutoSize = true;
            this.Female_Rbtn.Location = new System.Drawing.Point(188, 30);
            this.Female_Rbtn.Name = "Female_Rbtn";
            this.Female_Rbtn.Size = new System.Drawing.Size(93, 29);
            this.Female_Rbtn.TabIndex = 3;
            this.Female_Rbtn.TabStop = true;
            this.Female_Rbtn.Text = "Female";
            this.Female_Rbtn.UseVisualStyleBackColor = true;
            // 
            // contact_lbl
            // 
            this.contact_lbl.AutoSize = true;
            this.contact_lbl.Location = new System.Drawing.Point(13, 167);
            this.contact_lbl.Name = "contact_lbl";
            this.contact_lbl.Size = new System.Drawing.Size(143, 25);
            this.contact_lbl.TabIndex = 3;
            this.contact_lbl.Text = "Contact Number";
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(151, 27);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(481, 31);
            this.Username_txt.TabIndex = 0;
            this.Username_txt.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // ContactNum_txt
            // 
            this.ContactNum_txt.Location = new System.Drawing.Point(162, 175);
            this.ContactNum_txt.Name = "ContactNum_txt";
            this.ContactNum_txt.Size = new System.Drawing.Size(274, 31);
            this.ContactNum_txt.TabIndex = 4;
            this.ContactNum_txt.TextChanged += new System.EventHandler(this.ContactNum_txt_TextChanged);
            this.ContactNum_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contact_KeyPress);
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Location = new System.Drawing.Point(454, 167);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(44, 25);
            this.age_lbl.TabIndex = 5;
            this.age_lbl.Text = "Age";
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(504, 167);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(128, 31);
            this.age_txt.TabIndex = 6;
            this.age_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Spuntnik_Rbtn);
            this.groupBox2.Controls.Add(this.Covaxin_Rbtn);
            this.groupBox2.Controls.Add(this.covishield_Rbtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Vaccine ";
            // 
            // Spuntnik_Rbtn
            // 
            this.Spuntnik_Rbtn.AutoSize = true;
            this.Spuntnik_Rbtn.Location = new System.Drawing.Point(441, 41);
            this.Spuntnik_Rbtn.Name = "Spuntnik_Rbtn";
            this.Spuntnik_Rbtn.Size = new System.Drawing.Size(113, 29);
            this.Spuntnik_Rbtn.TabIndex = 7;
            this.Spuntnik_Rbtn.TabStop = true;
            this.Spuntnik_Rbtn.Text = "Sputnik V";
            this.Spuntnik_Rbtn.UseVisualStyleBackColor = true;
            // 
            // Covaxin_Rbtn
            // 
            this.Covaxin_Rbtn.AutoSize = true;
            this.Covaxin_Rbtn.Location = new System.Drawing.Point(274, 41);
            this.Covaxin_Rbtn.Name = "Covaxin_Rbtn";
            this.Covaxin_Rbtn.Size = new System.Drawing.Size(99, 29);
            this.Covaxin_Rbtn.TabIndex = 6;
            this.Covaxin_Rbtn.TabStop = true;
            this.Covaxin_Rbtn.Text = "Covaxin";
            this.Covaxin_Rbtn.UseVisualStyleBackColor = true;
            // 
            // covishield_Rbtn
            // 
            this.covishield_Rbtn.AutoSize = true;
            this.covishield_Rbtn.Location = new System.Drawing.Point(99, 41);
            this.covishield_Rbtn.Name = "covishield_Rbtn";
            this.covishield_Rbtn.Size = new System.Drawing.Size(120, 29);
            this.covishield_Rbtn.TabIndex = 5;
            this.covishield_Rbtn.TabStop = true;
            this.covishield_Rbtn.Text = "CoviSheild";
            this.covishield_Rbtn.UseVisualStyleBackColor = true;
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Location = new System.Drawing.Point(12, 367);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(77, 25);
            this.Address_lbl.TabIndex = 8;
            this.Address_lbl.Text = "Address";
            // 
            // Adrress_txt
            // 
            this.Adrress_txt.Location = new System.Drawing.Point(151, 367);
            this.Adrress_txt.Name = "Adrress_txt";
            this.Adrress_txt.Size = new System.Drawing.Size(481, 31);
            this.Adrress_txt.TabIndex = 9;
            this.Adrress_txt.TextChanged += new System.EventHandler(this.Adrress_txt_TextChanged);
            // 
            // Adrees_proof
            // 
            this.Adrees_proof.AutoSize = true;
            this.Adrees_proof.Location = new System.Drawing.Point(12, 429);
            this.Adrees_proof.Name = "Adrees_proof";
            this.Adrees_proof.Size = new System.Drawing.Size(121, 25);
            this.Adrees_proof.TabIndex = 10;
            this.Adrees_proof.Text = "AddressProof";
            // 
            // Adres_prf
            // 
            this.Adres_prf.FormattingEnabled = true;
            this.Adres_prf.Location = new System.Drawing.Point(151, 429);
            this.Adres_prf.Name = "Adres_prf";
            this.Adres_prf.Size = new System.Drawing.Size(481, 33);
            this.Adres_prf.TabIndex = 11;
            this.Adres_prf.SelectedIndexChanged += new System.EventHandler(this.Adres_prf_SelectedIndexChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.Location = new System.Drawing.Point(224, 508);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(194, 46);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(438, 508);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(194, 46);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
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
            // reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.Adres_prf);
            this.Controls.Add(this.Adrees_proof);
            this.Controls.Add(this.Adrress_txt);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.ContactNum_txt);
            this.Controls.Add(this.contact_lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.Username_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reg_form";
            this.Text = "]=";
            this.Load += new System.EventHandler(this.reg_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Male_Rbtn;
        private System.Windows.Forms.RadioButton Female_Rbtn;
        private System.Windows.Forms.Label contact_lbl;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox ContactNum_txt;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Spuntnik_Rbtn;
        private System.Windows.Forms.RadioButton Covaxin_Rbtn;
        private System.Windows.Forms.RadioButton covishield_Rbtn;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.TextBox Adrress_txt;
        private System.Windows.Forms.Label Adrees_proof;
        private System.Windows.Forms.ComboBox Adres_prf;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

