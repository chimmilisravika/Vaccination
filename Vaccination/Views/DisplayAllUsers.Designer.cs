
namespace Vaccination
{
    partial class DisplayAllUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAllUsers));
            this.gbAllLineDetails = new System.Windows.Forms.GroupBox();
            this.grdvDisplayAllUsers = new System.Windows.Forms.DataGridView();
            this.repositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbAllLineDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDisplayAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAllLineDetails
            // 
            this.gbAllLineDetails.Controls.Add(this.grdvDisplayAllUsers);
            this.gbAllLineDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAllLineDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAllLineDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbAllLineDetails.Name = "gbAllLineDetails";
            this.gbAllLineDetails.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbAllLineDetails.Size = new System.Drawing.Size(1333, 865);
            this.gbAllLineDetails.TabIndex = 0;
            this.gbAllLineDetails.TabStop = false;
            this.gbAllLineDetails.Text = "Display All Users";
            // 
            // grdvDisplayAllUsers
            // 
            this.grdvDisplayAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvDisplayAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvDisplayAllUsers.Location = new System.Drawing.Point(4, 30);
            this.grdvDisplayAllUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grdvDisplayAllUsers.Name = "grdvDisplayAllUsers";
            this.grdvDisplayAllUsers.RowHeadersWidth = 62;
            this.grdvDisplayAllUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.grdvDisplayAllUsers.Size = new System.Drawing.Size(1325, 829);
            this.grdvDisplayAllUsers.TabIndex = 0;
            // 
            // DisplayAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 865);
            this.Controls.Add(this.gbAllLineDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "DisplayAllUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display All Users";
            this.Load += new System.EventHandler(this.DisplayAllUsers_Load);
            this.gbAllLineDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvDisplayAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAllLineDetails;
        private System.Windows.Forms.DataGridView grdvDisplayAllUsers;
        private System.Windows.Forms.BindingSource repositoryBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}