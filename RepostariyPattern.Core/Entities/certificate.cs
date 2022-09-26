using RepostaryPattren.Core.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepostaryPattren.Core.Entities
{
    public class certificate
    {
        public int id { get; set; }

        public string name { get; set; }

        public ICollection<User> users { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
