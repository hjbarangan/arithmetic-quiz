
namespace ArithmeticQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int num1, num2, answer, userAnswer;
            Random rand = new Random();
            int totalQuestions = rand.Next(5, 15);
            int correct = 0;
            int incorrect = 0;
            int operators;

            // Loop for totalQuestions times
            for (int i = 0; i < totalQuestions; i++)
            {
                // Generate random numbers
                num1 = rand.Next(1, 101);
                num2 = rand.Next(1, 101);

                // Choose random arithmetic operation
                operators = rand.Next(1, 5);
                switch (operators)
                {
                    case 1:
                        answer = num1 + num2;
                        Console.Write(num1 + " + " + num2 + " = ");
                        break;
                    case 2:
                        answer = num1 - num2;
                        Console.Write(num1 + " - " + num2 + " = ");
                        break;
                    case 3:
                        answer = num1 * num2;
                        Console.Write(num1 + " * " + num2 + " = ");
                        break;
                    case 4:
                        if (num2 == 0) // Avoid division by zero
                        {
                            Console.WriteLine("Divide by zero avoided!");
                            continue;
                        }
                        answer = num1 / num2;
                        Console.Write(num1 + " / " + num2 + " = ");
                        break;
                    default:
                        continue; // Skip this iteration if invalid operation chosen
                }

                // Get user's answer
                userAnswer = Convert.ToInt32(Console.ReadLine());

                // Check if the answer is correct
                if (userAnswer == answer)
                {
                    Console.WriteLine("Correct!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("Incorrect. The answer is {0}", answer);
                    incorrect++;
                }
            }

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Total Correct Answers: {0}", correct);
            Console.WriteLine("Total Incorrect Answers: {0}", incorrect);
            Console.WriteLine("Total Questions: {0}", totalQuestions);
            Console.WriteLine("Percentage: {0}%", correct * 100 / totalQuestions);
            Console.ReadLine();
        }
    }
}
