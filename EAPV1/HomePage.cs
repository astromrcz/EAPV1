using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAPV1
{
    public partial class AdminHomePage : Form
    {
        private AccountCreation createAccount; // Declare globally
        public AdminHomePage()
        {
            InitializeComponent();
            // Initialize the user control but keep it disabled
            createAccount = new AccountCreation();
            createAccount.Enabled = false; // Greyed out initially
            createAccount.Location = new Point(AdminPanel.Right + 10, AdminPanel.Top);
            createAccount.Size = new Size(400, AdminPanel.Height);

            // Add it to the form beside the panel
            this.Controls.Add(createAccount);

        }

        private void LoadUserControlBesidePanel(UserControl userControl)
        {
            // Ensure previous user controls are removed before adding a new one
            this.Controls.RemoveByKey(userControl.Name);

            // Set the position dynamically
            userControl.Location = new Point(AdminPanel.Right + 10, AdminPanel.Top); // Places it beside the panel
            userControl.Size = new Size(400, AdminPanel.Height); // Adjust size to match panel

            // Add the user control to the AdminHomePage form
            this.Controls.Add(userControl);
            userControl.BringToFront(); // Ensure it's on top
        }





        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            AccountCreation createAccount = new AccountCreation();
            LoadUserControlBesidePanel(createAccount);
        }

        private void ModifyAccountButton_Click(object sender, EventArgs e)
        {
            AccountModification modifyAccount = new AccountModification();
            LoadUserControlBesidePanel(modifyAccount);
        }





        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            //condition pag employee = employee panel pag admin = admin panel pag manager = manager panel
        }
    }
}
