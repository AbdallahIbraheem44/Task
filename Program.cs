
 double X,Y,A,B,sum;
Console.WriteLine("Please enter the X:");
X = double.Parse(Console.ReadLine());
Console.WriteLine("please enter the Y:");
Y = double.Parse(Console.ReadLine());

Console.WriteLine("The Perfect numbers within the given range :");

for (A = X; A <= Y ;A++)
{
    B = 1;
    sum = 0;
    while (B < A)
    {
        if (A % B == 0)
            sum = sum + B;
        B++;
    }
    if (sum == A)
        Console.WriteLine("{0}", A);
}
Console.WriteLine(" ");

