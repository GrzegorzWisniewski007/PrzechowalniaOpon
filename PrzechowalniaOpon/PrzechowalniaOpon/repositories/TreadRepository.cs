using PrzechowalniaOpon.common;
using PrzechowalniaOpon.entitydb;
using PrzechowalniaOpon.helpers;
using PrzechowalniaOpon.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.repositories
{
    public class TreadRepository
    {
        public initialize dbContext = new initialize("przechowalnia", "False");
        string tableName;

        Serialize serialize = new Serialize();
        Treads model = new Treads();

        public TreadRepository()
        {
            this.tableName = "treads";
        }

        public List<Treads> getTreads(int id)
        {
            // open the connection:
            dbContext.sqlite_conn.Open();

            // create a new SQL command:
            dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            dbContext.sqlite_cmd.CommandText = "SELECT * FROM " + this.tableName + " where (tire_id=" + id + ")";

            dbContext.sqlite_cmd.ExecuteNonQuery();

            var modelList = model.DeserializeMultiple(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

            // We are ready, now lets cleanup and close our connection:
            dbContext.sqlite_conn.Close();

            return modelList;
        }

        public Treads setNewTread(Treads model,int tire_id)
        {
            try
            {                
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                dbContext.sqlite_cmd.CommandText = "" +
                           "INSERT INTO '" + this.tableName + "' (" +
                           "tire_id," +
                           "tread)" +                          
                           "VALUES ('" +
                           tire_id +
                           "', '" + model.tread +                        
                           "');";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                throw ex;
            }

        }

        public Treads deleteTread(int id)
        {
            try
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                dbContext.sqlite_cmd.CommandText = "DELETE FROM '" + this.tableName + "' WHERE tire_id='" + id + "'";
                dbContext.sqlite_cmd.ExecuteNonQuery();

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                throw ex;
            }

        }
    }
}
