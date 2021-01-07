using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWrapper.Models;

namespace YoutubeEmailExtractorApi.Models.Interfaces
{
    public interface IApiWrapper
    {
        Task<List<VideoInfo>> GetVideosInfoByChannelId(string channelId);
        Task<List<ChannelInfo>> GetChannelsInfoByName(string channelName);
        Task<string> GetVideoIdByName(string name);
        Task<List<string>> GetVideosIdsByChannelId(string channelId);
        Task<List<Comment>> GetCommentsByVideoId(string videoId);
        Task<string> GetChannelIdByName(string channelName);
        Task ExtractEmailsAsync(ConcurrentBag<string> emails, string videoId);

    }
}
