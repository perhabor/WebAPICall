using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICall.Models
{
    public class HubViewModel
    {
        public string State { get; set; }

        ICollection<Hub> Hubs { get; set; }

        public Hub Hub { get; set; }
    }
}
