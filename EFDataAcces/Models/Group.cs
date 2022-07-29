using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAcces.Models
{
    public class Group
    {
        public int Id { get; set; }
        public List<Spot> Spots { get; set; } = new List<Spot>();
        public List<User> Users { get; set; } = new List<User>();
        public List<User> Admin { get; set; } = new List<User>();

    }
}
