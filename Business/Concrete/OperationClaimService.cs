using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Entities.Abstract;

namespace Business.Concrete
{
    public class OperationClaimService : IOperationClaimService
    {
        private readonly IOperationClaimRepository _operationClaimRepository;

        public OperationClaimService(IOperationClaimRepository operationClaimRepository)
        {
            _operationClaimRepository = operationClaimRepository;
        }

        public void Add(OperationClaim operationClaim)
        {
            _operationClaimRepository.Add(operationClaim);
        }
    }
}
