using Single_Responsibility;

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice
        {
            InvoiceId = 1,
            CustomerName = "John Doe",
            Amount = 500.00
        };

        invoice.GenerateInvoice();

        
    }
}