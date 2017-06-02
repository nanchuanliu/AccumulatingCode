using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatingCode.MultiProcess
{
    /// <summary>
    /// 使用FileSystemWatcher实现文件监控
    /// </summary>
    public partial class frmFileReader : Form
    {
        public frmFileReader()
        {
            InitializeComponent();
        }

        private string fileName = "";

        private void LoadFile()
        {
            switch (Path.GetExtension(fileName).ToUpper())
            {
                case ".RTF":
                    rtfEditor.LoadFile(fileName);
                    break;
                case ".TXT":
                    rtfEditor.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    break;
                default:
                    MessageBox.Show("只能显示RTF和TXT格式的文件");
                    break;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                LoadFile();
                SetupFileSystemWatcher();
                Text = "监控：" + fileName;
            }
        }

        private void SetupFileSystemWatcher()
        {
            //设定监控的文件名
            fileSystemWatcher1.Filter = Path.GetFileName(fileName);
            //设定监控的文件夹名
            fileSystemWatcher1.Path = Path.GetDirectoryName(fileName);
            //指明只监控文件大小的改变
            fileSystemWatcher1.NotifyFilter=NotifyFilters.Size;

            //监控文件夹及其子文件夹的所有TXT文件
            //fileSystemWatcher1.Filter = "*.txt";
            //fileSystemWatcher1.IncludeSubdirectories = true;

            //监控对象的大小和文件名改变两个事件
            //fileSystemWatcher1.NotifyFilter = NotifyFilters.Size | NotifyFilters.FileName;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            LoadFile();
        }
    }
}

