using Admin_Form.Models;
using FromAe_App.Core;
using FromAe_App.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Form
{
    class UsingDB
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;
        private List<ProductSpecification> specifications;
        private List<UserModel> log_user;
        private List<OrderModel> orders;
        private List<StickerModel> stickers;
        private string connection;
        private string querry;

        // connection to db method //
        public void ConnectDB(string name_db)
        {
            connection = ConfigurationManager.ConnectionStrings[name_db].ConnectionString;
            sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
        }

        // insert data to db method //
        public void InsertToDB(string table,string values)
        {
            querry = $"INSERT INTO {table} VALUES ({values})";
            sqlCommand = new SqlCommand(querry, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        // insert edited product data to products table //
        public void InsertEditProData(string proName,string proPrice)
        {
            string querryInsertPro = $"UPDATE Products SET [ProductName] ='{proName}' ,[Price] = '{proPrice}' WHERE ProductId = {EditDataId.Id}";
            sqlCommand = new SqlCommand(querryInsertPro, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        // insert edited specification data to ProductsSpecification table //
        public void InsertEditSpeData(string model, string color,string size,string cardsCount,string innerStorage,string ram,string backCam, string froCam,string batVolume)
        {
            string querryInsertPro = $"UPDATE ProductSpefications SET [Model] ='{model}' ,[Color] = '{color}',[Sizes]='{size}',[Cards count]='{cardsCount}',[Inner storage]='{innerStorage}' " +
                $",[RAM]='{ram}',[Front Camera]='{backCam}',[Back Camera]='{froCam}',[Battery Volume]='{batVolume}' WHERE ProductId = {EditDataId.Id}";
            sqlCommand = new SqlCommand(querryInsertPro, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        // getting id from db for product specification //
        public int GetID(string name_db,string proc_name,string id_column)
        {
            ConnectDB(name_db);
            int id = 0;
            sqlCommand = new SqlCommand(proc_name, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                id = Convert.ToInt32(sqlDataReader[id_column]);
            }
            sqlDataReader.Close();
            return id;
        }

        // get all product specifications //
        public List<ProductSpecification> GetProductDetails(string name_db,string proc_name)
        {
            specifications = new List<ProductSpecification>();
            ConnectDB(name_db);
            sqlCommand = new SqlCommand(proc_name, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) 
            {
                specifications.Add(new ProductSpecification()
                {
                    Product_Name = sqlDataReader["ProductName"].ToString(),
                    Product_Photo = sqlDataReader["PhotoPath"].ToString(),
                    Product_Price = sqlDataReader["Price"].ToString(),
                    Model = sqlDataReader["Model"].ToString(),
                    Color = sqlDataReader["Color"].ToString(),
                    Size = sqlDataReader["Sizes"].ToString(),
                    Cards_Count = sqlDataReader["Cards count"].ToString(),
                    Inner_Storage = sqlDataReader["Inner Storage"].ToString(),
                    Ram = sqlDataReader["Ram"].ToString(),
                    Front_Camera = sqlDataReader["Front Camera"].ToString(),
                    Back_Camera = sqlDataReader["Back Camera"].ToString(),
                    Battery_Volume = sqlDataReader["Battery Volume"].ToString()
                });
            }
            sqlDataReader.Close();
            return specifications;
        }

        // gets user information from db //
        public List<UserModel> GetUser(string db_name)
        {
            log_user = new List<UserModel>();
            ConnectDB(db_name);
            sqlCommand = new SqlCommand("SELECT UserId,Name,Surname, Email,Password FROM Users", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                log_user.Add(new UserModel()
                {
                    UserId = sqlDataReader["UserID"].ToString(),
                    Name = sqlDataReader["Name"].ToString(),
                    Surname = sqlDataReader["Surname"].ToString(),
                    Email = sqlDataReader["Email"].ToString(),
                    Password = sqlDataReader["Password"].ToString()
                });

            }
            sqlDataReader.Close();
            return log_user;
        }

        // get orders for admin //
        public List<OrderModel> GetOrders(string db_name)
        {
            orders = new List<OrderModel>();
            ConnectDB(db_name);
            sqlCommand = new SqlCommand("GetOrders", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                orders.Add(new OrderModel()
                {
                    Order_UserName = sqlDataReader["Name"].ToString(),
                    Order_UserSurname = sqlDataReader["Surname"].ToString(),
                    ProductName = sqlDataReader["ProductName"].ToString(),
                    Product_Model = sqlDataReader["ProductModel"].ToString(),
                    Product_Price = sqlDataReader["ProdcutPrice"].ToString(),
                    Order_Date = Convert.ToDateTime(sqlDataReader["OrderDate"])
                });
            }
            sqlDataReader.Close();
            return orders;
        }

        // gets stickers for admin watch //
        public List<StickerModel> GetStickers(string db_name)
        {
            stickers = new List<StickerModel>();
            ConnectDB(db_name);
            string querry = "SELECT p.ProductId, p.[ProductName],p.[Price],ps.[Model],ps.[Color],ps.[Sizes],ps.[Cards count],ps.[Inner storage],ps.[Ram],ps.[Front camera],ps.[Back camera],ps.[Battery volume]" +
                            "FROM Products AS p INNER JOIN ProductSpefications AS ps ON p.ProductID = ps.ProductID";
            sqlCommand = new SqlCommand(querry, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                stickers.Add(new StickerModel()
                {
                    Id = Convert.ToInt32(sqlDataReader["ProductId"]),
                    Product_Name = sqlDataReader["ProductName"].ToString(),
                    Product_Price = sqlDataReader["Price"].ToString(),
                    Model = sqlDataReader["Model"].ToString(),
                    Color = sqlDataReader["Color"].ToString(),
                    Size = sqlDataReader["Sizes"].ToString(),
                    Cards_Count = sqlDataReader["Cards count"].ToString(),
                    Inner_Storage = sqlDataReader["Inner storage"].ToString(),
                    Ram = sqlDataReader["Ram"].ToString(),
                    Front_Camera = sqlDataReader["Front camera"].ToString(),
                    Back_Camera = sqlDataReader["Back camera"].ToString(),
                    Battery_Volume = sqlDataReader["Battery volume"].ToString()
                });
            }
            sqlDataReader.Close();
            return stickers;
        }

        // gets stickers data for admin to edit //
        public List<StickerModel> GetStickerDataEdit(string db_name)
        {
            stickers = new List<StickerModel>();
            ConnectDB(db_name);
            
            sqlCommand = new SqlCommand($"GetProductForEdit {EditDataId.Id}", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                stickers.Add(new StickerModel()
                {
                    Product_Name = sqlDataReader["ProductName"].ToString(),
                    Product_Price = sqlDataReader["Price"].ToString(),
                    Model = sqlDataReader["Model"].ToString(),
                    Color = sqlDataReader["Color"].ToString(),
                    Size = sqlDataReader["Sizes"].ToString(),
                    Cards_Count = sqlDataReader["Cards count"].ToString(),
                    Inner_Storage = sqlDataReader["Inner storage"].ToString(),
                    Ram = sqlDataReader["Ram"].ToString(),
                    Front_Camera = sqlDataReader["Front camera"].ToString(),
                    Back_Camera = sqlDataReader["Back camera"].ToString(),
                    Battery_Volume = sqlDataReader["Battery volume"].ToString()
                });
            }
            sqlDataReader.Close();
            return stickers;
        }

        // returns all productspecification //
        public List<ProductSpecification> GetProductSpecifications()
        {
            return specifications;
        }

        // close connection seans //
        public void DisposeSeans()
        {
            sqlConnection.Dispose();
            sqlCommand.Dispose();
        }
    }
}
