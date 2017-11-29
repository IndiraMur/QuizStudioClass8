using System;

namespace QuizStudioClass8
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz shapesQuiz = new Quiz();

            Console.WriteLine("Quiz");


            MultipleChoice question = new MultipleChoice("Round", "Square", "Rectangle", "Flat");
            question.QuestionStatement = "What shape is the earth?";
            question.Answer = "Round";
            shapesQuiz.Add(question);

            TrueFalse question2 = new TrueFalse
            {
                QuestionStatement = "The earth is round",
                Answer = "true"

            };

            shapesQuiz.Add(question2);

            shapesQuiz.Run();

            Console.WriteLine(shapesQuiz.Grade());


            Console.ReadLine();

        }
    }
}
