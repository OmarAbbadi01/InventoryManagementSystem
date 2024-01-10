using InventoryManagementSystem.model;

namespace InventoryManagementSystem.repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        
        public IEnumerable<Product> FindAll()
        {
            return _products.ToList();
        }

        public Product? FindByName(string name)
        {
            return _products.FirstOrDefault(product => product.Name.Equals(name));
        }
        
        public void Create(Product product)
        {
            this._products.Add(product);
        }

        public void DeleteByName(string name)
        {
            this._products.RemoveAll(product => product.Name.Equals(name));
        }

        public void Update(Product product)
        {
            var index = _products.FindIndex(product1 => product1.Name.Equals(product.Name));
            _products[index] = product;
        }

        public bool ExistsByName(string name)
        {
            return this._products.Exists(product => product.Name.Equals(name));
        }
    }
}
