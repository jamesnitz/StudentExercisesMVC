using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public int StudentId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Cohort")]
        [Required]
        public int CohortId { get; set; }
        [Display(Name = "Slack Handle")]

        public string SlackHandle { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }

    }
}
