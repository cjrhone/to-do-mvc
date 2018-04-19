using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  /* Creating Item Class, which we will create instances from */
  {
    private string _description; /*Create Private string called _description*/
    private int _id; //Declaring new ID for Item Class
    private static List<Item> _instances = new List<Item> {}; /*Create private list called _instances, which will be empty for now*/

    public Item (string description)
    {
      _description = description;
      _instances.Add(this); //Referencing the item we are constructing with "this"
      _id = _instances.Count; //Gets the number of elements contained in a List
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetId()
    {
      return _id;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    // public void Save()
    // {
    //   _instances.Add(this);
    // } //No Longer needed because each item now has an ID reference
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1]; //-1 because List index starts at 0
    }

  }
}
