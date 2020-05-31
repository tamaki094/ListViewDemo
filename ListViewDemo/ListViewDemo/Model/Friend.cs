using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewDemo.Model
{
    public class Friend
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
