using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            // if use same context through out the whole project it can actually be a problem as it can track entities
            // can get messy if you have a bunch of different forms
            using APContext dbContext = new APContext(); // using is an object to make sure things get disposed of properly

            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList(); // query database right away

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       select v).ToList();
        }

        private void btnAllCaliVendors_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();
            List<Vendor> vendorList = dbContext.Vendors
                                       .Where(v => v.VendorState == "CA")
                                       .OrderBy(v => v.VendorName)
                                       .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            APContext dbcontext = new();

            // Annonymous type
            List<VendorLocation> results = (from v in dbcontext.Vendors
                          select new VendorLocation
                          {
                              // added VendorName = before as now it is a explicit type so no need to use var
                                VendorName = v.VendorName,
                                VendorState = v.VendorState,
                                VendorCity = v.VendorCity
                          }).ToList();

            // String builder is better for concatination for a larger list and strings are mutable
            StringBuilder displayString = new();
            foreach (VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");

            }

            // message box does not know how to show a string builder so had to add tostring
            MessageBox.Show(displayString.ToString());
        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            // Check if something exists
            bool doesExist = (from v in dbContext.Vendors
                             where v.VendorState == "WA"
                             select v).Any(); // all the aggregates have methods such as min max and sum

            // Get number of Invoices
            int invoiceCount = (from invoice in dbContext.Invoices
                                select invoice).Count(); // returns the number of entity

            // Query a single vendor
            Vendor ? singleVendor = (from v in dbContext.Vendors
                                     where v.VendorName == "IBM"
                                     select v).SingleOrDefault();

            if (singleVendor != null)
            {
                // Do something with the Vendor Object
            }
        }

        private void btnVendorsAndInvoices_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            // Vendors LEFT JOIN Invoices
            List<Vendor> allVendors = dbContext.Vendors.Include(v => v.Invoices).ToList();

            // Unfinished code: This pulls a Vendor object for each individual invoice, vendors
            // are also pulled back if they have no invoices
           /* List<Vendor> allVendors = (from v in dbContext.Vendors
                                      join inv in dbContext.Invoices
                                        on v.VendorId equals inv.VendorId into grouping
                                      from inv in grouping.DefaultIfEmpty()
                                      select v).ToList(); */

            StringBuilder results = new();

            foreach(Vendor v in allVendors)
            {
                results.Append(v.VendorName);

                foreach(Invoice inv in v.Invoices)
                {
                    results.Append(", ");
                    results.Append(inv.InvoiceNumber);
                }
                results.AppendLine();
            }

            MessageBox.Show(results.ToString());
        }
    }
    // want to add a class to represent annonymous type
    class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorState { get; set; }

        public string VendorCity { get; set; }
    }

}