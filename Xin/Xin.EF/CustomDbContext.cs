namespace Xin.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomDbContext : DbContext
    {
        public CustomDbContext()
            : base("name=ABPFrame")
        {
        }


    }
}
