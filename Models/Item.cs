using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  /* Creating Item Class, which we will create instances from */
  {
    private string _description; /*Create Private string called _description*/
    private static List<Item> _instances = new List<Item> {}; /*Create private list called _instances, which will be empty for now*/

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
