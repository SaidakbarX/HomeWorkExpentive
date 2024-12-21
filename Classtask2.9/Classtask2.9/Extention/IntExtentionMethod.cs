namespace Classtask2._9.Extention;

public static class IntExtentionMethod
{
    public static bool IsCouple(this int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        return false;
    }
    public static bool PrimeNumber(this int number)
    {
        var count = 0;
        for (var i = 0; i < number; i++)
        {
            count = 0;
            if (number % i == 0)
            {
                count++;
            }

        }
        if (count == 2)
        {
            return true;
        }
        return false;
    }
    public static int Variable(this int number, int value)
    {

        return value + number;
    }
    public static int CountUppercaseLetters(this string uppercase)
    {
        var count = 0;
        foreach (char c in uppercase)
        {
            if (char.IsUpper(c))
            {
                count++;
            }
        }
        return count;
    }
    public static Person TheOldes(this List<Person> age)
    {
        Person oldes = null;
        var max = 0;
        foreach (var person in age)
        {
            if (max < person.Age)
            {
                max = person.Age;
                oldes = person;
            }
        }
        return oldes;
    }
    public static Book TheMostExpensiveBook(this List<Book> books)
    {
        var expensive = books[0];
        foreach (var book in books)
        {
            if (book.Price > expensive.Price)
            {
                expensive = book;
            }
        }
        return expensive;
    }


}