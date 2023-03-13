using FileProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;


namespace FileCombiner.FileCleaner
{
    public partial class FrmFileCleanerMain : Form
    {
        public FrmFileCleanerMain()
        {
            InitializeComponent();

            string path = "C:\\Users\\Master\\Desktop\\cleaner test";

            string[] dirPatterns =
            {
                ".vs",
                ".DS_Store",
                "Debug",
                "bin",
                "debug",
                "obj"
            };

            Finder finder = new Finder();
            finder.DirPatterns = dirPatterns;
            finder.Analyze(path);


            ObjectContainer ResultContainer = finder.ResultContainer;

            finder.ResultContainer.Dirs.ForEach(dir =>
            {
                lvRemovedItems.Items.Add(dir.FullName);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                //string filename = @"C:\Users\Master\Desktop\cleaner test";
                //Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(filename, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                foreach (var item in lvRemovedItems.CheckedItems)
                {
                    string filename = @item.ToString()!;
                    MessageBox.Show(item.ToString());

                    if (chbMoveToTrash.Checked)                       
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(filename, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);                  
                    else
                        Directory.Delete(filename);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File or directory not found!");
            }
        }
    }
}
