using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Saloon
{
    public class validationforid : RequiredAttribute
    {
        public bool Disabled { get; set; }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            return base.IsValid(value);
        }
    }
}