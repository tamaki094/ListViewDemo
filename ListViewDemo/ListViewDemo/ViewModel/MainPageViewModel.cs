using ListViewDemo.Helpers;
using ListViewDemo.Model;
using ListViewDemo.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }
        public Command AddFriendCommand { get; set; }
        private INavigation Navigation;
        public Command ItemTappedCommand { get; set; }
        private Friend _currentFriend { get; set; }

        public Friend CurrentFriend
        {
            get
            {
                return _currentFriend;
            }
            set
            {
                _currentFriend = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPageViewModel(INavigation navigation)
        {
            FriendRepository repository = new FriendRepository();
            Friends = repository.getAllGrouped();

            Navigation = navigation;

            AddFriendCommand = new Command(async () => await NavigateToFriendView());
            ItemTappedCommand = new Command(async () => await NavigateToEditFriendView());

        }

        private async Task NavigateToEditFriendView()
        {
            await Navigation.PushAsync(new FriendView(CurrentFriend));
        }

        private async Task NavigateToFriendView()
        {
            await Navigation.PushAsync(new FriendView());
        }
    }
}
