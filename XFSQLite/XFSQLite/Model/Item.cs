using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFSQLite.Model
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
    }
}
