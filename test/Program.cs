using test;

Account a1 = new();

a1.SetName("Acme, Inc.");
a1.Deposit(500M);

if (a1.Withdraw(300M))
{
    Console.WriteLine($"The new balance for {a1.GetName()} is {a1.GetBalance()}");
}

if (a1.Withdraw(400M, true))
{
    Console.WriteLine($"The new balance for {a1.GetName()} is {a1.GetBalance()}");
}

if (a1.Withdraw(1000M))
{
    Console.WriteLine($"The new balance for {a1.GetName()} is {a1.GetBalance()}");
    
}
else
{
    Console.WriteLine("Overdraft!");
}



// Coordinate c1 = new();
//
// c1.X = 3;
// c1.Y = 5.5;
//
// Console.WriteLine($"This coordinate has a point of {c1.X}, {c1.Y}");
//
// Coordinate[] myPoints = new Coordinate[5];
//
// myPoints[0] = new Coordinate();
// myPoints[0].X = 5;
// Console.WriteLine(myPoints[0].X);
//
// // myPoints[0].X = 2;
// // myPoints[0].Y = -1.5;
//
// test.Custom.Console con = new(10.0);
//
// Console.WriteLine(con.Fish());
//
// Console.WriteLine(con.Sum(1,2,3,4));
//
// Console.WriteLine(con.Sum1(2,3,4));