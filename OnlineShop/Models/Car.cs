namespace OnlineShop.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string img {  get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public int available { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }  
    }
}
