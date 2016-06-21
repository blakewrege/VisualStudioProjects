using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimekeeperFixer
{


    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void showButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Red;
                checkBox1.Text = "Turn Off Touch Screen Utilites";
                Process.Start("net", "start TabletInputService");

            }
            else
            {
                checkBox1.BackColor = Color.Green;
                checkBox1.Text = "Turn On Touch Screen Utilites";
                Process.Start("net", "stop TabletInputService");
            }
        }


    }


}


