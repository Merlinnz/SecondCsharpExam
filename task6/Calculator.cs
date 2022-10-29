public class Calculator
{
    public long Factorial(long n)
    {
        if (n == 0)
        {
            return 1;
        }
        else 
        {
            return n * Factorial(n - 1);
        }
            
    }
    public double Multiple(double a, double b)
    {
        return a*b;
    }
    public double Division(double a, double b)
    {
        return a/b;
    }
}