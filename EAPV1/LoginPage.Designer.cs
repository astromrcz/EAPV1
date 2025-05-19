namespace EAPV1
{
    partial class LoginPage
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
            LoginButton = new Button();
            EmailTextBox = new TextBox();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(331, 258);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(226, 141);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(335, 27);
            EmailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 144);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(226, 191);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(335, 27);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 194);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(PasswordTextBox);
            Controls.Add(label1);
            Controls.Add(EmailTextBox);
            Controls.Add(LoginButton);
            Name = "LoginPage";
            Text = "Login Page";
            FormClosing += LoginPage_FormClosing;
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox EmailTextBox;
        private Label label1;
        private TextBox PasswordTextBox;
        private Label label2;
    }
}
