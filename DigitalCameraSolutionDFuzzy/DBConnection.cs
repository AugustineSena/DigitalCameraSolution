// <copyright file="DBConnection.cs" company="Ma Chung University">
// Copyright © 2017 All Rights Reserved
// Malang, East Java, Indonesia
// </copyright>
// <author> Augustine Sena aka Sena </author> 
// <summary>Example program of project campus
// Using softcomputing-fuzzy database fuzzyfy digital camera data
// Bad Recommendation for Big Data</summary>
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DigitalCameraSolutionDFuzzy
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "digital_camera_solution";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        #region INSERT OPERATION
        public void INSERT_MEMBER_AGE(int ID, 
            int age, 
            double md_earliest, 
            double md_latest)
        {
            string query = "INSERT INTO member_age "
            + "(ID,age,md_earliest,md_latest)"
            + " VALUES('" + ID
            + "', '" + age
            + "', '" + md_earliest
            + "', '" + md_latest
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_DIMENSION(int ID, 
            int dimension, 
            double md_small, 
            double md_medium, 
            double md_large)

        {
            string query = "INSERT INTO member_dimension "
            + "(ID,dimension,md_small,md_medium,md_large)"
            + " VALUES('" + ID
            + "', '" + dimension
            + "', '" + md_small
            + "', '" + md_medium
            + "', '" + md_large
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_EFFECTIVE_PIXEL(int ID, 
            double effective_pixel, 
            double md_low, 
            double md_medium, 
            double md_high)
        {
            string query = "INSERT INTO member_effective_pixel "
            + "(ID,effective_pixel,md_low,md_medium,md_high)"
            + " VALUES('" + ID
            + "', '" + effective_pixel
            + "', '" + md_low
            + "', '" + md_medium
            + "', '" + md_high
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_MAX_RESOLUTION(int ID, 
            int max_resolution, 
            double md_low, 
            double md_medium, 
            double md_high)
        {
            string query = "INSERT INTO member_max_resolution "
            + "(ID,max_resolution,md_low,md_medium,md_high)"
            + " VALUES('" + ID
            + "', '" + max_resolution
            + "', '" + md_low
            + "', '" + md_medium
            + "', '" + md_high
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_PHOTO_DETECTORS(int ID, 
            double photo_detectors, 
            double md_low, 
            double md_medium, 
            double md_high)
        {
            string query = "INSERT INTO member_photo_detectors "
            + "(ID,photo_detectors,md_low,md_medium,md_high)"
            + " VALUES('" + ID
            + "', '" + photo_detectors
            + "', '" + md_low
            + "', '" + md_medium
            + "', '" + md_high
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_PRICE(int ID, 
            int price, 
            double md_cheap, 
            double md_medium, 
            double md_expensive)
        {
            string query = "INSERT INTO member_price "
            + "(ID,price,md_cheap,md_medium,md_expensive)"
            + " VALUES('" + ID
            + "', '" + price
            + "', '" + md_cheap
            + "', '" + md_medium
            + "', '" + md_expensive
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_SCREEN_DOTS(int ID, 
            int screen_dots, 
            double md_low, 
            double md_high)
        {
            string query = "INSERT INTO member_screen_dots "
            + "(ID,screen_dots,md_low,md_high)"
            + " VALUES('" + ID
            + "', '" + screen_dots
            + "', '" + md_low
            + "', '" + md_high
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_SENSOR_SIZE(int ID, 
            double sensor_size, 
            double md_small, 
            double md_medium, 
            double md_big)
        {
            string query = "INSERT INTO member_sensor_size "
            + "(ID,sensor_size,md_small,md_medium,md_big)"
            + " VALUES('" + ID
            + "', '" + sensor_size
            + "', '" + md_small
            + "', '" + md_medium
            + "', '" + md_big
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void INSERT_MEMBER_WEIGHT(int ID,
            int weight,
            double md_light,
            double md_medium,
            double md_heavy)
        {
            string query = "INSERT INTO member_weight "
            + "(ID,weight,md_light,md_medium,md_heavy)"
            + " VALUES('" + ID
            + "', '" + weight
            + "', '" + md_light
            + "', '" + md_medium
            + "', '" + md_heavy
            + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        #endregion

        #region TRUNCATE OPERATION
        public void TRUNCATE_MEMBER_AGE()
        {
            string query = "TRUNCATE member_age ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_MEMBER_DIMENSION()
        {
            string query = "TRUNCATE member_dimension ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_MEMBER_EFFECTIVE_PIXEL()
        {
            string query = "TRUNCATE member_effective_pixel ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_MEMBER_MAX_RESOLUTION()
        {
            string query = "TRUNCATE member_max_resolution ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_MEMBER_PHOTO_DETECTORS()
        {
            string query = "TRUNCATE member_photo_detectors ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_MEMBER_PRICE()
        {
            string query = "TRUNCATE member_price ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_MEMBER_SCREEN_DOTS()
        {
            string query = "TRUNCATE member_screen_dots ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_SENSOR_SIZE()
        {
            string query = "TRUNCATE member_sensor_size ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void TRUNCATE_WEIGHT()
        {
            string query = "TRUNCATE member_weight ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        #endregion

        #region SELECT OPERATION
        public List<int> GET_PRICE_LIST()
        {
            string query = "SELECT price FROM main_data ORDER BY ID";

            //Create a list to store the result
            List<int> price=new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    price.Add(Convert.ToInt32(dataReader["price"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return price;
            }
            else
            {
                return price;
            }
        }
        public List<int> GET_RELEASE_DATE_LIST()
        {
            string query = "SELECT DATEDIFF(NOW(),release_date)'datediff' FROM main_data ORDER BY ID ";

            //Create a list to store the result
            List<int> date = new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    date.Add(Convert.ToInt32(dataReader["datediff"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return date;
            }
            else
            {
                return date;
            }
        }
        public List<int> GET_DIMENSION_SQUARECUBIC_LIST()
        {
            string query = "SELECT (dimension_width*dimension_height*dimension_dept)'dimension'FROM main_data ORDER BY ID ";

            //Create a list to store the result
            List<int> dimension = new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dimension.Add(Convert.ToInt32(dataReader["dimension"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return dimension;
            }
            else
            {
                return dimension;
            }
        }
        public List<int> GET_WEIGHT_LIST()
        {
            string query = "SELECT dimension_weight FROM main_data ORDER BY ID ";

            //Create a list to store the result
            List<int> list= new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(Convert.ToInt32(dataReader["dimension_weight"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<int> GET_SCREEN_DOTS_LIST()
        {
            string query = "SELECT screen_dots FROM main_data ORDER BY ID ";

            //Create a list to store the result
            List<int> list = new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(Convert.ToInt32(dataReader["screen_dots"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<int> GET_MAX_RESOLUTION_LIST()
        {
            string query = "SELECT(max_res_width * max_res_height)'max_res' FROM main_data ORDER BY ID";
            
            //Create a list to store the result
            List<int> list = new List<int>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(Convert.ToInt32(dataReader["max_res"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<double> GET_EFFECTIVE_PIXEL_LIST()
        {
            string query = "SELECT effective_pixel FROM main_data ORDER BY ID";

            //Create a list to store the result
            List<double> list = new List<double>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(Convert.ToDouble(dataReader["effective_pixel"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<double> GET_PHOTO_DETECTORS_LIST()
        {
            string query = " SELECT photo_detectors FROM main_data ORDER BY ID";
           
            //Create a list to store the result
            List<double> list = new List<double>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(Convert.ToDouble(dataReader["photo_detectors"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        public List<double> GET_SENSOR_SIZE_LIST()
        {
            string query = "SELECT(sensor_size_width * sensor_size_height)'sensor_size' FROM main_data ORDER BY ID";

            //Create a list to store the result
            List<double> list = new List<double>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(Convert.ToDouble(dataReader["sensor_size"].ToString()));
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        #endregion

        public int MAINDATA_LENGTH()
        {
            string query = "SELECT MAX(ID)'max' FROM main_data ";

            //Create a list to store the result
            int length = 0;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    length = Convert.ToInt32(dataReader["max"].ToString());
                }
                dataReader.Close();
                this.CloseConnection();
                return length;
            }
            else
            {
                return length;
            }
        }

        public List<string>[] ViewCameraCatalog()
        {
            string query =
               "SELECT ID,Prod_name,price,brand,main_data.type,colour,release_date," +
                "CONCAT(dimension_width, ' x ', dimension_height, ' x ', dimension_dept)'dimension',dimension_weight,screen_dots," +
                "CONCAT(max_res_width, ' x ', max_res_height)'max_res',CONCAT(image_ratio_min_w, ' : ', image_ratio_min_h, ' - ', image_ratio_max_w, ' : ', image_ratio_max_h)'image_ratio'," +
                "effective_pixel,photo_detectors,CONCAT(sensor_size_width, ' x ', sensor_size_height)'sensor_size'," +
                "CONCAT(ISO_min, ' - ', ISO_max)'ISO',White_Blnc_presets,coverage,magnification,CONCAT(shutter_speed_min, ' - ', shutter_speed_max)'shutter_speed'," +
                "flash_range,continuos_drivemax,self_timermax,exposure_comp,ae_bracketing,wb_bracketing," +
                "CONCAT(resolution_min_w, ' x ', resolution_min_h, ' - ', resolution_max_w, ' x ', resolution_max_h)'resolution'" +
                 "FROM main_data";

            //Create a list to store the result
            List<string>[] list = new List<string>[27];
            list[0] = new List<string>();list[1] = new List<string>();list[2] = new List<string>();
            list[3] = new List<string>();list[4] = new List<string>();list[5] = new List<string>();
            list[6] = new List<string>();list[7] = new List<string>();list[8] = new List<string>();
            list[9] = new List<string>();list[10] = new List<string>();list[11] = new List<string>();
            list[12] = new List<string>();list[13] = new List<string>();list[14] = new List<string>();
            list[15] = new List<string>();list[16] = new List<string>();list[17] = new List<string>();
            list[18] = new List<string>();list[19] = new List<string>();list[20] = new List<string>();
            list[21] = new List<string>();list[22] = new List<string>();list[23] = new List<string>();
            list[24] = new List<string>();list[25] = new List<string>();list[26] = new List<string>();


            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID"]+"");list[1].Add(dataReader["Prod_name"] + "");list[2].Add(dataReader["price"] + "");
                    list[3].Add(dataReader["brand"] + "");list[4].Add(dataReader["type"] + "");list[5].Add(dataReader["colour"] + "");
                    list[6].Add(dataReader["release_date"] + "");list[7].Add(dataReader["dimension"] + ""); list[8].Add(dataReader["dimension_weight"] + "");
                    list[9].Add(dataReader["screen_dots"] + ""); list[10].Add(dataReader["max_res"] + ""); list[11].Add(dataReader["image_ratio"] + "");
                    list[12].Add(dataReader["effective_pixel"] + ""); list[13].Add(dataReader["photo_detectors"] + ""); list[14].Add(dataReader["sensor_size"] + "");
                    list[15].Add(dataReader["ISO"] + ""); list[16].Add(dataReader["white_blnc_presets"] + ""); list[17].Add(dataReader["coverage"] + "");
                    list[18].Add(dataReader["magnification"] + ""); list[19].Add(dataReader["shutter_speed"] + ""); list[20].Add(dataReader["flash_range"] + "");
                    list[21].Add(dataReader["continuos_drivemax"] + ""); list[22].Add(dataReader["self_timermax"] + ""); list[23].Add(dataReader["exposure_comp"] + "");
                    list[24].Add(dataReader["ae_bracketing"] + ""); list[25].Add(dataReader["wb_bracketing"] + ""); list[26].Add(dataReader["resolution"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
    }

}
