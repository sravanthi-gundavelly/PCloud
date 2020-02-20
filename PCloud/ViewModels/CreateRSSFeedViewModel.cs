using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacteraCloud.ViewModels
{
    public class CreateRSSFeedViewModel
    {
        [Required]
        public string FeedName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Link { get; set; }


        public IFormFile Data { get; set; }
    }
}
