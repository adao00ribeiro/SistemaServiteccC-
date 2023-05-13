using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using SistemaServitec.Data;
using SistemaServitec.Models;
using SistemaServitec.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SistemaServitecDBContex DbContex;
        public PersonRepository ( SistemaServitecDBContex dbContex )
        {
            DbContex = dbContex;
        }

        public async Task<PersonModel> Add ( PersonModel Person )
        {
            await DbContex.Persons.AddAsync ( Person );
            await  DbContex.SaveChangesAsync ( );
            return Person;
        }

        public async Task<PersonModel> SearchById ( int Id )
        {
            return await DbContex.Persons.FirstOrDefaultAsync ( x => x.Id == Id );
        }

        public async Task<PersonModel> Update ( PersonModel Person , int id )
        {
            PersonModel temp = await SearchById(id);

            if ( temp == null )
            {
                return null;
            }

            DbContex.Persons.Update ( Person );
            await DbContex.SaveChangesAsync ( );
            return Person;
        }

        public async Task<bool> Delete ( int id )
        {
            PersonModel temp = await SearchById(id);

            if ( temp == null )
            {
                throw new Exception ( $"Not {id}" );
            }

            DbContex.Persons.Remove ( temp );
            await DbContex.SaveChangesAsync ( );
            return true;
        }

        public async Task<PersonModel> TakeTheLast ( )
        {
            return await DbContex.Persons.Include(x => x.Identidade).LastAsync ( );
        }

        public async Task<PersonModel> TakeTheFirst ( )
        {
            return await DbContex.Persons.FirstAsync ( );
        }
    }
}
