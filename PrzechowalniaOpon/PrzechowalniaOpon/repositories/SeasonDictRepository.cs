﻿using PrzechowalniaOpon.common;
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
    class SeasonDictRepository
    {
        public initialize dbContext = new initialize("przechowalnia", "False");
        string tableName;

        Serialize serialize = new Serialize();
        SeasonDict model = new SeasonDict();


        public SeasonDictRepository()
        {
            this.tableName = "season_dict";
        }

        public List<SeasonDict> getSeasons()
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

        public SeasonDict getById(int Id)
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

        public SeasonDict getByAbbr(string param)
        {
            try
            {
                // open the connection:
                dbContext.sqlite_conn.Open();

                // create a new SQL command:
                dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                dbContext.sqlite_cmd.CommandText = "SELECT * FROM '" + this.tableName + "' where abbr like '" + param + "'";

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
    }
}
