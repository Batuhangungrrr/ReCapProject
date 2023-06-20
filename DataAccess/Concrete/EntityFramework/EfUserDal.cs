using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public List<UserDetailDto> GetUserDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from user in context.Users
                             join customer in context.Customers
                             on user.Id equals customer.UserId
                             select new UserDetailDto
                             {
                                 Id = user.Id,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = customer.CompanyName,
                             };
                return result.ToList();
            }
        }
    }
}
