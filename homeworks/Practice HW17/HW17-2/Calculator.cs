namespace HW17_2
{
    internal class Calculator : IMath
    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

    }
}
