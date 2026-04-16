using System;

class Product
{
    public double price;
    public string product;
    public int id;
    public int stock;
    
    public double cPrice;
    public int cId;
    public string cProduct;
    public int cQuantity;
    
    public void DisplayMenu()
    {
        Console.WriteLine
        ("  " + price + "              " + product + " " + id + "             " + stock);
    }
    
    public void AnotherMethod()
    {
        Console.WriteLine("\n\n===== Come Back Soon! ====");

    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[15];
        Product[] cart = new Product[15];
        int tt = 0;
        int count = 0;

        products[0] = new Product();
        products[0].price = 400;
        products[0].product = "Rice (5 kg)              ";
        products[0].id = 101;
        products[0].stock = 160;
        
        products[1] = new Product();
        products[1].price = 160;
        products[1].product = "Pandesal (12 pcs.)       ";
        products[1].id = 102;
        products[1].stock = 115;
        
        products[2] = new Product();
        products[2].price = 130;
        products[2].product = "Noodles (double pack)    ";
        products[2].id = 103;
        products[2].stock = 225;
        
        products[3] = new Product();
        products[3].price = 210;
        products[3].product = "Chicken (1 kg)           ";
        products[3].id = 201;
        products[3].stock = 115;
        
        products[4] = new Product();
        products[4].price = 195;
        products[4].product = "Eggs (1 tray)            ";
        products[4].id = 202;
        products[4].stock = 90;
        
        products[5] = new Product();
        products[5].price = 270;
        products[5].product = "Pork (1 kg)              ";
        products[5].id = 203;
        products[5].stock = 90;
        
        products[6] = new Product();
        products[6].price = 100;
        products[6].product = "Pechay (5 bundles)       ";
        products[6].id = 301;
        products[6].stock = 140;
        
        products[7] = new Product();
        products[7].price = 190;
        products[7].product = "Bananas (2 kg)           ";
        products[7].id = 302;
        products[7].stock = 75;
        
        products[8] = new Product();
        products[8].price = 110;
        products[8].product = "Potatoes (1 kg)          ";
        products[8].id = 303;
        products[8].stock = 60;
        
        products[9] = new Product();
        products[9].price = 195;
        products[9].product = "Cooking Oil (1 L)        ";
        products[9].id = 401;
        products[9].stock = 120;
        
        products[10] = new Product();
        products[10].price = 150;
        products[10].product = "Soy Sauce (2 bottles)    ";
        products[10].id = 402;
        products[10].stock = 140;
        
        products[11] = new Product();
        products[11].price = 130;
        products[11].product = "Sugar (2 kg)             ";
        products[11].id = 403;
        products[11].stock = 160;
        
        products[12] = new Product();
        products[12].price = 185;
        products[12].product = "Fresh Milk (carton)      ";
        products[12].id = 501;
        products[12].stock = 110;
        
        products[13] = new Product();
        products[13].price = 140;
        products[13].product = "Body Wash                ";
        products[13].id = 502;
        products[13].stock = 150;
        
        products[14] = new Product();
        products[14].price = 100;
        products[14].product = "Dishwashing Liquid (1 L) ";
        products[14].id = 503;
        products[14].stock = 185;

        char o = 'y';
        int ti = 0;
        
        while (char.ToLower(o) == 'y')
        {
            ti++;
            
            if (ti == 1)
            {
                Console.WriteLine("=== TRONO'S STORE MENU ===");
                Console.WriteLine("========= GROCERY ========");
                
            }
            else
            {
                Console.WriteLine("\n\n=== TRONO'S STORE MENU ===");
                Console.WriteLine(    "===== UPDATED GROCERY ====");
                
            }
            string[] aisle =
            {
                "1 - Rice & Grains",
                "2 - Proteins",
                "3 - Vegetables & Fruits",
                "4 - Pantry & Essentials",
                "5 - Household & Personal Care"
            };
            for (int c = 1; c <= 5; c++)
            {
                Console.WriteLine($"\n{aisle[c - 1]}");
                Console.WriteLine("\n  Price            Product                   Product ID      Stock\n");
                for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i].id / 100 == c)
                        {
                            products[i].DisplayMenu();
                        }
                    }
            }
            Console.WriteLine($"\n\nCart: ({tt} / 100)");
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{cart[i].cProduct} {cart[i].cQuantity}");
            }
            int iId;
            bool ex = false;

            while (true)
            {
                Console.Write("\nEnter product ID:  ");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out iId))
                {
                    Console.WriteLine("\nInvalid product ID:\n  The product ID you entered does not exist. Please select a valid ID from the store menu.");
                    continue;
                }
                ex = false;

                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] != null && products[i].id == iId)
                        {
                            ex = true;
                            break;
                        }
                }
                if (ex)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInvalid product ID:\n  The product ID you entered does not exist. Please select a valid ID from the store menu.");
                }
            }       
            
            int iQ;
            
            while (true)
            {
                Console.Write("Enter quantity:    ");
                string input = Console.ReadLine();
            
                if (!int.TryParse(input, out iQ))
                {
                    Console.WriteLine("\nNon-integer quantity:\n     Please enter a whole number within the stock amount for the quantity.\n");
                    continue;
                }
            
                if (tt + iQ > 100)
                {
                    Console.WriteLine($"\nCart limit reached:\n  You can only add {100 - tt} more item(s).\n");
                    continue;
                }
            
                bool v = false;
            
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] != null && products[i].id == iId)
                    {
                        if (products[i].stock >= iQ)
                        {
                            v = true;
                        }
                        break;
                    }
                }
            
                if (v)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("\nInsufficient quantity:\n   Not enough stock for this product.\n");
                    continue;
                }
            }
            
            tt += iQ;
            
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].id == iId)
                {
                    if (products[i].stock >= iQ)
                    {
                        products[i].stock -= iQ;
                        
                        bool f = false;

                        for (int j = 0; j < count; j++)
                        {
                            if (cart[j] != null && cart[j].cId == iId)
                            {
                                cart[j].cQuantity += iQ;
                                f = true;
                                Console.WriteLine($"\nYou successfully added {iQ} {products[i].product}");
                                break;
                            }
                        }

                        if (!f)
                        {
                            cart[count] = new Product();
                            cart[count].cId = iId;
                            cart[count].cProduct = products[i].product;
                            cart[count].cQuantity = iQ;
                            cart[count].price = products[i].price;
                            count++;
                            Console.WriteLine($"\nYou successfully added {iQ} {products[i].product}");
                        }
                    }
                    break;
                }
            }
            if (tt == 100)
            {
                break;
            }
            else if (tt < 100)
            {
                Console.Write("\nWould you like to order more? (Y/N): ");
                o = Convert.ToChar(Console.ReadLine());
            }
        }
        
        double tp = 0;
        
        Console.WriteLine("\n\n=== TRONO'S STORE MENU ===");
        Console.WriteLine("======== RECEIPT =========\n");
        
        for (int i = 0; i < count; i++)
        {
            Product c = cart[i];
        
            double bruh = c.cQuantity * c.price; 
            tp += bruh;
            
            Console.WriteLine($"{c.cId} {c.cProduct} {bruh}");
                    Console.WriteLine($"   {c.cQuantity} # {c.price}");
        }
        
         double d = 0;
                string dm = "[NOT APPLIED]";
                
                if (tp >= 5000)
                {
                    d = tp * 0.10;
                    dm = "[APPLIED]";
                }
                
                double ft = tp - d;
        
                Console.WriteLine($"\n            Grand Total:      {tp}");
                Console.WriteLine(  $"            10% Discount:     {dm}");
                Console.WriteLine(  $"            Final Total:      {ft}");
        
        Console.WriteLine("\n\n=== TRONO'S STORE MENU ===");
        Console.WriteLine(    "===== UPDATED GROCERY ====");
        string[] tAisle =
        {
            "1 - Rice & Grains",
            "2 - Proteins",
            "3 - Vegetables & Fruits",
            "4 - Pantry & Essentials",
            "5 - Household & Personal Care"
        };
        for (int c = 1; c <= 5; c++)
        {
            Console.WriteLine($"\n{tAisle[c - 1]}");
            Console.WriteLine("\n  Price            Product           Product ID      Stock\n");
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].id / 100 == c)
                {
                    products[i].DisplayMenu();
                }
            }
        }
        Product a = new Product();
        a.AnotherMethod();
    }   
}
