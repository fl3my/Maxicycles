namespace Maxicycles.Models;

// This class inherits from the item class.
public class Service : Item
{
    // Get and set the maximum amount of daily services that can be done on one day.
    public int DailyMaxServices { get; set; }
}