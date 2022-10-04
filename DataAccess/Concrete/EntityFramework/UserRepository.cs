using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;

namespace Entities.Concrete.EntityFramework
{
    public class UserRepository : EntityRepository<User,VtContext>, IUserRepository
    {
    }
}
