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

public class Shop {
    public static double GetDiscountedPrice(int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException("Price can not be negative");
        else if (n < 100)
            return n;
        else if (n < 1000)
            return n * 0.9;
        else if (n < 10000)
            return n * 0.8;
        else
            return n * 0.7;
    }
}
