using SimpleMVP.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleMVP
{
    public partial class Form1 : Form, IStringView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Show(List<string> strings)
        {
            StringList.DataSource = strings;
        }
    }
}
