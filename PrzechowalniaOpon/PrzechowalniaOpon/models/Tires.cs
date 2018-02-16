using PrzechowalniaOpon.helpers;
using PrzechowalniaOpon.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.models
{
    public class Tires : DefaultModel
    {
        public Tires()
        {
            this.tableName = "tires";
        }

        public int id { get; set; }
        [DisplayName("Producent")]
        [Required(ErrorMessage = "Producent jest wymagany.")]
        public string manufacturer { get; set; }
        [DisplayName("Rozmiar")]
        [Required(ErrorMessage = "Rozmiar jest wymagany.")]
        public string size { get; set; }
        [Browsable(false)]
        public int season_id { get; set; }
        [Browsable(false)]
        public int rims_id { get; set; }
        [DisplayName("Ilość")]
        public int quantity { get; set; }
        [Required(ErrorMessage = "Wybierz klienta.")]
        [ClientValidator]
        [Browsable(false)]
        public int client_id { get; set; }
        [DisplayName("Klient")]
        public string ClientFullname { get; set; }
        [DisplayName("Uwagi")]
        public string comments { get; set; }
        [DisplayName("Data przyjęcia")]
        public string date_creation { get; set; }
        [DisplayName("Data wydania")]
        public string date_release { get; set; }
        [Browsable(false)]
        public Clients client { get; set; }
        [Browsable(false)]
        public RimsDict rims { get; set; }
        [Browsable(false)]
        public SeasonDict season { get; set; }
        [Browsable(false)]
        public List<Treads> treads { get; set; }

        public Tires DeserializeOne(List<string> query)
        {
            this.id = Convert.ToInt32(query[0]);
            this.manufacturer = query[1];
            this.size = query[2];
            this.season_id = Convert.ToInt32(query[3]);
            this.rims_id = Convert.ToInt32(query[4]);
            this.quantity = Convert.ToInt32(query[5]);
            this.client_id = Convert.ToInt32(query[6]);
            this.comments = query[7];
            this.date_creation = query[8];
            this.date_release = query[9];
            this.ClientFullname = getClient(Convert.ToInt32(query[6])).first_name + " " + getClient(Convert.ToInt32(query[6])).last_name;
            this.treads = getTreads(Convert.ToInt32(query[0]));

            return this;
        }

        public List<Tires> DeserializeMultiple(List<string> query)
        {
            List<Tires> result = new List<Tires>();
            if (query.Count() == 0)
            {
                return result;
            }
            for (int i = 0; i < query.Count(); i += 10)
            {
                result.Add(new Tires()
                {
                    id = Convert.ToInt32(query[i + 0]),
                    manufacturer = query[i + 1],
                    size = query[i + 2],
                    season_id = Convert.ToInt32(query[i + 3]),
                    rims_id = Convert.ToInt32(query[i + 4]),
                    quantity = Convert.ToInt32(query[i + 5]),
                    client_id = Convert.ToInt32(query[i + 6]),
                    comments = query[i + 7],
                    date_creation = query[i + 8],
                    date_release = query[i + 9],
                    client = getClient(Convert.ToInt32(query[i + 6])),
                    rims = getRimsDict(Convert.ToInt32(query[i + 4])),
                    season = getSeasonDict(Convert.ToInt32(query[i + 3])),
                    ClientFullname = getClient(Convert.ToInt32(query[i + 6])).first_name + " " + getClient(Convert.ToInt32(query[i + 6])).last_name,
                    treads = getTreads(Convert.ToInt32(query[i + 0]))
                });
            }

            return result;
        }

        public Clients getClient(int id)
        {
            ClientRepository repo = new ClientRepository();
            return repo.getById(id);
        }

        private RimsDict getRimsDict(int id)
        {
            RimsDictRepository repo = new RimsDictRepository();
            return repo.getById(id);
        }

        private SeasonDict getSeasonDict(int id)
        {
            SeasonDictRepository repo = new SeasonDictRepository();
            return repo.getById(id);
        }

        private List<Treads> getTreads(int id)
        {
            TreadRepository repo = new TreadRepository();
            return repo.getTreads(id);
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ClientValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((int)value == 0)
                {
                    return new ValidationResult("Wybierz klienta z listy.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
