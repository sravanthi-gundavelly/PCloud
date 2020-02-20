using PCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCloud.Repository
{
    public class CloudDocumentsRepository : ICloudDocumentsRepository
    {
        private readonly LogicAppDBContext context;

        public CloudDocumentsRepository(LogicAppDBContext context)
        {
            this.context = context;
        }
        //public void CreateCloudDocument(CloudDocuments document)
        //{
        //    if (document != null)
        //        context.CloudDocuments.Add(document);
        //    context.SaveChanges();
        //}

        //public void DeleteCloudDocument(Guid Id)
        //{
        //    if (Id != null)
        //    {
        //        CloudDocuments cloud = context.CloudDocuments.Find(Id);
        //        if (cloud != null)
        //        {
        //            context.CloudDocuments.Remove(cloud);
        //        }
        //    }
        //    context.SaveChanges();
        //}

        public IEnumerable<CloudDocuments> GetAllCloudDocuments()
        {
            return context.CloudDocuments.ToList<CloudDocuments>();
        }

        public CloudDocuments GetDocumentById(Guid Id)
        {
            return context.CloudDocuments.Where(x => x.Id == Id).FirstOrDefault();
        }

        public IEnumerable<CloudDocuments> GetAllCloudDocuments(string category)
        {
            return context.CloudDocuments.Where(x=>x.DocumentCatogery == category).ToList<CloudDocuments>();
        }

        //public void UpdateCloudDcoument(Guid Id, CloudDocuments document)
        //{
        //    if (Id != null)
        //    {
        //        CloudDocuments cloud = context.CloudDocuments.Find(Id);
        //        cloud.ContentType = document.ContentType;
        //        cloud.DocumentName = document.DocumentName;
        //        cloud.DocumentCatogery = document.DocumentCatogery;
        //        cloud.Data = document.Data;
        //    }
        //    context.SaveChanges();
        //}
    }
}
