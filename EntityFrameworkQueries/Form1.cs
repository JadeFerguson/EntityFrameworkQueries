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
    }
    // want to add a class to represent annonymous type
    class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorState { get; set; }

        public string VendorCity { get; set; }
    }

}