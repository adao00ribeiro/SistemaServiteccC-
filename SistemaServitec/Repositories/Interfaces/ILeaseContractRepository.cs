using SistemaServitec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Repositories.Interfaces
{
    public interface ILeaseContractRepository
    {
        Task<LeaseContractModel> SearchById ( int Id );
        Task<LeaseContractModel> Add ( LeaseContractModel Person );
        Task<LeaseContractModel> Update ( LeaseContractModel Person , int id );
        Task<LeaseContractModel> TakeTheLast( );
        Task<LeaseContractModel> TakeTheFirst ( );
        Task<List<LeaseContractModel>> ListAll ( );
        Task<bool> Delete ( int id );
    }
}
