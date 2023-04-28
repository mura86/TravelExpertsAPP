# TravelExpertsAPP
Final project travel experts app with SQL database

In order that employees of Travel Experts can administer the data stored on their database, they need an application that will provide a graphical interface for viewing and modifying the data.  At this point, they have identified the tables that are most important, and request that access to these be developed as a prototype.

You have already received the TravelExperts SQL Server database.  You can build your application using the existing database structure. However, there may be minor improvements that would make your programming easier, so you are free to make improvements to the database. Make sure to keep track of the SQL commands to implement these changes.

There are no restrictions on the GUI design you choose to build; it’s up to your team. Ensure that the navigation is user-friendly. Your application will need functionality that will allow the user to maintain the data in the tables listed below.

The agents need to add/edit travel packages.  This function must allow the user to enter data for the package and select from a product_supplier list to add products from suppliers to the package. Delete functionality is not required.
 
The application will also require a simple add/edit access for maintaining the product, suppliers, and product_suppliers data. Delete functionality is not required.

The tables that will be used by this project are:
1.	Packages
2.	Products
3.	Products_suppliers
4.	Suppliers
5.	Packages_products_suppliers

Make sure that you validate the data before creating a package, a product, or a supplier record.
a)	Data entered has to be appropriate for the type
b)	There is NOT NULL requirement on most columns in the tables. Data for these columns has to be provided
c)	The Agency Commission for a package cannot be greater than the Base Price
d)	The Package End Date must be later than Package Start Date
 
