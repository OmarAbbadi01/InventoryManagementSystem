using InventoryManagementSystem.model;
using InventoryManagementSystem.repository;

namespace InventoryManagementSystem.service;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public IEnumerable<Product> FindAll()
    {
        return _repository.FindAll();
    }
    
    public Product FindByName(string name)
    {
        return _repository.FindByName(name) ?? throw new InventoryException($"Product With Name {name} Not Found.");
    }

    public void DeleteByName(string name)
    {
        _repository.DeleteByName(name);
    }

    public void Update(Product product)
    {
        if (!_repository.ExistsByName(product.Name))
        {
            throw new InventoryException($"Product With Name {product.Name} Not Found.");
        }
        _repository.Update(product);
    }

    public void Create(Product product)
    {
        if (_repository.ExistsByName(product.Name))
        {
            throw new InventoryException($"Product With Name {product.Name} Already Exists.");
        }
        _repository.Create(product);
    }
}