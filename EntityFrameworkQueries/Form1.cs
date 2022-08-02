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
    }
}