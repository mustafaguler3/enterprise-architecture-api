using Entities.Abstract;
using Entities.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.EntityFramework
{
    public class OperationClaimRepository : IOperationClaimRepository
    {
        public void Add(OperationClaim operationClaim)
        {
            using (var context = new VtContext())
            {
                context.OperationClaims.Add(operationClaim);
            }
        }

        public void Delete(OperationClaim operationClaim)
        {
            using (var context = new VtContext())
            {
                context.OperationClaims.Remove(operationClaim);
            }
        }

        public OperationClaim Get(int id)
        {
            using (var context = new VtContext())
            {
                return context.OperationClaims.Find(id);
            }
        }

        public List<OperationClaim> GetAll()
        {
            using (var context = new VtContext())
            {
                return context.OperationClaims.ToList();
            }
        }

        public void Update(OperationClaim operationClaim)
        {
            using (var context = new VtContext())
            {
                context.OperationClaims.Update(operationClaim);
            }
        }
    }
}
