using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAssignment
{
    public class Question
    {
        public string questionText;
        public string optionA;
        public string optionB;
        public string optionC;
        public string optionD;
        public char correctAnswerLetter;
        private static char defaultCorrectAnswerLetter = 'X';

        public Question()
        {
            questionText = null;
            optionA = null;
            optionB = null;
            optionC = null;
            optionD = null;
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Question(string questionText)
        {
            this.questionText = questionText;
            optionA = null;
            optionB = null;
            optionC = null;
            optionD = null;
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter) : this(questionText)
        {
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.correctAnswerLetter = correctAnswerLetter;
        }

        public bool IsValid()
        {
            int NoOfNullQuestions = 0;
            if (optionA != null) { NoOfNullQuestions++; }
            if (optionB != null) { NoOfNullQuestions++; }
            if (optionC != null) { NoOfNullQuestions++; }
            if (optionD != null) { NoOfNullQuestions++; }

            return NoOfNullQuestions >= 2;

        }
    }

   
    public class Program
    {
        static void Main()
        {
            Question question = new Question();
            Question question1 = new Question("What is the capital of the USA?");
            Question question2 = new Question("What is the capital of the USA?", "London", "New York", "Washington, D.C.", "San Diego", 'C');
            Question question3 = new Question("What is the capital of the USA?", "London", "New York", "Washington, D.C.", "San Diego",' ');

            Console.WriteLine("Question is valid:" + question.IsValid());
            Console.WriteLine("Question is valid:" + question1.IsValid());
            Console.WriteLine("Question is valid:" + question2.IsValid());
            Console.WriteLine("Question is valid:" + question3.IsValid());

            Console.ReadKey();
        }
    }
}
