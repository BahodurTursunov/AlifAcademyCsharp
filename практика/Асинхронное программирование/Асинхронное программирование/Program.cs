
Coffee coffeeTask = await PourCoffeeAsync();
Egg eggTask = await FryEggAsync();
Toast toastTask = await ToastBreadAsync();
async Task<Coffee> PourCoffeeAsync()
{
    Console.WriteLine("Pour coffee.....");
    await Task.Delay(2000);
    Console.WriteLine("Pouring coffee finished.....");
    return new();
}   
async Task<Egg> FryEggAsync()
{
    Console.WriteLine("Frying eggs.....");
    await Task.Delay(2000);
    Console.WriteLine("Frying finished.....");
    return new();
}

async Task<Toast> ToastBreadAsync()
{
    Console.WriteLine("Toast bread.....");
    await Task.Delay(2000);
    Console.WriteLine("Toasting bread finished.....");
    return new();

}
class Coffee { }
class Egg { }
class Toast { }


