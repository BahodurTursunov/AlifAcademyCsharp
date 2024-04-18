
Coffee coffee = PourCoffee();
Egg egg = FryEgg();
Toast toast = ToastBread();

1:02:58 
Coffee PourCoffee()
{
    Console.WriteLine("Pour coffee.....");
    Thread.Sleep(1000);
    return new();
}
Egg FryEgg()
{
    Console.WriteLine("Frying eggs.....");
    Thread.Sleep(1000);
    return new();
}

Toast ToastBread()
{
    Console.WriteLine("Toast bread.....");
    Thread.Sleep(1000);
    return new();
}


class Coffee{ }
class Egg { }
class Toast { }


