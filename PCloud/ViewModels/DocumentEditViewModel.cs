using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacteraCloud.ViewModels
{
    public class DocumentEditViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string DocumentCatogery { get; set; }

        [Required]
        public string DocumentDescription { get; set; }

        [Required]
        public IFormFile Document { get; set; }
    }
}
