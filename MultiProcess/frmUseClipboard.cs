using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatingCode.MultiProcess
{
    /// <summary>
    /// 剪贴板Clipboard的运用
    /// </summary>
    public partial class frmUseClipboard : Form
    {
        private string currentNameSpace = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace;

        public frmUseClipboard()
        {
            InitializeComponent();
        }

        private MyPic CreateMyPicObj()
        {
            MyPic obj = new MyPic();
            obj.pic = bmp;
            obj.picInfo = info;
            return obj;
        }


        private Image bmp
        {
            get { return pictureBoxImage.Image; }
            set { pictureBoxImage.Image = value; }
        }


        private string info
        {
            get { return txtImageInfo.Text; }
            set { txtImageInfo.Text = value; }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            MyPic obj = CreateMyPicObj();

            //创建一个数据对象，将MyPic类型的对象装入
            IDataObject dataobj = new DataObject(obj);
            dataobj.SetData(DataFormats.UnicodeText, info);
            dataobj.SetData(DataFormats.Bitmap, bmp);

            //复制到剪贴板上，第二个参数表明程序退出时不清空剪贴板
            Clipboard.SetDataObject(dataobj, true);
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            ChooseImageFile();
        }

        private void ChooseImageFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(currentNameSpace+".MyPic") == false)
                return;
            
            IDataObject clipobj = Clipboard.GetDataObject();
            MyPic myPicobj = clipobj.GetData(currentNameSpace+".MyPic") as MyPic;
            info = myPicobj.picInfo;
            pictureBoxImage.Image = myPicobj.pic;
        }
    }


    [Serializable]
    class MyPic
    {
        public Image pic;   //图片
        public string picInfo;  //图片信息说明
    }
}
