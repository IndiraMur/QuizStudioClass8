using System;
using System.Collections.Generic;
using System.Text;

namespace QuizStudioClass8
{
        public class Question
        {
            public string QuestionStatement { get; set; }
            public string Answer { get; set; }
            public List<string> Choices { get; set; }
            public int Id { get; set; }
            private int nextId = 1;



            public Question()
            {
                Id = nextId;
                nextId++;
            }

            public void OutputChoices()
            {
                foreach (string choice in Choices)
                {
                    Console.WriteLine(choice);
                }

            }


        }

        public class MultipleChoice : Question
        {
            public string Op1 { get; set; }
            public string Op2 { get; set; }
            public string Op3 { get; set; }
            public string Op4 { get; set; }

            public MultipleChoice(string op1, string op2, string op3, string op4)
            {
                Op1 = op1;
                Op2 = op2;
                Op3 = op3;
                Op4 = op4;

                Choices = new List<string> { op1, op2, op3, op4 };
            }

        }

         public class Checkbox : MultipleChoice
        {
            public Checkbox(string op1, string op2, string op3, string op4) : base( op1, op2, op3, op4) { }
        }

        public class TrueFalse : Question
        {


            public TrueFalse()
            {
                Choices = new List<string> { "true or false" };
            }

        }
}


