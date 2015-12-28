﻿using ConsoleForum.Contracts;
using System;

namespace ConsoleForum.Entities.Users
{
    public class Administrator : User, IAdministrator
    {
        public Administrator(int id, string name, string password, string email)
            : base(id, name, password, email)
        {
        }
    }
}
