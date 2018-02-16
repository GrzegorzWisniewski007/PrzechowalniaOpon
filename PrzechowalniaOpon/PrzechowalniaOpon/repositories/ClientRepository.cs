using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrzechowalniaOpon.entitydb;
using PrzechowalniaOpon.models;
using PrzechowalniaOpon.common;

namespace PrzechowalniaOpon.helpers
{
    public class ClientRepository
    {
        public initialize dbContext = new initialize("przechowalnia", "False");
        string tableName;

        Serialize serialize = new Serialize();
        Clients model = new Clients();


        public ClientRepository()
        {
            this.tableName = "clients";
        }

        public List<Clients> getClients()
        {
            try
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
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                return null;
            }

        }

        public Clients getById(int Id)
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
                return null;
            }

        }

        public Clients getByName(string name)
        {
            try
            {
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                dbContext.sqlite_cmd.CommandText = "SELECT * FROM '" + this.tableName + "' where first_name like '" + name + "'";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                model = model.DeserializeOne(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                return null;
            }

        }

        public Clients getByEmail(string email)
        {
            try
            {
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                dbContext.sqlite_cmd.CommandText = "SELECT * FROM '" + this.tableName + "' where email = '" + email + "'";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                model = model.DeserializeOne(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                return null;
            }

        }

        public Clients getByPhone(string phone)
        {
            try
            {
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                dbContext.sqlite_cmd.CommandText = "SELECT * FROM '" + this.tableName + "' where phone = '" + phone + "'";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                model = model.DeserializeOne(serialize.SerializeResult(dbContext.sqlite_cmd.ExecuteReader()));

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                return null;
            }

        }

        public Clients setNewClient(Clients client)
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
                           "INSERT INTO '" + this.tableName + "' (first_name,last_name,phone,email,date_creation) " +
                           "VALUES ('" + client.first_name + "', '" + client.last_name + "','" + client.phone + "','" + client.email + "','" + now.ToString("yyyy-MM-dd HH:mm:ss") + "');";

                dbContext.sqlite_cmd.ExecuteNonQuery();

                // We are ready, now lets cleanup and close our connection:
                dbContext.sqlite_conn.Close();

                return model;
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                return null;
            }

        }

        public Clients deleteClientById(int id)
        {
            try
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
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
                return null;
            }

        }

        public Clients updateClient(Clients model)
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
                    "first_name='" + model.first_name + "'," +
                    "last_name='" + model.last_name + "'," +
                    "phone='" + model.phone + "'," +
                    "email='" + model.email + "' " +
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



    }
}
