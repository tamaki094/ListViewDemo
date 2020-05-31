using ListViewDemo.Data;
using ListViewDemo.Model;
using ListViewDemo.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
    public partial class App : Application
    {
        private static FriendDataBase database;
        
        public static FriendDataBase DataBase
        {
            get
            {
                if(database == null)
                {
                    database = new FriendDataBase(DependencyService.Get<IFileHelper>().getLocalFilePath("friendsdb.db3")) ;
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
