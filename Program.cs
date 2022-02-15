// See https://aka.ms/new-console-template for more information
string pass = "";
Console.WriteLine("Enter length of password:");
int Pass_Length = 0;
Random ran = new Random();
try
{
    Pass_Length = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}
for (int i = 0; i < Pass_Length; i++)
{
    pass += (char)ran.Next(33,126);
}
Console.WriteLine(pass);