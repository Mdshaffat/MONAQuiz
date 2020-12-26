using Microsoft.EntityFrameworkCore;
using MonaQuiz.Data;
using MONAQuiz.Models;
using Quizaldo.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizaldo.Services.Implementations
{
    public class UserService : DataService, IUserService
    {
        public UserService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersByTotalPoints()
        {
            var users = await this.context.Users
                .OrderByDescending(u => u.TotalQuizPoints)
                .ToListAsync();

            return users;
        }
    }
}
