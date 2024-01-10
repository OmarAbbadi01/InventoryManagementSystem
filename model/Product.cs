namespace InventoryManagementSystem.model;

public class Product
{
    public string Name { get; set; }

    public string Price { get; set; }

    public string Quantity { get; set; }

    public Product(string name, string price, string quantity)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Price = price ?? throw new ArgumentNullException(nameof(price));
        Quantity = quantity ?? throw new ArgumentNullException(nameof(quantity));
    }
}