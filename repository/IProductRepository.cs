using InventoryManagementSystem.model;

namespace InventoryManagementSystem.repository
{
    public interface IProductRepository
    {

        IEnumerable<Product> FindAll();

        Product? FindByName(string name);

        void DeleteByName(string name);

        void Update(Product product);

        void Create(Product product);

        bool ExistsByName(string name);
    }
}
