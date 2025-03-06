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
    }
}
