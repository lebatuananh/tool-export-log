using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.ExportLog.Shared;

namespace Tool.ExportLog.UI
{
    public partial class form_main : Form
    {
        private readonly IExportService _exportService;

        public form_main()
        {
            InitializeComponent();

            _exportService = (IExportService)Program.ServiceProvider.GetService(typeof(IExportService));
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            txtAppPath.Text = appSettings.Get("apppath");
            txtOutput.Text = appSettings.Get("output");

            fromDate.Value = new DateTime(2021, 6, 4);
            toDate.Value = DateTime.Now;

            fromDate.MinDate = new DateTime(2021, 6, 4);
            fromDate.MaxDate = toDate.Value;
            toDate.MaxDate = DateTime.Now;

            richtextActivityTime.ReadOnly = true;
            richTextOutput.ReadOnly = true;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // check exist folder
            string folder = txtAppPath.Text;
            if (!System.IO.Directory.Exists(folder))
            {
                MessageBox.Show("Folder not exist!", "Validation");
                return;
            }

            // check date not null
            if (fromDate.Value == null || toDate.Value == null)
            {
                MessageBox.Show("Enter fromDate & toDate!", "Validation");
                return;
            }

            // check files exist
            if (!System.IO.Directory.EnumerateFiles(folder, "CMX*").Any())
            {
                MessageBox.Show("Files not exist!", "Validation");
                return;
            }

            // start
            foreach (DateTime day in Helper.EachDay(fromDate.Value, toDate.Value))
            {
                var ExportAt = "Export Start At " + System.DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss");
                //Console.WriteLine(ExportAt);
                AddActivityLog(ExportAt);

                var searchPattern = day.ToString("yyyyMMdd");
                AddActivityLog($"Scan with {searchPattern}");

                var lines = _exportService.GetAllLines(folder, searchPattern);
                //Console.WriteLine($"Total row scans: {lines}");
                AddActivityLog($"Total row scans: {lines}");

                var output = _exportService.ReadLines(txtOutput.Text);
                ////Console.WriteLine(output);
                AddOutputFolder($"{output}");

                var ExportEnd = "Export End At" + System.DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss") + "\r\n";
                //Console.WriteLine(ExportEnd);
                AddActivityLog(ExportEnd);
            }

            // end
            MessageBox.Show("All Done!", DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss tt"));
            AddActivityLog($"All Done! {DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss tt")}");
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void AddActivityLog(string output)
        {
            if (!string.IsNullOrWhiteSpace(richtextActivityTime.Text))
            {
                richtextActivityTime.AppendText("\r\n" + output);
            }
            else
            {
                richtextActivityTime.AppendText(output);
            }
            richtextActivityTime.ScrollToCaret();
        }

        private void AddOutputFolder(string output)
        {
            if (!string.IsNullOrWhiteSpace(richTextOutput.Text))
            {
                richTextOutput.AppendText("\r\n" + output);
            }
            else
            {
                richTextOutput.AppendText(output);
            }
            richTextOutput.ScrollToCaret();
        }

        private void chooseFolderInput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogInput.ShowDialog() == DialogResult.OK)
            {
                txtAppPath.Text = folderBrowserDialogInput.SelectedPath + "\\";
            }
        }

        private void chooseFolderOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogOutput.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = folderBrowserDialogOutput.SelectedPath + "\\";
            }
        }

        private void lbGuide_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                popup.Close();
            }
            popup.Dispose();
        }
    }
}
