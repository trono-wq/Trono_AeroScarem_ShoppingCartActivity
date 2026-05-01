using System;

class Product
{
    public double price;
    public string product;
    public int id;
    public int stock;
    
    public static string[] Categories = 
            {"1 - Rice & Grains",
            "2 - Proteins",
            "3 - Vegetables & Fruits", 
            "4 - Pantry & Essentials", 
            "5 - Household & Personal Care"
            };

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

class Cart
{
    public double price;
    public int cId;
    public string cProduct;
    public int cQuantity;
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[15];
        Cart[] cart = new Cart[15];
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

        bool v = true;
        int ti = 0;
        
        while (v)
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
                Console.WriteLine("===== UPDATED GROCERY ====");
            }
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\n" + Product.Categories[i - 1]);
                Console.WriteLine("  Price            Product                   Product ID      Stock\n");
                for (int j = 0; j < products.Length; j++)
                {
                    if (products[j].id / 100 == i)
                    {
                        products[j].DisplayMenu();
                    }
                }
            }
            
            Console.WriteLine($"\n\nCart: ({tt} / 100)");
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{cart[i].cProduct} {cart[i].cQuantity}");
            }
            
            Console.WriteLine("\n1 - Add to cart");
            Console.WriteLine  ("2 - Cart Management");

            string a; 

            while (true)
            {
                Console.Write("\nSelect Option:                 ");
                a = Console.ReadLine();
            
                if (a == "1" || a == "2")
                {
                    break;
                }
                
                Console.WriteLine("\nInvalid input:\n  Please enter 1 or 2.");
            }
            
            if (a == "1")
            {
                string f;
                
                while (true)
                {
                    Console.Write("\nFilter by category? (y/n):     ");
                    f = Console.ReadLine().ToLower();
                
                    if (f == "y" || f == "n")
                        break;
                
                    Console.WriteLine("\nInvalid input:\n  Please enter Y or N.");
                }
                
                int c;
                
                if (f == "y")
                {
                    Console.WriteLine();

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine(Product.Categories[i]);

                    while (true)
                    {
                         Console.Write("\nSelect category:               ");
    
                         if (int.TryParse(Console.ReadLine(), out c) && c >= 1 && c <= 5)
                                break;
   
                         Console.WriteLine("\nInvalid input:\n  Please enter a valid numbered category (1 to 5)");
                    }
          
                    Console.WriteLine("\n" + Product.Categories[c - 1]);

                    for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i].id / 100 == c)
                        {
                            products[i].DisplayMenu();
                        }
                    }
                }
                
                Product fo = null;
                int iId = 0;
                
                while (true)
                {
                    Console.Write("\nEnter product ID or name:      ");
                    string ion = Console.ReadLine().ToLower();
                
                    if (string.IsNullOrWhiteSpace(ion) || !int.TryParse(ion, out iId) )
                    {
                        Console.WriteLine("\nInvalid product ID / name:\n  The product ID / name you entered does not exist. Please select a valid ID / name from the store menu.");
                        continue;
                    }
                
                    for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i] != null)
                        {
                            if (int.TryParse(ion, out int id))
                            {
                                if (products[i].id == id)
                                {
                                    fo = products[i];
                                    iId = id;
                                    break;
                                }
                            }
                            else
                            {
                                if (products[i].product.ToLower().Contains(ion))
                                {
                                    fo = products[i];
                                    iId = products[i].id;
                                    break;
                                }
                            }
                        }
                    }
                
                    if (fo != null)
                    {
                        Console.WriteLine("\n" + "Product is found and selected: " + fo.product);
                        break;
                    }
                }
                int iQ;

                while (true)
                {
                    Console.Write("\nEnter quantity:                ");
                    string q = Console.ReadLine();

                    if (!int.TryParse(q, out iQ))
                    {
                        Console.WriteLine("\nNon-integer quantity:\n     Please enter a whole number within the stock amount for the quantity.");
                        continue;
                    }
                    
                    if (tt + iQ > 100)
                    {
                        Console.WriteLine($"\nCart limit reached:\n  You can only add {100 - tt} more item(s).\n");
                        continue;
                    }
                
                    bool vo = false;
                
                    for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i].id == iId)
                        {
                            if (products[i].stock >= iQ)
                            {
                                vo = true;
                            }
                            break;
                        }
                    }
                
                    if (vo)
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
                            
                            bool ft = false;
    
                            for (int j = 0; j < count; j++)
                            {
                                if (cart[j] != null && cart[j].cId == iId)
                                {
                                    cart[j].cQuantity += iQ;
                                    ft = true;
                                    Console.WriteLine($"\nYou successfully added {iQ} {products[i].product}");
                                    break;
                                }
                            }
    
                            if (!ft)
                            {
                                cart[count] = new Cart();
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
            } 
        }
    }
}


