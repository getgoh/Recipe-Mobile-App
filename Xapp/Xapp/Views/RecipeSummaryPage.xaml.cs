using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xapp.ViewModels;

namespace Xapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeSummaryPage : ContentPage
	{
        public RecipeSummaryPage(RecipeViewModel recipeViewModel)
        {
            InitializeComponent();

            this.BindingContext = recipeViewModel;

            //MessagingCenter.Subscribe<RecipeViewModel, string>(this, "submitClick", (sender, arg) =>
            //{
            //    DisplayAlert("DIsplay title", arg, "Cancel button?");
            //});
        }
    }
}