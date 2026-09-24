using System;

public static class ConsoleApp1
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // Initial commit (Master)
    }

    static void Master1()
    {
        // This change is in Modernisation!!!!!!!!!!

        // Oops - This will only affect Modernisation (incorrect name)
    }

    static void MasterChange1()
    {
        // A change to the master branch
    }

    static void MasterChange2Master()
    {
        // Another change to the master branch
    }

    static void MasterChange2Modernisation()
    {
        // This will definitely cause a merge issue
    }

    static void MasterChange3()
    {
        // Added directly from within DevOps
    }

    static void Modernisation1()
    {
        // This change is for modernisation only
    }
    // At this point this branch doesn't know about the DevOps change
}
