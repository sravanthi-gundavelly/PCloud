using System;
using System.Collections.Generic;

namespace PCloud
{
    public partial class Rssfeeds
    {
        public Guid Id { get; set; }
        public string FeedName { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public byte[] Data { get; set; }
    }
}
