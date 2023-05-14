// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul 
//konsoolis kuvatakse "Welcome to Instagram!"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap (suur andmekogu), 13 - stack (võtab vähem vahemälu)

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}

else //ei pea siia lisama vanust, sest arvuti saab ise aru
{
    Console.WriteLine("You are too young to use Instagram!");
}