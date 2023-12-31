﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace todolist_project
{
    internal class Database
    {
        static readonly string server = "127.0.0.1";
        static readonly string username = "root";
        static readonly string password = "";
        static readonly string database = "gecicsharp";
        public static string connection_string = "server='" + server + "'; username='" + username + "'; database='" + database + "';password='" + password + "'";
        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);

        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Kezeljük a kivételt vagy dobhatjuk tovább a hívónak
                // A részletes hibainformációkat logolhatjuk vagy megjeleníthetjük
                Console.WriteLine($"Hiba a kapcsolódás során: {ex.Message}");
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Hiba a kapcsolat lezárása során: {ex.Message}");
                return false;
            }
        }


    }
}
