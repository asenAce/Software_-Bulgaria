using ConsoleForum.Contracts;
using ConsoleForum.Utility;
using System;
using System.Text;

namespace ConsoleForum.Entities.Posts
{
    public class BestAnswer : Answer
    {
        public BestAnswer(int id, string body, IUser author)
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            var bestAnswer = new StringBuilder();
            string bestAnswerDelimiter = new string('*', OutputUtility.DeafultDelimiterLength);
            bestAnswer.AppendLine(bestAnswerDelimiter)
                .AppendLine(base.ToString())
                .AppendLine(bestAnswerDelimiter);
            return bestAnswer.ToString();
        }
    }
}
