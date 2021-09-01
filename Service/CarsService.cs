using System.Collections.Generic;
using gregslist_c_sharp.Models;

namespace gregslist_c_sharp.Service
{
    public class CarsService
    {
        internal IEnumerable<Car> Get()
        {
            return FakeDb.Cars;
        }

        internal Car Get(string id)
        {
            Car found = FakeDb.Cars.Find(j => j.Id == id);
            if(found == null)
            {
                throw new System.Exception("Invalid Id");
            }
            return found;
        }

        internal Car Create(Car rawCar)
        {
            FakeDb.Cars.Add(rawCar);
            return rawCar;
        }

        internal void Delete(string id)
        {
            int deleted = FakeDb.Cars.RemoveAll(j => j.Id == id);
            if(deleted == 0)
            {
                throw new System.Exception("Invalid Id");
            }
            System.Console.WriteLine("Deleted Car");

        }
    }
}