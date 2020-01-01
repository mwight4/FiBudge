using System;
using SQLite;

namespace FiBudge.Models
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string Frequency { get; set; }
        public float Amount { get; set; }
        public float RepeatCount { get; set; }

    }
}
