namespace TestCreditScore;

//////////////////////
// ASSIGNMENT START //
//////////////////////

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public partial class CreditScore
{
    enum ScoreType
    {
        FICO,
        Vantage
    }
    string QualifyScore(ScoreType type, int actualScore)
    {
        //Your code starts here
        if (actualScore < 300 || actualScore > 850)
            throw new ArgumentOutOfRangeException("Score must be 300-850");

        if (type == ScoreType.FICO)
        {
            if (actualScore < 580)
                return "Poor";
            else if (actualScore < 670)
                return "Fair";
            else if (actualScore < 740)
                return "Good";
            else if (actualScore < 800)
                return "Very Good";
            else
                return "Exceptional";
        }
        else
        {
            if (actualScore < 500)
                return "Very Poor";
            else if (actualScore < 601)
                return "Poor";
            else if (actualScore < 661)
                return "Fair";
            else if (actualScore < 781)
                return "Good";
            else
                return "Excellent";
        }
        //Your code ends here
    }
}
