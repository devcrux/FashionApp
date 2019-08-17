using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> AllCategories { get => GetCategories(); }

        private List<Category> GetCategories()
        {
            var catList = new List<Category>();
            catList.Add(new Category { Image = "summerCol.png", Title = "SUMMER COLLECTION", Caption = "BEST DISCOUNT THIS SEASON" });
            catList.Add(new Category { Image = "womenCol.png", Title = "WOMEN'S CLOTHINGS", Caption = "UP TO 50% OFF ON EVERY ITEM" });
            catList.Add(new Category { Image = "elegantCol.png", Title = "ELEGANT CLOTHINGS", Caption = "UNQUE COLLECTIONS AND STYLES" });
            return catList;
        }
    }
}