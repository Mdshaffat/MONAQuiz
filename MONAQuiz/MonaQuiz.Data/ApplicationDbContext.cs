using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonaQuiz.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<UserResult> UserResults { get; set; }

        public DbSet<QuestionSuggestion> QuestionSuggestions { get; set; }
    }
}
