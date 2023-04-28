public class Packages
{
    // Properties that correspond to the columns in the Packages table
    public int PackageId { get; set; }
    public string PkgName { get; set; }
    public DateTime PkgStartDate { get; set; }
    public DateTime PkgEndDate { get; set; }
    public string PkgDesc { get; set; }
    public decimal PkgBasePrice { get; set; }
    public decimal PkgAgencyCommission { get; set; }

    // Method for adding a new package to the Packages table
    public void AddPackage()
    {
        // TODO: Implement SQL command to add package to database
    }

    // Method for updating an existing package in the Packages table
    public void UpdatePackage()
    {
        // TODO: Implement SQL command to update package in database
    }

    // Method for retrieving all packages from the Packages table
    public static List<Packages> GetAllPackages()
    {
        List<Packages> packages = new List<Packages>();

        // TODO: Implement SQL command to retrieve all packages from database

        return packages;
    }

    public class Products
{
    // Properties that correspond to the columns in the Products table
    public int ProductId { get; set; }
    public string ProdName { get; set; }

    // Method for adding a new product to the Products table
    public void AddProduct()
    {
        // TODO: Implement SQL command to add product to database
    }

    // Method for updating an existing product in the Products table
    public void UpdateProduct()
    {
        // TODO: Implement SQL command to update product in database
    }

    // Method for retrieving all products from the Products table
    public static List<Products> GetAllProducts()
    {
        List<Products> products = new List<Products>();

        // TODO: Implement SQL command to retrieve all products from database

        return products;
    }
}

public class ProductsSuppliers
{
    // Properties that correspond to the columns in the Products_suppliers table
    public int ProductSupplierId { get; set; }
    public int ProductId { get; set; }
    public int SupplierId { get; set; }

    // Method for adding a new products_supplier record to the Products_suppliers table
    public void AddProductSupplier()
    {
        // TODO: Implement SQL command to add products_supplier record to database
    }

    // Method for updating an existing products_supplier record in the Products_suppliers table
    public void UpdateProductSupplier()
    {
        // TODO: Implement SQL command to update products_supplier record in database
    }

    // Method for retrieving all products_supplier records from the Products_suppliers table
    public static List<ProductsSuppliers> GetAllProductSuppliers()
    {
        List<ProductsSuppliers> productSuppliers = new List<ProductsSuppliers>();

        // TODO: Implement SQL command to retrieve all products_supplier records from database

        return productSuppliers;
    }
}

public class Suppliers
{
    // Properties that correspond to the columns in the Suppliers table
    public int SupplierId { get; set; }
    public string SupName { get; set; }

    // Method for adding a new supplier to the Suppliers table
    public void AddSupplier()
    {
        // TODO: Implement SQL command to add supplier to database
    }

    // Method for updating an existing supplier in the Suppliers table
    public void UpdateSupplier()
    {
        // TODO: Implement SQL command to update supplier in database
    }

    // Method for retrieving all suppliers from the Suppliers table
    public static List<Suppliers> GetAllSuppliers()
    {
        List<Suppliers> suppliers = new List<Suppliers>();

        // TODO: Implement SQL command to retrieve all suppliers from database

        return suppliers;
    }
}

public class PackagesProductsSuppliers  
{
    // Properties that correspond to the columns in the Packages_products_suppliers table
    public int PackageProductSupplierId { get; set; }
    public int PackageId { get; set; }
    public int ProductSupplierId { get; set; }
    public decimal ProductSupplierPrice { get; set; }

    // Method for adding a new package_products_supplier record to the Packages_products_suppliers table
    public void AddPackageProductSupplier()
    {
        // TODO: Implement SQL command to add package_products_supplier record to database
    }

    // Method for updating an existing package_products_supplier record in the Packages_products_suppliers table
    public void UpdatePackageProductSupplier()
    {
        // TODO: Implement SQL command to update package_products_supplier record in database
    }

// Define a class to handle database operations
public class DatabaseHelper
{
    private string connectionString = "your_connection_string_here";

    // Method to retrieve a list of products from the database
    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT ProductId, ProdName, ProdDesc FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.ProdName = reader["ProdName"].ToString();
                product.ProdDesc = reader["ProdDesc"].ToString();
                products.Add(product);
            }
        }
        return products;
    }

    // Method to add a new product to the database
    public void AddProduct(Product product)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Products (ProdName, ProdDesc) VALUES (@ProdName, @ProdDesc)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName);
            cmd.Parameters.AddWithValue("@ProdDesc", product.ProdDesc);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Method to update an existing product in the database
    public void UpdateProduct(Product product)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE Products SET ProdName = @ProdName, ProdDesc = @ProdDesc WHERE ProductId = @ProductId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName);
            cmd.Parameters.AddWithValue("@ProdDesc", product.ProdDesc);
            cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Method to retrieve a list of suppliers from the database
    public List<Supplier> GetSuppliers()
    {
        List<Supplier> suppliers = new List<Supplier>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT SupplierId, SupName FROM Suppliers";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                supplier.SupName = reader["SupName"].ToString();
                suppliers.Add(supplier);
            }
        }
        return suppliers;
    }

    // Method to add a new supplier to the database
    public void AddSupplier(Supplier supplier)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Suppliers (SupName) VALUES (@SupName)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@SupName", supplier.SupName);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }