    Console.WriteLine("Welcome to your Tamagotchi");

    Tamagotchi myTama = new Tamagotchi();

    Console.WriteLine("Choose a name for your buddy");
    myTama.name = Console.ReadLine();

    Console.WriteLine($"Wonderfull {myTama.name} is a great name");