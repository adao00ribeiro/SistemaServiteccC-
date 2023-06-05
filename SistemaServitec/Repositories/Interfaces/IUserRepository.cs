using SistemaServitec.Models;

namespace SistemaServitec.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel> SearchById ( int Id );
        Task<UserModel> SearchByUserName ( string UserName , string password );
        Task<UserModel> SearchByUserName ( string UserName );
        Task<UserModel> Add ( UserModel Person );
        Task<UserModel> Update ( UserModel Person , int id );
        Task<UserModel> TakeTheLast( );
        Task<UserModel> TakeTheFirst ( );
        Task<List<UserModel>> ListAll ( );
        Task<bool> Delete ( int id );
    }
}
