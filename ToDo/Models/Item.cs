using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private static List<Item> _instances = new List<Item>{};

        // constructor with description
        public Item(string theDescription)
        {
            _description = theDescription;
            _instances.Add(this);
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }

        // get list items
        public static List<Item> GetAll()
        {
            return _instances;
        }

    }
}