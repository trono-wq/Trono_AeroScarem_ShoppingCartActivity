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

        while (char.ToLower(o) == 'y')
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].DisplayMenu();
            }

            Console.Write("\nEnter product ID: ");
            int iId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int iQ = Convert.ToInt32(Console.ReadLine());
            
            t += iQ;
            
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
                            if (cart[j].cId == iId)
                            {
                                cart[j].cQuantity += iQ;
                                f = true;
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
                        }
                    }
                    break;
                }
            }

            Console.WriteLine($"Cart: ({t} / 100)");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{cart[i].cProduct} {cart[i].cQuantity}");
            }

            Console.Write("\nWould you like to order more? (Y/N): ");
            o = Convert.ToChar(Console.ReadLine());
        }
	    double tp = 0;

        for (int i = 0; i < count; i++)
        {
            Product c = cart[i];
            Product p = products[i];
            Console.WriteLine(p.product + " " + c.cQuantity + " " + p.price);

            tp += c.cQuantity * p.price;
        } 
            double d = 0;

            if (tp >= 5000)
            {
                d = tp * 0.1;
            }
            
            tp -= d;
            Console.WriteLine($"\nTotal price: {tp}");
    }
}
