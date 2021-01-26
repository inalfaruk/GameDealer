using System;

namespace GameDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.TcNo = "222";
            customer.Name = "Faruk";
            customer.Surname = "İnal";
            customer.BirthDate = Convert.ToDateTime("30.07.1992");

            CustomerManager customermanager = new CustomerManager();
            customermanager.Control(customer);

            Product product = new Product();
            product.Id = 1;
            product.ProductName = "COD";
            product.UnitPrice = 100;

            ProductManager productmanager = new ProductManager();
            productmanager.AddLibrary(product,customer);



            CampaignProduct campaignproduct = new CampaignProduct();
            campaignproduct.Id = 2;
            campaignproduct.ProductName = "Farcry";
            campaignproduct.UnitPrice = 400;
            campaignproduct.CampaignName = "Bahar Kampanyası";
            campaignproduct.Discount = 20/100;


            productmanager.AddLibrary(campaignproduct,customer);





        }
    }
}
