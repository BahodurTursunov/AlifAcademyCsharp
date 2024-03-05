namespace HW29_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Operation> operationsStack = new();

            operationsStack.Push(new Operation(1, '+', 2));
            operationsStack.Push(new Operation(3, '*', 4));
            operationsStack.Push(new Operation(5, '-', 6));

            ReverseStack(operationsStack);

            while (operationsStack.Count > 0)
            {
                Operation operation = operationsStack.Pop();
                Console.WriteLine($"{operation.LeftOperand} {operation.Operator} {operation.RightOperand} = {operation.Result}");
            }
        }

        static void ReverseStack(Stack<Operation> stack)
        {
            // Создаем вспомогательный стек
            Stack<Operation> tempStack = new();

            // Перемещаем элементы из исходного стека во вспомогательный стек в обратном порядке
            while (stack.Count > 0)
            {
                tempStack.Push(stack.Pop());
            }

            // Перемещаем элементы из вспомогательного стека обратно в исходный стек
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
        }
    }

    public class Operation
    {
        public int LeftOperand { get; set; }
        public char Operator { get; set; }
        public int RightOperand { get; set; }
        public int Result { get; set; }

        public Operation(int leftOperand, char @operator, int rigtOperand)
        {
            LeftOperand = leftOperand;
            Operator = @operator; // @ унарный оператор
            RightOperand = rigtOperand;
            Result = CalculateResult();
        }

        private int CalculateResult()
        {
            return Operator switch
            {
                '+' => LeftOperand + RightOperand,
                '-' => LeftOperand - RightOperand,
                '*' => LeftOperand * RightOperand,
                '/' => LeftOperand / RightOperand,
                _ => throw new InvalidOperationException("Неизвестный оператор: " + Operator),
            };
        }
    }
}