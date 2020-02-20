using PCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCloud.Repository
{
    public interface ICloudDocumentsRepository
    {
        IEnumerable<CloudDocuments> GetAllCloudDocuments();
        IEnumerable<CloudDocuments> GetAllCloudDocuments(string category);
        CloudDocuments GetDocumentById(Guid guid);
        //void CreateCloudDocument(CloudDocuments document);
        //void UpdateCloudDcoument(Guid Id, CloudDocuments document);
        //void DeleteCloudDocument(Guid Id);

    }
}
