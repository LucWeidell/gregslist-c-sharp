using System.Collections.Generic;
using gregslist_c_sharp.Models;

namespace gregslist_c_sharp.Service
{
    public class HousesService
    {
        internal IEnumerable<House> Get()
        {
            return FakeDb.Houses;
        }

        internal House Get(string id)
        {
            House found = FakeDb.Houses.Find(j => j.Id == id);
            if(found == null)
            {
                throw new System.Exception("Invalid Id");
            }
            return found;
        }

        internal House Create(House rawHouse)
        {
            FakeDb.Houses.Add(rawHouse);
            return rawHouse;
        }

        internal void Delete(string id)
        {
            int deleted = FakeDb.Houses.RemoveAll(j => j.Id == id);
            if(deleted == 0)
            {
                throw new System.Exception("Invalid Id");
            }
            System.Console.WriteLine("Deleted House");

        }
    }
}