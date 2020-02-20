using System;
using System.Collections.Generic;

namespace PCloud
{
    public partial class CustomerFeedback
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string OptionId { get; set; }
        public string OpportunityId { get; set; }
    }
}
