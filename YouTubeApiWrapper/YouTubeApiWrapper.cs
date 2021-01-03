using ApiWrapper.Models;
using ApiWrapper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using YouTubeApiWrapper.Models;
using static System.String;

namespace ApiWrapper
{//TODO incapsulate creating parametrs in one method/entity

    /// <summary>
    /// Provides API and models to work with youtube api
    /// </summary>
    public class YouTubeApiWrapper
    {
        public HttpClient Client = new();
        public CancellationTokenSource cancellation = new();
        //public static async Task Main()
        //{
        //   var c = new YouTubeApiWrapper().GetVideoIdByName("жизнь обмен денис борисов").Result;
        //    Console.WriteLine(c);
        //    //foreach (var i in new YouTubeApiWrapper().GetVideosIdsByChannelId("UCXOzPAwI8ChKpGjRXE4E7ew").Result)
        //    //    Console.WriteLine(i);
        //    //new CancellationToken().c
        //    //var c =  await(await new myClient().SendAsync(new(HttpMethod.Get, "https://google.com"), new CancellationToken())).Content.ReadAsStringAsync();
        //    //Console.WriteLine(c);
        //}
        /// <summary>
        /// Search most relevant video by name
        /// </summary>
        /// <param name="name">video name or keywords to search video</param>
        /// <returns>video id or null if not found</returns>
        public async Task<string> GetVideoIdByName(string name)
        {
            //create uri with all query params
            UriBuilder uriBuilder = new("https://www.googleapis.com/youtube/v3/search");
            //add params to get videos from api
            uriBuilder.AddQueryParam("part", "id")
                .AddQueryParam("maxResults", 1)
                .AddQueryParam("type", "video")
                .AddQueryParam("q", name)
                .AddQueryParam("key", Environment.GetEnvironmentVariable("YoutubeApiKey"));
            //send request
            GetVideoIdByNameModel responce;
            HttpRequestMessage message = new()
            {
                Method = HttpMethod.Get,
                RequestUri = uriBuilder.Uri
            };
            var result = await Client.SendAsync(message, cancellation.Token);
            string json = await result.Content.ReadAsStringAsync();
            responce = JsonSerializer.Deserialize<GetVideoIdByNameModel>(json);
            //return id if responce is not null
            return responce?.items?[0]?.id?.videoId;
        }
        /// <summary>
        /// get all videos id of channel id. To get channel id you can use GetChannelIdByName method
        /// </summary>
        /// <param name="channelId">channel id for video receiving</param>
        /// <param name="pageToken">using in recursion to get many videos pages.
        /// <para>You can specify it if you would get videos scince certain page</para></param>
        /// <returns>list of video id's</returns>
        public async Task<List<string>> GetVideosIdsByChannelId(string channelId, string pageToken = null)
        {
            List<string> Ids = new();
            //create uri with all query params
            UriBuilder uriBuilder = new("https://www.googleapis.com/youtube/v3/search");
            //add params to get videos from api
            uriBuilder.AddQueryParam("part", "id")
                .AddQueryParam("maxResults", 11)
                .AddQueryParam("type", "video")
                .AddQueryParam("channelId", channelId)
                .AddQueryParam("key", Environment.GetEnvironmentVariable("YoutubeApiKey"));
            if (pageToken is not null)
                uriBuilder.AddQueryParam("pageToken", pageToken);

            //configure variables to send request and get responce
            GetVIdeosIdsByChannelIdModel responce;
            HttpRequestMessage message = new()
            {
                Method = HttpMethod.Get,
                RequestUri = uriBuilder.Uri
            };
            var result = await Client.SendAsync(message, cancellation.Token);
            string json = await result.Content.ReadAsStringAsync();
            responce = JsonSerializer.Deserialize<GetVIdeosIdsByChannelIdModel>(json);
            //add videos id's from responce
            foreach (var i in responce.items.Select(item => item.id.videoId))
                Ids.Add(i);
            //if next videos page exist add this videos
            if (!IsNullOrEmpty(responce.nextPageToken))
                Ids.AddRange(await GetVideosIdsByChannelId(channelId, responce.nextPageToken));

            return Ids;
        }
        /// <summary>
        /// get all comments to the video and return most useful information about them
        /// </summary>
        /// <param name="videoId">video id to extract comments</param>
        /// <returns>list of <see cref="Comment"/> objects</returns>
        public async Task<List<Comment>> GetCommentsByVideoId(string videoId,string pageToken = null)
        {
            //create uri with all query params
            UriBuilder uriBuilder = new("https://youtube.googleapis.com/youtube/v3/commentThreads");

            uriBuilder.AddQueryParam("part", "snippet")
                .AddQueryParam("maxResults", 100)
                .AddQueryParam("videoId", videoId)
                .AddQueryParam("key", Environment.GetEnvironmentVariable("YoutubeApiKey"));

            if (!IsNullOrEmpty(pageToken))
                uriBuilder.AddQueryParam("pageToken", pageToken);
            //create request message with all neede api data
            HttpRequestMessage message = new()
            {
                Method = HttpMethod.Get,
                RequestUri = uriBuilder.Uri
            };
            //get answer in model
            var result = await Client.SendAsync(message, cancellation.Token);
            string json = await result.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<GetCommentsByVideoIdModel>(json);
            //write most useful comment data from model to return data
            List<Comment> comments = new();
            foreach (var i in data.items) 
            {
                Comment comment = new()
                {
                    AuthorName = i.snippet.topLevelComment.snippet.authorDisplayName,
                    CommentText = i.snippet.topLevelComment.snippet.textOriginal
                };
                comments.Add(comment);
            }
            //get next page of comments if exist
            if (!IsNullOrEmpty(data.nextPageToken))
                comments.AddRange(await GetCommentsByVideoId(videoId, data.nextPageToken));

            return comments;
        }
        /// <summary>
        /// search most popular channel with inserted name
        /// </summary>
        /// <param name="channelName"></param>
        /// <returns>most relevant channel id, return string empty if not found</returns>
        public async Task<string> GetChannelIdByName(string channelName)
        {
            //create uri with all query params
            UriBuilder uriBuilder = new("https://www.googleapis.com/youtube/v3/search");

            uriBuilder.AddQueryParam("part", "id")
                .AddQueryParam("maxResults", 1)
                .AddQueryParam("type", "channel")
                .AddQueryParam("q", channelName)
                .AddQueryParam("key", Environment.GetEnvironmentVariable("YoutubeApiKey"));


            HttpRequestMessage message = new()
            {
                Method = HttpMethod.Get,
                RequestUri = uriBuilder.Uri
            };

            var result = await Client.SendAsync(message, cancellation.Token);
            string json = await result.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<GetChannelNameByIdModel>(json);

            return data.items.First().id.channelId;
        }
    }
}
