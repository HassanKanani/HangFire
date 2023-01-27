using Microsoft.EntityFrameworkCore;

namespace HangFireTaturial
{
    public class context:DbContext
    {
        public context(DbContextOptions<context>op):base(op)
        {

        }
    }
}
