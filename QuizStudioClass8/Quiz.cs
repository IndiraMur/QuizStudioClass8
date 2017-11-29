using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudioClass8
{

        class Quiz
        {
            List<Question> questions = new List<Question>();
            private static int score = 0;


            public void Add(Question question)
            {
                questions.Add(question);

            }

            public void Run()
            {
                

                foreach (var question in questions)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Current Score:" + score.ToString());
                    Console.WriteLine("");
                    Console.WriteLine(question.QuestionStatement);
                    Console.WriteLine("");
                    question.OutputChoices();
                    string input = Console.ReadLine();
                    if (input.Equals(question.Answer))
                    {
                        score++;
                    }

                }
            }

            public string Grade()
            {
                int grade = score / questions.Count;
                grade = grade * 100;
                string finalScore =  "Final Score="+ grade.ToString() + "%";
                return finalScore;
            }


        }

}
