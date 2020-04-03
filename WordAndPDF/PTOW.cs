using Aspose.Words;
using Spire.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAndPDF
{
    public partial class PTOW : Form
    {
        public PTOW()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.ShowDialog();
            this.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();

            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择文件的后缀名
                string extension = Path.GetExtension(fileDialog.FileName);
                //声明允许的后缀名
                string[] str = new string[] { ".pdf" };
                if (!((IList)str).Contains(extension))
                {
                    MessageBox.Show("仅能选择pdf格式的文件！");
                }
                else
                {
                    label2.Text = fileDialog.FileName;

                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string FilePath = label2.Text.ToString();
            if (FilePath.Trim() == "")
            {
                MessageBox.Show("请选择PDF文件！");
            }
            else
            {

                string FileName = Path.GetFileNameWithoutExtension(FilePath);//这个就是获取文件名的
                PdfDocument doc = new PdfDocument();
                doc.LoadFromFile(FilePath);//pdf物理路径
                string SaveStr = @"D:\" + FileName + ".docx";

                try
                {
                    doc.SaveToFile(SaveStr, FileFormat.DOCX);//生成word的物理路径
                    string message = @"成功在D:\" + "生成文件→" + FileName + ".docx";
                    DialogResult dr = MessageBox.Show(message);
                    if (dr == DialogResult.OK)
                    {
                        label2.Text = "";
                    }
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.ToString());
                }

            }
        }

       
    }
}
