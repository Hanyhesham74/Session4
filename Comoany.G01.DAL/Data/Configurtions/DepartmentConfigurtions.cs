using Comoany.G01.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comoany.G01.DAL.Data.Configurtions
{
    public class DepartmentConfigurtions : IEntityTypeConfiguration<Department> 
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           builder.Property(D=>D.Id).UseIdentityColumn(); 
        }
    }
}
