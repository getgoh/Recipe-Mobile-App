using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xapp.Models;

namespace Xapp.ViewModels
{
    public class RecipeViewModel : INotifyPropertyChanged
    {
        private Recipe _recipe;
        public event PropertyChangedEventHandler PropertyChanged;

        public Command OnSubmitClickCommand { get; set; }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public RecipeViewModel(Recipe recipe)
        {
            _recipe = recipe;
            Directions = new ObservableCollection<Directions>(_recipe.Directions);
            OnSubmitClickCommand = new Command(OnSubmitClick);
        }

        public void OnSubmitClick()
        {
            //MessagingCenter.Send(this, "submitClick", "I came from the ViewModel!");
            Application.Current.MainPage.DisplayAlert("DIsplay title", "I came from the ViewModel!", "Cancel button?");
        }

        public ObservableCollection<Directions> Directions
        {
            get
            {
                return _recipe != null ? _recipe.Directions : null;
            }
            set
            {
                if (_recipe != null)
                {
                    _recipe.Directions = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return _recipe != null ? _recipe.Name : null; }
            set
            {
                if (_recipe != null)
                {
                    _recipe.Name = value;

                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return _recipe != null ? _recipe.Description : null; }
            set
            {
                if (_recipe != null)
                {
                    _recipe.Description = value;
                    OnPropertyChanged();
                }
            }
        }

        public string PrepTime
        {
            get { return _recipe != null ? _recipe.PrepTime.ToString() : "None"; }
            set
            {
                if (_recipe != null)
                {
                    //_recipe.PrepTime = TimeSpan.Parse(value);
                    OnPropertyChanged();
                }
            }
        }

        public string CookingTime
        {
            get { return _recipe != null ? _recipe.CookingTime.ToString() : "None"; }
            set
            {
                if (_recipe != null)
                {
                    //_recipe.CookingTime = TimeSpan.Parse(value);
                    OnPropertyChanged();
                }
            }
        }


    }
}
