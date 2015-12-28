using ConsoleForum.Contracts;
using ConsoleForum.Utility;
using System;
using System.Text;

namespace ConsoleForum.Entities.Posts
{
    public class Answer : Post, IAnswer
    {
        public Answer(int id, string body, IUser author)
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            var answer = new StringBuilder();
            answer.AppendFormat("[ Answer ID: {0} ]", this.Id).AppendLine()
                .AppendFormat("Posted by: {0}", this.Author).AppendLine()
                .AppendFormat("Answer Body: {0}", this.Body).AppendLine()
                .Append(new string('-', OutputUtility.DeafultDelimiterLength));

            return answer.ToString();
        }
    }
}
