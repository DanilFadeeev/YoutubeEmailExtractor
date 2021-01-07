using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWrapper.Models
{
    public class GetChannelNameByIdModel
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public chnlPageInfo pageInfo { get; set; }
        public List<chnlItem> items { get; set; }
    }
    public class chnlPageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }
    public class chnlItem
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public chnlId id { get; set; }
    }
    public class chnlId
    {
        public string kind { get; set; }
        public string channelId { get; set; }
    }
}
