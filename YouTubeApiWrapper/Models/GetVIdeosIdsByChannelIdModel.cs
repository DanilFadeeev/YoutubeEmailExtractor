using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeApiWrapper.Models
{
    public class GetVIdeosIdsByChannelIdModel
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public PageInfo pageInfo { get; set; }
        public List<Item> items { get; set; }
    }
    public class PageInfo
    {
        public int totalResults { get; set; }
        public int resultPerPage { get; set; }
    }
    public class Item
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public Id id { get; set; }
    }
    public class Id
    {
        public string kind { get; set; }
        public string videoId { get; set; }
    }
}
