using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzechowalniaOpon.models
{
    public class DefaultModel
    {
        public string tableName;

        public string validationMessage(List<ValidationResult> errors)
        {
            string result = "";
            foreach (ValidationResult error in errors)
            {
                result += error.ErrorMessage + "\r\n";
            }
            return result;
        }
    }
}
