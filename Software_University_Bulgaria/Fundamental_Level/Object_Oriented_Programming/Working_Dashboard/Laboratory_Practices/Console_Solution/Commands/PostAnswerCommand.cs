using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using System;

namespace ConsoleForum.Commands
{
    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var author = this.Forum.CurrentUser;
            var question = this.Forum.CurrentQuestion;
            string answerBody = this.Data[1];
            var answer = new Answer(this.Forum.Answers.Count + 1, answerBody, author);
            this.Forum.Answers.Add(answer);
            question.Answers.Add(answer);
            this.Forum.Output.AppendFormat(Messages.PostAnswerSuccess, answer.Id).AppendLine();
        }
    }
}
