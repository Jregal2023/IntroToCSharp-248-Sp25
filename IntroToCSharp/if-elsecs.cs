/*//Conditionals ie if-else
//just like in python you can have a single if statement with no else ie single alternative

//relational operators to check values equal, greater than, etc...
//>,<,<=,>=,==,!=
//remember when comparing two values we use == instead of =... = assigns values == compares value


//let's create a program to see if someone is eligible to vote
//just checking age

int age = 19;
//if statements use the following syntax: if(comparison){}
//if statements get skipped if they are not true
if (age >= 18)
{
    Console.WriteLine("You are old enough to vote");
}
//else - dual alternative - two choices
//alse known as if-else
else
{
    Console.WriteLine("You are not old enough to vote");
}

//compund operators - check if multiple conditions are true/false
//and, or, nots. THey look different than python
//and = & - both comparisons must be true for the if statement to run
// or = || - only one of the comparisons must be true for the if statment to run
// not = ! - take the resulting boolean value and flips it (true becomes false and false becomes true)

//check to see if a person is a US citizen and above 18 years old to vote
int votingAge = 15;
String citizen = "y";
if (votingAge >= 18 & citizen == "y")
{
    Console.WriteLine("You are old enough and you are a citizen you can vote");
}
//maybe we want to tell the use the reason why they cannot vote. We can use multi-alternative to do so.
//aka else if statements
else if (votingAge >= 18 & citizen == "n")
{
    Console.WriteLine("You are old enough to vote but not a citizen, You cannot vote");
}
else if (votingAge <= 17 & citizen == "y")
{
    Console.WriteLine("You are not old enough to vote, but you are a citizen, You cannot vote");

}
else
{
    Console.WriteLine(" You are niether old enough, and you are not a citizen, You cannot vote");
}*/