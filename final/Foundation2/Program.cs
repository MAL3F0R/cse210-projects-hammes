using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        bool isUsResident;
        double totalPrice;

        Product product = new Product();
        Customer customer = new Customer();
        Address address = new Address();
        Order order = new Order();

        customer.ChangeCustomerName("Anna Gullbrandt");
        address.ChangeCustomerAddress("167 12th ave S, Alcove Ky");
        product.AddProduct("Usb charger", 5.99, 23454, 2);
        product.AddProduct("Notepad", 2.99, 59075, 1);
        isUsResident = address.UsStatus("yes");
        totalPrice = order.CalculateTotalPrice(product.GetProductPrices(), isUsResident);
        order.CreateLabel(address.GetCustomerAdress(), customer.GetCustomerName(), product.GetProductIds(), totalPrice);
        product.ClearLists();

        customer.ChangeCustomerName("Robert Gray");
        address.ChangeCustomerAddress("1265 3rd st SW, Seattle WA");
        product.AddProduct("Honda Civic Cabin Blower Motor", 64.99, 45870, 1);
        product.AddProduct("Basic Calculator", 8.99, 34784, 1);
        product.AddProduct("ScrewDriver Kit", 12.99, 44560, 2);
        isUsResident = address.UsStatus("yes");
        totalPrice = order.CalculateTotalPrice(product.GetProductPrices(), isUsResident);
        order.CreateLabel(address.GetCustomerAdress(), customer.GetCustomerName(), product.GetProductIds(), totalPrice);
        product.ClearLists();

        customer.ChangeCustomerName("Jack Dunningham");
        address.ChangeCustomerAddress("1904 6&1/2 ave W, Rollag MN");
        product.AddProduct("Grease Canister", 4.99, 78653, 1);
        product.AddProduct("Water Bottle", 2.99, 90986, 1);
        isUsResident = address.UsStatus("yes");
        totalPrice = order.CalculateTotalPrice(product.GetProductPrices(), isUsResident);
        order.CreateLabel(address.GetCustomerAdress(), customer.GetCustomerName(), product.GetProductIds(), totalPrice);
        product.ClearLists();

    }
}

internal class Product
{
    private List<string> productName = new List<string>();
    private List<double> productPrice = new List<double>();
    private List<int> productId = new List<int>();
    private List<int> productQty = new List<int>();
    internal void AddProduct(string name, double price, int id, int amount)
    {
        productName.Add(name);
        if (amount > 1)
        {
            double qtyPrice = price * amount;
            productPrice.Add(qtyPrice);
        }
        else if(amount == 1)
        {
            productPrice.Add(price);
        }
        productId.Add(id);
        productQty.Add(amount);
    }

    internal List<double> GetProductPrices()
    {
        return productPrice;
    }

    internal List<int> GetProductIds()
    {
        return productId;
    }

    internal void ClearLists()
    {
        productName.Clear();
        productPrice.Clear();
        productId.Clear();
        productQty.Clear();
    }
}

internal class Customer
{
    string customerName;
    internal void ChangeCustomerName(string inputName)
    {
        customerName = inputName;
    }

    internal string GetCustomerName()
    {
        return customerName;
    }
}

internal class Address 
{
    string customerAddress;
    internal void ChangeCustomerAddress(string inputAdress)
    {
        customerAddress = inputAdress;
    }
    bool isUS;
    internal bool UsStatus(string countryStatus)
    {
        if (countryStatus == "yes")
        {
            isUS = true;
        }
        else
        {
            isUS = false;
        }

        return isUS;
    }

    internal string GetCustomerAdress()
    {
        return customerAddress;
    }
}

internal class Order
{
    internal double CalculateTotalPrice(List<double> prices, bool isUSA)
    {   
        double totalPrice = 0;
        for (int i = 0; i <= prices.Count() - 1; i++ )
        {
            totalPrice = totalPrice + prices[i]; 
        }

        if (isUSA == true)
        {
            totalPrice = totalPrice + 5.0;
        }
        else
        {
            totalPrice = totalPrice + 35.0;
        }

        return totalPrice;
    }

    internal void CreateLabel(string address, string name, List<int> productIds, double totalCost)
    {
        Console.WriteLine("");
        Console.Write($@"Ship to: {address}
Receptient Name: {name}
Total Price: {totalCost}$
");
        for (int j = 0; j <= productIds.Count() - 1; j++)
        {
            Console.WriteLine($"Product Id {j + 1}: {productIds[j]}");
        }
    }
}