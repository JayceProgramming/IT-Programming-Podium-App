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
    public partial class frmStudentInformationForm : Form
    {
        public frmStudentInformationForm()
        {
            InitializeComponent();
        }

        private void frmStudentInformationForm_Load(object sender, EventArgs e)
        {
            cmbGrade.SelectedIndex = 0;
            cmbSchools.SelectedIndex = 0;
        }

        // If the user didn't enter any characters For their first name, once they do the error message will go away
        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if (lblFirstNameError.Visible == true)
            {
                lblFirstNameError.Visible = false;
            }
        }

        // If the user didn't enter any characters For their last name, once they do the error message will go away
        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (lblLastNameError.Visible == true)
            {
                lblLastNameError.Visible = false;
            }
        }

        // Exit Button In Menu Strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                lblFirstNameError.Text = "(Please Enter Your First Name)";
                lblFirstNameError.Visible = true;

                if (txtLName.Text == "")
                {
                    lblLastNameError.Text = "(Please Enter Your Last Name)";
                    lblLastNameError.Visible = true;
                }
            }
            else if (txtLName.Text == "")
            {
                lblLastNameError.Text = "(Please Enter Your Last Name)";
                lblLastNameError.Visible = false;
            }
            else
            {
                string fName = txtFName.Text;
                string lName = txtLName.Text;
            }
            
            
        }

    }
}
