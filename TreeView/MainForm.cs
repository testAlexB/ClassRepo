using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeView.Models;

namespace TreeView
{
    public partial class MainForm: Form
    {
        private List<TreeNodeModel> treeData_;
        public MainForm()
        {
            InitializeComponent();

            treeData_ = new List<TreeNodeModel>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                treeData_.Add(new TreeNodeModel("РФ"));
                var russianNode = treeData_[0];
                var torzhok = russianNode.AddChildNode("Торжокский");
                torzhok.AddChildNode("Грузины");
                torzhok.AddChildNode("Мошки");
                torzhok.AddChildNode("Высокое");

                russianNode.AddChildNode("Осташковский");
                russianNode.AddChildNode("Сонковский");
            }


            treeData_.Add(new TreeNodeModel("USA"));

            FillTreeNodeCollection(treeData_, MyTreeView.Nodes);

            MyTreeView.ExpandAll();
        }

        static private void FillTreeNodeCollection(List<TreeNodeModel> sourceData, //данные источника - модели
                                                   TreeNodeCollection targetData) // данные приемника - представления
        {
            foreach(var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name); // объект узла в представлении
                targetData.Add(treeNode); // добавили узел в дерево

                if(node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes); //переносим дочерние элементы узла модели в дочерние элементы узла представления
                }
            }
        }

        private void MyTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show($"Вы дважды кликнули на узел: {e.Node.Text}");
        }

        private void MyTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show($"Вы развернули узел: {e.Node.Text}");
        }

        private void MyTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show($"Вы свернули узел: {e.Node.Text}");
        }

        private void MyTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            MessageBox.Show($"Вы хотите развернуть узел: {e.Node.Text}");
        }

        private void MyTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            MessageBox.Show($"Вы хотите свернуть узел: {e.Node.Text}");
        }
    }
}
