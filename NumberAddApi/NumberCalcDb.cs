using Microsoft.EntityFrameworkCore;

namespace NumberAddApi
{
    public class NumberCalcDb : DbContext
    {
        public NumberCalcDb(DbContextOptions<NumberCalcDb> options)
            : base(options) { }

        public DbSet<NumberCalc> CalcResults { get; set; }
    }
}
