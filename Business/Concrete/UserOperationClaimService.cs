using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class UserOperationClaimService: IUserOperationClaimService
    {
        private readonly IUserOperationClaimRepository _userOperationClaim;

        public UserOperationClaimService(IUserOperationClaimRepository userOperationClaim)
        {
            _userOperationClaim = userOperationClaim;
        }

        public void Add(UserOperationClaim operationClaim)
        {
            _userOperationClaim.Add(operationClaim);
        }
    }
}
