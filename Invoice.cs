using System;
using System.Collections.Generic;

namespace XeroTechnicalTest
{
    public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }

        public List<InvoiceLine> LineItems = new List<InvoiceLine>();

        public void AddInvoiceLine(InvoiceLine invoiceLine)
        {
            LineItems.Add(invoiceLine);
        }

        public void RemoveInvoiceLine(int SOMEID)
        {
            LineItems.RemoveAt(SOMEID);
        }

        /// <summary>
        /// GetTotal should return the sum of (Cost * Quantity) for each line item
        /// </summary>
        public decimal GetTotal()
        {
            int total = 0;
            foreach(InvoiceLine item in LineItems)
            {
                total =+ (int)item.Cost * item.Quantity;
            }
            return total;
        }

        /// <summary>
        /// MergeInvoices appends the items from the sourceInvoice to the current invoice
        /// </summary>
        /// <param name="sourceInvoice">Invoice to merge from</param>
        public void MergeInvoices(Invoice sourceInvoice)
        {
            foreach(InvoiceLine lineItem in sourceInvoice.LineItems)
            {
                LineItems.Add(lineItem);
            }
            
        }

        /// <summary>
        /// Creates a deep clone of the current invoice (all fields and properties)
        /// </summary>
        public Invoice Clone()
        {
            Invoice cloneInvoice = new Invoice();
            cloneInvoice = this;
            return cloneInvoice;
        }

        /// <summary>
        /// Outputs string containing the following (replace [] with actual values):
        /// Invoice Number: [InvoiceNumber], InvoiceDate: [DD/MM/YYYY], LineItemCount: [Number of items in LineItems] 
        /// </summary>
        public override string ToString()
        {

        }
    }
}