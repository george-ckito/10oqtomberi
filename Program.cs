using _10oqtomberi;

Console.WriteLine("Which davaleba would you like to run? 1/2/3/4/bonus");
string choice = Console.ReadLine();
if(Convert.ToInt32(choice) == 1)
{
    Davaleba1 davaleba = new Davaleba1();
    davaleba.Execute();
} else if (Convert.ToInt32(choice) == 2)
{
    Davaleba2 davaleba = new Davaleba2();
    davaleba.Execute();
}