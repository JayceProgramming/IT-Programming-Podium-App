using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Programming_Attendance_And_Sign_Out
{
    public partial class SwipeToAdd : Form
    {
        public SwipeToAdd()
        {
            InitializeComponent();
        }

        // Return Home Button In Menu Strip
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
            frmWelcomePage welcomePage = new frmWelcomePage();
            welcomePage.Show();
        }

        // Exit Button In Menu Strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SwipeToAdd_Load(object sender, EventArgs e)
        {
            this.Close();
            frmStudentInformationForm frmStudentInformation = new frmStudentInformationForm();
            frmStudentInformation.Show();
        }
    }
}
