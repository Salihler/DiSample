using System.Collections.Generic;

namespace DiPatternSample
{
    public class BL
    {
        private IDAL _dal {get; set;}
        int sayi;

        public BL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}