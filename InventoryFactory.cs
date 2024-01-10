using InventoryManagementSystem.repository;
using InventoryManagementSystem.service;

namespace InventoryManagementSystem;

public class InventoryFactory
{
    public static IProductService ProductService()
    {
        return new ProductService(repository: ProductRepository());
    }

    private static IProductRepository ProductRepository()
    {
        return new ProductRepository();
    }

    private InventoryFactory()
    {
    }
}