using System;

public delegate double CalcDelegate(double num1, double num2, char operation);

class CalcProgram
{
    public static double Calc(double num1, double num2, char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
        }
        return result;
    }

    public CalcDelegate funcCalc = new CalcDelegate(Calc);
}