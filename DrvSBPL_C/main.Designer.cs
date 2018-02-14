namespace DrvSBPL_C
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdReference = new System.Windows.Forms.Button();
            this.txtFileNm = new System.Windows.Forms.TextBox();
            this.fixPrinter = new System.Windows.Forms.Label();
            this.cmdEnd = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.labelPrinterName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataSupply = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLabelSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupply)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdReference
            // 
            this.cmdReference.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdReference.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdReference.Location = new System.Drawing.Point(598, 43);
            this.cmdReference.Name = "cmdReference";
            this.cmdReference.Size = new System.Drawing.Size(78, 34);
            this.cmdReference.TabIndex = 1;
            this.cmdReference.Text = "Select";
            this.cmdReference.UseVisualStyleBackColor = true;
            this.cmdReference.Click += new System.EventHandler(this.cmdReference_Click);
            // 
            // txtFileNm
            // 
            this.txtFileNm.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFileNm.Location = new System.Drawing.Point(173, 49);
            this.txtFileNm.Name = "txtFileNm";
            this.txtFileNm.ReadOnly = true;
            this.txtFileNm.Size = new System.Drawing.Size(419, 23);
            this.txtFileNm.TabIndex = 0;
            // 
            // fixPrinter
            // 
            this.fixPrinter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fixPrinter.Location = new System.Drawing.Point(15, 16);
            this.fixPrinter.Name = "fixPrinter";
            this.fixPrinter.Size = new System.Drawing.Size(153, 22);
            this.fixPrinter.TabIndex = 93;
            this.fixPrinter.Text = "Target Printer";
            // 
            // cmdEnd
            // 
            this.cmdEnd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdEnd.Location = new System.Drawing.Point(466, 501);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(210, 36);
            this.cmdEnd.TabIndex = 4;
            this.cmdEnd.Text = "Exit software";
            this.cmdEnd.UseVisualStyleBackColor = true;
            this.cmdEnd.Click += new System.EventHandler(this.cmdEnd_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Enabled = false;
            this.cmdPrint.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdPrint.ForeColor = System.Drawing.Color.LightBlue;
            this.cmdPrint.Location = new System.Drawing.Point(18, 501);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(195, 36);
            this.cmdPrint.TabIndex = 3;
            this.cmdPrint.Text = "Print All";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // labelPrinterName
            // 
            this.labelPrinterName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPrinterName.Location = new System.Drawing.Point(173, 16);
            this.labelPrinterName.Name = "labelPrinterName";
            this.labelPrinterName.Size = new System.Drawing.Size(145, 22);
            this.labelPrinterName.TabIndex = 95;
            this.labelPrinterName.Text = "SATO SR408";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(15, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 25);
            this.Label1.TabIndex = 94;
            this.Label1.Text = "Target TSV file";
            // 
            // dataSupply
            // 
            this.dataSupply.AllowUserToAddRows = false;
            this.dataSupply.AllowUserToDeleteRows = false;
            this.dataSupply.AllowUserToOrderColumns = true;
            this.dataSupply.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSupply.Location = new System.Drawing.Point(17, 111);
            this.dataSupply.Name = "dataSupply";
            this.dataSupply.ReadOnly = true;
            this.dataSupply.RowTemplate.Height = 21;
            this.dataSupply.Size = new System.Drawing.Size(658, 379);
            this.dataSupply.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "Target label size";
            // 
            // cmbLabelSize
            // 
            this.cmbLabelSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbLabelSize.FormattingEnabled = true;
            this.cmbLabelSize.Items.AddRange(new object[] {
            "Normal",
            "Small"});
            this.cmbLabelSize.Location = new System.Drawing.Point(173, 81);
            this.cmbLabelSize.Name = "cmbLabelSize";
            this.cmbLabelSize.Size = new System.Drawing.Size(353, 20);
            this.cmbLabelSize.TabIndex = 98;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 545);
            this.Controls.Add(this.cmbLabelSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataSupply);
            this.Controls.Add(this.labelPrinterName);
            this.Controls.Add(this.cmdReference);
            this.Controls.Add(this.txtFileNm);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.fixPrinter);
            this.Controls.Add(this.cmdEnd);
            this.Controls.Add(this.cmdPrint);
            this.Name = "frmMain";
            this.Text = "PFS Label Print";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSupply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdReference;
        internal System.Windows.Forms.TextBox txtFileNm;
        internal System.Windows.Forms.Label fixPrinter;
        internal System.Windows.Forms.Button cmdEnd;
        internal System.Windows.Forms.Button cmdPrint;
        internal System.Windows.Forms.Label labelPrinterName;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dataSupply;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLabelSize;
    }
}

