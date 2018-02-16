using PrzechowalniaOpon.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.helpers
{
    public class documentHelper
    {
        public string clientList(List<Clients> models)
        {
            string physicPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string htmlPath = physicPath + "\\documentTemplates\\clientList.html";
            string clients = "";
            foreach (Clients model in models)
            {
                clients += "<tr>";
                clients += "<td>" + model.first_name + "</td>";
                clients += "<td>" + model.last_name + "</td>";
                clients += "<td>" + model.email + "</td>";
                clients += "<td>" + model.phone + "</td>";
                clients += "<td>" + model.date_creation + "</td>";
                clients += "</tr>";
            }            

            StreamReader sr = new StreamReader(htmlPath);
            string html = sr.ReadToEnd();

            html = html.Replace("[clients]", clients);

            return html;
        }

        public string tireList(List<Tires> models)
        {
            string physicPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string htmlPath = physicPath + "\\documentTemplates\\tireList.html";
            string clients = "";
            foreach (Tires model in models)
            {
                clients += "<tr>";
                clients += "<td>" + model.manufacturer + "</td>";
                clients += "<td>" + model.size + "</td>";
                clients += "<td>" + model.quantity + "</td>";
                clients += "<td>" + model.ClientFullname + "</td>";
                clients += "<td>" + model.comments + "</td>";
                clients += "<td>" + model.date_creation + "</td>";
                clients += "<td>" + model.date_release + "</td>";
                clients += "</tr>";
            }

            StreamReader sr = new StreamReader(htmlPath);
            string html = sr.ReadToEnd();

            html = html.Replace("[tires]", clients);

            return html;
        }

        public string spendPdf(Tires model)
        {
            string physicPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string htmlPath = physicPath + "\\documentTemplates\\spend.html";

            StreamReader sr = new StreamReader(htmlPath);
            string html = sr.ReadToEnd();

            html = html.Replace("[client_full_name]", model.client.full_name);
            html = html.Replace("[client_email]", model.client.email);
            html = html.Replace("[client_phone]", model.client.phone);
            html = html.Replace("[create_date]", model.date_creation);
            html = html.Replace("[spend_date]", model.date_release);

            return html;
        }
    }
}
