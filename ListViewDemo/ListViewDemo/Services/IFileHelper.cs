using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewDemo.Services
{
    public interface IFileHelper
    {
        string getLocalFilePath(string FileName);
    }
}
