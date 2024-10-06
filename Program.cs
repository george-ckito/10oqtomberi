using _10oqtomberi;

Console.WriteLine("Which davaleba would you like to run? 1/2/3/4/5 (5 = bonus)");
string choice = Console.ReadLine();
switch (Convert.ToInt32(choice))
{
    case 1:
        Davaleba1 davaleba = new Davaleba1();
        davaleba.Execute();
        break;

    case 2:
        Davaleba2 davaleba2 = new Davaleba2();
        davaleba2.Execute();
        break;

    case 3:
        Davaleba3 davaleba3 = new Davaleba3();
        davaleba3.Execute();
        break;

    case 4:
        Davaleba4 davaleba4 = new Davaleba4();
        davaleba4.Execute();
        break;

    case 5:
        Davaleba5 davaleba5 = new Davaleba5();
        davaleba5.Execute();
        break;

    default:
        Console.WriteLine("Not a valid option!");
        break;

}
