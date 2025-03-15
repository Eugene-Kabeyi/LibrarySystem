using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LibrarySystem
{
    public partial class StartupPage : Form
    {
        public StartupPage()
        {
            InitializeComponent();
        }

        private void StartupPage_Load(object sender, EventArgs e)
        {
        }

        // Change background and text color when hovered
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn != null)
            {
                btn.BackColor = SystemColors.Window;
                btn.ForeColor = SystemColors.Highlight;
                btn.IconColor = SystemColors.Highlight;
            }
        }

        // Restore original colors when hover is removed
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn != null)
            {
                btn.BackColor = SystemColors.Highlight;
                btn.ForeColor = SystemColors.Window;
                btn.IconColor = Color.White;
            }
        }

        // Navigate to UserLogin form
        private void BtnUserToLogin_Click(object sender, EventArgs e)
        {
            UserLogin userLoginForm = new UserLogin();
            userLoginForm.Show();
            this.Hide(); // Hides the current form
        }

        // Navigate to StaffLogin form
        private void BtnStaffToLogin_Click(object sender, EventArgs e)
        {
            StaffLogin staffLoginForm = new StaffLogin();
            staffLoginForm.Show();
            this.Hide(); // Hides the current form
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
