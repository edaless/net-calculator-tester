namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float Add(float num1, float num2)
            {
                return num1 + num2;
            }
            float Subtract(float num1, float num2)
            {
                return num1 - num2;
            }
            float Divide(float num1, float num2)
            {
                return num1 / num2;
            }
            float Multiply(float num1, float num2)
            {
                return num1 * num2;
            }


            Console.WriteLine(Add(2, 5));
            Console.WriteLine(Subtract(2, 5));
            Console.WriteLine(Divide(2, 5));
            Console.WriteLine(Multiply(2, 5));


        }

    }
}