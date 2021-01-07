using ApiWrapper.Models;
using ApiWrapper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ApiWrapper.Models;
using static System.String;
using System.Collections.Concurrent;
using EmailExtractor;

namespace ApiWrapper
{//TODO incapsulate creating parametrs in one method/entity
    //TODO add tests to get video info method
    //TODO add test to get channels info method

    /// <summary>
    /// Provides API and models to work with youtube api
    /// </summary>
    public class YouTubeApiWrapper
    {
        public HttpClient Client = new();
        public CancellationTokenSource cancellation = new();

        //public static HttpClient Client = new();
        //public static CancellationTokenSource cancellation = new();
        //public static string pageToken = null;
        //public static async Task Main()
        //{
        //    //new[] { 43, 56, 22, 11, 34 }
        //    //.Last(i => i % 2 == 0);
        //    //  var channels = new YouTubeApiWrapper().GetChannelsInfoByName("илья фадеев").Result;
        //    var videos = new YouTubeApiWrapper().GetVideosInfoByChannelId("UC1X2oDYWAw8M5T88XxP7jqA").Result;
        //    foreach (var v in videos)
        //    {
        //        Console.WriteLine(v.Id);
        //        Console.WriteLine(v.Title);
        //        Console.WriteLine(v.ImageAddress);
        //    }
        //    //foreach(var i in channels)
        //    //{
        //    //    Console.WriteLine(i.ImageAddress);
        //    //    Console.WriteLine(i.Title);
        //    //    Console.WriteLine(i.Id);
        //    //    Console.WriteLine();
        //    //    Console.WriteLine();
        //    //}

        //    //var c = new YouTubeApiWrapper().GetVideoIdByName("жизнь обмен денис борисов").Result;
        //    //Console.WriteLine(c);
        //    //foreach (var i in new YouTubeApiWrapper().GetVideosIdsByChannelId("UCXOzPAwI8ChKpGjRXE4E7ew").Result)
        //    //    Console.WriteLine(i);
        //    //new CancellationToken().c
        //    //var c =  await(await new myClient().SendAsync(new(HttpMethod.Get, "https://google.com"), new CancellationToken())).Content.ReadAsStringAsync();
        //    //Console.WriteLine(c);
        //}

        public async Task<List<VideoInfo>> GetVideosInfoByChannelId(string channelId, string pageToken = null)
        {
            List<VideoInfo> VideoInfoList = new();
            //create uri with all query params
            UriBuilder uriBuilder = new("https://www.googleapis.com/youtube/v3/search");
            //add params to get videos from api
            uriBuilder.AddQueryParam("part", "snippet")
                .AddQueryParam("maxResults", 100)
                .AddQueryParam("type", "video")
                .AddQueryParam("channelId", channelId)
                .AddQueryParam("key", Environment.GetEnvironmentVariable("YoutubeApiKey"));
            if (pageToken is not null)
                uriBuilder.AddQueryParam("pageToken", pageToken);

            //configure variables to send request and get responce
            GetVideosInfoByChannelIdModel responce;
            HttpRequestMessage message = new()
            {
                Method = HttpMethod.Get,
                RequestUri = uriBuilder.Uri
            };
            var result = await Client.SendAsync(message, cancellation.Token);
            string json = await result.Content.ReadAsStringAsync();
            responce = JsonSerializer.Deserialize<GetVideosInfoByChannelIdModel>(json);

            //add videos info from responce
            responce.items.ForEach(i =>
            {
                VideoInfo info = new()
                {
                    Id = i.id.videoId,
                    ImageAddress = i.snippet.thumbnails.@default.url,
                    Title = i.snippet.title
                };
                VideoInfoList.Add(info);
            });
            //if next videos page exist add this videos
            if (!IsNullOrEmpty(responce.nextPageToken))
                VideoInfoList.AddRange(await GetVideosInfoByChannelId(channelId, responce.nextPageToken));

            return VideoInfoList;
        }

        /// <summary>
        /// Get common get 10 most popular channels by inserted name
        /// </summary>
        /// <param name="channelId">id of channel what videos info need to get</param>
        /// <param name="pageToken">using in recursion to get video info from many pages</param>
        /// <returns>list of <see cref="ChannelInfo"/> contails all videos from channel</returns>
        public async Task<List<ChannelInfo>> GetChannelsInfoByName(string channelName)
        {
            List<ChannelInfo> VideoInfoList = new();
            //create uri with all query params
            UriBuilder uriBuilder = new("https://www.googleapis.com/youtube/v3/search");
            //add params to get videos from api
            uriBuilder.AddQueryParam("part", "snippet")
                .AddQueryParam("maxResults", 10)
                .AddQueryParam("type", "channel")
                .AddQueryParam("q", channelName)
                .AddQueryParam("key", Environment.GetEnvironmentVariable("YoutubeApiKey"));

            //configure variables to send request and get responce
            GetVideosInfoByChannelIdModel responce;
            HttpRequestMessage message = new()
            {
                Method = HttpMethod.Get,
                RequestUri = uriBuilder.Uri
            };
            var result = await Client.SendAsync(message, cancellation.Token);
            string json = await result.Content.ReadAsStringAsync();
            //this model valid to get data for channel
            responce = JsonSerializer.Deserialize<GetVideosInfoByChannelIdModel>(json);

            //add channel info from responce
            foreach (var i in responce.items)
            {
                ChannelInfo info = new()
                {
                    Id = i.snippet.channelId,
                    ImageAddress = i.snippet.thumbnails.@default.url,
                    Title = i.snippet.title
                };
                VideoInfoList.Add(info);
            }

            return VideoInfoList;
        }

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
        /// get comments page from the video and next page token, if exists
        /// </summary>
        /// <param name="videoId">video id to extract comments</param>
        /// <returns>list of <see cref="Comment"/> represents most useful information about them</returns>
        public List<Comment> GetCommentsByVideoId(string videoId, out string nextPageToken, string pageToken = null)
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
            var result = Client.SendAsync(message, cancellation.Token).Result;
            string json = result.Content.ReadAsStringAsync().Result;
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
            nextPageToken = data.nextPageToken;
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
        /// <summary>
        /// Get all comments from video and write emails to Bag
        /// </summary>
        /// <param name="emails">collection to write emails</param>
        /// <returns>completed task when all emails will be extracted</returns>
        public async Task ExtractEmailsAsync(ConcurrentBag<string> emails, string videoId)
        {
            List<Task> tasks = new();
            string nextPage = null;
            do
            {
                List<Comment> comments = GetCommentsByVideoId(videoId, out nextPage, nextPage);
                Task t = new(() =>
                {
                    Extractor extractor = new();
                    foreach (var c in comments.Select(com => com.CommentText))
                        foreach (var email in extractor.GetEmailsFromMessage(c))
                            if(!emails.Contains(email))
                                emails.Add(email);
                });
                t.Start();
                tasks.Add(t);
            } while (nextPage is not null);
            await Task.WhenAll(tasks.ToArray());
            return;
        }
    }
}
