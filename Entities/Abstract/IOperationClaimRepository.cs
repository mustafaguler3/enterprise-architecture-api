using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IOperationClaimRepository
    {
        void Add(OperationClaim operationClaim);
        void Update(OperationClaim operationClaim);
        void Delete(OperationClaim operationClaim);
        List<OperationClaim> GetAll();
        OperationClaim Get(int id);
    }
}
