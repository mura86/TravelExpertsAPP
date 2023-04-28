namespace TravelExpertsData
{
    public class ProductDB
    {
        public static bool DeleteProduct(int productId)
        {
            using (var context = new TravelExpertsContext())
            {
                // Retrieve the product by id
                var product = context.Products.FirstOrDefault(p => p.ProductId == productId);

                if (product != null)
                {
                    // Retrieve related products_suppliers
                    var productsSuppliers = context.ProductsSuppliers.Where(ps => ps.ProductId == productId).ToList();

                    // Delete related booking details, packages_products_suppliers, and products_suppliers
                    foreach (var ps in productsSuppliers)
                    {
                        var bookingDetails = context.BookingDetails.Where(bd => bd.ProductSupplierId == ps.ProductSupplierId).ToList();
                        context.BookingDetails.RemoveRange(bookingDetails);

                        var packagesProductsSuppliers = context.PackagesProductsSuppliers.Where(pps => pps.ProductSupplierId == ps.ProductSupplierId).ToList();
                        context.PackagesProductsSuppliers.RemoveRange(packagesProductsSuppliers);

                        context.ProductsSuppliers.Remove(ps);
                    }

                    // Delete the product
                    context.Products.Remove(product);

                    // Save changes to the database
                    context.SaveChanges();

                    // Return true if the product is deleted successfully
                    return true;
                }
            }
            // Return false if the product is not found or not deleted
            return false;
        }
    }
}