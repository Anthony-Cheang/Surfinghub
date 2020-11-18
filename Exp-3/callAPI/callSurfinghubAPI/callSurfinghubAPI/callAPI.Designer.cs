
namespace callSurfinghubAPI
{
    partial class callAPI
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
            this.getFriendsBtn = new System.Windows.Forms.Button();
            this.editSignBtn = new System.Windows.Forms.Button();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.inputSignBox = new System.Windows.Forms.TextBox();
            this.getSignBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getFriendsBtn
            // 
            this.getFriendsBtn.Location = new System.Drawing.Point(12, 12);
            this.getFriendsBtn.Name = "getFriendsBtn";
            this.getFriendsBtn.Size = new System.Drawing.Size(89, 49);
            this.getFriendsBtn.TabIndex = 0;
            this.getFriendsBtn.Text = "获取好友列表";
            this.getFriendsBtn.UseVisualStyleBackColor = true;
            this.getFriendsBtn.Click += new System.EventHandler(this.getFriendsBtn_Click);
            // 
            // editSignBtn
            // 
            this.editSignBtn.Location = new System.Drawing.Point(203, 12);
            this.editSignBtn.Name = "editSignBtn";
            this.editSignBtn.Size = new System.Drawing.Size(89, 49);
            this.editSignBtn.TabIndex = 1;
            this.editSignBtn.Text = "修改个性签名";
            this.editSignBtn.UseVisualStyleBackColor = true;
            this.editSignBtn.Click += new System.EventHandler(this.editSignBtn_Click);
            // 
            // inputNameBox
            // 
            this.inputNameBox.Location = new System.Drawing.Point(13, 67);
            this.inputNameBox.Multiline = true;
            this.inputNameBox.Name = "inputNameBox";
            this.inputNameBox.Size = new System.Drawing.Size(279, 26);
            this.inputNameBox.TabIndex = 2;
            this.inputNameBox.Text = "输入框（用户名）";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(13, 131);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(279, 180);
            this.outputBox.TabIndex = 3;
            this.outputBox.Text = "反馈框";
            // 
            // inputSignBox
            // 
            this.inputSignBox.Location = new System.Drawing.Point(13, 99);
            this.inputSignBox.Multiline = true;
            this.inputSignBox.Name = "inputSignBox";
            this.inputSignBox.Size = new System.Drawing.Size(279, 26);
            this.inputSignBox.TabIndex = 4;
            this.inputSignBox.Text = "输入框（个性签名）";
            // 
            // getSignBtn
            // 
            this.getSignBtn.Location = new System.Drawing.Point(107, 12);
            this.getSignBtn.Name = "getSignBtn";
            this.getSignBtn.Size = new System.Drawing.Size(89, 49);
            this.getSignBtn.TabIndex = 5;
            this.getSignBtn.Text = "获取个性签名";
            this.getSignBtn.UseVisualStyleBackColor = true;
            this.getSignBtn.Click += new System.EventHandler(this.getSignBtn_Click);
            // 
            // callAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 323);
            this.Controls.Add(this.getSignBtn);
            this.Controls.Add(this.inputSignBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputNameBox);
            this.Controls.Add(this.editSignBtn);
            this.Controls.Add(this.getFriendsBtn);
            this.Name = "callAPI";
            this.Text = "callAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getFriendsBtn;
        private System.Windows.Forms.Button editSignBtn;
        private System.Windows.Forms.TextBox inputNameBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox inputSignBox;
        private System.Windows.Forms.Button getSignBtn;
    }
}

