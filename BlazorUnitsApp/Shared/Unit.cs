using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUnitsApp.Shared
{
    public class Unit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Ip_Address { get; set; }

        
        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}
