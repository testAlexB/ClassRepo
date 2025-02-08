using SimpleMVP.Models;
using SimpleMVP.Presenters;
using SimpleMVP.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleMVP
{
    public partial class Form1 : Form, IStringView
    {
        private StringsPresenter presenter_;
        public Form1()
        {
            InitializeComponent();
            presenter_ = new StringsPresenter(new ConcreteStringModel(), this);
        }

        public void Show(List<string> data)
        {
            StringList.DataSource = data;
        }
    }
}
