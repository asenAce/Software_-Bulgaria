using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using System;
using System.Linq;

namespace ConsoleForum.Commands
{
    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            string title = this.Data[1];
            string body = this.Data[2];

            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            var questions = this.Forum.Questions;
            var author = this.Forum.CurrentUser;
            var question = new Question(questions.Count + 1, title, body, author);

            this.Forum.Questions.Add(question);
            this.Forum.Output.AppendFormat(
                    Messages.PostQuestionSuccess,
                    question.Id)
                .AppendLine();
        }
    }
}
