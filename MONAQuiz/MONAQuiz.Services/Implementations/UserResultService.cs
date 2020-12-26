using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MonaQuiz.Data;
using MONAQuiz.Models;
using MONAQuiz.Services.Interfaces;
using System.Threading.Tasks;

namespace Quizaldo.Services.Implementations
{
    public class UserResultService : DataService, IUserResultService
    {
        private readonly IMapper mapper;

        public UserResultService(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        public async Task<UserResult> GetUserResultById(int id, string username)
        {
            var user = await this.context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            var userResult = await this.context.UserResults.Include(q => q.Quiz).FirstOrDefaultAsync(ur => ur.Id == id);

            return userResult;
        }
    }
}
