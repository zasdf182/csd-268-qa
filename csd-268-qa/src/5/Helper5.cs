namespace Helper5;

public class Generation
{
    public static bool IsMillenial(int yearOfBirth) {
        if (yearOfBirth < 1582)
            throw new ArgumentOutOfRangeException(
                "ERROR: Year must be at least 1582"
                + " (the year that the Gregorian Calendar went into effect)"
            );
        if (yearOfBirth < 1981 || yearOfBirth > 1996)
            return false;
        else
            return true;
    }
}
