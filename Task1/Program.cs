Exception myException = new("Произошло непредвиденное исключение!");

myException.Data.Add("Дата создания исключения: ", DateTime.Now);
myException.HelpLink = "www.google.com";

try
{
    switch(Int32.Parse(Console.ReadLine()))
    {
        case 0:
            throw myException; //Мое исключение
        case 1:
            int[] array = Array.Empty<int>();
            Console.WriteLine(array[1]); //Это вызовет IndexOutOfRangeException
            break;
        case 2:
            File.Open("364yti5kjtnhijy6jjgrjg09ruh49jht;iqofjmijhg409hj4ihpio64i965hojkp6559oh", FileMode.Open);
            //FileNotFoundException, если, конечно, у вас нет файла с таким странным именем
            break;
        case 3:
            throw new NotImplementedException();
        default:
            throw new FormatException(); //Любое значение кроме 0-4 вызовет FormatException
    }
}
catch(Exception e) when (e is FormatException)
{
    Console.WriteLine("Некорректный формат ввода!");
}
catch (Exception e) when (e == myException)
{
    Console.WriteLine(
        $"{e.Message}\n" +
        $"Дата создания исключения: {e.Data["Дата создания исключения: "]}.\n" +
        $"Обратитесь за помощью по данной ссылке: {e.HelpLink}");
}
catch (Exception e) when (e is IndexOutOfRangeException)
{
    Console.WriteLine("Индекс находится за пределами массива.");
}
catch (Exception e) when (e is FileNotFoundException)
{
    Console.WriteLine("Файла с таким именем не существует.");
}
catch(Exception e) when (e is NotImplementedException)
{
    Console.WriteLine("Эта функция еще не работает! :c");
}
finally
{
    Console.WriteLine("Finally!"); //Я не очень понимаю, зачем это нужно
}