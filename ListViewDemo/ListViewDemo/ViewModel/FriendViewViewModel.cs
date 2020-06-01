using ListViewDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo.ViewModel
{
    public class FriendViewViewModel
    {
        public Command AddFriendCommand { get; set; }
        public Friend NewFriend { get; set; }
        private INavigation Navigation;

        public FriendViewViewModel(INavigation navigation)
        {
            NewFriend = new Friend();
            AddFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }

        public FriendViewViewModel(INavigation navigation, Friend friend)
        {
            NewFriend = friend;
            AddFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }

        private async Task SaveFriend()
        {
            await App.DataBase.saveItemAsync(NewFriend);
            await Navigation.PopToRootAsync();
        }
    }
}
