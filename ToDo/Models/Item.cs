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
        // default constructor
        public Item(){}

        // constructor with description
        public Item(string theDescription)
        {
            _description = theDescription;
        }

    }
}