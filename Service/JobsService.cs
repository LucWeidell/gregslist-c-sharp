using System.Collections.Generic;
using gregslist_c_sharp.Models;

namespace gregslist_c_sharp.Service
{
    public class JobsService
    {
        internal IEnumerable<Job> Get()
        {
            return FakeDb.Jobs;
        }

        internal Job Get(string id)
        {
            Job found = FakeDb.Jobs.Find(j => j.Id == id);
            if(found == null)
            {
                throw new System.Exception("Invalid Id");
            }
            return found;
        }

        internal Job Create(Job rawJob)
        {
            FakeDb.Jobs.Add(rawJob);
            return rawJob;
        }

        internal void Delete(string id)
        {
            int deleted = FakeDb.Jobs.RemoveAll(j => j.Id == id);
            if(deleted == 0)
            {
                throw new System.Exception("Invalid Id");
            }
            System.Console.WriteLine("Deleted Job");

        }
    }
}