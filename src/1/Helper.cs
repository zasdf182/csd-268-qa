namespace Helper;

public class Math
{
    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException(
                "Can not get factorial of negative number");
        if (n >= 13)
            throw new ArgumentOutOfRangeException(
                "Can not get factorial of 13 or greater." +
                " The result is bigger than a 32 bit integer.");
        int result = 1;
        for(int i = n; i > 0; i--) 
            result *= i; 
        return result;
    }
}
