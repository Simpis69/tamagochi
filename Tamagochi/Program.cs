    Console.WriteLine("Welcome to your Tamagotchi");

    Tamagotchi myTama = new Tamagotchi();

    Console.WriteLine("Choose a name for your buddy");
    myTama.name = Console.ReadLine();

    Console.WriteLine($"Wonderfull {myTama.name} is a great name");

    while(myTama.GetAlive() == true)
    {
        Console.Clear();
        Console.WriteLine("What do you want to do now?");
        Console.WriteLine($"1. Teach {myTama.name} a new word");
        Console.WriteLine($"2. Talk to {myTama.name}");
        Console.WriteLine($"3. Feed {myTama.name}");
        Console.WriteLine($"4. Do nothing");

        string doWhat = Console.ReadLine();
        if(doWhat == "1")
        {
            Console.WriteLine($"What word do you want to teach {myTama.name}?");
            string word = Console.ReadLine();
            myTama.Teach(word);
        }
        if(doWhat == "2")
        {
            myTama.Hi();
        }
        if(doWhat == "3")
        {
            myTama.Feed();
        }
        else
        {
            Console.WriteLine("Doing nothing...");
        }
        myTama.Tick();
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    Console.WriteLine($"OH NO {myTama.name} died because of YOU!");
    Console.WriteLine("Press ENTER to quit");
    Console.ReadLine();