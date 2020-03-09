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
    public partial class Scan : Form
    {
        public Scan()
        {
            InitializeComponent();

            //try
            //{
            //    DialogResult result = MessageBox.Show("Are You Sure?", DateTime.Now.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //    if (result == DialogResult.Yes)
            //    {

            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.ToString());
            //}



        }

        private void BarcodetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (int)Keys.Enter)
                {
                    DataTable Barcode = this.barcodesTableAdapter.Getscan(BarcodetextBox.Text);

                    if (Barcode.Rows.Count == 1)
                    {
                        string BarcodeTxt = Barcode.Rows[0]["Barcode"].ToString();
                        bool BarcodeStatus = bool.Parse(Barcode.Rows[0]["status"].ToString());

                        if (BarcodeStatus==false)
                        {
                            barcodesTableAdapter.UpdateStatus(true, BarcodeTxt);
                            MessageBox.Show("login successfully.", DateTime.Now.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("This barcode has already been used.", DateTime.Now.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        this.barcodesTableAdapter.View(this.partyDataSet.Barcodes);
                    }
                    else
                    {
                        MessageBox.Show("This barcode does not exist.", DateTime.Now.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearall();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void Scan_Load(object sender, EventArgs e)
        {
            try
            {
                this.barcodesTableAdapter.View(this.partyDataSet.Barcodes);
                clearall();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void Scan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                clearall();
            }            
        }

        private void clearall()
        {
            //BarcodetextBox.ResetText();
            BarcodetextBox.Focus();
            BarcodetextBox.SelectAll();
        }






    }
}
