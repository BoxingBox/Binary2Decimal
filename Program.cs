using Bin2Dec;

Console.WriteLine("Please enter a binary number up to 8 digits long.");
Console.WriteLine("-------------------------------------------------");

string input = Console.ReadLine();
int flag=0;
int flagtwo=0;
string inputCheck = input.ToString();

for (int i = 0; i < inputCheck.Length; i++)
{
    int check = Int32.Parse(inputCheck.Substring(i,1));
    if ( check ==0 || check == 1) {  flag = 1; }
    else {  flagtwo = 1;  }
} //check creation


if (inputCheck.Length <= 8 && flagtwo==0)
{
    
    Console.WriteLine(" The binary number entered was: " + input);
    Console.WriteLine("Decimal result is: " + Calculations.Calculation(inputCheck));
}  
else if (inputCheck.Length > 8)
{
    Console.WriteLine("Plese enter a binary number  up to 8 digits and not above");
}
else if (flagtwo==1)
{
    Console.WriteLine("Please enter a binary number");
}
else
{
    Console.WriteLine("Plese enter a BINARY number  UP TO 8 digits and not above");
}



