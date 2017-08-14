using System;

namespace TheRebelsMusicWeb.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string Description { get; set; }
        public DateTime ConcertDateTime { get; set; }
        public bool IsPublic { get; set; }
    }
}