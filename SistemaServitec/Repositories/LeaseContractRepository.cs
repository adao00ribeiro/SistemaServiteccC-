using Microsoft.EntityFrameworkCore;
using SistemaServitec.Data;
using SistemaServitec.Models;
using SistemaServitec.Repositories.Interfaces;


namespace SistemaServitec.Repositories
{
    public class LeaseContractRepository : ILeaseContractRepository
    {
        private readonly SistemaServitecDBContex DbContex;
        public LeaseContractRepository ( SistemaServitecDBContex dbContex )
        {
            DbContex = dbContex;
        }

        public async Task<LeaseContractModel> Add ( LeaseContractModel contract )
        {
            await DbContex.Contracts.AddAsync ( contract );
            await  DbContex.SaveChangesAsync ( );
            return contract;
        }

        public async Task<LeaseContractModel> SearchById ( int Id )
        {
            return await DbContex.Contracts.Include(x=>x.PersonLocador).Include ( x => x.PersonLocatario ).FirstOrDefaultAsync ( x => x.Id == Id );
        }

        public async Task<LeaseContractModel> Update ( LeaseContractModel Person , int id )
        {
            LeaseContractModel temp = await SearchById(id);

            if ( temp == null )
            {
                return null;
            }

            DbContex.Contracts.Update ( Person );
            await DbContex.SaveChangesAsync ( );
            return Person;
        }

        public async Task<bool> Delete ( int id )
        {
            LeaseContractModel temp = await SearchById(id);

            if ( temp == null )
            {
                throw new Exception ( $"Not {id}" );
            }

            DbContex.Contracts.Remove ( temp );
            await DbContex.SaveChangesAsync ( );
            return true;
        }

        public async Task<LeaseContractModel> TakeTheLast ( )
        {
            return await DbContex.Contracts.Include ( x => x.PersonLocador ).Include ( x => x.PersonLocatario ).OrderByDescending ( x=>x.Id).Take(1).SingleAsync();
        }

        public async Task<LeaseContractModel> TakeTheFirst ( )
        {
            return await DbContex.Contracts.Include ( x => x.PersonLocador ).Include ( x => x.PersonLocatario ).FirstAsync ( );
        }

        public async Task<List<LeaseContractModel>> ListAll ( )
        {
            return await DbContex.Contracts.ToListAsync ( );
        }
    }
}
