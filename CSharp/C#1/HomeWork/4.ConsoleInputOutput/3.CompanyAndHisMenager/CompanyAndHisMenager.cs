using System;
class CompanyAndHisMenager
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string companyPhoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string menagerFName = Console.ReadLine();
        string menagerLName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        string menagerPhoneNumber = Console.ReadLine();



        Console.WriteLine("Comany name: {0}", companyName);
        Console.WriteLine("Compan adress: {0}", companyAdress);
        Console.WriteLine("Company Phone number: {0}", companyPhoneNumber);
        Console.WriteLine("Company fax number: {0}", faxNumber);
        Console.WriteLine("Menager first name: {0}", menagerFName);
        Console.WriteLine("Menager last name: {0}", menagerLName);
        Console.WriteLine("Menager age: {0}", age);
        Console.WriteLine("Menager phone number: {0}", menagerPhoneNumber);
    }
}

