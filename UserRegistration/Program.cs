﻿using UserRegistration;
Console.WriteLine("Enter First Name:");
string userName = Console.ReadLine();
Registration UName = new Registration();
if (UName.ValidateFirstName(userName)==true)
    Console.WriteLine("First name accepted");
else
    Console.WriteLine("Invalid!!First letter must be capital and minimum 3 characters requiered!!");
Console.WriteLine("Enter Last Name:");
string LastName = Console.ReadLine();
Registration LName = new Registration();
if (LName.ValidateLasttName(LastName)==true)
    Console.WriteLine("Last name accepted");
else
    Console.WriteLine("Invalid!!Last letter must be capital and minimum 3 characters requiered!!");