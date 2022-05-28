using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer2 = new Customer { Id = 2, FirstName = "ismail", Lastname = "kahraman", City = "fethiye" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Agah";
            customer3.Lastname = "Beyoğlu";             // 3 farklı şekildede customer tanımlayabilirim.
            customer3.City = "İstanbul";

            Customer customer1 = new Customer(1,"efe","beyoğlu","İstanbul");

            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer   // constructor lar class içerisinde tanımlanır.
    {
        public Customer()  // customer2 yi de o şekilde tanımlamak için bir constructor daha tanımlamam gerekir
        {

        }
        public Customer(int Id,string firstname,string lastname,string city) //customer1 i o şekilde tanımlamak için kullanılan constructor
        {
            Id = Id;
            FirstName = firstname; // new customer oluştuğunda bu blok çalışır.
            Lastname = lastname;  //Constructer yapısında bunları tanımlamazsam örneğin customer 1 i oluşturduğumda 
            // özniteliklerine teker teker ulaşamam !!
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }


    }
}
