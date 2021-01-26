using System;
using System.Collections.Generic;
using System.Text;

namespace GameDealer
{
    class CustomerManager
    {
  
        
        public  void Control (Customer customer)
        {
            if (customer.Name == customer.Name && customer.TcNo==customer.TcNo && customer.BirthDate == customer.BirthDate )

            {
                Console.WriteLine("Doğrulandı");

               
            }


            else

                Console.WriteLine("Girilen bilgiler eşleşmemektedir.");

        }


    }
}
