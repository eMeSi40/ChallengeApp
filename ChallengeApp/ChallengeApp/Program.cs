
// Zadanie domowe - dzień 4

string name = "Ewa";
var age = 17;
bool women = true;

if (women == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else if (women == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else
{
    Console.WriteLine("Nie spełnia żadnych kryteriów");
}




