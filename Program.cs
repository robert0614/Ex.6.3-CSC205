using System;

public class SquareRootCalculator
{
    /* The method first checks if the input number a is negative and throws an exception if it is,
     * because the square root of a negative number is not defined in the realm of real numbers. */

    public static double SquareRoot(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Cannot compute the square root of a negative number");
        }

        double x0 = a / 2;
        double x1 = (x0 + a / x0) / 2;

        while (Math.Abs(x1 - x0) >= 0.0001)
        {
            x0 = x1;
            x1 = (x0 + a / x0) / 2;
        }

        return x1;

        /* The initial guess, x0, is set to a/2.
         * 
         * We then calculate a new estimate, x1, using the formula given. The loop continues updating 
         * x0 and x1 until the absolute difference between x1 and x0 is less than 0.0001. 
         * 
         * Once the condition is met, the method return x1, which is our approximate square root of a. */
    }

    public static void Main()
    {
        double number = 9;
        double result = SquareRoot(number);
        Console.WriteLine("Square root of {0} is approximately {1}", number, result);
    }
}
// This code provides an effecient way to approximate the square root of anumber using an iterative method.