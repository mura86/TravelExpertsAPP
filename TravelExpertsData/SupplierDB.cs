namespace TravelExpertsData
{
    public static class SupplierDB
    {
        public static bool DeleteSupplier(int supplierId)
        {
            using (var context = new TravelExpertsContext())
            {
                // Retrieve the supplier by id
                var supplier = context.Suppliers.FirstOrDefault(s => s.SupplierId == supplierId);

                if (supplier != null)
                {
                    // Retrieve and delete related supplier contacts
                    var supplierContacts = context.SupplierContacts.Where(sc => sc.SupplierId == supplierId).ToList();
                    context.SupplierContacts.RemoveRange(supplierContacts);

                    // Retrieve related products_suppliers
                    var productsSuppliers = context.ProductsSuppliers.Where(ps => ps.SupplierId == supplierId).ToList();

                    // Delete related booking details, packages_products_suppliers, and products_suppliers
                    foreach (var ps in productsSuppliers)
                    {
                        var bookingDetails = context.BookingDetails.Where(bd => bd.ProductSupplierId == ps.ProductSupplierId).ToList();
                        context.BookingDetails.RemoveRange(bookingDetails);

                        var packagesProductsSuppliers = context.PackagesProductsSuppliers.Where(pps => pps.ProductSupplierId == ps.ProductSupplierId).ToList();
                        context.PackagesProductsSuppliers.RemoveRange(packagesProductsSuppliers);

                        context.ProductsSuppliers.Remove(ps);
                    }

                    // Delete the supplier
                    context.Suppliers.Remove(supplier);

                    // Save changes to the database
                    context.SaveChanges();

                    // Return true if the supplier is deleted successfully
                    return true;
                }
            }
            // Return false if the supplier is not found or not deleted
            return false;
        }
    }
}