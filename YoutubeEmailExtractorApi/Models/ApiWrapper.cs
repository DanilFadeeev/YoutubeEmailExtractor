using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeEmailExtractorApi.Models.Interfaces;
using ApiWrapper;
using ApiWrapper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace YoutubeEmailExtractorApi.Models
{
    /// <summary>
    /// adapter to IApiWrapper interface
    /// </summary>
    public class ApiWrapper : YouTubeApiWrapper, IApiWrapper
    {
        /// <summary>
        /// get all comments from video by id
        /// </summary>
        /// <param name="videoId">video to get comments</param>
        /// <returns>list of <see cref="Comment"/>obects represents main comment informatoin</returns>
        public async Task<List<Comment>> GetCommentsByVideoId(string videoId)
        {
            string a;
            return  GetCommentsByVideoId(videoId,out a, null);
        }
        /// <summary>
        /// get all videos by channel
        /// </summary>
        /// <param name="channelId">channel id to extract videos</param>
        /// <returns>list of videos id</returns>
        public async Task<List<string>> GetVideosIdsByChannelId(string channelId)
        {
            return await GetVideosIdsByChannelId(channelId, null);
        }
        /// <summary>
        /// get all videos info from channel by id
        /// </summary>
        /// <param name="channelId">channel to extract videos</param>
        /// <returns>list of <see cref="VideoInfo"/> represents main information about video</returns>
        public async Task<List<VideoInfo>> GetVideosInfoByChannelId(string channelId)
        {
            return await GetVideosInfoByChannelId(channelId, null);
        }
    }
}
