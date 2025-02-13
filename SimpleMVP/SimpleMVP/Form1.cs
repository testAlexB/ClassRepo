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

        private bool sortingOrder_ = true; // значение true - по возрастанию
        public Form1()
        {
            InitializeComponent();
            presenter_ = new StringsPresenter(new ConcreteStringModel(), this);
        }

        public event Action<bool> SortingEvent;

        public void Show(List<string> data)
        {
            StringList.DataSource = null;
            StringList.DataSource = data;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            SortingEvent?.Invoke(sortingOrder_);
            sortingOrder_ = !sortingOrder_;
        }
    }
}
