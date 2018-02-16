using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.models
{
    public class SeasonDict : DefaultModel
    {
        public SeasonDict()
        {
            this.tableName = "season_dict";
        }
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Sezon")]
        public string name { get; set; }
        public string abbr { get; set; }

        public SeasonDict DeserializeOne(List<string> query)
        {
            if (query.Count() == 0)
            {
                return this;
            }
            this.id = Convert.ToInt32(query[0]);
            this.name = query[1];
            this.abbr = query[2];

            return this;
        }

        public List<SeasonDict> DeserializeMultiple(List<string> query)
        {
            List<SeasonDict> result = new List<SeasonDict>();
            if (query.Count() == 0)
            {
                return result;
            }
            for (int i = 0; i < query.Count(); i += 3)
            {
                result.Add(new SeasonDict()
                {
                    id = Convert.ToInt32(query[i]),
                    name = query[i + 1],
                    abbr = query[i + 2],
                });
            }

            return result;
        }
    }
}
