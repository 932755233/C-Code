using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveFile
{
    public partial class Form1 : Form
    {

        string[] extension = { ".png", ".jpg", ".gif", ".jpeg" };

        //第几个图片
        int index = -1;

        string inputStr = @"G:\QQ文档\932755233\Image\C2C";
        string outputStr = "G:\\QQ文档\\932755233\\Image\\C2C";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            tbxInput.Text = inputStr;
            lvwFiles.Columns.Add("文件名", 200);
            lvwFiles.Columns.Add("大小", 100);
            lvwFiles.Columns.Add("时间", 100);

            lvwFiles.View = View.Details;

            string[] paths = Environment.GetLogicalDrives();

            foreach(string path in paths)
            {
                TreeNode node = new TreeNode();
                node.Text = path;
                tvwDirectories.Nodes.Add(node);

                DirectoryInfo info =new DirectoryInfo(path);

                DirectoryInfo[] infos = info.GetDirectories();
                foreach(DirectoryInfo item in infos)
                {
                    node.Nodes.Add(new TreeNode(item.Name));
                }
               

            }

            
            
            


        }

        private void btnInput_Click(object sender, EventArgs e)
        {
          

            if (!"".Equals(inputStr))
            {
                fbdDirectory.SelectedPath = inputStr;
            }
            fbdDirectory.Description = "请选择一个输入文件夹";
            fbdDirectory.ShowNewFolderButton = false;
            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                inputStr = fbdDirectory.SelectedPath;
                tbxInput.Text = fbdDirectory.SelectedPath;
                openInput();
                
            }



        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //
            if (!"".Equals(outputStr))
            {
                fbdDirectory.SelectedPath = tbxInput.Text = inputStr;
            }
            fbdDirectory.Description = "请选择一个输出文件夹";
            fbdDirectory.ShowNewFolderButton = true;
            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                outputStr = fbdDirectory.SelectedPath;
                tbxOutput.Text = fbdDirectory.SelectedPath;

                  



            }
        }

        private void fbdDirectory_HelpRequest(object sender, EventArgs e)
        {
        }

        private void openInput()
        {


            lvwFiles.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

            DirectoryInfo TheFolder = new DirectoryInfo(inputStr);
            Console.WriteLine(TheFolder.GetFiles().Length);
            foreach (FileInfo NextFolder in TheFolder.GetFiles())
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("DirectoryName\t{0}", NextFolder.DirectoryName);//所在的文件夹
                Console.WriteLine("Extension\t{0}", NextFolder.Extension);//扩展名
                Console.WriteLine("FullName\t{0}", NextFolder.FullName);//文件路径加文件名
                Console.WriteLine("Name\t{0}", NextFolder.Name);//文件名
                Console.WriteLine("---------------------------------");

                var item = new ListViewItem(NextFolder.Name);
                item.SubItems.Add(NextFolder.Length.ToString());
                item.SubItems.Add(NextFolder.LastWriteTime.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss"));
                item.Tag = NextFolder.FullName;
                lvwFiles.Items.Add(item);


            }

            lvwFiles.EndUpdate();//结束数据处理，UI界面一次性绘制。


        }

        private void msInput_Click(object sender, EventArgs e)
        {
            openInput();
        }

        private void msOutput_Click(object sender, EventArgs e)
        {

        }

        private void msSaveSetting_Click(object sender, EventArgs e)
        {

        }

        private void msExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tvwDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void lvwFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                pbxPhoto.ImageLocation = lvwFiles.SelectedItems[0].Tag.ToString();
            }
        }

        private void lvwFiles_Click(object sender, EventArgs e)
        {

        }

        private void pbxPhoto_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(pbxPhoto.ImageLocation);
        }

    }
}
