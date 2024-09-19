int moana = 0;
int elsa = 0;
int cinderella = 0;
int merida = 0;
int darthvader = 0;
Console.WriteLine("Princess Quiz!!!");
Console.WriteLine("Question 1:");
Console.WriteLine("Out of these animals which is your favorite?");
Console.WriteLine("Please make sure to type the answer exactly like how it is spelled to you, including capitals");
Console.WriteLine("Mantaray, Bear, Lizard, Mice");
string ans1 = Console.ReadLine();
if (ans1 == "Mantaray") 
{
    moana++;
}
else if (ans1 == "Bear")
 {
    merida++;
}
else if (ans1 == "Lizard")
 {
    elsa++;
}
else if (ans1 == "Mice") 
{
    cinderella++;
}
else
{
    Console.WriteLine("Sorry, thats not an option");
    darthvader++;
}
Console.WriteLine("Question 2:");
Console.WriteLine("Which of these colors do you like most?");
Console.WriteLine("Orange, Green, Blue, White");
string ans2 = Console.ReadLine();
if (ans2 == "Orange")
 {
    moana++;
}
else if (ans2 == "Green")
 {
    merida++;
}
else if (ans2 == "White")
 {
    elsa++;
}
else if (ans2 == "Blue") 
{
    cinderella++;
}
else
{
    Console.WriteLine("Sorry, thats not an option");
    darthvader++;
}
Console.WriteLine("Question 3:");
Console.WriteLine("Which of these areas do you like more?");
Console.WriteLine("Mountains, Forests, Ocean, Home");
string ans3 = Console.ReadLine();
if (ans3 == "Ocean") 
{
    moana++;
}
else if (ans3 == "Forests") 
{
    merida++;
}
else if (ans3 == "Mountains")
 {
    elsa++;
}
else if (ans3 == "Home")
 {
    cinderella++;
}
else
{
    Console.WriteLine("Sorry, thats not an option");
    darthvader++;
}

if (moana > merida && moana > elsa && moana > cinderella && moana > darthvader) 
{
    Console.WriteLine("You got Moana");
}
else if (merida > moana && merida > elsa && merida > cinderella && merida > darthvader)
 {
    Console.WriteLine("You got Merida");
}
else if (elsa > moana && elsa > merida && elsa > cinderella && elsa > darthvader) 
{
    Console.WriteLine("You got Elsa");
}
else if (cinderella > moana && cinderella > merida && cinderella > elsa && cinderella > darthvader)
 {
    Console.WriteLine("You got Cinderella");
}
else if (darthvader > moana && darthvader > merida && darthvader > elsa && darthvader > cinderella)
 {
    Console.WriteLine("You got the secret princess, Darth Vader!!!");
}
else 
{
    Console.WriteLine("You Were Tied Between Multiple Princesses, Try Again?");
}
