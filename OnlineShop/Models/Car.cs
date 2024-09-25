namespace OnlineShop.Models
{
    public class Car
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string shortDescription { set; get; }
        public string longDescription { set; get; }
        public string img {  set; get; }
        public decimal price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryId { set; get; }
        public virtual Category Category { set; get; }  
    }
}
