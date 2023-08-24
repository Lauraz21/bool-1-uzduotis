int age = Convert.ToInt32(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("Jums nepriklauso nepilnamečio akcija");
}
else if (age >18 && age <65)
{
    Console.WriteLine("Jūs esate suaugęs");
}
else if (age >=65)
{
    Console.WriteLine("Jums priklauso senioro akcija");
}