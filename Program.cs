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
        
        int r = 0;             
        double[] h = new double[50];
        int[] hr = new int[50];
        int hc = 0;

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
                
                    if (string.IsNullOrWhiteSpace(ion))
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
                                if (products[i].product.ToLower().Trim() == ion)
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
            else if (a == "2")
            {
                bool co = true;
    
                while (co)
                {
                    Console.WriteLine("\n1 - View Cart\n2 - Remove from cart\n3 - Clear cart\n4 - Add to cart\n5 - Checkout");
                    
                    string c;
                    
                    while (true)
                    {
                        Console.Write("\nSelect Option:                 ");
                        c = Console.ReadLine();
                        
                        if (c == "1" || c == "2"|| c == "3" || c == "4" || c == "5")
                        break;
                
                        Console.WriteLine("\nInvalid input:\n  Please enter a valid option (1 to 5)");
                    }
                    
                    if (c == "1")
                    {
                        Console.WriteLine($"\nCart: ({tt} / 100)");
                
                        for (int i = 0; i < count; i++)
                        {
                            if (cart[i] != null)
                            {
                                Console.WriteLine($"{cart[i].cProduct} {cart[i].cQuantity}");
                            }
                        }
                    }
                    
                    else if (c == "2")
                    {
                        while (true)
                        {
                            Console.Write("\nEnter product ID or name:      ");
                            string iono = Console.ReadLine().ToLower();
        
                            int ind = -1;
        
                            for (int i = 0; i < count; i++)
                            {
                                if (cart[i] != null &&
                                   (cart[i].cId.ToString() == iono || products[i].product.ToLower().Trim() == iono))
                                {
                                    ind = i;
                                    break;
                                }
                            }
        
                            if (ind == -1)
                            {
                                Console.WriteLine("\nInvalid product ID / name:\n  The product ID / name you entered does not exist. Please select a valid ID / name from your cart.");
                                continue;
                            }
        
                            int qo;
        
                            while (true)
                            {
                                Console.Write("\nEnter quantity:                ");
        
                                if (int.TryParse(Console.ReadLine(), out qo))
                                {
                                    break;
                                }
        
                                Console.WriteLine("\nNon-integer quantity:\n     Please enter a whole number within the stock amount for the quantity.");
                            }
        
                            if (qo > cart[ind].cQuantity)
                            {
                                Console.WriteLine("\nInsufficient quantity:\n   Not enough stock for this product.\n");
                                continue;
                            }
        
                            Cart removedItem = cart[ind];  
                            
                            cart[ind].cQuantity -= qo;
                            tt -= qo;
                            
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (products[i].id == cart[ind].cId)
                                {
                                    products[i].stock += qo;
                                    break;
                                }
                            }
                            
                            if (cart[ind].cQuantity <= 0)
                            {
                                for (int i = ind; i < count - 1; i++)
                                {
                                    cart[i] = cart[i + 1];
                                }
                            
                                cart[count - 1] = null;
                                count--;
                            }
                            
                            Console.WriteLine($"\nRemoved from cart: {removedItem.cQuantity}     {removedItem.cProduct}");
                            break;
                        }
                    }
                    
                    else if (c == "3")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if (cart[i] != null)
                            {
                                for (int j = 0; j < products.Length; j++)
                                {
                                    if (products[j].id == cart[i].cId)
                                    {
                                            products[j].stock += cart[i].cQuantity;
                                            break;
                                    }
                                }
                        
                                cart[i] = null;
                                
                            }
                        }
                        
                        count = 0;
                        tt = 0;
                        
                        Console.WriteLine("\nCart is cleared and products are returned to the store.");
                    }
                    
                    else if (c == "4")
                    {
                        break;
                    }
                    
                    else if (c == "5")
                    {
                        if (tt == 0)
                        {
                            Product an = new Product();
                            an.AnotherMethod();
                        
                            return;
                        }
                        
                        double tp = 0;
                                        
                        for (int i = 0; i < count; i++)
                        {
                            Cart ca = cart[i];
                            
                            if (ca == null) continue;
                            
                            double bruh = ca.cQuantity * ca.price;
                            tp += bruh;
                        }
                
                        
                        double d = 0;
                        string dm = "[NOT APPLIED]";
                                
                        if (tp >= 5000)
                        {
                            d = tp * 0.10;
                            dm = "[APPLIED]";
                        }
                                
                        double ft = tp - d;
                        
                        double pa;
                
                        while (true)
                        {
                            Console.WriteLine($"\nFinal Total:                   {ft}");
 
                            Console.Write("Enter Payment:                 ");
                
                            string inpu = Console.ReadLine();
                
                            if (!double.TryParse(inpu, out pa))
                            {
                                Console.WriteLine("Non-integer quantity:\n     Please enter a whole number within the stock amount for the quantity.");
                                continue;
                            }
                
                            if (pa < ft)
                            {
                                Console.WriteLine("\nInsufficient payment:\n  Payment must higher or equal than the final total.");
                                continue;
                            }
                
                            break;
                        }
                        
                        double ch = pa - ft;
                        
                        r++; 
                        int receiptNo = r;
                        
                        if (hc < h.Length)
                        {
                            h[hc] = ft;
                            hr[hc] = receiptNo;
                            hc++;
                        }
                        
                        Console.WriteLine("\n\n=== TRONO'S STORE MENU ===");
                        Console.WriteLine("======== RECEIPT =========\n");
                        Console.WriteLine($"Receipt #:      {receiptNo}");
                        Console.WriteLine($"Date, Time:     {DateTime.Now}\n");
                
                        for (int i = 0; i < count; i++)
                        {
                            Cart car = cart[i];

                            if (car == null) continue;

                            double bruh = car.cQuantity * car.price;
                            
                            Console.WriteLine($"{car.cId} {car.cProduct} {bruh}");
                            Console.WriteLine($"   {car.cQuantity} # {car.price}");
                        }
                
                        Console.WriteLine($"\n            Grand Total:      {tp}");
                        Console.WriteLine(  $"            10% Discount:     {dm}");
                        Console.WriteLine(  $"            Final Total:      {ft}");
                        Console.WriteLine($"\n            Payment:          {pa}");
                        Console.WriteLine(  $"            Change:           {ch}");
                        
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] != null && products[i].stock <= 5)
                            {
                                Console.WriteLine("\nLOW STOCK ALERT:");
                                Console.WriteLine("  Product                  Stock");
                                Console.WriteLine("  " + products[i].product + products[i].stock);
                            }
                        }
                        string pls;

                        while (true)
                        {
                            Console.Write("\nOrder History? (y/n):          ");
                            pls = Console.ReadLine().ToLower();
                        
                            if (pls == "y" || pls == "n")
                                break;
                        
                            Console.WriteLine("\nInvalid input:\n  Please enter 1 or 2.");
                        }
                        
                        if (pls == "y")
                        {
                            Console.WriteLine();
                            
                            for (int i = 0; i < hc; i++)
                            {
                                Console.WriteLine($"Receipt #{hr[i]} - Final Total: PHP {h[i]}");
                            }
                        }
                        
                        Console.Write("\nShop again? (y/n):              "); 

                        string work;
                        
                        while (true)
                        {
                            work = Console.ReadLine().ToLower();
                        
                            if (work == "y" || work == "n")
                                break;
                        
                            Console.WriteLine("\nInvalid input:\n  Please enter 1 or 2.");
                        }
                        
                        if (work == "y")
                        {
                            count = 0;
                            Array.Clear(cart, 0, cart.Length);
                            tt = 0;
                            co = false; 
                        }
                        else
                        {
                            Console.WriteLine("\n\n=== TRONO'S STORE MENU ===");
                            Console.WriteLine("===== UPDATED GROCERY ");
                                    
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
                            Product ans = new Product();
                            ans.AnotherMethod();
                        
                            return;
                        }
                    }
                }
            }
        }
    }
}
