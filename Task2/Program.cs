using Task2;

string[] namesarray = new string[5] {"Павел", "Анна", "Сергей", "Михаил", "Нина"};
// В задании было сказано, что список должен быть из фамилий, но 5 имен придумать намного проще
NamesSorter sorter = new();
NamesWriter writer = new();

sorter.NamesSorted += writer.OnNamesSorted;

try
{
    sorter.SortNames(namesarray);
}
catch(FormatException)
{
    Console.WriteLine("Некорректный формат ввода");
}
