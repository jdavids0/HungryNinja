// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Buffet IndianMenu = new Buffet();

Ninja Ryu = new Ninja ("Ryu");

Console.WriteLine($"Welcome to the restaurant, {Ryu.Name}");

while (Ryu.IsFull == false){
    Ryu.Eat(IndianMenu.Serve());
}

Console.WriteLine($"Warning: calorie intake is {Ryu.CalorieProp}. {Ryu.Name} is full!");