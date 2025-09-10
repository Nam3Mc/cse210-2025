public class FractionOutput
{
    public void OnlyNumerator(int numerator)
    {
        Fraction newFraction = new Fraction(numerator);
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());
    }
    public void NumeratorAndDenominator(int numerator, int denominator)
    {
        Fraction newFraction = new Fraction(numerator, denominator);
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());
    }

}