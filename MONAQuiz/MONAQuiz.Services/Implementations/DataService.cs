using MonaQuiz.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizaldo.Services.Implementations
{
    public abstract class DataService
    {
        protected readonly ApplicationDbContext context;

        public DataService(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
