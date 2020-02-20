using System;
using System.Collections.Generic;

namespace PCloud
{
    public partial class CloudDocuments
    {
        public Guid Id { get; set; }
        public string DocumentName { get; set; }
        public string ContentType { get; set; }
        public string DocumentCatogery { get; set; }
        public byte[] Data { get; set; }
        public string DocumentDescription { get; set; }
        public string title { get; set; }
    }
}
