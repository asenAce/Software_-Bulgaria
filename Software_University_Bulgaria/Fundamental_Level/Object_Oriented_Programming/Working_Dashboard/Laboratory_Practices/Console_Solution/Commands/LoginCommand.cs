using ConsoleForum.Contracts;
using ConsoleForum.Utility;
using System;
using System.Linq;

namespace ConsoleForum.Commands
{
    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            var users = this.Forum.Users;
            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            var existingUser = users
                .FirstOrDefault(u => u.Username == username &&
                                    u.Password == password);
            if (existingUser == null)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = existingUser;
            this.Forum.Output
              .AppendFormat(Messages.LoginSuccess, existingUser)
              .AppendLine();
        }
    }
}
