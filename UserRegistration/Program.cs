using UserRegistration;
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
    Console.WriteLine("Enter Email address");
string email= Console.ReadLine();
Registration Email = new Registration();
if (LName.ValidateEmail(email))
    Console.WriteLine("Email accepted");
else
    Console.WriteLine("Invalid!!");

Registration num = new Registration();
Console.WriteLine("Enter mobile number");
var number = Console.ReadLine();
if (num.ValidateMobileNumber(number)==true)
    Console.WriteLine("Mobile number eccepted");
else
    Console.WriteLine("Please enter a valid number");
Console.WriteLine("Enter 8 character password");
var pwd = Console.ReadLine();
if (num.ValidatePasswordRule1(pwd)==true)
    Console.WriteLine("Password eccepted");
else
    Console.WriteLine("Invalid");



Registration num=new Registration();
Console.WriteLine("Enter mobile number");
var number=Console.ReadLine();
if (num.ValidateMobileNumber(number)==true)
    Console.WriteLine("Mobile number eccepted");
else
    Console.WriteLine("Please enter a valid number");

