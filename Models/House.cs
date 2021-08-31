namespace gregslist_c_sharp.Models
{
    public class House
    {

    public string Id { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Levels { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    public string ImgUrl { get; set; }
    public string Description { get; set; }

    public House(int bedrooms, int bathrooms, int levels, int year, int price, string imgUrl, string description)
    {
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Levels = levels;
      Year = year;
      Price = price;
      ImgUrl = imgUrl;
      Description = description;
      Id = new System.Guid().ToString();

    }
    }
}