using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.models
{
    public class Clients : DefaultModel
    {

        public Clients()
        {
            this.tableName = "clients";
        }
        [DisplayName("Id")]
        public int id { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Pole imię wymaga minimum 3 znaków")]
        [DisplayName("Imię")]
        public string first_name { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Pole nazwisko wymaga minimum 3 znaków")]
        [DisplayName("Nazwisko")]
        public string last_name { get; set; }
        [DisplayName("Telefon")]
        public string phone { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Data dodania")]
        public DateTime date_creation { get; set; }

        public string full_name { get; set; }

        public Clients DeserializeOne(List<string> query)
        {
            if (query.Count() == 0)
            {
                return this;
            }
            this.id = Convert.ToInt32(query[0]);
            this.first_name = query[1];
            this.last_name = query[2];
            this.phone = query[3];
            this.email = query[4];
            this.date_creation = Convert.ToDateTime(query[5]);

            this.full_name = query[1] + " " + query[2];

            return this;
        }

        public List<Clients> DeserializeMultiple(List<string> query)
        {
            List<Clients> result = new List<Clients>();
            if (query.Count() == 0)
            {
                return result;
            }
            for (int i = 0; i < query.Count(); i += 6)
            {
                result.Add(new Clients()
                {
                    id = Convert.ToInt32(query[i]),
                    first_name = query[i + 1],
                    last_name = query[i + 2],
                    phone = query[i + 3],
                    email = query[i + 4],
                    date_creation = Convert.ToDateTime(query[i + 5]),
                    full_name = query[i + 1] + " " + query[i + 2]
                });
            }

            return result;
        }
    }
}
