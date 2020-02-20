using PCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCloud.Repository
{
    public class RSSFeedsRepository
    {
        //private readonly AppDbContext context;

        //public RSSFeedsRepository(AppDbContext context)
        //{
        //    this.context = context;
        //}
        //public void CreateRSSFeeds(RSSFeeds RSSFeed)
        //{
        //    if (RSSFeed != null)
        //        context.RSSFeeds.Add(RSSFeed);
        //    context.SaveChanges();
        //}

        //public void DeleteRSSFeed(Guid Id)
        //{
        //    if (Id != null)
        //    {
        //        var tem = context.RSSFeeds.Find(Id);
        //        if (tem != null)
        //        {
        //            context.RSSFeeds.Remove(tem);
        //        }
        //    }
        //    context.SaveChanges();
        //}

        //public IEnumerable<RSSFeeds> GetAllRSSFeeds()
        //{
        //    return context.RSSFeeds;
        //}

        //public RSSFeeds GetRSSFeedById(Guid Id)
        //{
        //    return context.RSSFeeds.Where(x => x.Id == Id).FirstOrDefault();
        //}

        //public void UpdateRSSFeeds(Guid Id, RSSFeeds RSSFeeds)
        //{
        //    if (Id != null && RSSFeeds != null)
        //    {
        //        var temp = context.RSSFeeds.Find(Id);
        //        temp.Data = RSSFeeds.Data;
        //        temp.Description = RSSFeeds.Description;
        //        temp.FeedName = RSSFeeds.FeedName;
        //        temp.Link = RSSFeeds.Link;
        //        context.SaveChanges();
        //    }
        //}
    }
}
