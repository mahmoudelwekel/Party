using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
using System.IO;

namespace Party
{
    public partial class Generate : Form
    {

        public Generate()
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

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You Sure?", DateTime.Now.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    progressBar1.Minimum = 0;

                    progressBar1.Maximum =int.Parse( numericUpDown.Value.ToString());

                    for (int i = 0; i < numericUpDown.Value; i++)
                    {
                        barcodesTableAdapter.Insert(RandomString(6), false);

                        progressBar1.Value = i;
                    }

                    this.barcodesTableAdapter.Fill(this.partyDataSet.Barcodes);

                    MessageBox.Show("Done !");
                    progressBar1.Value = progressBar1.Minimum;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void DeleteAllbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You Sure?", DateTime.Now.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    barcodesTableAdapter.DeleteAll();
                    this.barcodesTableAdapter.Fill(this.partyDataSet.Barcodes);
                    MessageBox.Show("Done !");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void Generate_Load(object sender, EventArgs e)
        {
            try
            {

                this.barcodesTableAdapter.Fill(this.partyDataSet.Barcodes);
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void ShowAllbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You Sure?", DateTime.Now.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.barcodesTableAdapter.Fill(this.partyDataSet.Barcodes);
                    MessageBox.Show("Done !");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void SaveAllbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You Sure?", DateTime.Now.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        DataTable barcodes = barcodesTableAdapter.GetData();
                        string selectedPath = folderBrowserDialog1.SelectedPath;

                        StreamWriter swExtLogFile = new StreamWriter(selectedPath + "\\Barcodes.txt", true);
                        swExtLogFile.Write(Environment.NewLine);

                        progressBar1.Minimum = System.IO.Directory.GetFiles(selectedPath).Length;

                        progressBar1.Maximum = barcodes.Rows.Count + System.IO.Directory.GetFiles(selectedPath).Length;

                        foreach (DataRow item in barcodes.Rows)
                        {
                            string barcode = item[0].ToString();
                            string path = selectedPath + "\\" + barcode + ".png";
                            GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode(barcode, BarcodeWriterEncoding.Code128).ResizeTo(600, 525).SetMargins(25).ChangeBackgroundColor(Color.Transparent).AddBarcodeValueTextBelowBarcode();

                            MyBarCode.SaveAsPng(path);

                            swExtLogFile.WriteLine(barcode);

                            progressBar1.Value = System.IO.Directory.GetFiles(selectedPath).Length;
                        }

                        swExtLogFile.Write(Environment.NewLine);
                        swExtLogFile.Write("***** END OF DATA ["+ barcodes.Rows.Count + " Barcode] **** " + DateTime.Now.ToString());
                        swExtLogFile.Flush();
                        swExtLogFile.Close();

                        MessageBox.Show("Done !");
                        progressBar1.Value = progressBar1.Minimum;
                    }


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        













    }
}
