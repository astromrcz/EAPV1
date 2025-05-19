namespace EAPV1
{
    partial class AdminHomePage
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
            AdminPanel = new Panel();
            ModifyAccountButton = new Button();
            CreateAccountButton = new Button();
            LogoutButton = new Button();
            label1 = new Label();
            AdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(ModifyAccountButton);
            AdminPanel.Controls.Add(CreateAccountButton);
            AdminPanel.Controls.Add(LogoutButton);
            AdminPanel.Controls.Add(label1);
            AdminPanel.Dock = DockStyle.Left;
            AdminPanel.Location = new Point(0, 0);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(239, 450);
            AdminPanel.TabIndex = 0;
            AdminPanel.Paint += AdminPanel_Paint;
            // 
            // ModifyAccountButton
            // 
            ModifyAccountButton.Location = new Point(47, 108);
            ModifyAccountButton.Name = "ModifyAccountButton";
            ModifyAccountButton.Size = new Size(122, 29);
            ModifyAccountButton.TabIndex = 3;
            ModifyAccountButton.Text = "Modify Account";
            ModifyAccountButton.UseVisualStyleBackColor = true;
            ModifyAccountButton.Click += ModifyAccountButton_Click;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(47, 73);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(122, 29);
            CreateAccountButton.TabIndex = 2;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(61, 394);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 1;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminPanel);
            Name = "AdminHomePage";
            Text = "Home Page";
            FormClosing += AdminHomePage_FormClosing;
            Load += AdminHomePage_Load;
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AdminPanel;
        private Button LogoutButton;
        private Label label1;
        private Button CreateAccountButton;
        private Button ModifyAccountButton;
    }
}