using System;

public class Address
{
    private string _name;
    private string _adress;

    public Address(string name, string adress)
    {
        _name = name;
        _adress = adress;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine($"To: {_name}");
        Console.WriteLine($"Address: {_adress}");
    }




    public List<Product> _productsList = new List<Product>(); // List to store products

    public int ShowProducts()
    {
        Console.WriteLine("SET OF PRODUCTS LABEL: ");
        foreach (Product product in _productsList)
        {
            product.DisplayVideoInformation();
        }
        Console.WriteLine($"Number of Products in the cart: {_productsList.Count}");
        //Console.WriteLine();
        return _productsList.Count;
    }
    


}
