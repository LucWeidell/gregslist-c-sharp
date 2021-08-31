namespace gregslist_c_sharp.Models
{
    public class Job
    {

    public string Id { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public int Rate { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }


    public Job(string jobTitle, string company, int rate, int hours, string description)
    {
      JobTitle = jobTitle;
      Company = company;
      Rate = rate;
      Hours = hours;
      Description = description;
      Id = new System.Guid().ToString();

    }
    }
}