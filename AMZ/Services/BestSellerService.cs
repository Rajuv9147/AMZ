using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using AMZ.Models;

namespace AMZ.Services
{
    public class BestSellerService
    {
        public static IEnumerable<Item> GetItems(string itemtype)
        {
           XDocument feedXML = XDocument.Load("https://www.amazon.com/gp/rss/bestsellers/"+itemtype);

           var items = from item in feedXML.Descendants("item")
                        select new Item
                        {
                            Title = item.Element("title").Value,
                            Guid_Id = item.Element("guid").Value,
                            Link = item.Element("link").Value,
                            PubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        };

            return items;

        }
    }
}