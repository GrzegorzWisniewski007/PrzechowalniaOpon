using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;


namespace PrzechowalniaOpon.entitydb
{
    public class initialize
    {
        // [snip] - As C# is purely object-oriented the following lines must be put into a class:
        // We use these three SQLite objects:
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;

        /// <summary>
        /// Initialize db Context
        /// </summary>
        /// <param name="dbName">just string</param>
        /// <param name="isNew">True or False</param>
        public initialize(string dbName, string isNew)
        {            
            sqlite_conn = new SQLiteConnection("Data Source="+ dbName+".db;Version=3;New="+ isNew+";Compress=True;");
        }

        //public Object executeModel(SQLiteDataReader result,Object model)
        //{

        //}
    }
}
