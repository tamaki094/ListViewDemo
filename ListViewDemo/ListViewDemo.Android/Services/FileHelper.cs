using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using ListViewDemo.Droid.Services;
using ListViewDemo.Services;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]
namespace ListViewDemo.Droid.Services
{
    public class FileHelper : IFileHelper
    {
        public string getLocalFilePath(string FileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal); //accediendo al folder personal de cada dispositivo
            return Path.Combine(path, FileName);
        }
    }
}