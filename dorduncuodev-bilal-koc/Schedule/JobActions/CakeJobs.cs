using DataAccess.DataModels;
using DataAccess.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.JobActions
{
    public class CakeJobs
    {
        private readonly IUnitOfWork unitOfWork;

        public CakeJobs(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void MakingCake()
        {
            var random = new Random();
            var cake = new Cake()
            {
                CakeType = (DataAccess.Enums.CakeType)random.Next(1, 4),
                Price = 90,
                Status = DataAccess.Enums.Status.preparing,
                CreatedDate = DateTime.Now
            };
            unitOfWork.Cakes.Add(cake);
            unitOfWork.Complete();
        }

        public void ChangeStatus()
        {
            var preparedCakes = unitOfWork.Cakes.GetByExp(x => x.CreatedDate.Date == DateTime.Now.Date).ToList();
            foreach (var cake in preparedCakes)
            {
                cake.Status = DataAccess.Enums.Status.selling;
            }
            unitOfWork.Cakes.UpdateList(preparedCakes);
            unitOfWork.Complete();
        }
    }
}
