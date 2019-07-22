using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Test
{
    [TestClass]
    public class ItemTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }
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

        [TestMethod]
        public void SetDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string updateDescription = "Do the dishes.";
            newItem.Description = updateDescription;
            string result = newItem.Description;

            Assert.AreEqual(updateDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            List<Item> newList = new List<Item>{ };
            List<Item> result = Item.GetAll();
            CollectionAssert.AreEqual(newList, result);

        }
        [TestMethod]
        public void GetAll_ReturnsItem_ItemList()
        {
            string d1 = "Walk the dog";
            string d2 = "Wash the dishes";
            Item item1 = new Item(d1);
            Item item2 = new Item(d2);
            List<Item> newList = new List<Item>{item1, item2};

            List<Item> result = Item.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }
}