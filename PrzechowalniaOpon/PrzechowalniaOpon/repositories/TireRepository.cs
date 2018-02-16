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
    public class TireRepository
    {
        public initialize dbContext = new initialize("przechowalnia", "False");
        string tableName;

        Serialize serialize = new Serialize();
        Tires model = new Tires();

        public TireRepository()
        {
            this.tableName = "tires";
        }

        public List<Tires> getTires()
        {
            // open the connection:
            dbContext.sqlite_conn.Open();

            // create a new SQL command:
            dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            dbContext.sqlite_cmd.CommandText = "SELECT * FROM " + this.tableName + "";

            dbContext.sqlite_cmd.ExecuteNonQuery();

            var modelList = model.DeserializeMultiple(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

            // We are ready, now lets cleanup and close our connection:
            dbContext.sqlite_conn.Close();

            return modelList;
        }

        public Tires setNewTire(Tires model)
        {
            try
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                dbContext.sqlite_cmd.CommandText = "" +
                           "INSERT INTO '" + this.tableName + "' (" +
                           "manufacturer," +
                           "size," +
                           "season_id," +
                           "rims_id," +
                           "quantity," +
                           "client_id," +
                           "comments," +
                           "date_creation," +
                           "date_release) " +
                           "VALUES ('" +
                           model.manufacturer +
                           "', '" + model.size +
                           "','" + model.season_id +
                           "','" + model.rims_id +
                           "','" + model.quantity +
                           "','" + model.client_id +
                           "','" + model.comments +
                           "','" + now.ToString("yyyy-MM-dd HH:mm:ss") +
                            "','" + model.date_release +
                           "');";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                int id = getLast().id;

                if (model.treads != null)
                {
                    TreadRepository treadRepo = new TreadRepository();                    
                    foreach(Treads t in model.treads)
                    {
                        treadRepo.setNewTread(t, id);
                    }
                    
                }

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                throw ex;
            }

        }

        public Tires updateTire(Tires model)
        {
            try
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                dbContext.sqlite_cmd.CommandText = "UPDATE " + this.tableName
                    + " SET " +
                    "manufacturer='" + model.manufacturer + "'," +
                    "size='" + model.size + "'," +
                    "season_id='" + model.season_id + "'," +
                    "rims_id='" + model.rims_id + "'," +
                    "quantity='" + model.quantity + "'," +
                    "client_id='" + model.client_id + "'," +
                    "comments='" + model.comments + "' " +
                    //"date_creation='" + model.date_creation + "'," +
                    //"date_release='" + model.date_release + "' " +                    
                    "where id=" + model.id + ";";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                if (model.treads != null)
                {
                    TreadRepository treadRepo = new TreadRepository();
                    treadRepo.deleteTread(model.id);
                    foreach (Treads t in model.treads)
                    {
                        treadRepo.setNewTread(t, model.id);
                    }

                }

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                throw ex;
            }
        }
        public Tires spendTire(Tires model)
        {
            try
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                dbContext.sqlite_cmd.CommandText = "UPDATE " + this.tableName
                    + " SET " +
                    "date_release='" + model.date_release + "' " +
                    "where id=" + model.id + ";";

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

        public Tires deleteTireById(int id)
        {
            try
            {
                //najpierw usuwam stany biezkinow
                TreadRepository treadRepo = new TreadRepository();
                treadRepo.deleteTread(id);

                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                dbContext.sqlite_cmd.CommandText = "DELETE FROM '" + this.tableName + "' WHERE id='" + id + "'";
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

        public Tires getById(int Id)
        {
            try
            {
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                dbContext.sqlite_cmd.CommandText = "SELECT * FROM " + this.tableName + " where (id=" + Id + ")";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                model = model.DeserializeOne(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

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

        public Tires getLast()
        {
            try
            {
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                dbContext.sqlite_cmd.CommandText = "SELECT * FROM " + this.tableName + " ORDER BY id DESC LIMIT 1";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                model = model.DeserializeOne(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

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
