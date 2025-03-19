/*//Switch case statement. Great use of conditional checking where there can be multiple answers or
//responses, and you know the possibilities of the answers/responses
//Think like a drop-down menu on a website
//Ask user for a numerical day of the week, and we repond with its text version
//of that week (ie Monday = 1, Tuesday = 2, Wed = 3, and so on).

Console.WriteLine("Give me a numerical day of the week: ");
int day = int.Parse(Console.ReadLine());

// a switch syntax is switch(variableyouarechecking). It will check that value with the cases below it

switch (day)
{
    //case: value you are looking for.case works like an if statement to see if the value matches
    //that case
    case 1:
        Console.WriteLine("Monday");
        //if this case matches we break out of the switch case statement
        break;
    case 2:
        Console.WriteLine("Tuesday");
        //if this case matches we break out of the switch case statement
        break;
    case 3:
        Console.WriteLine("Wednesday");
        //if this case matches we break out of the switch case statement
        break;
    case 4:
        Console.WriteLine("Thursday");
        //if this case matches we break out of the switch case statement
        break;
    case 5:
        Console.WriteLine("Friday");
        //if this case matches we break out of the switch case statement
        break;
    case 6:
        Console.WriteLine("Saturday");
        //if this case matches we break out of the switch case statement
        break;
    case 7:
        Console.WriteLine("Sunday");
        //if this case matches we break out of the switch case statement
        break;
    //default is like our else statement.. if it doesn't meet any of the above conditions we can
    //call our default statement
    default:
        Console.WriteLine("You did not give us an actual day please try again");
        break;
}*/