using System.Collections.Generic;
using gregslist_c_sharp.Models;

namespace gregslist_c_sharp
{
    public class FakeDb
    {
        public List<House> houses { get; set; } = new List<House>();
        public List<Job> jobs { get; set; } = new List<Job>();
        public List<Car> cars { get; set; } = new List<Car>();
    }
}