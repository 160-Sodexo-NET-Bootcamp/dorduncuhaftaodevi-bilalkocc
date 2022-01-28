using DataAccess.Context;
using DataAccess.DataModels;
using DataAccess.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.CakeRepo
{
    public class CakeRepository : GenericRepository<Cake>, ICakeRepository
    {
        private readonly DataContext context;

        public CakeRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
        

    }
}
