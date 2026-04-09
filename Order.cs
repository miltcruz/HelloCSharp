namespace HelloCSharp;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double Total { get; private set; }

    public Order(int orderId, string customerName, double total)
    {
        OrderId = orderId;
        CustomerName = customerName;
        Total = total;
    }

    public void ApplyDiscount(double percentage)
    {
        Total -= Total * (percentage / 100);
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Total: {Total:C}");
    }
}