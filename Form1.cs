using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intubation_Dummy_Desktop_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupForm();
        }


        // METHODS TO HANDLE FORM

        void SetupForm()
        {
            WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            BackColor = Color.FromArgb(26, 26, 26);
            tabPage1.BackColor = Color.FromArgb(26, 26, 26);
        }

    }
}
