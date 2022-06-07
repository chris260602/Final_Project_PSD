// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Currency
{
    public Currency(string value)
    {
        this.value = value;
    }
    private string value { get; set; }
}
public class Price
{
    public Price(Currency currency, int amount)
    {
        this.currency = currency;
        this.amount = amount;
    }
    private Currency currency { get; set; }
    private int amount { get; set; }
}
public class PhoneNumber
{
    public PhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }
    private string phoneNumber { get; set; }
    private void validatePhoneNumber(string phoneNumber)
    {
        //...
    }
}
public class Email
{
    public Email(string email)
    {
        this.email = email;
    }
    private string email { get; set; }
    private void validateEmail(string email)
    {
        //...
    }
}
public class PaymentType
{
    public PaymentType(string type)
    {
        this.type = type;
    }
    private string type { get; set; }
}
public class Payment
{
    public Payment(int totalPrice, PaymentType paymentType)
    {
        this.totalPrice = totalPrice;
        this.paymentType = paymentType;
    }
    private int totalPrice { get; set; }
    private PaymentType paymentType { get; set; }
}
public class Address
{
    public Address(int streetNumber, string street, string city, string province, string country, string postCode)
    {
        this.streetNumber = streetNumber;
        this.street = street;
        this.city = city;
        this.province = province;
        this.country = country;
        this.postCode = postCode;
    }
    private int streetNumber { get; set; }
    private string street { get; set; }
    private string city { get; set; }
    private string province { get; set; }
    private string country { get; set; }
    private string postCode { get; set; }

    private void validateProvince(string province)
    {
        //...
    }
    private void validateCity(string city)
    {
        //...
    }
    private void validateCountry(string country)
    {
        //...
    }
    private void validatePostCode(string postCode)
    {
        //...
    }
}



public class Storage
{
    public Storage(int StorageCapacity)
    {
        this.StorageID = new Guid();
        this.StorageCapacity = StorageCapacity;
    }

    public Guid StorageID { get; set; }
    public int StorageCapacity { get; set; }

    public void StoreProduct()
    {
        //...
    }
}

//DIBAWAH SUDAH ENTITY
public class Product
{
    public Product(Guid ProductId, Guid SupplierId, Storage StorageID, string ProductName, string ProductCategory, int ProductPrice, DateTime productExpire, string productDescription)
    {
        this.ProductId = new Guid();
        this.SupplierId = SupplierId;
        this.StorageID = StorageID;
        this.ProductName = ProductName;
        this.ProductCategory = ProductCategory;
        this.ProductPrice = ProductPrice;
        this.productExpire = productExpire;
        this.productDescription = productDescription;
    }

    public Guid ProductId { get; set; }
    public Guid SupplierId { get; set; }
    public Storage StorageID { get; set; }
    public string ProductName { get; set; }
    public string ProductCategory { get; set; }
    public int ProductPrice { get; set; }
    public DateTime productExpire { get; set; }
    public string productDescription { get; set; }

    public void AddProduct()
    {
        //...
    }
    public void DeleteProduct()
    {
        //...
    }
    public void UpdateProduct()
    {
        //...
    }
}

public class Supplier
{
    public Supplier(string SupplierName, Address address)
    {
        this.SupplierId = new Guid();
        this.SupplierName = SupplierName;
        this.SupplierAddress = address;
    }

    public Guid SupplierId { get; set; }
    public string SupplierName { get; set; }
    public Address SupplierAddress { get; set; }

    public void BringSupplies()
    {
        //...
    }
    public void ProduceSupplies()
    {
        //...
    }
}

public class Employee
{
    public Employee(string EmployeeName, Address EmployeeAddress, DateTime EmployeeDOB, string EmployeeGender, PhoneNumber EmployeePhoneNumber, Email EmployeeEmail)
    {
        this.EmployeeID = new Guid();
        this.EmployeeName = EmployeeName;
        this.EmployeeAddress = EmployeeAddress;
        this.EmployeeDOB = EmployeeDOB;
        this.EmployeeGender = EmployeeGender;
        this.EmployeePhoneNumber = EmployeePhoneNumber;
        this.EmployeeEmail = EmployeeEmail;
    }

    public Guid EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public Address EmployeeAddress { get; set; }
    public DateTime EmployeeDOB { get; set; }
    public string EmployeeGender { get; set; }
    public PhoneNumber EmployeePhoneNumber { get; set; }
    public Email EmployeeEmail { get; set; }

    public void ScanProduct()
    {
        //...
    }
    public void ManagePayment()
    {
        //...
    }
}

public class Shipping
{
    public Shipping(string ShipperName, Address Destination, string ShippingType)
    {
        this.ShippingId = new Guid();
        this.ShipperName = ShipperName;
        this.Destination = Destination;
        this.ShippingType = ShippingType;
    }
    public Guid ShippingId { get; set; }
    public string ShipperName { get; set; }
    public Address Destination { get; set; }
    public string ShippingType { get; set; }

    public void PickUpOrder()
    {
        //...
    }

    public void SendOrder()
    {
        //...
    }
}

public class Customer
{
    public Customer(string CustomerName, Address CustomerAddress, PhoneNumber PhoneNumber, Email Email)
    {
        this.CustomerId = new Guid();
        this.CustomerName = CustomerName;
        this.CustomerAddress = CustomerAddress;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
    }
    public Guid CustomerId { get; set; }
    public string CustomerName { get; set; }
    public Address CustomerAddress { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
    public Email Email { get; set; }

    public void OrderProduct()
    {
        //...
    }
    public void BuyProduct()
    {
        //...
    }
    public void Pay()
    {
        //...
    }
    public void ChooseShippingType()
    {
        //...
    }
    public void ChooseTransactionMethod()
    {
        //...
    }
}

