using PrzechowalniaOpon.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.models
{
    public class Treads : DefaultModel
    {
        public Treads()
        {
            this.tableName = "treads";
        }

        public int id { get; set; }
        public int tire_id { get; set; }
        public string tread { get; set; }

        public List<Tires> tires { get; set; }

        public Treads DeserializeOne(List<string> query)
        {
            this.id = Convert.ToInt32(query[0]);
            this.tire_id = Convert.ToInt32(query[1]);
            this.tread = query[2];

            return this;
        }

        public List<Treads> DeserializeMultiple(List<string> query)
        {
            List<Treads> result = new List<Treads>();
            if (query.Count() == 0)
            {
                return result;
            }
            for (int i = 0; i < query.Count(); i += 3)
            {
                result.Add(new Treads()
                {
                    id = Convert.ToInt32(query[i+0]),
                    tire_id = Convert.ToInt32(query[i+1]),
                    tread = query[i+2]
                });
            }

            return result;
        }

        private List<Treads> getTreads(int id)
        {
            TreadRepository repo = new TreadRepository();
            return repo.getTreads(id);
        }
    }
}
