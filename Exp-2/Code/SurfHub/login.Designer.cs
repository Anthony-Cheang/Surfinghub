namespace SurfHub
{
    partial class login
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
            this.labelpsw = new System.Windows.Forms.Label();
            this.labelaccount = new System.Windows.Forms.Label();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.TextboxAccout = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonlogon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelpsw
            // 
            this.labelpsw.AutoSize = true;
            this.labelpsw.BackColor = System.Drawing.Color.Transparent;
            this.labelpsw.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelpsw.Location = new System.Drawing.Point(43, 129);
            this.labelpsw.Name = "labelpsw";
            this.labelpsw.Size = new System.Drawing.Size(49, 20);
            this.labelpsw.TabIndex = 9;
            this.labelpsw.Text = "密码";
            // 
            // labelaccount
            // 
            this.labelaccount.AutoSize = true;
            this.labelaccount.BackColor = System.Drawing.Color.Transparent;
            this.labelaccount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelaccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaccount.Location = new System.Drawing.Point(43, 101);
            this.labelaccount.Name = "labelaccount";
            this.labelaccount.Size = new System.Drawing.Size(49, 20);
            this.labelaccount.TabIndex = 8;
            this.labelaccount.Text = "账户";
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Location = new System.Drawing.Point(124, 129);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.PasswordChar = '*';
            this.TextboxPassword.Size = new System.Drawing.Size(204, 22);
            this.TextboxPassword.TabIndex = 11;
            // 
            // TextboxAccout
            // 
            this.TextboxAccout.Location = new System.Drawing.Point(124, 101);
            this.TextboxAccout.Name = "TextboxAccout";
            this.TextboxAccout.Size = new System.Drawing.Size(204, 22);
            this.TextboxAccout.TabIndex = 10;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.Location = new System.Drawing.Point(277, 173);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(84, 41);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonlogon
            // 
            this.buttonlogon.BackColor = System.Drawing.Color.Transparent;
            this.buttonlogon.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonlogon.Location = new System.Drawing.Point(12, 173);
            this.buttonlogon.Name = "buttonlogon";
            this.buttonlogon.Size = new System.Drawing.Size(80, 41);
            this.buttonlogon.TabIndex = 12;
            this.buttonlogon.Text = "注册";
            this.buttonlogon.UseVisualStyleBackColor = false;
            this.buttonlogon.Click += new System.EventHandler(this.buttonlogon_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SurfHub.Properties.Resources.logo__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 239);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonlogon);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxAccout);
            this.Controls.Add(this.labelpsw);
            this.Controls.Add(this.labelaccount);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.Text = "SurfingHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpsw;
        private System.Windows.Forms.Label labelaccount;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.TextBox TextboxAccout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonlogon;
    }
}

