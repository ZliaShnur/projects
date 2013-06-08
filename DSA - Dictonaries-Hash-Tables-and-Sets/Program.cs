using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Wintellect.PowerCollections; 


class Program
{
    static void Main()
    {
        PhoneBook phoneBook = new PhoneBook(@"..\..\phones.txt"); //input file
        phoneBook.Find("Shmatka"); // by town
        Console.WriteLine("--------------");
        phoneBook.Find("Shmatka","Plovdiv"); // by name and town
        Console.WriteLine("--------------");
        phoneBook.Find("Shmatka", "Chepelare"); // there is no such Town
    }
}
