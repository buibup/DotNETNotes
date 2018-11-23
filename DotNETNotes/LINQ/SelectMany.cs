using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class SelectMany : Base
    {
        private static Customer[] GetCustomers()
        {
            var customers = new[] {
            new Customer {
                Invoices = new[] {
                new Invoice {Id=1},
                new Invoice {Id=2},
                }
            },
            new Customer {
                Invoices = new[] {
                new Invoice {Id=3},
                new Invoice {Id=4},
                }
            },
            new Customer {
                Invoices = new[] {
                new Invoice {Id=5},
                new Invoice {Id=6},
                }
            }
            };

            return customers;
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var customers = GetCustomers();
                var allInvoicesFromAllCustomers = customers.SelectMany(c => c.Invoices);
                Utilities.PrintStart(new SelectMany().ToString());
                Console.WriteLine(
                string.Join(",", allInvoicesFromAllCustomers.Select(i => i.Id).ToArray()));
                Utilities.PrintEnd(new SelectMany().ToString());
            }
        }

        public override string ToString()
        {
            return "SelectMany";
        }
    }

    public class Invoice
    {
        public int Id { get; set; }
    }
    public class Customer
    {
        public Invoice[] Invoices { get; set; }
    }
}
