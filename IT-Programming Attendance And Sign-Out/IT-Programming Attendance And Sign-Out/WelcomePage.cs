using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace IT_Programming_Attendance_And_Sign_Out
{
    public partial class frmWelcomePage : Form
    {
        public frmWelcomePage()
        {
            InitializeComponent();
        }

        // Add Student Button In Menu Strip
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            SwipeToAdd frmSwipeToAdd = new SwipeToAdd();
            frmSwipeToAdd.Show();
        }

        // Exit Button In Menu Strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Form Load 
        private void frmWelcomePage_Load(object sender, EventArgs e)
        {
            // Creating A Timer For 5 Hours
            System.Timers.Timer timer = new System.Timers.Timer(18000000);

            timer.Start();

            // After 5 Hours It Will Call The Method 
            timer.Elapsed += SaveDataPeriodically;

            timer.Stop();

        }

        // Non-Returning Method Changes Background When Called
        void SaveDataPeriodically(object sender, ElapsedEventArgs e)
        {
            this.BackgroundImage = IT_Programming_Attendance_And_Sign_Out.Properties.Resources.PM_Background;
        }

    }
}
