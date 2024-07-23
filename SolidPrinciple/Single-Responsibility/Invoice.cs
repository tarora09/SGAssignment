using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    
        public class Invoice
        {
            public int InvoiceId { get; set; }
            public string CustomerName { get; set; }
            public double Amount { get; set; }

            public void GenerateInvoice()
            {
                Console.WriteLine("Generating Invoice...");
                Console.WriteLine($"Invoice ID: {InvoiceId}");
                Console.WriteLine($"Customer Name: {CustomerName}");
                Console.WriteLine($"Amount: {Amount}");
                Console.WriteLine("Invoice Generated Successfully.\n");
            }
        }

       

       
    }


