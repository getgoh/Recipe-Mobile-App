using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xapp.Models;
using Xapp.ViewModels;

namespace Xapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeListPage : ContentPage
	{
		public RecipeListPage ()
		{
			InitializeComponent ();

            this.BindingContext = new RecipeListViewModel();
        }

        public void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var recipe = args.Item as Recipe;
            if (recipe == null)
                return;


            Navigation.PushAsync(new RecipeSummaryPage(new RecipeViewModel(recipe)));
            // Reset the selected item
            recipeList.SelectedItem = null;
        }
    }
}