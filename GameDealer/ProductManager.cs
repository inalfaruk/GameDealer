using System;
using System.Collections.Generic;
using System.Text;

namespace GameDealer
{
    class ProductManager
    {

        public void AddLibrary(Product product,Customer customer) 
        {

            Console.WriteLine("Sayın "+ customer.Name+" "+customer.Surname + " " +product.ProductName + " isimli oyun listenize eklenmiştir.");

        }

        public void AddLibrary(CampaignProduct product, Customer customer)  //Kampanyalı Ürün için Overload işlemi 
        {

            Console.WriteLine("Sayın " + customer.Name + customer.Surname+", " 
                + product.CampaignName + " Kampanyasından aldığınız  " + 
                product.ProductName + " isimli oyun listenize eklenmiştir.");

        }

    }
}
