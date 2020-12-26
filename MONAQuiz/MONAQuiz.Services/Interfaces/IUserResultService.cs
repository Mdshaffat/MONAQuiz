using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MONAQuiz.Services.Interfaces
{
    public interface IUserResultService
    {
        Task<UserResult> GetUserResultById(int id, string username);
    }
}
