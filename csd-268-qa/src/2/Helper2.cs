namespace Helper2;

public class Time {
    public static bool IsLeap(int year) {
        if (year < 1582)
            throw new ArgumentOutOfRangeException(
                "ERROR: Year must be at least 1582"
                + " (the year that the Gregorian Calendar went into effect)"
            );

        if((year % 400 == 0) || (year % 100 != 0) && (year % 4 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
