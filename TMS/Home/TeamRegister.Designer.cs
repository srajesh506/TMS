namespace TMS.Home
{
    partial class frmteamregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmteamregister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxforexistingemployee = new System.Windows.Forms.GroupBox();
            this.dview = new System.Windows.Forms.DataGridView();
            this.groupBoxforbutton = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBoxforregistration = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnupload = new System.Windows.Forms.Button();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtremark = new System.Windows.Forms.RichTextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblremark = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.lblreg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxforexistingemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.groupBoxforbutton.SuspendLayout();
            this.groupBoxforregistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBoxforexistingemployee);
            this.panel1.Controls.Add(this.groupBoxforbutton);
            this.panel1.Controls.Add(this.groupBoxforregistration);
            this.panel1.Controls.Add(this.lblreg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 568);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxforexistingemployee
            // 
            this.groupBoxforexistingemployee.BackColor = System.Drawing.Color.White;
            this.groupBoxforexistingemployee.Controls.Add(this.dview);
            this.groupBoxforexistingemployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforexistingemployee.Location = new System.Drawing.Point(6, 358);
            this.groupBoxforexistingemployee.Name = "groupBoxforexistingemployee";
            this.groupBoxforexistingemployee.Size = new System.Drawing.Size(1035, 198);
            this.groupBoxforexistingemployee.TabIndex = 14;
            this.groupBoxforexistingemployee.TabStop = false;
            this.groupBoxforexistingemployee.Text = "Existing Employee";
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.Location = new System.Drawing.Point(6, 26);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1023, 166);
            this.dview.TabIndex = 0;
            this.dview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            // 
            // groupBoxforbutton
            // 
            this.groupBoxforbutton.Controls.Add(this.btnsave);
            this.groupBoxforbutton.Controls.Add(this.btnmodify);
            this.groupBoxforbutton.Controls.Add(this.btncancel);
            this.groupBoxforbutton.Controls.Add(this.btnexit);
            this.groupBoxforbutton.Controls.Add(this.btnadd);
            this.groupBoxforbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxforbutton.Location = new System.Drawing.Point(366, 301);
            this.groupBoxforbutton.Name = "groupBoxforbutton";
            this.groupBoxforbutton.Size = new System.Drawing.Size(316, 48);
            this.groupBoxforbutton.TabIndex = 13;
            this.groupBoxforbutton.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(68, 15);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(56, 23);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(129, 15);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(56, 23);
            this.btnmodify.TabIndex = 15;
            this.btnmodify.Text = "&Modify";
            this.btnmodify.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(191, 15);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(56, 23);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "&Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(253, 15);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(56, 23);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(6, 15);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(56, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "&Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBoxforregistration
            // 
            this.groupBoxforregistration.Controls.Add(this.pictureBox1);
            this.groupBoxforregistration.Controls.Add(this.btnupload);
            this.groupBoxforregistration.Controls.Add(this.chkactive);
            this.groupBoxforregistration.Controls.Add(this.txtpwd);
            this.groupBoxforregistration.Controls.Add(this.label1);
            this.groupBoxforregistration.Controls.Add(this.rtxtremark);
            this.groupBoxforregistration.Controls.Add(this.lblname);
            this.groupBoxforregistration.Controls.Add(this.lblempid);
            this.groupBoxforregistration.Controls.Add(this.txtemail);
            this.groupBoxforregistration.Controls.Add(this.lblrole);
            this.groupBoxforregistration.Controls.Add(this.txtrole);
            this.groupBoxforregistration.Controls.Add(this.lblemail);
            this.groupBoxforregistration.Controls.Add(this.txtname);
            this.groupBoxforregistration.Controls.Add(this.lblremark);
            this.groupBoxforregistration.Controls.Add(this.txtempid);
            this.groupBoxforregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforregistration.Location = new System.Drawing.Point(6, 27);
            this.groupBoxforregistration.Name = "groupBoxforregistration";
            this.groupBoxforregistration.Size = new System.Drawing.Size(1035, 268);
            this.groupBoxforregistration.TabIndex = 11;
            this.groupBoxforregistration.TabStop = false;
            this.groupBoxforregistration.Text = "Employee Registeration Form";
            this.groupBoxforregistration.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(829, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnupload
            // 
            this.btnupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.Location = new System.Drawing.Point(847, 215);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(109, 32);
            this.btnupload.TabIndex = 15;
            this.btnupload.Text = "upload";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkactive.Location = new System.Drawing.Point(39, 228);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(69, 19);
            this.chkactive.TabIndex = 13;
            this.chkactive.Text = "Is Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtpwd.Location = new System.Drawing.Point(497, 166);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(223, 27);
            this.txtpwd.TabIndex = 12;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(415, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "&Password";
            // 
            // rtxtremark
            // 
            this.rtxtremark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtremark.Location = new System.Drawing.Point(497, 107);
            this.rtxtremark.Name = "rtxtremark";
            this.rtxtremark.Size = new System.Drawing.Size(223, 49);
            this.rtxtremark.TabIndex = 10;
            this.rtxtremark.Text = "";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(35, 107);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 19);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(35, 48);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(106, 19);
            this.lblempid.TabIndex = 1;
            this.lblempid.Text = "&Employee Id";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtemail.Location = new System.Drawing.Point(497, 45);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(223, 27);
            this.txtemail.TabIndex = 9;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblrole.Location = new System.Drawing.Point(35, 166);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(42, 19);
            this.lblrole.TabIndex = 3;
            this.lblrole.Text = "Role";
            // 
            // txtrole
            // 
            this.txtrole.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtrole.Location = new System.Drawing.Point(164, 166);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(223, 27);
            this.txtrole.TabIndex = 8;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblemail.Location = new System.Drawing.Point(411, 48);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 19);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtname.Location = new System.Drawing.Point(164, 107);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(223, 27);
            this.txtname.TabIndex = 7;
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblremark.Location = new System.Drawing.Point(411, 107);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(69, 19);
            this.lblremark.TabIndex = 5;
            this.lblremark.Text = "Remark";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtempid.Location = new System.Drawing.Point(164, 45);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(223, 27);
            this.txtempid.TabIndex = 6;
            // 
            // lblreg
            // 
            this.lblreg.BackColor = System.Drawing.Color.White;
            this.lblreg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.White;
            this.lblreg.Location = new System.Drawing.Point(1, 4);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(1086, 20);
            this.lblreg.TabIndex = 0;
            this.lblreg.Text = "Team Registration";
            // 
            // frmteamregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 568);
            this.Controls.Add(this.panel1);
            this.Name = "frmteamregister";
            this.Text = "Team Register";
            this.panel1.ResumeLayout(false);
            this.groupBoxforexistingemployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.groupBoxforbutton.ResumeLayout(false);
            this.groupBoxforregistration.ResumeLayout(false);
            this.groupBoxforregistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.GroupBox groupBoxforbutton;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBoxforregistration;
        private System.Windows.Forms.RichTextBox rtxtremark;
        private System.Windows.Forms.GroupBox groupBoxforexistingemployee;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnupload;
    }
}