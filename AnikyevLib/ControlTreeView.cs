using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnikyevLib
{
    public partial class ControlTreeView : UserControl
    {
        public void Clear()
        {
            treeView1.Nodes.Clear();
        }

        public bool AddNode(string text, string path)
        {
            var pathList = path.Split('/');
            var nodes = treeView1.Nodes;
            for (int i = 1; i < pathList.Length - 1; i++)
            {
                nodes = Find(nodes, pathList[i]);
                if (nodes == null) return false;
            }
            if (Find(nodes, text) != null) return false;
            nodes.Add(new TreeNode(text));
            return true;
        }
        private TreeNodeCollection Find(TreeNodeCollection nodes, string text)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Text == text)
                {
                    return nodes[i].Nodes;
                }
            }
            return null;
        }

        public ControlTreeView()
        {
            InitializeComponent();
        }
    }
}
