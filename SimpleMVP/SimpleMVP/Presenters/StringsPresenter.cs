using SimpleMVP.Models;
using SimpleMVP.Views;
using System.Windows.Forms;

namespace SimpleMVP.Presenters
{
    public class StringsPresenter
    {
        private IStringModel model_;
        private IStringView view_;

        public StringsPresenter(IStringModel model, IStringView view)
        {
            model_ = model;
            view_ = view;

            model_.SuccessLoadedData += Model__SuccessLoadedData;
            model_.LoadData();

            view_.SortingEvent += View__SortingEvent;

        }

        private void View__SortingEvent(bool sortingOrder)
        {
            model_.SuccessLoadedData += Model__SuccessLoadedData;
            model_.SortData(sortingOrder);
        }

        private void Model__SuccessLoadedData()
        {
            view_.Show(model_.GetData());
        }
    }
}
