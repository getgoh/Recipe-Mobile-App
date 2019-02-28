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
    public partial class RecipeAddNew : ContentPage
    {
        public RecipeAddNew()
        {
            InitializeComponent();

            BindingContext = new RecipeAddViewModel();
        }
    }
}