using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel=Microsoft.Office.Interop.Excel;

namespace Folder_Crwaler
{
    public partial class FolderCrawler : Form
    {
        public FolderCrawler()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            double MB=20971520;
            if ((txtMB.Text.All(char.IsDigit)))
            {
                MB = Convert.ToDouble(txtMB.Text);
                MB = MB * 1024 * 1024;
            }
            Dictionary<string, string> list = new Dictionary<string, string>();
            int count = 1;
            if (!string.IsNullOrEmpty(FolderPath.Text))
            {
                if (FolderPath.Text.Contains('"'))
                {
                    FolderPath.Text=FolderPath.Text.Replace("\"", string.Empty);
                }

                foreach (var file in Directory.EnumerateFiles(
                        FolderPath.Text, "*.*", SearchOption.AllDirectories)
                        .Where(s => new FileInfo(s).Length > MB)
                        )
                {
                    FileInfo size = new FileInfo(file);

                    list.Add(file.Split('\\').Last().ToString(), Convert.ToString(size.Length / 1048576));
                    count++;
                }
                WriteToExcel(list,count);

            }
            
        }

        private void WriteToExcel(Dictionary<string,string> dict,int count)
        {
            Excel.Application oXL = new Excel.Application();
            Excel._Workbook oWB = (Excel._Workbook)(oXL.Workbooks.Add(Type.Missing));
            Excel._Worksheet oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            Excel.Range oRng;
            try
            {

                oRng = (Microsoft.Office.Interop.Excel.Range)oSheet.get_Range("A1", "D" + count);
                int row = 1;
                foreach (string key in dict.Keys)
                {
                     // Initialize for values in key.
                    
                    oSheet.Cells[row, 1].Value = key;
                    oSheet.Cells[row, 2].Value = dict[key]+" MB";
                    row++;
                }
                
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "My media list";
                saveFileDialog1.Title = "Save path of the file to be exported";
                saveFileDialog1.Filter = "Execl files (*.xls)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    oXL.ActiveWorkbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);
                    oWB.Close();
                    oXL.Quit();
                    MessageBox.Show("File has been saved successfully ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oXL.Quit();
                if (oXL != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                if (oWB != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oWB);
                oXL = null;
                oWB = null;
                GC.Collect();
            }
        }

        private void BtnSongs_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            int count = 1;
            if (!string.IsNullOrEmpty(FolderPath.Text))
            {
                if (FolderPath.Text.Contains('"'))
                {
                    FolderPath.Text = FolderPath.Text.Replace("\"", string.Empty);
                }

                foreach (var file in Directory.EnumerateFiles(
                        FolderPath.Text, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".mp3"))
                        )
                {
                    FileInfo size = new FileInfo(file);

                    list.Add(file.Split('\\').Last().ToString(), Convert.ToString(size.Length / 1048576));
                    count++;
                }
                WriteToExcel(list, count);

            }

        }

        private void Btn_SngFolders_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            int count = 1;
            if (!string.IsNullOrEmpty(FolderPath.Text))
            {
                if (FolderPath.Text.Contains('"'))
                {
                    FolderPath.Text = FolderPath.Text.Replace("\"", string.Empty);
                }

                foreach (var file in Directory.EnumerateFiles(
                        FolderPath.Text, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".mp3"))
                        )
                {
                    FileInfo size = new FileInfo(file);

                    list.Add(file, Convert.ToString(size.Length / 1048576));
                    count++;
                }
                WriteToExcel(list, count);

            }
        }

        private void Btn_MediaFldr_Click(object sender, EventArgs e)
        {
            double MB = 20971520;
            if ((txtMB.Text.All(char.IsDigit)))
            {
                MB = Convert.ToDouble(txtMB.Text);
                MB = MB * 1024 * 1024;
            }
            Dictionary<string, string> list = new Dictionary<string, string>();
            int count = 1;
            if (!string.IsNullOrEmpty(FolderPath.Text))
            {
                if (FolderPath.Text.Contains('"'))
                {
                    FolderPath.Text = FolderPath.Text.Replace("\"", string.Empty);
                }

                foreach (var file in Directory.EnumerateFiles(
                        FolderPath.Text, "*.*", SearchOption.AllDirectories)
                        .Where(s => new FileInfo(s).Length > MB)
                        )
                {
                    FileInfo size = new FileInfo(file);

                    list.Add(file, Convert.ToString(size.Length / 1048576));
                    count++;
                }
                WriteToExcel(list, count);

            }
        }

        
    }
}
