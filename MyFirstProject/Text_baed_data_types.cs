namespace HelloWorld;

class ProgramText
{
    static void Main(string[] args)
    {

        string name = "Aba";
        char letter = 'a';

        System.Console.WriteLine(name);
        System.Console.WriteLine(letter);

        System.Console.Write("Your name is ");
        System.Console.Write(name);
        System.Console.WriteLine();

        Console.WriteLine("Hello, World!");

//  Convert string to numbers 

        string textAge = "-23";
        int age = Convert.ToInt32(textAge); 
        Console.WriteLine(age);

        string textBigNumber = " 90000000";
        long bugNumber = Convert.ToInt64(textBigNumber); 
        Console.WriteLine(bugNumber);

        string textNegative = " -55.2";
        double negative = Convert.ToDouble(textNegative); // make it been seen as double 
        System.Console.WriteLine(  negative);

        string textPrecision = " 5.000001";
        float precision = Convert.ToSingle(textPrecision);
        System.Console.WriteLine(precision);

        string textMoney = " 19.99";
        decimal money = Convert.ToDecimal(textMoney);
        System.Console.WriteLine(money);

    }
}