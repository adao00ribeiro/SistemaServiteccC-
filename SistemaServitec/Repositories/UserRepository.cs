using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using SistemaServitec.Data;
using SistemaServitec.Models;
using SistemaServitec.Repositories.Interfaces;


namespace SistemaServitec.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SistemaServitecDBContex DbContex;
        public UserRepository ( SistemaServitecDBContex dbContex )
        {
            DbContex = dbContex;
        }

        public async Task<UserModel> Add ( UserModel Person )
        {
            await DbContex.Users.AddAsync ( Person );
            await  DbContex.SaveChangesAsync ( );
            return Person;
        }

        public async Task<UserModel> SearchById ( int Id )
        {
            return await DbContex.Users.FirstOrDefaultAsync ( x => x.Id == Id );
        }

        public async Task<UserModel> Update ( UserModel Person , int id )
        {
            UserModel temp = await SearchById(id);

            if ( temp == null )
            {
                return null;
            }

            DbContex.Users.Update ( Person );
            await DbContex.SaveChangesAsync ( );
            return Person;
        }

        public async Task<bool> Delete ( int id )
        {
            UserModel temp = await SearchById(id);

            if ( temp == null )
            {
                throw new Exception ( $"Not {id}" );
            }

            DbContex.Users.Remove ( temp );
            await DbContex.SaveChangesAsync ( );
            return true;
        }

        public async Task<UserModel> TakeTheLast ( )
        {
            return await DbContex.Users.OrderByDescending ( x=>x.Id).Take(1).SingleAsync();
        }

        public async Task<UserModel> TakeTheFirst ( )
        {
            return await DbContex.Users.FirstAsync ( );
        }

        public async Task<List<UserModel>> ListAll ( )
        {
            return await DbContex.Users.ToListAsync ( );
        }

        public async Task<UserModel> SearchByUserName ( string UserName , string password )
        {
            return await DbContex.Users.FirstOrDefaultAsync ( x => x.UserName == UserName && x.Password == password );
        }
        public async Task<UserModel> SearchByUserName ( string UserName )
        {
            return await DbContex.Users.FirstOrDefaultAsync ( x => x.UserName == UserName  );
        }
    }
}
