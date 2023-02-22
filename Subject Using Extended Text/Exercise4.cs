using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject_Using_Extended_Text
{
    public partial class Exercise4 : Form
    {
        //TreeNode node = new TreeNode();
        public Exercise4()
        {
            InitializeComponent();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("FullName");
            listView1.Columns.Add("CreationTime");
            listView1.Columns.Add("LastAccessTime");
            listView1.Columns.Add("LastWriteTime");
            listView1.Columns.Add("Extension");
            listView1.View = View.Details;
        }

        private void Exercise4_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
            {
                TreeNode driveNode = new TreeNode(driveInfo.Name);
                driveNode.Nodes.Add("*");
                treeView1.Nodes.Add(driveNode);
            }

        }
        private TreeNode PopulateTreeNode(string path, TreeNode node)
        {
            try
            {
                foreach (string item in Directory.GetDirectories(path))
                {
                    TreeNode itemNode = new TreeNode(item);
                    if (Directory.GetDirectories(item).Length != 0)
                    {
                        itemNode.Nodes.Add("*");
                    }
                    node.Nodes.Add(itemNode);

                }
            }
            catch
            {

            }
            return node;
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();
            PopulateTreeNode(e.Node.Text, e.Node);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            FileInfo info = new FileInfo(e.Node.Text);
            ListViewItem list = new ListViewItem(new string[] {
                info.Name,
                info.FullName,
                info.CreationTime.ToString(),
                info.LastAccessTime.ToString(),
                info.LastWriteTime.ToString(),
                info.Extension,
            }) ;
            listView1.Items.Add(list);
        }
    }
}
