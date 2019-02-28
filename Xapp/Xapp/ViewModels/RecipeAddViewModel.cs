using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xapp.Helpers;
using Xapp.Models;

namespace Xapp.ViewModels
{
    public class RecipeAddViewModel : INotifyPropertyChanged
    {
        Recipe recipe;



        public RecipeAddViewModel()
        {
            this.recipe = new Recipe();
            this.OnSubmitClickCommand = new Command(OnSubmitClick);
        }

        public Command OnSubmitClickCommand { get; set; }
        public async void OnSubmitClick()
        {
            string newRecipe = "Name: " + recipe.Name;
            newRecipe += "\nDesc: " + recipe.Description;
            newRecipe += "\nPreptime: " + recipe.PrepTime;
            newRecipe += "\nCooktime: " + recipe.CookingTime;
            //await Application.Current.MainPage.DisplayAlert("Your new Recipe", newRecipe, "Okay button?");

            List<string> dirs = new List<string>();
            dirs.Add("1. This is 1");
            dirs.Add("2. This is 2");
            dirs.Add("3. This is 3");

            recipe.Directions = dirs;

            // poll API to add new
            await MyHttp<Recipe>.Post(recipe);
        }

        public string Name {
            get { return recipe != null ? recipe.Name : null; }
            set
            {
                if (recipe != null)
                {
                    recipe.Name = value;

                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return recipe != null ? recipe.Description : null; }
            set
            {
                if (recipe != null)
                {
                    recipe.Description = value;

                    OnPropertyChanged();
                }
            }
        }

        public int PrepTime
        {
            get { return recipe != null ? recipe.PrepTime : 0; }
            set
            {
                if (recipe != null)
                {
                    recipe.PrepTime = value;

                    OnPropertyChanged();
                }
            }
        }

        public int CookingTime
        {
            get { return recipe != null ? recipe.CookingTime : 0; }
            set
            {
                if (recipe != null)
                {
                    recipe.CookingTime = value;

                    OnPropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
