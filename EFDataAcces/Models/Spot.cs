using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAcces.Models
{
    public class Spot
    {
        public int Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();
        public List<Image> images { get; set; } = new List<Image>();
        public User Creator { get; set; }

    }
}
