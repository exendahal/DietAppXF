using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DietApp.ViewModel
{
    
    public class WelcomeImageViewModel : INotifyPropertyChanged
    {
        readonly IList<welcomeImage> source;
        public ObservableCollection<welcomeImage> welcomeImages { get; private set; }

        public WelcomeImageViewModel()
        {
            source = new List<welcomeImage>();
            CreateMonkeyCollection();

        }

        void CreateMonkeyCollection()
        {
            source.Add(new welcomeImage
            {
                img_url = "img1"
            });
            source.Add(new welcomeImage
            {
                img_url = "img1"
            });
            source.Add(new welcomeImage
            {
                img_url = "img1"
            });
            welcomeImages = new ObservableCollection<welcomeImage>(source);
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
