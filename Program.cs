Console.WriteLine("Please enter a binary number up to 8 digits long.");
Console.WriteLine("-------------------------------------------------");

string input = Console.ReadLine();
int flag=0;
int flagtwo=0;
int intResultTwo = 0;
int intResult = 0;
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
    Calculation(inputCheck);
    Console.WriteLine("Decimal result is: " + intResult);
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



 int Calculation(string a)
{
    for (int i = 0; i < a.Length; i++) //1001
    {

        string stringResult = a.Substring(i, 1);
        intResult = Int32.Parse(stringResult);
        if (i == 0) intResult = intResult + (2 * 0);
        else intResult = intResult + (2 * intResultTwo);
        intResultTwo = intResult; //4


    }
    return intResult;
}