using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PasswordMatchValidator : ValidationAttribute
    {
        public string FirstPropertyName { get; set; }
        public string SecondPropertyName { get; set; }

        public PasswordMatchValidator(string firstPropertyName, string secondPropertyName)
        {
            FirstPropertyName = firstPropertyName;
            SecondPropertyName = secondPropertyName;
        }

        public override bool IsValid(object value)
        {
            Type objectType = value.GetType();

            PropertyInfo[] properties = objectType.GetProperties().Where(propertyInfo => propertyInfo.Name == FirstPropertyName
                                            || propertyInfo.Name == SecondPropertyName).ToArray();

            if (properties.Count() != 2)
            {
                throw new ApplicationException($"PasswordMatchValidator error on {objectType.Name}");
            }

            Boolean isValid = true;

            if (!Convert.ToString(properties[0].GetValue(value, null)).Equals(Convert.ToString(properties[1].GetValue(value, null))))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
