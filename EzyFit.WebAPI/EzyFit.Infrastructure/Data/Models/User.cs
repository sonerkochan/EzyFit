using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzyFit.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [Description("Flag indicating whether the user profile is still active")]
        public bool IsActive { get; set; } = true;



        public IEnumerable<UserWorkout> WorkoutIds { get; set; } = new List<UserWorkout>();


        [Description("Registration date of the user.")]
        public DateTime? RegistrationDate { get; set; }

        public DateTime? LastOnline { get; set; }


        [Description("Preferred language code of the user (e.g., 'en', 'bg')")]
        [StringLength(5)]
        public string PreferredLanguage { get; set; } = "en";
    }
}
