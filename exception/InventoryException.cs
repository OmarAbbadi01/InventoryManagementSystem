namespace InventoryManagementSystem.exception;

public class InventoryException : Exception
{
    public string Message { get; private set; }

    public InventoryException(string message) : base(message)
    {
        Message = message;
    }
}