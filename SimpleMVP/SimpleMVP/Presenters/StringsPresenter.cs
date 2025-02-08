using SimpleMVP.Models;
using SimpleMVP.Views;

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

        }

        private void Model__SuccessLoadedData()
        {
            view_.Show(model_.GetData());
        }
    }
}
