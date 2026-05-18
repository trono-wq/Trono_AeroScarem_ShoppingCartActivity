using System;

public class Product
{
    private double price;
    private string product;
    private int id;
    private int stock;
    
    public void Sprice(double price)
    {
        this.price = price;
    }
    public double Gprice()
    {
        return price;
    }
    public void Sproduct(string product)
    {
        this.product = product;
    }
    public string Gproduct()
    {
        return product;
    }
    public void Sid(int id)
    {
        this.id = id;
    }
    public int Gid()
    {
        return id;
    }
    public void Sstock(int stock)
    {
        this.stock = stock;
    }
    public int Gstock()
    {
        return stock;
    }
    
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
        ("  " + Gprice() + "              " + Gproduct() + " " + Gid() + "             " + Gstock());
    }
    
    public void AnotherMethod()
    {
        Console.WriteLine("\n\n===== Come Back Soon! ====");
    }
}

public class Cart
{
    private double price;
    private int cId;
    private string cProduct;
    private int cQuantity;
    
    public void Sprice(double price)
    {
        this.price = price;
    }
    public double Gprice()
    {
        return price;
    }
        public void ScId(int cId)
    {
        this.cId = cId;
    }
    public int GcId()
    {
        return cId;
    }
    public void ScProduct(string cProduct)
    {
        this.cProduct = cProduct;
    }
    public string GcProduct()
    {
        return cProduct;
    }
    public void ScQuantity(int cQuantity)
    {
        this.cQuantity = cQuantity;
    }
    public int GcQuantity()
    {
        return cQuantity;
    }
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
        products[0].Sprice(400);
        products[0].Sproduct("Rice (5 kg)              ");
        products[0].Sid(101);
        products[0].Sstock(160);
        
        products[1] = new Product();
        products[1].Sprice(160);
        products[1].Sproduct("Pandesal (12 pcs.)       ");
        products[1].Sid(102);
        products[1].Sstock(115);
        
        products[2] = new Product();
        products[2].Sprice(130);
        products[2].Sproduct("Noodles (double pack)    ");
        products[2].Sid(103);
        products[2].Sstock(225);
        
        products[3] = new Product();
        products[3].Sprice(210);
        products[3].Sproduct("Chicken (1 kg)           ");
        products[3].Sid(201);
        products[3].Sstock(115);
        
        products[4] = new Product();
        products[4].Sprice(195);
        products[4].Sproduct("Eggs (1 tray)            ");
        products[4].Sid(202);
        products[4].Sstock(90);
        
        products[5] = new Product();
        products[5].Sprice(270);
        products[5].Sproduct("Pork (1 kg)              ");
        products[5].Sid(203);
        products[5].Sstock(90);
        
        products[6] = new Product();
        products[6].Sprice(100);
        products[6].Sproduct("Pechay (5 bundles)       ");
        products[6].Sid(301);
        products[6].Sstock(140);
        
        products[7] = new Product();
        products[7].Sprice(190);
        products[7].Sproduct("Bananas (2 kg)           ");
        products[7].Sid(302);
        products[7].Sstock(75);
        
        products[8] = new Product();
        products[8].Sprice(110);
        products[8].Sproduct("Potatoes (1 kg)          ");
        products[8].Sid(303);
        products[8].Sstock(60);
        
        products[9] = new Product();
        products[9].Sprice(195);
        products[9].Sproduct("Cooking Oil (1 L)        ");
        products[9].Sid(401);
        products[9].Sstock(120);
        
        products[10] = new Product();
        products[10].Sprice(150);
        products[10].Sproduct("Soy Sauce (2 bottles)    ");
        products[10].Sid(402);
        products[10].Sstock(140);
        
        products[11] = new Product();
        products[11].Sprice(130);
        products[11].Sproduct("Sugar (2 kg)             ");
        products[11].Sid(403);
        products[11].Sstock(160);
        
        products[12] = new Product();
        products[12].Sprice(185);
        products[12].Sproduct("Fresh Milk (carton)      ");
        products[12].Sid(501);
        products[12].Sstock(110);
        
        products[13] = new Product();
        products[13].Sprice(140);
        products[13].Sproduct("Body Wash                ");
        products[13].Sid(502);
        products[13].Sstock(150);
        
