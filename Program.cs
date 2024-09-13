using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp10
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = master; Trusted_Connection=True; TrustServerCertificate = True";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{

            //    await connection.OpenAsync();

            //    SqlCommand command = new SqlCommand();

            //    command.CommandText = "CREATE DATABASE OnlineStore";

            //    command.Connection = connection;

            //    await command.ExecuteNonQueryAsync();
            //    Console.WriteLine("DB created");


            //}




            //string sqlQuery_Products = "CREATE TABLE Products (ProductId  INT PRIMARY KEY IDENTITY, Name NVARCHAR(40) NOT NULL, Description NVARCHAR(40) NOT NULL,Price DECIMAL(10,2) DEFAULT 0 ,Stock INT)";
            //await ExecuteCommand(sqlQuery_Products);


            //string sqlQuery_Categories = "CREATE TABLE Categories (CategoryId INT PRIMARY KEY IDENTITY, CategoryName  NVARCHAR(40) NOT NULL)";
            //await ExecuteCommand(sqlQuery_Categories);


            //string sqlQuery_ProductCategories = "CREATE TABLE ProductCategories (ProductId  INT NOT NULL REFERENCES Products(ProductID) ON DELETE CASCADE, CategoryId   INT NOT NULL REFERENCES Categories(CategoryId ) ON DELETE CASCADE)";
            //await ExecuteCommand(sqlQuery_ProductCategories);


            //----------------------------------------------------
            ////string sqlQuery_DROPProducts = "DROP TABLE Products ";
            ////await ExecuteCommand(sqlQuery_DROPProducts);

            ////string sqlQuery_DROPCategories = "DROP TABLE Categories ";
            ////await ExecuteCommand(sqlQuery_DROPCategories);
            //------------------------------------------------------



            //Реализуй метод для добавления новых продуктов в таблицу Products

            //string sqlExpression = "INSERT INTO Products (Name, Description,Price,Stock) VALUES ('Iphone 15', 'phone',56000.00, 15),('Iphone 14', 'phone',36000.00, 5),('Xiaomi 14 Ultra','phone', 24000.00, 10),('Гарнітура HUAWEI','Аксесуары для смартфонов',2000.50, 5),('Гарнітура APPLE','Аксесуары для смартфонов',5000.50, 7)";
            //await Command_ADD_VALUES(sqlExpression);



            ////-----------------------------------------------------------
            ////Реализуй метод для добавления категорий в таблицу Categories.

            //string sqlExpressionADD_CATEGORY = "INSERT INTO Categories (CategoryName) VALUES ('phone'),('TV'), ('Аксесуары для смартфонов'),('Powerbank')";
            //await Command_ADD_CATEGORY(sqlExpressionADD_CATEGORY);



            ////-----------------------------------------------------------
            ////Реализуй метод для привязки категорий к продуктам в таблице ProductCategories

            //string sqlExpressionCategory = "INSERT INTO ProductCategories (ProductId, CategoryId) VALUES ((SELECT TOP 1 ProductId FROM Products WHERE Name = 'Iphone 15'), (SELECT CategoryId FROM Categories  WHERE CategoryName = 'phone'))";
            //await Command_Category(sqlExpressionCategory);

            //sqlExpressionCategory = "INSERT INTO ProductCategories (ProductId, CategoryId) VALUES ((SELECT TOP 1 ProductId  FROM Products WHERE Name = 'Iphone 14'), (SELECT CategoryId FROM Categories  WHERE CategoryName = 'phone'))";
            //await Command_Category(sqlExpressionCategory);

            //sqlExpressionCategory = "INSERT INTO ProductCategories (ProductId, CategoryId) VALUES ((SELECT TOP 1 ProductId FROM Products WHERE Name = 'Xiaomi 14 Ultra'), (SELECT CategoryId FROM Categories  WHERE CategoryName = 'phone'))";
            //await Command_Category(sqlExpressionCategory);

            //sqlExpressionCategory = "INSERT INTO ProductCategories (ProductId, CategoryId) VALUES ((SELECT ProductId FROM Products WHERE Name = 'Гарнітура HUAWEI'), (SELECT CategoryId FROM Categories  WHERE CategoryName = 'Аксесуары для смартфонов'))";
            //await Command_Category(sqlExpressionCategory);

            //sqlExpressionCategory = "INSERT INTO ProductCategories (ProductId, CategoryId) VALUES ((SELECT ProductId FROM Products WHERE Name = 'Гарнітура APPLE'), (SELECT CategoryId FROM Categories  WHERE CategoryName = 'Аксесуары для смартфонов'))";
            //await Command_Category(sqlExpressionCategory);



            //-----------------------------------------------------------
            //Реализуй метод для изменения цены продукта.

            //string sqlExpressionUPDATE_Price = "UPDATE Products SET Price = 55600.00 WHERE ProductId = 1";
            //await Command_UDATE_PRICE(sqlExpressionUPDATE_Price);

            //sqlExpressionUPDATE_Price = "UPDATE Products SET Price = Price * 1.10";
            //await Command_UDATE_PRICE(sqlExpressionUPDATE_Price);



            ////-----------------------------------------------------------
            ////Реализуй метод для изменения количества товара на складе

            //string sqlExpressionUPDATE_Stock = "UPDATE Products SET Stock = 25 WHERE Stock < 10";
            //await Command_UDATE_Stock(sqlExpressionUPDATE_Stock);



            ////-----------------------------------------------------------
            ////Реализуй метод для удаления продукта по его идентификатору

            //string sqlExpressionDELETE_Products = "DELETE FROM Products WHERE ProductId = 3";
            //await Command_DELETE_Products(sqlExpressionDELETE_Products);



            //-----------------------------------------------------------
            //Реализуй метод для удаления категории

            //string sqlExpressionDELETE_Categories_1 = "DELETE FROM ProductCategories WHERE CategoryId IN (SELECT CategoryId FROM Categories WHERE CategoryName = 'phone')";
            //string sqlExpressionDELETE_Categories_2 = "DELETE FROM Categories FROM Categories WHERE CategoryName = 'phone'";
            //await Command_DELETE_Categories(sqlExpressionDELETE_Categories_1, sqlExpressionDELETE_Categories_2);


            //-----------------------------------------------------------
            //Реализуй метод для изменения описания продукта

            //string sqlExpressionUPDATE_Description = "UPDATE Products SET Description  = 'Phone by APPLE' WHERE ProductId = 5";
            //await Command_UPDATE_Description(sqlExpressionUPDATE_Description);

            //sqlExpressionUPDATE_Description = "UPDATE Products SET Description  = 'Phone by APPLE' WHERE Name = 'Iphone 15'";
            //await Command_UPDATE_Description(sqlExpressionUPDATE_Description);


            //-----------------------------------------------------------
            //Реализуй метод для перевода всех продуктов из одной категории в другую

            //string sqlExpressionUPDATE_CategoryId = " UPDATE ProductCategories  SET CategoryId = 3 WHERE CategoryId != 3";
            //await Command_UPDATE_CategoryId(sqlExpressionUPDATE_CategoryId);
        }



        //В базе данных создайте таблицы
        static async Task ExecuteCommand(string sqlQuery)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlQuery;

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("Table created");


                }

            }


            //Реализуй метод для добавления новых продуктов в таблицу Products

            static async Task Command_ADD_VALUES(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    int number = await command.ExecuteNonQueryAsync();
                    Console.WriteLine($"Добавлено продуктов: {number}");


                }

            }

            //Реализуй метод для добавления категорий в таблицу Categories.


            static async Task Command_ADD_CATEGORY(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    int number = await command.ExecuteNonQueryAsync();
                    Console.WriteLine($"Добавлено категорий: {number}");

                }

            }

            //Реализуй метод для привязки категорий к продуктам в таблице ProductCategories

            static async Task Command_Category(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine(" категории привзаны к продуктам в таблице ProductCategories");


                }

            }




            //Реализуй метод для изменения цены продукта.

            static async Task Command_UDATE_PRICE(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    int number = await command.ExecuteNonQueryAsync();
                    Console.WriteLine($"цена изменена: {number} раз");


                }
            }


            //Реализуй метод для изменения количества товара на складе

            static async Task Command_UDATE_Stock(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("измененино количество товара на складе");


                }
            }


            //Реализуй метод для удаления продукта по его идентификатору

            static async Task Command_DELETE_Products(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine($"удаленино продукт по ID");

                }
            }



            //Реализуй метод для удаления категории

            static async Task Command_DELETE_Categories(string sqlExpression_1, string sqlExpression_2)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand(sqlExpression_1, connection);
                    int number = await command.ExecuteNonQueryAsync();


                    SqlCommand command_2 = new SqlCommand(sqlExpression_2, connection);
                    await command_2.ExecuteNonQueryAsync();
                    Console.WriteLine("удаленино категорию");

                }
            }


            //Реализуй метод для изменения описания продукта

            static async Task Command_UPDATE_Description(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    int number = await command.ExecuteNonQueryAsync();
                    Console.WriteLine($"измененино описание продукта: {number} раз");


                }

            }

            //Реализуй метод для перевода всех продуктов из одной категории в другую

            static async Task Command_UPDATE_CategoryId(string sqlExpression)
            {
                string connectionString = @"Data Source = DESKTOP-ITRLGSN; Initial Catalog = OnlineStore; Trusted_Connection=True; TrustServerCertificate = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = sqlExpression;

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("переводено все продукты из одной категории в другую");


                }

            }
        
    }
}