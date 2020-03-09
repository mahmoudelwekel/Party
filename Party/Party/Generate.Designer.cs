namespace Party
{
    partial class Generate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyWordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.DeleteAllbutton = new System.Windows.Forms.Button();
            this.SaveAllbutton = new System.Windows.Forms.Button();
            this.ShowAllbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyDataSet = new Party.PartyDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barcodesTableAdapter = new Party.PartyDataSetTableAdapters.BarcodesTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.keyWordtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(464, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // keyWordtextBox
            // 
            this.keyWordtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyWordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.keyWordtextBox.Location = new System.Drawing.Point(124, 10);
            this.keyWordtextBox.Name = "keyWordtextBox";
            this.keyWordtextBox.Size = new System.Drawing.Size(330, 30);
            this.keyWordtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key Word";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 60);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(464, 50);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.numericUpDown.Location = new System.Drawing.Point(124, 10);
            this.numericUpDown.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(330, 30);
            this.numericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Generatebutton
            // 
            this.Generatebutton.AutoSize = true;
            this.Generatebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.Generatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Generatebutton.Location = new System.Drawing.Point(10, 110);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(464, 47);
            this.Generatebutton.TabIndex = 2;
            this.Generatebutton.Text = "Generate";
            this.Generatebutton.UseVisualStyleBackColor = true;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // DeleteAllbutton
            // 
            this.DeleteAllbutton.AutoSize = true;
            this.DeleteAllbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteAllbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.DeleteAllbutton.Location = new System.Drawing.Point(10, 251);
            this.DeleteAllbutton.Name = "DeleteAllbutton";
            this.DeleteAllbutton.Size = new System.Drawing.Size(464, 47);
            this.DeleteAllbutton.TabIndex = 5;
            this.DeleteAllbutton.Text = "Delete All";
            this.DeleteAllbutton.UseVisualStyleBackColor = true;
            this.DeleteAllbutton.Click += new System.EventHandler(this.DeleteAllbutton_Click);
            // 
            // SaveAllbutton
            // 
            this.SaveAllbutton.AutoSize = true;
            this.SaveAllbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveAllbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.SaveAllbutton.Location = new System.Drawing.Point(10, 157);
            this.SaveAllbutton.Name = "SaveAllbutton";
            this.SaveAllbutton.Size = new System.Drawing.Size(464, 47);
            this.SaveAllbutton.TabIndex = 4;
            this.SaveAllbutton.Text = "Save All";
            this.SaveAllbutton.UseVisualStyleBackColor = true;
            this.SaveAllbutton.Click += new System.EventHandler(this.SaveAllbutton_Click);
            // 
            // ShowAllbutton
            // 
            this.ShowAllbutton.AutoSize = true;
            this.ShowAllbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowAllbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ShowAllbutton.Location = new System.Drawing.Point(10, 204);
            this.ShowAllbutton.Name = "ShowAllbutton";
            this.ShowAllbutton.Size = new System.Drawing.Size(464, 47);
            this.ShowAllbutton.TabIndex = 3;
            this.ShowAllbutton.Text = "Show All";
            this.ShowAllbutton.UseVisualStyleBackColor = true;
            this.ShowAllbutton.Click += new System.EventHandler(this.ShowAllbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.barcodesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Width = 58;
            // 
            // barcodesBindingSource
            // 
            this.barcodesBindingSource.DataMember = "Barcodes";
            this.barcodesBindingSource.DataSource = this.partyDataSet;
            this.barcodesBindingSource.Sort = "status,Barcode";
            // 
            // partyDataSet
            // 
            this.partyDataSet.DataSetName = "PartyDataSet";
            this.partyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(10, 298);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(464, 130);
            this.panel3.TabIndex = 6;
            // 
            // barcodesTableAdapter
            // 
            this.barcodesTableAdapter.ClearBeforeFill = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(10, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DeleteAllbutton);
            this.Controls.Add(this.ShowAllbutton);
            this.Controls.Add(this.SaveAllbutton);
            this.Controls.Add(this.Generatebutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.KeyPreview = true;
            this.Name = "Generate";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.Generate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox keyWordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.Button DeleteAllbutton;
        private System.Windows.Forms.Button SaveAllbutton;
        private System.Windows.Forms.Button ShowAllbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PartyDataSet partyDataSet;
        private System.Windows.Forms.BindingSource barcodesBindingSource;
        private PartyDataSetTableAdapters.BarcodesTableAdapter barcodesTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}