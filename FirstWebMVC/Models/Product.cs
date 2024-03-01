namespace FirstWebMVC.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Location { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string title, string description, string image, string location, decimal price)
    {
        Id = id;
        Title = title;
        Description = description;
        Image = image;
        Location = location;
        Price = price;
    }
}