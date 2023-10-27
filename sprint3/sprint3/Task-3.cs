using System.Collections.Generic;

class ListProgram
{
    static List<int> ListWithPositive(List<int> inputList)
    {
        List<int> positiveNumbers = inputList.FindAll(num => num > 0 && num <= 10);
        return positiveNumbers;
    }
}
