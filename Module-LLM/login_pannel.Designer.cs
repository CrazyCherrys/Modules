
namespace Module_LLM
{
    partial class loginin_pannel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.passwd_text = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(77, 151);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 18);
            this.username.TabIndex = 0;
            this.username.Text = "用户名:";
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Location = new System.Drawing.Point(77, 221);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(62, 18);
            this.passwd.TabIndex = 1;
            this.passwd.Text = "密码：";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(202, 148);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(199, 28);
            this.username_text.TabIndex = 2;
            // 
            // passwd_text
            // 
            this.passwd_text.Location = new System.Drawing.Point(202, 211);
            this.passwd_text.Name = "passwd_text";
            this.passwd_text.Size = new System.Drawing.Size(199, 28);
            this.passwd_text.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Location = new System.Drawing.Point(165, 438);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(173, 110);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // loginin_pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 743);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.passwd_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.username);
            this.Name = "loginin_pannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox passwd_text;
        private System.Windows.Forms.Button btn_login;
    }
}

