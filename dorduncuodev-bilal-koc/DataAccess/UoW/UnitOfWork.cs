using DataAccess.Context;
using DataAccess.Repos.CakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICakeRepository Cakes { get; private set; }
        
        private readonly DataContext context;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
            Cakes = new CakeRepository(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }
    }
}
