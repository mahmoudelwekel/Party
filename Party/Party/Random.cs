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
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.barcodesTableAdapter.Random(this.partyDataSet.Barcodes,int.Parse( numericUpDown.Value.ToString()));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }


    }
}
