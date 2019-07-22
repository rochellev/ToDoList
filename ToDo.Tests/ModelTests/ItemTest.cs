using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDoList.Models;

namespace ToDoList.Test
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new Item();
            Assert.AreEqual(typeof(Item), newItem.GetType());
            
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string result = newItem.Description;
            Assert.AreEqual(description, result);
        }
    }
}