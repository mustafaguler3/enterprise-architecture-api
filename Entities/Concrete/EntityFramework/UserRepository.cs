using Entities.Abstract;
using Entities.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.EntityFramework
{
    public class UserRepository : IUserRepository
    {

        public void Add(User user)
        {
            using (var context = new VtContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (var context = new VtContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public User Get(int id)
        {
            using (var context = new VtContext())
            {
                return context.Users.Find(id);
            }
        }

        public List<User> GetAll()
        {
            using (var context = new VtContext())
            {
                return context.Users.ToList();
            }
        }

        public void Update(User user)
        {
            using (var context = new VtContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}
