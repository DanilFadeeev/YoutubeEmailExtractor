using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeApiWrapper.Models
{
    class GetVideoIdByNameModel
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public  PageInfo pageInfo { get; set; }
        public List<Item> items { get; set; }
    }
}
