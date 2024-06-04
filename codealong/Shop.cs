class Shop
{
    //public Product Item { get; set; }
    public List<Product> Products { get; private set; }
    public List<Product> Cart { get; private set; }


    public Shop()
    {
        Products = new List<Product>()
        {
            new Product("melk", 20),
            new Product("egg", 40),
            new Product("sukker", 15)
        };

        Cart = new List<Product>();
    }

    public void ShowProducts()
    {
        int i = 0;
        foreach (var product in Products)
        {
            i++;
            Console.WriteLine($"{i}. {product.Name}, price: {product.Price}kr");
        }
    }

    public void AddToCart()
    {
        while (true)
        {
            Console.WriteLine("Skriv inn nummer som samsvarer med varen du vil legge til i handlevogna, om du er ferdig med å legge til varer, trykk 0 for total sum");
            if (int.TryParse(Console.ReadLine(), out int number )) 
            {
                if (number == 0){
                    CalculateSum();
                    break;
                }
                else if (number < Products.Count + 1) {
                    
                    Cart.Add(Products[number - 1]);
                    Console.WriteLine($"{Products[number - 1].Name} ble lagt til i handlevogna");
                }
                else
                { Console.WriteLine("Feil nummer/svar"); }
            }
            else{
                Console.WriteLine("Feil nummer/svar");}
        }
    }

    public void CalculateSum()
    {
        int sum = 0;
        foreach(var product in Cart)
        {
            sum += product.Price;
        }
        Console.WriteLine($"total pris blir{sum}kr");
    }

}
//ctor
//ctorfp

//cw tab console writeline


//forklar
//google hvis du ikke vet 
//vis problemløsningsevner