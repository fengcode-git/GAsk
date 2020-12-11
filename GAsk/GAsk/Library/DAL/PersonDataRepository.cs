using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;

namespace GAsk.Library.DAL
{
    public class PersonDataRepository : BaseRepository<PersonData>
    {
        public PersonDataRepository(DbConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
