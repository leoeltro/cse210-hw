using System;

class Program
{
    private static string _productName = "";   
    private static string _productID = "";
    private static float _UnitPrice = 0;
    private static float _quantity = 0;
    private static string _name = "";
    private static int _typeAddress; // 1 for USA, 2 for International
    private static string _Address = "";
    private static float _finalPrice = 0;
    private static int _numberProductsCart = 0;


    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");




		//ORDER ADRRESS 01  -------------------------------------------------------------------------------------
		Console.WriteLine("ORDER 01");
        // PRODUCT 01
        _productName= "Ice Cream";        
        _productID = "12345";
		_UnitPrice = 6;
        _quantity = 2;
		
        _name = "John Doe";
        _typeAddress = 1; // 1 for USA, 2 for International
        _Address = "St: 46 Main , City: Utah, Country: USA";

        Product _product01 = new Product(_productName, _productID, _UnitPrice, _quantity, _typeAddress);// Create a product INITIALIZED
        _finalPrice = _product01.TotalProductPrice();// Calculate final price
        Console.WriteLine($"Final Price: ${_finalPrice}"); // Show final price
        _product01.DisplayVideoInformation(); // Show product information

        Address _address01 = new Address( _name, _Address);// Create a address INITIALIZED
        _address01._productsList.Add(_product01);// Add product to _products LIST in Address class




        // PRODUCT 02
        _productName = "Potato Chips";        
        _productID = "54321";
		_UnitPrice = 4.15f;
        _quantity = 5;
		
        //_name = "Robert Smith";
        //_typeAddress = 1; // 1 for USA, 2 for International
        //_Address = "St: 1054 Main , City: Miami, Country: USA";

        Product _products02 = new Product(_productName, _productID, _UnitPrice, _quantity, _typeAddress);// Create a product INITIALIZED
        _finalPrice = _products02.TotalProductPrice();// Calculate final price
        Console.WriteLine($"Final Price: ${_finalPrice}"); // Show final price
        _products02.DisplayVideoInformation(); // Show product information

        //Address _address01 = new Address( _name, _Address);// Create a address INITIALIZED
        _address01._productsList.Add(_products02);// Add product to _products LIST in Address class



        // PRODUCT 03
        _productName = "Sandals";        
        _productID = "47896";
		_UnitPrice = 7;
        _quantity = 2;
		
        //_name = "Jessica Lima";
        //_typeAddress = 2; // 1 for USA, 2 for International
        //_Address = "St: 56 Main , City: Nova Jersey, Country: USA";

        Product _products03 = new Product(_productName, _productID, _UnitPrice, _quantity, _typeAddress);// Create a product INITIALIZED
        _finalPrice = _products03.TotalProductPrice();// Calculate final price
        Console.WriteLine($"Final Price: ${_finalPrice}"); // Show final price
        _products03.DisplayVideoInformation(); // Show product information

        //Address _address01 = new Address( _name, _Address);// Create a address INITIALIZED
        _address01._productsList.Add(_products03);// Add product to _products LIST in Address class



        Console.WriteLine("-------------------------------------------------------------------------------------");
        _address01.DisplayShippingLabel();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("-------------------------------------------------------------------------------------");
          _numberProductsCart = _address01.ShowProducts();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        //Console.WriteLine($"Number of Products: {_numberProductsCart}");
        Console.WriteLine();
        







        //ORDER ADRRESS 02  -------------------------------------------------------------------------------------
	Console.WriteLine("ORDER 02");
        // PRODUCT 01
        _productName= "Pants";        
        _productID = "45678";
		_UnitPrice = 12;
        _quantity = 1;
		
        _name = "John Doe";
        _typeAddress = 2; // 1 for USA, 2 for International
        _Address = "St: 1245 Main , City: Belo Horizonte, Country: Brazil";

        Product _product04 = new Product(_productName, _productID, _UnitPrice, _quantity, _typeAddress);// Create a product INITIALIZED
        _finalPrice = _product04.TotalProductPrice();// Calculate final price
        Console.WriteLine($"Final Price: ${_finalPrice}"); // Show final price
        _product04.DisplayVideoInformation(); // Show product information

        Address _address02 = new Address( _name, _Address);// Create a address INITIALIZED
        _address02._productsList.Add(_product04);// Add product to _products LIST in Address class




        // PRODUCT 02
        _productName = "T Shirt";        
        _productID = "789456";
		_UnitPrice = 16;
        _quantity = 2;
		
        //_name = "Robert Smith";
        //_typeAddress = 1; // 1 for USA, 2 for International
        //_Address = "St: 1054 Main , City: Miami, Country: USA";

        Product _products05 = new Product(_productName, _productID, _UnitPrice, _quantity, _typeAddress);// Create a product INITIALIZED
        _finalPrice = _products05.TotalProductPrice();// Calculate final price
        Console.WriteLine($"Final Price: ${_finalPrice}"); // Show final price
        _products05.DisplayVideoInformation(); // Show product information

        //Address _address01 = new Address( _name, _Address);// Create a address INITIALIZED
        _address02._productsList.Add(_products05);// Add product to _products LIST in Address class



        // PRODUCT 03
        _productName = "Sock";        
        _productID = "321654";
		_UnitPrice = 4;
        _quantity = 2;
		
        //_name = "Jessica Lima";
        //_typeAddress = 2; // 1 for USA, 2 for International
        //_Address = "St: 56 Main , City: Nova Jersey, Country: USA";

        Product _products06 = new Product(_productName, _productID, _UnitPrice, _quantity, _typeAddress);// Create a product INITIALIZED
        _finalPrice = _products06.TotalProductPrice();// Calculate final price
        Console.WriteLine($"Final Price: ${_finalPrice}"); // Show final price
        _products06.DisplayVideoInformation(); // Show product information

        //Address _address01 = new Address( _name, _Address);// Create a address INITIALIZED
        _address02._productsList.Add(_products06);// Add product to _products LIST in Address class



        Console.WriteLine("-------------------------------------------------------------------------------------");
        _address02.DisplayShippingLabel();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("-------------------------------------------------------------------------------------");
          _numberProductsCart = _address02.ShowProducts();
        Console.WriteLine("-------------------------------------------------------------------------------------");
		//Console.WriteLine($"Number of Products: {_numberProductsCart}");
        Console.WriteLine();
		


    }
}




