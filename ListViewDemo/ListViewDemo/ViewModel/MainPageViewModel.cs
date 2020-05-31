using ListViewDemo.Helpers;
using ListViewDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }

        public MainPageViewModel()
        {
            FriendRepository repository = new FriendRepository();
            Friends = repository.getAllGrouped();
        }
    }
}
