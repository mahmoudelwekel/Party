using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                Generate gnerate = new Generate();
                gnerate.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            try
            {
                Scan scan = new Scan();
                scan.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void random_Click(object sender, EventArgs e)
        {
            try
            {
                Random scan = new Random();
                scan.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
