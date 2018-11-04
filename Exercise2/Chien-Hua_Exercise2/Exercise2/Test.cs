using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var invoiceList = new[]
            {
                 new Invoice(87, "Electric Sander", 7, 57.98M),
                 new Invoice(24, "Power Saw", 18, 99.99M),
                 new Invoice(7, "Sledge Hammer", 11, 21.50M),
                 new Invoice(77, "Hammer", 76, 11.99M),
                 new Invoice(39, "Lawn Mower", 3, 79.50M),
                 new Invoice(68, "Screw Driver", 106, 6.99M),
                 new Invoice(56, "Jig saw", 21, 11.00M),

        };
            Queue<Invoice> invoiceQueue = new Queue<Invoice>();
            foreach (var invoice in invoiceList)
            {
                invoiceQueue.Enqueue(invoice);
            }
            //Use LINQ to sort the Invoice objects by PartDescription
            Console.WriteLine("Use LINQ to sort the Invoice objects by PartDescription\n");
            var sortByPartDescription = from invoice in invoiceQueue
                                        orderby invoice.PartDescription
                                        select new
                                        {
                                            invoice.PartNumber,
                                            invoice.PartDescription,
                                            invoice.Quantity,
                                            invoice.Price
                                        };

            foreach (var element in sortByPartDescription)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //Use LINQ to sort the Invoice objects by Price
            Console.WriteLine("Use LINQ to sort the Invoice objects by Price\n");
            var sortByPrice = from invoice in invoiceQueue
                              orderby invoice.Price
                              select new
                              {
                                  invoice.PartNumber,
                                  invoice.PartDescription,
                                  invoice.Quantity,
                                  invoice.Price
                              };

            foreach (var element in sortByPartDescription)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //Use LINQ to select the PartDecription and Quantity and sort the results by Quantity.
            Console.WriteLine("Use LINQ to select the PartDecription and Quantity and sort the results by Quantity\n");
            var PandQSortByQ = from invoice in invoiceQueue
                               orderby invoice.Price
                               select new { invoice.PartDescription, invoice.Quantity };

            foreach (var element in PandQSortByQ)
            {
                Console.WriteLine(element);
            }
        }
    }
}
