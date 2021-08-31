using System.Collections.Generic;
using gregslist_c_sharp.Models;

namespace gregslist_c_sharp
{
    public class FakeDb
    {
        public static List<House> Houses { get; set; } = new List<House>();
        public static List<Job> Jobs { get; set; } = new List<Job>();
        public static List<Car> Cars { get; set; } = new List<Car>();
    }
}