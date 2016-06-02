namespace brLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUserPass = new System.Windows.Forms.CheckBox();
            this.chkUserId = new System.Windows.Forms.CheckBox();
            this.txtUser_Pass = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(183, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(23, 19);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(63, 19);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "Usuário:";
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPass.Location = new System.Drawing.Point(34, 52);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(52, 19);
            this.lblUserPass.TabIndex = 3;
            this.lblUserPass.Text = "Senha:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(109, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(68, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 41);
            this.panel1.TabIndex = 7;
            // 
            // chkUserPass
            // 
            this.chkUserPass.AutoSize = true;
            this.chkUserPass.Checked = global::brLauncher.Properties.Settings.Default.userpass_remember;
            this.chkUserPass.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::brLauncher.Properties.Settings.Default, "userpass_remember", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUserPass.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserPass.Location = new System.Drawing.Point(266, 55);
            this.chkUserPass.Name = "chkUserPass";
            this.chkUserPass.Size = new System.Drawing.Size(67, 18);
            this.chkUserPass.TabIndex = 4;
            this.chkUserPass.Text = "Lembrar";
            this.chkUserPass.UseVisualStyleBackColor = true;
            // 
            // chkUserId
            // 
            this.chkUserId.AutoSize = true;
            this.chkUserId.Checked = global::brLauncher.Properties.Settings.Default.userid_remember;
            this.chkUserId.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::brLauncher.Properties.Settings.Default, "userid_remember", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUserId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserId.Location = new System.Drawing.Point(266, 22);
            this.chkUserId.Name = "chkUserId";
            this.chkUserId.Size = new System.Drawing.Size(67, 18);
            this.chkUserId.TabIndex = 2;
            this.chkUserId.Text = "Lembrar";
            this.chkUserId.UseVisualStyleBackColor = true;
            // 
            // txtUser_Pass
            // 
            this.txtUser_Pass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::brLauncher.Properties.Settings.Default, "user_pass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUser_Pass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser_Pass.Location = new System.Drawing.Point(92, 49);
            this.txtUser_Pass.MaxLength = 32;
            this.txtUser_Pass.Name = "txtUser_Pass";
            this.txtUser_Pass.Size = new System.Drawing.Size(168, 27);
            this.txtUser_Pass.TabIndex = 3;
            this.txtUser_Pass.Text = global::brLauncher.Properties.Settings.Default.user_pass;
            this.txtUser_Pass.UseSystemPasswordChar = true;
            // 
            // txtUserId
            // 
            this.txtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::brLauncher.Properties.Settings.Default, "userid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUserId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(92, 16);
            this.txtUserId.MaxLength = 32;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(168, 27);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = global::brLauncher.Properties.Settings.Default.userid;
            // 
            // ntfIcon
            // 
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = global::brLauncher.Properties.Settings.Default.clockIcon;
            this.ntfIcon.Visible = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 133);
            this.ControlBox = false;
            this.Controls.Add(this.chkUserPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkUserId);
            this.Controls.Add(this.txtUser_Pass);
            this.Controls.Add(this.lblUserPass);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUser_Pass;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkUserId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkUserPass;
        private System.Windows.Forms.NotifyIcon ntfIcon;
    }
}

