using InventoryManagementSystem.model;

namespace InventoryManagementSystem.service;

public interface IProductService
{
    IEnumerable<Product> FindAll();

    Product FindByName(string name);

    void DeleteByName(string name);

    void Update(Product product);

    void Create(Product product);
}