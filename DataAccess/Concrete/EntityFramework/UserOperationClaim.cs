using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserOperationClaim : EntityRepository<UserOperationClaim, VtContext>, IUserOperationClaim
    {
    }
}
