﻿using System;
using System.Xml.Linq;
using LibrarySystemBL;
class program
{
    public static void Main(string[] args)
    {
        Book b= new Book();
        AudioBook ab= new AudioBook();
        


        Console.WriteLine($"check in date: {ab.checkin().ToString()} , check out remaining duration: {ab.checkout().ToString()} , Due Date is: {ab.getdue().ToString()}");

    }
}
