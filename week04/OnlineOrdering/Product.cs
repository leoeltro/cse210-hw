using System;

public class Product
{
    private string _productName;
    private string _productID;
    private float _UnitPrice;
    private float _quantity;
    private float _totalProductPrice;
    private  float priceDelivery;
    private float _finalPrice;
    private int _typeAddress;



    public Product(string productName, string productID, float UnitPrice, float quantity, int typeAddress)
    {
        _productName = productName;
        _productID = productID;
        _UnitPrice = UnitPrice;
        _quantity = quantity;
        _typeAddress = typeAddress;
        Console.WriteLine($"Type Address: {_typeAddress}");

        if (_typeAddress == 1)
        {
            priceDelivery = 5;
            Console.WriteLine("Delivery Price: $5.00" );

        }
        else if (_typeAddress == 2)
        {
            priceDelivery = 35;
            Console.WriteLine("Delivery Price: $35.00");
        }   
        
    }


    public float TotalProductPrice()
    {
        _totalProductPrice = _UnitPrice * _quantity;
        _finalPrice = _totalProductPrice + priceDelivery;
        return _finalPrice;
    }



    public void DisplayVideoInformation()
    {
        //Console.WriteLine("Product informations: ");
        Console.WriteLine($"Product name: {_productName};   Product ID: {_productID};   Unit Price: {_UnitPrice};   Quantity: {_quantity};   Type Address: {_typeAddress}; Final Price: {_finalPrice}");
        //Console.WriteLine();
    }



}


