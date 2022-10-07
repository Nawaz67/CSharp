using FoodManagementPresentation;
using System;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FoodManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Welcome to Food Court Management ---------");
            AdminPL adminPL = new AdminPL();
            adminPL.Login();
            Console.ReadLine();
        }
    }
}


