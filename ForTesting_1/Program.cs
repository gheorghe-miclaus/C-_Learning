// See https://aka.ms/new-console-template for more information

using Booking;
using Coding.Exercise;
using Coding.Exercise_2;
using ns_Triangle;
using Dog_class;
using ns_Order;
using ns_DailyAccountState;
using ns_NumberToDay;

Console.WriteLine("Hello, World!");
        Console.WriteLine(DateTime.Now.ToString());


Exercise file_1 = new Exercise();
        Console.WriteLine(file_1.IsElseConditionalStatement());

        Exercise_2 file_2 = new Exercise_2();


        foreach (var w in file_2.GetOnlyUpperCaseWords(new List<string> { "one", "TWO123", "THREE!&^", "four" }))
        {
            Console.WriteLine(w);
        };

        HotelBooking book = new HotelBooking("Geo", DateTime.Now, 5);
        Console.WriteLine(book.GuestName);
        Console.WriteLine(book.StartDate);
        Console.WriteLine(book.EndDate);


Triangle myTriangle = new Triangle(1, 3);
Console.WriteLine(myTriangle.AsString());
Console.WriteLine(myTriangle.CalculateArea());


//-----------------------------------------------------
Dog myDog_1 = new Dog("bubiku", "home", 4);
Console.WriteLine(myDog_1.Describe());

Dog myDog_2 = new Dog("Lord", 25);
Console.WriteLine(myDog_2.Describe());


//---------------------------------'
DateTime myDateTime = new DateTime(2024, 5, 17);
Order_2 myOrder = new Order_2("pc", myDateTime);

Console.WriteLine(myOrder.Item);

myOrder.Date = new DateTime(2023, 5, 17);
Console.WriteLine(myOrder.Date.ToString());

//-----------------------------------------

DailyAccountState myAccountState = new DailyAccountState(2000, -200);

Console.WriteLine(myAccountState.Report);

//--------------number to day------
var dd = NumberToDay.Translate(1);
Console.WriteLine(dd);