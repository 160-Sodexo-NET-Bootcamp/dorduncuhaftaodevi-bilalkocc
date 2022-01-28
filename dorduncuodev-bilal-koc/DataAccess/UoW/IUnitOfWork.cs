using DataAccess.Repos.CakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UoW
{
    public interface IUnitOfWork
    {
        ICakeRepository Cakes { get; }
        int Complete();

    }
}
