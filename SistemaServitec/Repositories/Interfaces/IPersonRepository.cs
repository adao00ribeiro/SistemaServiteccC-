using SistemaServitec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task<PersonModel> SearchById ( int Id );
        Task<PersonModel> Add ( PersonModel Person );
        Task<PersonModel> Update ( PersonModel Person , int id );
        Task<PersonModel> TakeTheLast( );
        Task<PersonModel> TakeTheFirst ( );
        Task<bool> Delete ( int id );
    }
}
