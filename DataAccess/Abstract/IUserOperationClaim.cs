using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data;
using Entities;

namespace DataAccess.Abstract
{
    public interface IUserOperationClaim : IEntityRepository<UserOperationClaim>
    {
    }
}
