using System;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using DllSBPL_C;

namespace DrvSBPL_C
{
    public partial class frmMain : Form
    {
        // message box title
        private string strMessageBox = "PFS Label Printer";
        private string sprSTX = "\x02";
        private string sprESC = "\x1b";
        private string sprETX = "\x03";
        // common defs
        private string sprPrintSize = "V00224H0330";
        private string sprInstHead = "PFS ";
        private string sprProdHead = "ID ";
        private string sprSeriHead = "#";
        private int[] sprInputSize = { 5, 18, 18, 8, 3 };

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdReference_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Filter = "CSV with tab (*.csv;*.tsv)|*.csv|All extensions (*.*)|*.*";
            ofd.InitialDirectory = txtFileNm.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileNm.Text = ofd.FileName;
                if (LoadLabelData())
                {
                    cmdPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    cmdPrint.Enabled = true;
                }
                else
                {
                    cmdPrint.ForeColor = System.Drawing.Color.LightBlue;
                    cmdPrint.Enabled = false;
                    cmdPrintSelected.ForeColor = System.Drawing.Color.LightBlue;
                    cmdPrintSelected.Enabled = false;
                }
            }
        }

        private bool LoadLabelData()
        {
            System.IO.StreamReader sr;
            try
            {
                sr = new System.IO.StreamReader(txtFileNm.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, strMessageBox, MessageBoxButtons.OK);
                return false;
            }
            dataSupply.RowCount = 0;
            string curLine;
            int curLineId = 0;
            while ((curLine = sr.ReadLine()) != null)
            {
                string[] clData = curLine.Split('\t');
                if (clData.Length == 5)
                {
                    dataSupply.Rows.Add(clData);
                    for (int cid = 0; cid < 5; cid++)
                    {
                        if (clData[cid].Length > sprInputSize[cid])
                        {
                            dataSupply.Rows[curLineId].Cells[cid].Style.ForeColor = System.Drawing.Color.Red;
                            dataSupply.Rows[curLineId].Cells[cid].Style.SelectionForeColor = System.Drawing.Color.Red;
                        }
                    }
                    curLineId++;
                }
            }
            sr.Close();
            dataSupply.AutoResizeColumns();
            if (curLineId == 0)
            {
                return false;
            }
            return true;
        }

        // on print button clicked, call generation and print
        // need to be replaced with loop over supplied (excel?) data
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            cmdPrint.Enabled = false;
            cmdPrintSelected.Enabled = false;
            if (cmbLabelSize.SelectedIndex < 0)
            {
                MessageBox.Show("No label size selected", strMessageBox, MessageBoxButtons.OK);
                cmdPrint.Enabled = true;
                cmdPrintSelected.Enabled = true;
                return;
            }
            string PrintData;
            for (int cId = 0; cId < dataSupply.RowCount; cId++)
            {
                DataGridViewRow cRow = dataSupply.Rows[cId];
                PrintData = GeneratePrintData(cRow.Cells[0].Value.ToString(),
                    cRow.Cells[1].Value.ToString(), cRow.Cells[2].Value.ToString(),
                    cRow.Cells[3].Value.ToString(), cRow.Cells[4].Value.ToString(),
                    cmbLabelSize.SelectedItem.ToString());
                PrintToPrinter(PrintData);
            }
            cmdPrint.Enabled = true;
            cmdPrintSelected.Enabled = true;
        }

        private void cmdPrintSelected_Click(object sender, EventArgs e)
        {
            cmdPrint.Enabled = false;
            cmdPrintSelected.Enabled = false;
            if (cmbLabelSize.SelectedIndex < 0)
            {
                MessageBox.Show("No label size selected", strMessageBox, MessageBoxButtons.OK);
                cmdPrint.Enabled = true;
                cmdPrintSelected.Enabled = true;
                return;
            }
            string PrintData;
            for (int cId = 0; cId < dataSupply.SelectedRows.Count; cId++)
            {
                DataGridViewRow cRow = dataSupply.SelectedRows[cId];
                PrintData = GeneratePrintData(cRow.Cells[0].Value.ToString(),
                    cRow.Cells[1].Value.ToString(), cRow.Cells[2].Value.ToString(),
                    cRow.Cells[3].Value.ToString(), cRow.Cells[4].Value.ToString(),
                    cmbLabelSize.SelectedItem.ToString());
                PrintToPrinter(PrintData);
            }
            cmdPrint.Enabled = true;
            cmdPrintSelected.Enabled = true;
        }

        // closing window
        private void cmdEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Generate byte data to print
        private string GeneratePrintData(string optInstitute, string optCmpName, 
            string optLocalID, string optProdId, string optSerNo, string optSize)
        {
            string PrintData = "";
            // head
            PrintData = sprSTX;
            PrintData += sprESC + "A" + sprESC + "A1" + sprPrintSize;
            PrintData += sprESC + "ID00"; // print sequence ID (not used)
            PrintData += sprESC + "WK" + "PFS"; // job name, up to 16 char
            PrintData += sprESC + "%0"; // print to normal direction
            if (optSize == "Normal")
            {
                // institute
                PrintData += sprESC + "V0135" + sprESC + "H0105"; // pos
                PrintData += sprESC + "P00" + sprESC + "L0101"; // font size
                PrintData += sprESC + "$B,38,88,9" + sprESC + "$="; // font id
                PrintData += sprInstHead + optInstitute; // data
                // component name
                PrintData += sprESC + "V0020" + sprESC + "H0020"; // pos
                PrintData += sprESC + "P03" + sprESC + "L0101"; // font size
                PrintData += sprESC + "M"; // font id
                PrintData += optCmpName; // data
                // component local ID
                PrintData += sprESC + "V0050" + sprESC + "H0020"; // pos
                PrintData += sprESC + "P03" + sprESC + "L0101"; // font size
                PrintData += sprESC + "M"; // font id
                PrintData += optLocalID; // data
                // product ID
                PrintData += sprESC + "V0090" + sprESC + "H0010"; // pos
                PrintData += sprESC + "P00" + sprESC + "L0102"; // font size
                PrintData += sprESC + "X22,"; // font id
                PrintData += sprProdHead + optProdId; // data
                // serial number
                PrintData += sprESC + "V0150" + sprESC + "H0010"; // pos
                PrintData += sprESC + "P00" + sprESC + "L0102"; // font size
                PrintData += sprESC + "X22,"; // font id
                PrintData += sprSeriHead + optSerNo; // data
            }
            else if (optSize == "Small")
            {
                // component name
                PrintData += sprESC + "V0020" + sprESC + "H0020"; // pos
                PrintData += sprESC + "P02" + sprESC + "L0102"; // font size
                PrintData += sprESC + "S"; // font id
                PrintData += optCmpName; // data
                // product ID
                PrintData += sprESC + "V0050" + sprESC + "H0010"; // pos
                PrintData += sprESC + "P00" + sprESC + "L0102"; // font size
                PrintData += sprESC + "X21,"; // font id
                PrintData += sprProdHead + optProdId + sprSeriHead + optSerNo; // data
            }
            else
            {
                return "";
            }
            // tailer
            PrintData += sprESC + "Q1"; // print quantity, up to 6 numeric
            PrintData += sprESC + "Z" + sprETX; // stop code and end of data
            return PrintData;
        }

        // Print byte data
        private bool PrintToPrinter(string PrintData)
        {
            if (PrintData == "")
            {
                MessageBox.Show("Print data error", strMessageBox, MessageBoxButtons.OK);
                return false;
            }
            // try to open printer
            try
            {
                IntPtr PrintHandle = new IntPtr();
                string AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                string ErrMsg = string.Empty;
                if (! Print.SatoOpen(ref PrintHandle, labelPrinterName.Text, AssemblyName, ref ErrMsg))
                {
                    // error to open printer
                    MessageBox.Show(ErrMsg, strMessageBox, MessageBoxButtons.OK);
                    return false;
                }
                byte[] bStData = System.Text.Encoding.GetEncoding(0).GetBytes(PrintData);
                if (! Print.SatoSend(PrintHandle, bStData, ref ErrMsg))
                {
                    MessageBox.Show(ErrMsg, strMessageBox, MessageBoxButtons.OK);
                    return false;
                }
                if (! Print.SatoClose(PrintHandle, ref ErrMsg))
                {
                    MessageBox.Show(ErrMsg, strMessageBox, MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, strMessageBox, MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        // form load. check predefined printer name exists and make things enabled.
        private void frmMain_Load(object sender, EventArgs e)
        {
            // check printer exists or not
            bool isPrinterFound = false;
            foreach (string p in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (p == labelPrinterName.Text) { isPrinterFound = true; }
            }
            if (isPrinterFound == false)
            {
                MessageBox.Show("Printer \"" + labelPrinterName.Text + "\" not found", strMessageBox, MessageBoxButtons.OK);
                labelPrinterName.ForeColor = System.Drawing.Color.Red;
                cmdPrint.Enabled = false;
            }
            dataSupply.ColumnCount = 5;
            dataSupply.Columns[0].Name = "Institute";
            dataSupply.Columns[1].Name = "Component name";
            dataSupply.Columns[2].Name = "Local ID";
            dataSupply.Columns[3].Name = "Product ID";
            dataSupply.Columns[4].Name = "Serial No";
            dataSupply.AutoResizeColumns();
            cmbLabelSize.SelectedIndex = 0;
        }

        private void dataSupply_SelectionChanged(object sender, EventArgs e)
        {
            if ((cmdPrint.Enabled == false) || (dataSupply.SelectedRows.Count < 1))
            {
                panelSampleNormal.Visible = false;
                cmdPrintSelected.ForeColor = System.Drawing.Color.LightBlue;
                cmdPrintSelected.Enabled = false;
                return;
            }
            DataGridViewRow curRow = dataSupply.SelectedRows[0];
            psInstitute.Text = curRow.Cells[0].Value.ToString();
            psCompName.Text = curRow.Cells[1].Value.ToString();
            psLocalId.Text = curRow.Cells[2].Value.ToString();
            psId.Text = curRow.Cells[3].Value.ToString();
            psSN.Text = curRow.Cells[4].Value.ToString();
            panelSampleNormal.Visible = true;
            cmdPrintSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cmdPrintSelected.Enabled = true;
        }
    }
}