namespace Entities.RequestFeatures
{
    public class BookParameters : RequestParameters
    {
        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; } = 1000; //kitapların max price 1000 olarak vermiştim 
        public bool ValidPriceRange => MaxPrice > MinPrice;

    }
}
