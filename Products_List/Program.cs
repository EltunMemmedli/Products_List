using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
string[][] Products = new string[][]
{
    new string[5]{"Apple", "Macbook Pro", "3000", "20", "Laptop"},
    new string[5]{"Samsung", "S22 Ultra", "2000", "30", "Phone"},
    new string[5]{"Apple", "Iphone 16 pro", "3500", "50", "Phone"},
};

Secim:
Console.WriteLine("Select the option:" +
                    "\n1. Show all products," +
                    "\n2. Show products by category," +
                    "\n3. Show total company price," +
                    "\n4. Show total price for category," +
                    "\n5. Add products," +
                    "\n6. Sell products" +
                    "\n-------------------------");

string Secim = Console.ReadLine();
int secim;

if (int.TryParse(Secim, out secim) && secim > 0 && secim < 7)
{
    if (secim == 1)
    {
        Console.Clear();

        int Counter = 1;
        foreach (var Product in Products)
        {
            Console.WriteLine($"Product {Counter++}:");
            Console.WriteLine($"Brand: {Product[0]}");
            Console.WriteLine($"Model: {Product[1]}");
            Console.WriteLine($"Price: {Product[2]}");
            Console.WriteLine($"Quantity: {Product[3]}");
            Console.WriteLine($"Category: {Product[4]}");
            Console.WriteLine("--------------------");
        }
    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }
    }

    else if(secim == 2)
    {
        Console.Clear();
        category:
        Console.WriteLine("Which category do you want?");
        string category = Console.ReadLine();
        Console.Clear();
        bool valid = false;
        foreach (var item in Products)
        {
            
            if (category.ToLower() == (string)item[4].ToString().ToLower())
            {
                valid = true;

                Console.WriteLine($"Brand: {item[0]}");
                Console.WriteLine($"Model: {item[1]}");
                Console.WriteLine($"Price: {item[2]}");
                Console.WriteLine($"Quantity: {item[3]}");
                Console.WriteLine($"Category: {item[4]}");
                Console.WriteLine("--------------------");
                
            }

        }
        if (!valid)
        {
            Console.Clear();
            Console.WriteLine("Cannot find category!");
            Thread.Sleep(1000);
            Console.Clear();
            goto category;
        }
    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }
    }

    else if (secim == 3)
    {
        Console.Clear();
        int TotalPrice = 0;

        foreach (var item in Products)
        {
            
            int price = Convert.ToInt32(item[2]); 
            int quantity = Convert.ToInt32(item[3]); 

            TotalPrice += price * quantity; 
        }

        Console.WriteLine($"Total Company Price: {TotalPrice}");

    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }
    }

    else if(secim == 4)
    {
        Console.Clear();
        Console.WriteLine("Which category do you want?");
        string category = Console.ReadLine();

        int TotalPriceByCategory = 0;
        bool valid = false; // Kateqoriya tapılıb-tapılmadığını yoxlayacaq dəyişən

        foreach (var item in Products)
        {
            if (category.ToLower() == (string)item[4].ToString().ToLower())
            {
                valid = true; // Kateqoriya tapıldı

                int price = Convert.ToInt32(item[2]);
                int quantity = Convert.ToInt32(item[3]);

                TotalPriceByCategory = TotalPriceByCategory + (price * quantity);
            }
        }

        // Kateqoriya tapılmadıqda xəbərdarlıq, tapıldıqda isə ümumi qiymət göstərilir
        if (valid)
        {
            Console.WriteLine($"Total price for category {category} is {TotalPriceByCategory}");
        }
        else
        {
            Console.WriteLine($"Category '{category}' not found.");
        }

    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }

    }

    else if(secim == 5)
    {
        string[][] NewProducts = new string[1][];

        // İstədiyiniz qədər məhsul əlavə etmək üçün NewProducts massivini yeniləyin
        NewProducts[0] = new string[5];

        Console.Clear();
    Brand:
        Console.WriteLine("Enter product's Brand:");
        string brand = Console.ReadLine();
        if (!string.IsNullOrEmpty(brand))
        {
            NewProducts[0][0] = brand;

            Console.Clear();
        Model:
            Console.WriteLine("Enter product's Model:");
            string model = Console.ReadLine();
            if (!string.IsNullOrEmpty(model))
            {
                NewProducts[0][1] = model;

                Console.Clear();
            Price:
                Console.WriteLine("Enter product's Price:");
                string priceInput = Console.ReadLine();
                if (decimal.TryParse(priceInput, out decimal price) && price > 0)
                {
                    NewProducts[0][2] = price.ToString();

                    Console.Clear();
                    Console.WriteLine("Enter product's Quantity:");
                    string quantityInput = Console.ReadLine();
                    if (int.TryParse(quantityInput, out int quantity) && quantity > 0)
                    {
                        NewProducts[0][3] = quantity.ToString();

                        Console.Clear();
                        Console.WriteLine("Enter product's Category:");
                        string category = Console.ReadLine();
                        if (!string.IsNullOrEmpty(category))
                        {
                            NewProducts[0][4] = category;

                            Console.Clear();
                            Console.WriteLine("Product added successfully!\n\n" +
                                              $"Brand: {NewProducts[0][0]}\n" +
                                              $"Model: {NewProducts[0][1]}\n" +
                                              $"Price: {NewProducts[0][2]}\n" +
                                              $"Quantity: {NewProducts[0][3]}\n" +
                                              $"Category: {NewProducts[0][4]}");

                            int length = Products.Length;
                            Array.Resize(ref Products, length + 1);
                            Products[length] = NewProducts[0];
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Category!");
                            Thread.Sleep(1000);
                            Console.Clear();
                            goto Model;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Quantity!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto Price;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Price!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Price;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Model!");
                Thread.Sleep(1000);
                Console.Clear();
                goto Model;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid Brand!");
            Thread.Sleep(1000);
            Console.Clear();
            goto Brand;
        }

    Kec:
        Thread.Sleep(2000);
        Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

        string Kec = Console.ReadLine();

        if (Kec.ToLower() == "f")
        {
            Console.Clear();
            goto Secim;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


            goto Kec;
        }


    }

    else if (secim == 6)
    {
        int say = Products.Length;
        Console.Clear();
        int Counter = 1;
        foreach (var Product in Products)
        {
            Console.WriteLine($"Product {Counter++}:");
            Console.WriteLine($"Brand: {Product[0]}");
            Console.WriteLine($"Model: {Product[1]}");
            Console.WriteLine($"Price: {Product[2]}");
            Console.WriteLine($"Quantity: {Product[3]}");
            Console.WriteLine($"Category: {Product[4]}");
            Console.WriteLine("--------------------");
        }
        ID:
        Console.Write("Write ID of the products: ");
        string ID = Console.ReadLine();
        int id;
        if (int.TryParse(ID, out id) && id > 0 && id < say + 1)
        {


            int quantity = int.Parse(Products[id - 1][3]);

            if (quantity > 0)
            {
                
                quantity--;
                Products[id - 1][3] = quantity.ToString();

                Console.Clear();
                int counter = 1;
                Console.WriteLine("Product sold successfully!\n");

                
                foreach (var Product in Products)
                {
                    Console.WriteLine($"Product {counter++}:");
                    Console.WriteLine($"Brand: {Product[0]}");
                    Console.WriteLine($"Model: {Product[1]}");
                    Console.WriteLine($"Price: {Product[2]}");
                    Console.WriteLine($"Quantity: {Product[3]}");
                    Console.WriteLine($"Category: {Product[4]}");
                    Console.WriteLine("--------------------");
                }

            Kec:
                Thread.Sleep(2000);
                Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

                string Kec = Console.ReadLine();

                if (Kec.ToLower() == "f")
                {
                    Console.Clear();
                    goto Secim;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                    goto Kec;
                }


            }
            else
            {
                Console.Clear();
                Console.WriteLine("Product has been finished");
                Thread.Sleep(1000);
                Console.Clear();
            Kec:
                Thread.Sleep(2000);
                Console.WriteLine("\nPress 'f' to return to the start or any other key to exit...");

                string Kec = Console.ReadLine();

                if (Kec.ToLower() == "f")
                {
                    Console.Clear();
                    goto Secim;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                    goto Kec;
                }

            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid ID!");
            Thread.Sleep(1000);
            Console.Clear();
            goto ID;
        }
    }
}

else
{
    Console.Clear();
    Console.WriteLine("Invalid option!");
    Thread.Sleep(1000);
    Console.Clear();
    goto Secim;
}


/*
Console.WriteLine($"Product {Counter++}:");
Console.WriteLine($"Brand: {Product[0]}");
Console.WriteLine($"Model: {Product[1]}");
Console.WriteLine($"Price: {Product[2]}");
Console.WriteLine($"Quantity: {Product[3]}");
Console.WriteLine($"Category: {Product[4]}");
Console.WriteLine("--------------------");*/