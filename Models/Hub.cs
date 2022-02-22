using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICall.Models
{
    public class Hub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string Tag { get; set; }
        public string Image { get; set; }

    }

    public class Hubs
    {
        public Hubs()
        {
            HubList = new List<Hub>();
        }
        public List<Hub> HubList { get; set; }
        public string State { get; set; }
        public Hub Hub { get; set; }
    }
}