using System.Collections.Generic;

namespace BakeryTracker.Models

{
public class Vendor
  {
    public string Description {get; set; }
    public string Name {get; set;  }
    public int Id {get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders {get; set;  }
  
  
  
    public Vendor(string description, string name)
    {
      Description = description;
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }


    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find (int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}

