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
            this.label3 = new System.Windows.Forms.Label();
            this.panelSampleNormal = new System.Windows.Forms.Panel();
            this.psInstitute = new System.Windows.Forms.Label();
            this.psStaticInstitute = new System.Windows.Forms.Label();
            this.psSN = new System.Windows.Forms.Label();
            this.psId = new System.Windows.Forms.Label();
            this.psStaticSN = new System.Windows.Forms.Label();
            this.psStaticId = new System.Windows.Forms.Label();
            this.psLocalId = new System.Windows.Forms.Label();
            this.psCompName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdPrintSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupply)).BeginInit();
            this.panelSampleNormal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdReference
            // 
            this.cmdReference.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdReference.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdReference.Location = new System.Drawing.Point(594, 27);
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
            this.txtFileNm.Location = new System.Drawing.Point(170, 33);
            this.txtFileNm.Name = "txtFileNm";
            this.txtFileNm.ReadOnly = true;
            this.txtFileNm.Size = new System.Drawing.Size(419, 23);
            this.txtFileNm.TabIndex = 0;
            // 
            // fixPrinter
            // 
            this.fixPrinter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fixPrinter.Location = new System.Drawing.Point(12, 9);
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
            this.cmdPrint.Location = new System.Drawing.Point(466, 417);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(209, 36);
            this.cmdPrint.TabIndex = 3;
            this.cmdPrint.Text = "Print All";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // labelPrinterName
            // 
            this.labelPrinterName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPrinterName.Location = new System.Drawing.Point(170, 9);
            this.labelPrinterName.Name = "labelPrinterName";
            this.labelPrinterName.Size = new System.Drawing.Size(145, 22);
            this.labelPrinterName.TabIndex = 95;
            this.labelPrinterName.Text = "SATO SR408";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(12, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 22);
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
            this.dataSupply.Location = new System.Drawing.Point(14, 98);
            this.dataSupply.Name = "dataSupply";
            this.dataSupply.ReadOnly = true;
            this.dataSupply.RowTemplate.Height = 21;
            this.dataSupply.Size = new System.Drawing.Size(658, 311);
            this.dataSupply.TabIndex = 96;
            this.dataSupply.SelectionChanged += new System.EventHandler(this.dataSupply_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 65);
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
            this.cmbLabelSize.Location = new System.Drawing.Point(170, 65);
            this.cmbLabelSize.Name = "cmbLabelSize";
            this.cmbLabelSize.Size = new System.Drawing.Size(353, 20);
            this.cmbLabelSize.TabIndex = 98;
            this.cmbLabelSize.Text = "Normal";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(16, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "Print sample";
            // 
            // panelSampleNormal
            // 
            this.panelSampleNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSampleNormal.Controls.Add(this.psInstitute);
            this.panelSampleNormal.Controls.Add(this.psStaticInstitute);
            this.panelSampleNormal.Controls.Add(this.psSN);
            this.panelSampleNormal.Controls.Add(this.psId);
            this.panelSampleNormal.Controls.Add(this.psStaticSN);
            this.panelSampleNormal.Controls.Add(this.psStaticId);
            this.panelSampleNormal.Controls.Add(this.psLocalId);
            this.panelSampleNormal.Controls.Add(this.psCompName);
            this.panelSampleNormal.Location = new System.Drawing.Point(146, 415);
            this.panelSampleNormal.Name = "panelSampleNormal";
            this.panelSampleNormal.Size = new System.Drawing.Size(213, 122);
            this.panelSampleNormal.TabIndex = 100;
            this.panelSampleNormal.Visible = false;
            // 
            // psInstitute
            // 
            this.psInstitute.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.psInstitute.Location = new System.Drawing.Point(119, 88);
            this.psInstitute.Name = "psInstitute";
            this.psInstitute.Size = new System.Drawing.Size(89, 27);
            this.psInstitute.TabIndex = 108;
            // 
            // psStaticInstitute
            // 
            this.psStaticInstitute.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.psStaticInstitute.Location = new System.Drawing.Point(66, 88);
            this.psStaticInstitute.Name = "psStaticInstitute";
            this.psStaticInstitute.Size = new System.Drawing.Size(60, 27);
            this.psStaticInstitute.TabIndex = 107;
            this.psStaticInstitute.Text = "PFS";
            // 
            // psSN
            // 
            this.psSN.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.psSN.Location = new System.Drawing.Point(22, 88);
            this.psSN.Name = "psSN";
            this.psSN.Size = new System.Drawing.Size(57, 27);
            this.psSN.TabIndex = 106;
            // 
            // psId
            // 
            this.psId.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.psId.Location = new System.Drawing.Point(34, 49);
            this.psId.Name = "psId";
            this.psId.Size = new System.Drawing.Size(149, 27);
            this.psId.TabIndex = 105;
            // 
            // psStaticSN
            // 
            this.psStaticSN.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.psStaticSN.Location = new System.Drawing.Point(2, 88);
            this.psStaticSN.Name = "psStaticSN";
            this.psStaticSN.Size = new System.Drawing.Size(23, 27);
            this.psStaticSN.TabIndex = 104;
            this.psStaticSN.Text = "#";
            // 
            // psStaticId
            // 
            this.psStaticId.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.psStaticId.Location = new System.Drawing.Point(3, 49);
            this.psStaticId.Name = "psStaticId";
            this.psStaticId.Size = new System.Drawing.Size(35, 27);
            this.psStaticId.TabIndex = 103;
            this.psStaticId.Text = "ID";
            // 
            // psLocalId
            // 
            this.psLocalId.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.psLocalId.Location = new System.Drawing.Point(3, 26);
            this.psLocalId.Name = "psLocalId";
            this.psLocalId.Size = new System.Drawing.Size(205, 22);
            this.psLocalId.TabIndex = 102;
            // 
            // psCompName
            // 
            this.psCompName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.psCompName.Location = new System.Drawing.Point(3, 4);
            this.psCompName.Name = "psCompName";
            this.psCompName.Size = new System.Drawing.Size(205, 22);
            this.psCompName.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(16, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 101;
            this.label4.Text = "(Select Row)";
            // 
            // cmdPrintSelected
            // 
            this.cmdPrintSelected.Enabled = false;
            this.cmdPrintSelected.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdPrintSelected.ForeColor = System.Drawing.Color.LightBlue;
            this.cmdPrintSelected.Location = new System.Drawing.Point(466, 459);
            this.cmdPrintSelected.Name = "cmdPrintSelected";
            this.cmdPrintSelected.Size = new System.Drawing.Size(209, 36);
            this.cmdPrintSelected.TabIndex = 102;
            this.cmdPrintSelected.Text = "Print Selected";
            this.cmdPrintSelected.UseVisualStyleBackColor = true;
            this.cmdPrintSelected.Click += new System.EventHandler(this.cmdPrintSelected_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 545);
            this.Controls.Add(this.cmdPrintSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelSampleNormal);
            this.Controls.Add(this.label3);
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
            this.panelSampleNormal.ResumeLayout(false);
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
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSampleNormal;
        internal System.Windows.Forms.Label psInstitute;
        internal System.Windows.Forms.Label psStaticInstitute;
        internal System.Windows.Forms.Label psSN;
        internal System.Windows.Forms.Label psId;
        internal System.Windows.Forms.Label psStaticSN;
        internal System.Windows.Forms.Label psStaticId;
        internal System.Windows.Forms.Label psLocalId;
        internal System.Windows.Forms.Label psCompName;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button cmdPrintSelected;
    }
}

