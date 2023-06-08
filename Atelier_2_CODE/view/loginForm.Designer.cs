namespace Atelier_2_CODE.view
{
    partial class loginForm
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
            label1 = new Label();
            label2 = new Label();
            text_login = new TextBox();
            text_pwd = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 72);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Login :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 128);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // text_login
            // 
            text_login.Location = new Point(191, 70);
            text_login.Name = "text_login";
            text_login.Size = new Size(127, 23);
            text_login.TabIndex = 2;
            // 
            // text_pwd
            // 
            text_pwd.Location = new Point(191, 125);
            text_pwd.Name = "text_pwd";
            text_pwd.Size = new Size(127, 23);
            text_pwd.TabIndex = 3;
            text_pwd.UseSystemPasswordChar = true;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 253);
            Controls.Add(text_pwd);
            Controls.Add(text_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "Se connecter";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text_login;
        private TextBox text_pwd;
    }
}