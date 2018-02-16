using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace PrzechowalniaOpon.helpers
{
    public class Serialize
    {
        public List<string> SerializeResult(SQLiteDataReader query)
        {
            List<string> result = new List<string>();
            while (query.Read()) // Read() returns true if there is still a result line to read
            {
                for (int i = 0; i < query.FieldCount; i++)
                {
                    result.Add(query.GetString(i));
                }

            }

            return result;
        }
    }
}
