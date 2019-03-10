using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xapp.Models;
using Xapp.ViewModels;
using Xapp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //var recipe = new Recipe
            //{
            //    Name = "Toast",
            //    Description = "It's toast, are you kidding?",
            //    PrepTime = new TimeSpan(0, 0, 15),
            //    CookingTime = new TimeSpan(0, 2, 0),
            //    Directions = new List<string> { "Grab bread", "Put bread in toaster", "Eat toast" }
            //};

            //MainPage = new RecipeSummaryPage(new RecipeViewModel(recipe));

            //MainPage = new NavigationPage(new RecipeListPage());

            MainPage = new NavigationPage(new Home());

            //MainPage = new RecipeAddNew();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
