using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Item> _items; //Empty Item List, which will contain items for certain a Category

    public Category (string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _items =  new List<Item>{}; //Creates empty list for Items
    }

    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Item> GetItems()
    {
      return _items;
    }

    public static List<Category> GetAll()
    {
      return _instances;
    }

    public void AddItem(Item item) /* Accepts Item Object */
    {
      _items.Add(item); //Adds Item to _items ( which is the Item list )
    }

    public static void Clear()
    {
      _instances.Clear();
    }
    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
