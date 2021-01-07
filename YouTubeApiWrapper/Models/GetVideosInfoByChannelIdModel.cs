using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWrapper.Models
{
    public class GetVideosInfoByChannelIdModel
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public PageInfo pageInfo { get; set; }
        public List<SnippetItem> items { get; set; }
    }
    public class SnippetItem
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public Id id { get; set; }
        public VideoSnippet snippet { get; set; }
        public string channelTitle { get; set; }
        public string liveBroadcastContent { get; set; }
        public string publishTime { get; set; }
    }
    public class VideoSnippet
    {
        public string publishedAt { get; set; }
        public string channelId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnails thumbnails { get; set; }
    }
    public class Thumbnails
    {
        public Thumbnail @default { get; set; }
        public Thumbnail medium { get; set; }
        public Thumbnail high { get; set; }
    }
    public class Thumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
