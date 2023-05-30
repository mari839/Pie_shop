namespace BethanyPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty; //it's not going to be nullable
        public string? Description { get; set; }
        public List<Pie>? Pies { get; set; } //nullable, it means we have categories, we do not have a list of pies
    }
}

//The dependency injection takes care of it and the instance will be injected in controller automatically