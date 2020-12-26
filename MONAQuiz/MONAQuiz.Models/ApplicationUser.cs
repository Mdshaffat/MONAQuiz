using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MONAQuiz.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public int TotalQuizPoints { get; set; }
    }
}
