﻿using Demo.Domain.Model.Users;
using Demo.Infrastructure.Data.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repository.EF
{
    public class UserRepository : IUserRepository
    {
        private IUserContext context;

        public UserRepository(IUserContext context)
        {
            this.context = context;
        }

        public User Add(User entity)
        {
            try
            {
                context.Users.Add(entity);
                context.SaveChanges();
                return GetById(entity.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User GetById(Guid id)
        {
            User usuario = default(User);

            try
            {
                usuario = (from u in context.Users
                           where u.Id == id
                           select u).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return usuario;
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

    }
}
