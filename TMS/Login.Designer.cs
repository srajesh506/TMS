namespace TMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlloginpage = new System.Windows.Forms.Panel();
            this.lbltaskmanagement = new System.Windows.Forms.Label();
            this.lblsystem = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnforgotpwd = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pnlpwd = new System.Windows.Forms.Panel();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.picboxpwdicon = new System.Windows.Forms.PictureBox();
            this.pnlusrname = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.picboxusrnameicon = new System.Windows.Forms.PictureBox();
            this.lbllogintoacc = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlloginpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.panelMain.SuspendLayout();
            this.pnlpwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpwdicon)).BeginInit();
            this.pnlusrname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxusrnameicon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlloginpage
            // 
            this.pnlloginpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlloginpage.Controls.Add(this.lbltaskmanagement);
            this.pnlloginpage.Controls.Add(this.lblsystem);
            this.pnlloginpage.Controls.Add(this.lblwelcome);
            this.pnlloginpage.Controls.Add(this.picboxlogo);
            this.pnlloginpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlloginpage.Location = new System.Drawing.Point(0, 0);
            this.pnlloginpage.Name = "pnlloginpage";
            this.pnlloginpage.Size = new System.Drawing.Size(750, 530);
            this.pnlloginpage.TabIndex = 0;
            // 
            // lbltaskmanagement
            // 
            this.lbltaskmanagement.AutoSize = true;
            this.lbltaskmanagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskmanagement.ForeColor = System.Drawing.Color.White;
            this.lbltaskmanagement.Location = new System.Drawing.Point(70, 277);
            this.lbltaskmanagement.Name = "lbltaskmanagement";
            this.lbltaskmanagement.Size = new System.Drawing.Size(200, 24);
            this.lbltaskmanagement.TabIndex = 2;
            this.lbltaskmanagement.Text = "Task Management";
            // 
            // lblsystem
            // 
            this.lblsystem.AutoSize = true;
            this.lblsystem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsystem.ForeColor = System.Drawing.Color.White;
            this.lblsystem.Location = new System.Drawing.Point(190, 300);
            this.lblsystem.Name = "lblsystem";
            this.lblsystem.Size = new System.Drawing.Size(81, 24);
            this.lblsystem.TabIndex = 1;
            this.lblsystem.Text = "System";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(91, 257);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(184, 24);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome to the ";
            // 
            // picboxlogo
            // 
            this.picboxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxlogo.Image")));
            this.picboxlogo.Location = new System.Drawing.Point(51, 31);
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.Size = new System.Drawing.Size(195, 172);
            this.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxlogo.TabIndex = 0;
            this.picboxlogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnforgotpwd);
            this.panelMain.Controls.Add(this.btnlogin);
            this.panelMain.Controls.Add(this.pnlpwd);
            this.panelMain.Controls.Add(this.pnlusrname);
            this.panelMain.Controls.Add(this.lbllogintoacc);
            this.panelMain.Controls.Add(this.btnclose);
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelMain.Location = new System.Drawing.Point(300, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(450, 530);
            this.panelMain.TabIndex = 1;
            // 
            // btnforgotpwd
            // 
            this.btnforgotpwd.BackColor = System.Drawing.SystemColors.Control;
            this.btnforgotpwd.FlatAppearance.BorderSize = 0;
            this.btnforgotpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforgotpwd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgotpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnforgotpwd.Location = new System.Drawing.Point(197, 321);
            this.btnforgotpwd.Name = "btnforgotpwd";
            this.btnforgotpwd.Size = new System.Drawing.Size(120, 25);
            this.btnforgotpwd.TabIndex = 5;
            this.btnforgotpwd.Text = "Forget Password ?";
            this.btnforgotpwd.UseVisualStyleBackColor = false;
            this.btnforgotpwd.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(34, 315);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(148, 35);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlpwd
            // 
            this.pnlpwd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlpwd.Controls.Add(this.txtpwd);
            this.pnlpwd.Controls.Add(this.picboxpwdicon);
            this.pnlpwd.Location = new System.Drawing.Point(-1, 237);
            this.pnlpwd.Name = "pnlpwd";
            this.pnlpwd.Size = new System.Drawing.Size(450, 48);
            this.pnlpwd.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtpwd.Location = new System.Drawing.Point(55, 11);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(370, 20);
            this.txtpwd.TabIndex = 6;
            this.txtpwd.Text = "admin@123";
            this.txtpwd.UseSystemPasswordChar = true;
            this.txtpwd.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // picboxpwdicon
            // 
            this.picboxpwdicon.Image = ((System.Drawing.Image)(resources.GetObject("picboxpwdicon.Image")));
            this.picboxpwdicon.Location = new System.Drawing.Point(7, 5);
            this.picboxpwdicon.Name = "picboxpwdicon";
            this.picboxpwdicon.Size = new System.Drawing.Size(38, 38);
            this.picboxpwdicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxpwdicon.TabIndex = 5;
            this.picboxpwdicon.TabStop = false;
            this.picboxpwdicon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.picboxpwdicon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pnlusrname
            // 
            this.pnlusrname.BackColor = System.Drawing.SystemColors.Control;
            this.pnlusrname.Controls.Add(this.txtusername);
            this.pnlusrname.Controls.Add(this.picboxusrnameicon);
            this.pnlusrname.Location = new System.Drawing.Point(0, 185);
            this.pnlusrname.Name = "pnlusrname";
            this.pnlusrname.Size = new System.Drawing.Size(449, 48);
            this.pnlusrname.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.Control;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtusername.Location = new System.Drawing.Point(55, 13);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(370, 20);
            this.txtusername.TabIndex = 5;
            this.txtusername.Text = "admin";
            this.txtusername.Click += new System.EventHandler(this.textBox1_Click);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // picboxusrnameicon
            // 
            this.picboxusrnameicon.Image = ((System.Drawing.Image)(resources.GetObject("picboxusrnameicon.Image")));
            this.picboxusrnameicon.Location = new System.Drawing.Point(6, 4);
            this.picboxusrnameicon.Name = "picboxusrnameicon";
            this.picboxusrnameicon.Size = new System.Drawing.Size(38, 38);
            this.picboxusrnameicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxusrnameicon.TabIndex = 4;
            this.picboxusrnameicon.TabStop = false;
            // 
            // lbllogintoacc
            // 
            this.lbllogintoacc.AutoSize = true;
            this.lbllogintoacc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogintoacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbllogintoacc.Location = new System.Drawing.Point(38, 123);
            this.lbllogintoacc.Name = "lbllogintoacc";
            this.lbllogintoacc.Size = new System.Drawing.Size(233, 25);
            this.lbllogintoacc.TabIndex = 1;
            this.lbllogintoacc.Text = "Login to your account";
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnclose.Location = new System.Drawing.Point(406, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlloginpage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlloginpage.ResumeLayout(false);
            this.pnlloginpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.pnlpwd.ResumeLayout(false);
            this.pnlpwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpwdicon)).EndInit();
            this.pnlusrname.ResumeLayout(false);
            this.pnlusrname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxusrnameicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlloginpage;
        private System.Windows.Forms.Label lbltaskmanagement;
        private System.Windows.Forms.Label lblsystem;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel pnlusrname;
        private System.Windows.Forms.Label lbllogintoacc;
        private System.Windows.Forms.Panel pnlpwd;
        private System.Windows.Forms.PictureBox picboxpwdicon;
        private System.Windows.Forms.PictureBox picboxusrnameicon;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnforgotpwd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Timer timer1;
    }
}