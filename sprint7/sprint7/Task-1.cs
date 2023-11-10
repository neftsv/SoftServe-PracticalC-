class P
{
    public static double EvaluateSumOfElementsOddPositions(double[] inputData)
    {
        double sum = 0;
        for (int i = 1; i < inputData.Length; i += 2)
        {
            sum += inputData[i];
        }
        return sum;
    }
}