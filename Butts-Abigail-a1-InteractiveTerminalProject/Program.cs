using System.Numerics;

bool endGame = false;
bool gameRunning = true;
bool moneyCheck = true;
bool localShop = false;
bool brandShop = false;
if (gameRunning == true) ;
{
    Console.WriteLine("please enter your name");
    string playerName = Console.ReadLine();
    // Getting an amount of money that works with the story
    Console.WriteLine($"ok {playerName}, how much money are you carrying (please select a number between 5 and 20)");
    int playerMoney = int.Parse(Console.ReadLine());
    //checks money total once so that it doesn't come back later in the story
    if (moneyCheck == true) ;
    {
        if (playerMoney > 20)
        {
            Console.WriteLine("that's too much money for the story");
            endGame = true;
        }
        else if (playerMoney < 5)
        {
            Console.WriteLine("that's not enough money for the story");
        }
        moneyCheck = false;
    }    // the start of the story
    Console.WriteLine("your walking down the street on a nice autumn after noon,");
    Console.WriteLine("something about the orange and brown leaves falling to the");
    Console.WriteLine("ground, and the brisk chilling air makes you want to enter");
    Console.WriteLine("a coffee shop, there are two in your view. A local shop(1)");
    Console.WriteLine($"or a really popular big branded coffee shop(2). {playerName}");
    Console.WriteLine("which shop do you enter?");
    int playerChoice = int.Parse(Console.ReadLine());
    if (playerChoice == 1)
    {
        localShop = true;
    }
    else if (playerChoice == 2)
    {
        brandShop = true;
    }
    else
    {
        Console.WriteLine("you look inside and decide that the lines are to long for you");
    }
    Console.WriteLine("As you enter the shop you notice that its pretty bust this time");
    Console.WriteLine("of year, you wait in line and by the time its your turn to order");
    Console.WriteLine("you decide to get:");
    Console.WriteLine("a coffee for $5(1), a pastry for $8(2) or both for $13(3)");
    playerChoice = int.Parse(Console.ReadLine());
    Console.WriteLine($"they ask for your name which you give them {playerName} in response");
    if (playerChoice == 1)
    {
        if (playerMoney > 5)
        {
            if (localShop == true)
            {
                Console.WriteLine("You get your coffee and your name's spelt correctly!");
            }
            if (brandShop == true)
            {
                Console.WriteLine("you get your coffee and your name's spelt wrong.");
            }
            playerMoney -= 5;
            Console.WriteLine($"{playerMoney}");
        }
        else if (playerMoney < 5)
        {
            Console.WriteLine("you didn't have enough money to pay");
        }
    }
    else if (playerChoice == 2)
    {
        if (playerMoney > 8)
        {
            if (localShop == true)
            {
                Console.WriteLine("You get your pastry and your name's spelt correctly!");
            }
            if (brandShop == true)
            {
                Console.WriteLine("you get your pastry and your name's spelt wrong.");
            }
            playerMoney -= 8;
            Console.WriteLine($"{playerMoney}");
        }
        else if (playerMoney < 8)
        {
            Console.WriteLine("you didn't have enough money to pay");
        }
    }
    else if (playerChoice == 3)
    {
        if (playerMoney > 13)
        {
            if (localShop == true)
            {
                Console.WriteLine("You get your coffee and pastry, you notice that your name's spelt correctly!");
            }
            if (brandShop == true)
            {
                Console.WriteLine("You get your coffee and pastry, you notice that your name's spelt wrong.");
            }
            playerMoney -= 13;
            Console.WriteLine($"{playerMoney}");
        }
        else if (playerMoney < 13)
        {
            Console.WriteLine("you didn't have enough money to pay");
        }
    }
    else
    {
        Console.WriteLine("After all that waiting you decide that your not in the mood for anything");
        Console.WriteLine("and leave after getting a water.");
    }
    if (endGame == true)
    {
        gameRunning = false;
    }
}


