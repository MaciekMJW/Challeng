var name = "Ewa";
var woman = false;
var age = 18;

if (woman == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age >= 30)
    {
        Console.WriteLine("Kobieta po 30-stce");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
}
if (woman == false)

    if (age < 18)
    {
        Console.WriteLine("Niepelnoletni mężczyzna");
    }
    else if (age >= 18)
    {
        Console.WriteLine("Mężczyzna");
    }

