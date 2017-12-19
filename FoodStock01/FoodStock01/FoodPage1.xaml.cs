using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodStock01;
using System.Globalization;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        String s = "http://cookpad.com/search/";

        //var listView = new ListView();

        //private ObservableCollection<FoodModel> ar = new ObservableCollection<FoodModel>(FoodModel.selectFood());

        //ObservableCollection<FoodModel> Items = new ObservableCollection<FoodModel>();
        
        public FoodPage1(string title)
        {
            //タイトル
            Title = title;

            InitializeComponent();

        }

        //public class SelectedItem : IValue

        void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            {
                s += ((CheckBox)sender).Text + "　";
                //DisplayAlert("URL", s, "ok");
            }
            //選択が外された時の処理
            else
            {
                s = s.Replace(((CheckBox)sender).Text +"　", "");
                //DisplayAlert("URL", s, "ok");
            }
        }

        void Delete_Clicked(object s, EventArgs a)
        {
            ItemSource.RemoveAt(IndexOf(a));
        }

        private void ListView_ItemTapped(object sender,ItemTappedEventArgs e)
        {
            var item = (FoodModel)e.Item;

            ObservableCollection<Food> ar = Foods;

            if (await DisplayAlert("削除してよろしいですか", item.ToString(), "OK", "キャンセル"))
            {
                a.RemoveAt(ar.IndexOf(item));
                //UserModel.deleteUser(item.Id);
            }
        }

        
            /*
            private void deletebutton_Clicked(object sender,EventArgs args)
            {
                var item = (UserModel)args.Item;

                if (await DisplayAlert("削除してよろしいですか", item.ToString(), "OK", "キャンセル"))
                {
                    ar.RemoveAt(ar.IndexOf(item));
                    UserModel.deleteUser(item.Id);
                }
            }*/

            /*void OnButtonClicked(object sender, EventArgs e)
            {
                s += ((Button)sender).Text + "　";
                DisplayAlert("URL", s, "ok");
            }

            public class ButtonAndString
            {
                public Button B { set; get; }
                public String S { set; get; }
            }*/

            void OnSearch_Clicked(object sender, EventArgs args)
        {
            //ページ遷移
            Navigation.PushAsync(new NextPage(s));
        }
    }
}