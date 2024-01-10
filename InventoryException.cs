namespace InventoryManagementSystem;

public class InventoryException : Exception
{
    private readonly string _message;

    public InventoryException(string message) : base(message)
    {
        this._message = message;
    }

}