        products[14] = new Product();
        products[14].Sprice(100);
        products[14].Sproduct("Dishwashing Liquid (1 L) ");
        products[14].Sid(503);
        products[14].Sstock(185);

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
                    if (products[j].Gid() / 100 == i)
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
                        if (products[i].Gid() / 100 == c)
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
                                if (products[i].Gid() == id)
                                {
                                    fo = products[i];
                                    iId = id;
                                    break;
                                }
                            }
                            else
                            {
                                if (products[i].Gproduct().ToLower().Trim() == ion)
                                {
                                    fo = products[i];
                                    iId = products[i].Gid();
                                    break;
                                }
                            }
                        }
                    }
                
                    if (fo != null)
                    {
                        Console.WriteLine("\n" + "Product is found and selected: " + fo.Gproduct());
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
                        if (products[i].Gid() == iId)
                        {
                            if (products[i].Gstock() >= iQ)
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
                    if (products[i].Gid() == iId)
                    {
                        if (products[i].Gstock() >= iQ)
                        {
                            products[i].Sstock(products[i].Gstock()  - iQ);
                            
                            bool ft = false;
    
                            for (int j = 0; j < count; j++)
                            {
                                if (cart[j] != null && cart[j].GcId() == iId)
                                {
                                    cart[j].ScQuantity(cart[j].GcQuantity() + iQ);
                                    ft = true;
                                    Console.WriteLine($"\nYou successfully added {iQ} {products[i].Gproduct()}");
                                    break;
                                }
                            }
    
                            if (!ft)
                            {
                                cart[count] = new Cart();
                                cart[count].ScId(iId);
                                cart[count].ScProduct(products[i].Gproduct());
                                cart[count].ScQuantity(iQ);
                                cart[count].Sprice(products[i].Gprice());
                                count++;
                                Console.WriteLine($"\nYou successfully added {iQ} {products[i].Gproduct()}");
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
                                Console.WriteLine($"{cart[i].GcProduct()} {cart[i].GcQuantity()}");
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
                                   (cart[i].GcId().ToString() == iono || cart[i].GcProduct().ToLower().Trim() == iono))
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
        
                            if (qo > cart[ind].GcQuantity())
                            {
                                Console.WriteLine("\nInsufficient quantity:\n   Not enough stock for this product.\n");
                                continue;
                            }
        
                            Cart removedItem = cart[ind];  
                            
                            cart[ind].ScQuantity(cart[ind].GcQuantity() - qo);
                            tt -= qo;
                            
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (products[i].Gid() == cart[ind].GcId())
                                {
                                    products[i].Sstock(products[i].Gstock() + qo);
                                    break;
                                }
                            }
                            
                            if (cart[ind].GcQuantity() <= 0)
                            {
                                for (int i = ind; i < count - 1; i++)
                                {
                                    cart[i] = cart[i + 1];
                                }
                            
                                cart[count - 1] = null;
                                count--;
                            }
                            
                            Console.WriteLine($"\nRemoved from cart: {qo}     {removedItem.GcProduct()}");
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
                                    if (products[j].Gid() == cart[i].GcId())
                                    {
                                            products[j].Sstock(products[j].Gstock() + cart[i].GcQuantity());
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
                            
                            double bruh = ca.GcQuantity() * ca.Gprice();
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

                            double bruh = car.GcQuantity() * car.Gprice();
                            
                            Console.WriteLine($"{car.GcId()} {car.GcProduct()} {bruh}");
                            Console.WriteLine($"   {car.GcQuantity()} # {car.Gprice()}");
                        }
                
                        Console.WriteLine($"\n            Grand Total:      {tp}");
                        Console.WriteLine(  $"            10% Discount:     {dm}");
                        Console.WriteLine(  $"            Final Total:      {ft}");
                        Console.WriteLine($"\n            Payment:          {pa}");
                        Console.WriteLine(  $"            Change:           {ch}");
                        
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] != null && products[i].Gstock() < 6)
                            {
                                Console.WriteLine("\nLOW STOCK ALERT:");
                                Console.WriteLine("  Product                  Stock");
                                Console.WriteLine("  " + products[i].Gproduct() + products[i].Gstock());
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
                                        if (products[j].Gid() / 100 == i)
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

