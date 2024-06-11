//Numbers:
//1) ask the user how many numbers they want to test
//2) read that many numbers from the user
//3) display all the things the user input AND weather they were valid numbers

//Notes;
//console only outputs strings from the user. You will need to find a way to verify what they input was a number somehow (convert/parse/check-each-character)
//Numbers can be in many formats
//123456
//123.456
//123,456
//123,456.78
//1000000000000000 

Console.WriteLine("How many numbers would you like to test?");
string count = Console.ReadLine();
int.TryParse(count, out int testcount);

List<string> numbers = [];

for (int i = 1; i <= testcount; i++)
{
    Console.WriteLine("Please enter number " + i);
    string input = Console.ReadLine();

    numbers.Add(input);
}

foreach (string number in numbers)
{
    ValidateNumber(number);
}



static void ValidateNumber(string number)
{
    int testnumber = 0;
    double testdouble = 0;
    long testlong = 0;
    string valid = " = Valid";
    string notvalid = " = Not Valid.";
        
        if (int.TryParse(number, out testnumber) || long.TryParse(number, out testlong) || double.TryParse(number, out testdouble))
        {
        Console.WriteLine(number + " = Valid");
    }
        else
        {
            Console.WriteLine(number + " = Not Valid.");
    }
    
}

