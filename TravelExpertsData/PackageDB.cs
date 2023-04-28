namespace TravelExpertsData
{
    public static class PackageDB
    {
        public static bool DeletePackage(int packageId)
        {
            using (var context = new TravelExpertsContext())
            {
                // Retrieve the package by id
                var package = context.Packages.FirstOrDefault(p => p.PackageId == packageId);

                if (package != null)
                {
                    // Retrieve related packages_products_suppliers
                    var packagesProductsSuppliers = context.PackagesProductsSuppliers
                        .Where(pps => pps.PackageId == packageId)
                        .ToList();

                    // For each packages_products_suppliers entry
                    foreach (var pps in packagesProductsSuppliers)
                    {
                        // Handle other foreign keys in the Packages_Products_Suppliers table if any
                        // For example: 
                        // var relatedEntities = context.RelatedEntities
                        //                            .Where(re => re.PackagesProductsSuppliersId == pps.Id)
                        //                            .ToList();
                        // context.RelatedEntities.RemoveRange(relatedEntities);

                        // Delete the packages_products_suppliers entry
                        context.PackagesProductsSuppliers.Remove(pps);
                    }

                    // Delete the package
                    context.Packages.Remove(package);

                    // Save changes to the database
                    context.SaveChanges();

                    // Return true if the package is deleted successfully
                    return true;
                }
            }
            // Return false if the package is not found or not deleted
            return false;
        }
    }
}