namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectAllVendors = new System.Windows.Forms.Button();
            this.btnAllCaliVendors = new System.Windows.Forms.Button();
            this.btnSelectSpecificColumns = new System.Windows.Forms.Button();
            this.btnMiscQueries = new System.Windows.Forms.Button();
            this.btnVendorsAndInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            this.btnSelectAllVendors.Location = new System.Drawing.Point(57, 78);
            this.btnSelectAllVendors.Name = "btnSelectAllVendors";
            this.btnSelectAllVendors.Size = new System.Drawing.Size(361, 52);
            this.btnSelectAllVendors.TabIndex = 0;
            this.btnSelectAllVendors.Text = "Select * FROM Vendors";
            this.btnSelectAllVendors.UseVisualStyleBackColor = true;
            this.btnSelectAllVendors.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // btnAllCaliVendors
            // 
            this.btnAllCaliVendors.Location = new System.Drawing.Point(57, 167);
            this.btnAllCaliVendors.Name = "btnAllCaliVendors";
            this.btnAllCaliVendors.Size = new System.Drawing.Size(825, 52);
            this.btnAllCaliVendors.TabIndex = 1;
            this.btnAllCaliVendors.Text = "SELECT * FROM VendorsState = \'CA\' ORDER BY VendorName ASC";
            this.btnAllCaliVendors.UseVisualStyleBackColor = true;
            this.btnAllCaliVendors.Click += new System.EventHandler(this.btnAllCaliVendors_Click);
            // 
            // btnSelectSpecificColumns
            // 
            this.btnSelectSpecificColumns.Location = new System.Drawing.Point(57, 255);
            this.btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            this.btnSelectSpecificColumns.Size = new System.Drawing.Size(825, 52);
            this.btnSelectSpecificColumns.TabIndex = 2;
            this.btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState FROM Vendors";
            this.btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            this.btnSelectSpecificColumns.Click += new System.EventHandler(this.btnSelectSpecificColumns_Click);
            // 
            // btnMiscQueries
            // 
            this.btnMiscQueries.Location = new System.Drawing.Point(57, 348);
            this.btnMiscQueries.Name = "btnMiscQueries";
            this.btnMiscQueries.Size = new System.Drawing.Size(321, 201);
            this.btnMiscQueries.TabIndex = 3;
            this.btnMiscQueries.Text = "Misc. Queries";
            this.btnMiscQueries.UseVisualStyleBackColor = true;
            this.btnMiscQueries.Click += new System.EventHandler(this.btnMiscQueries_Click);
            // 
            // btnVendorsAndInvoices
            // 
            this.btnVendorsAndInvoices.Location = new System.Drawing.Point(549, 368);
            this.btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
            this.btnVendorsAndInvoices.Size = new System.Drawing.Size(293, 181);
            this.btnVendorsAndInvoices.TabIndex = 4;
            this.btnVendorsAndInvoices.Text = "SELECT All Vendors with their invoices";
            this.btnVendorsAndInvoices.UseVisualStyleBackColor = true;
            this.btnVendorsAndInvoices.Click += new System.EventHandler(this.btnVendorsAndInvoices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 604);
            this.Controls.Add(this.btnVendorsAndInvoices);
            this.Controls.Add(this.btnMiscQueries);
            this.Controls.Add(this.btnSelectSpecificColumns);
            this.Controls.Add(this.btnAllCaliVendors);
            this.Controls.Add(this.btnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCaliVendors;
        private Button btnSelectSpecificColumns;
        private Button btnMiscQueries;
        private Button btnVendorsAndInvoices;
    }
}