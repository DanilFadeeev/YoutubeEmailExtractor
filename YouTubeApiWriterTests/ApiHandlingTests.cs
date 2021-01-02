using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ApiWrapper;

namespace YouTubeApiWrapperTests
{
    /// <summary>
    /// test class, provide default api responce from search method
    /// </summary>
    public class myClient : HttpClient
    {
        //provides typical channellId api responce
        class channelIdContent : HttpContent
        {
            protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
            {
                var writer = new StreamWriter(stream);
                writer.Write(@"
                {
                    ""kind"": ""youtube#searchListResponse"",
                    ""etag"": ""jBt18JhZwxyt2b_cl-JsPxn3Le4"",
                    ""nextPageToken"": ""CAEQAA"",
                    ""regionCode"": ""RU"",
                    ""pageInfo"": 
                    {
                        ""totalResults"": 16904,
                        ""resultsPerPage"": 1
                    },
                    ""items"": 
                    [{
                       ""kind"": ""youtube#searchResult"",
                       ""etag"": ""hTcOhG1VX-GsGOwMcF0AAiG_Kx8"",
                       ""id"": 
                       {
                           ""kind"": ""youtube#channel"",
                           ""channelId"": ""ExampleChannelId""
                       }
                    }]     
                }");
                writer.Flush();
                return Task.CompletedTask;
            }
            protected override bool TryComputeLength(out long length)
            {
                length = 0;
                return true;
            }
        }
        //provides typical list of videos id's api responce
        class videoIdsContent : HttpContent
        {
            protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
            {
                var writer = new StreamWriter(stream);
                writer.Write(ApiJsonResponces.videosIdsResponce);
                writer.Flush();
                return Task.CompletedTask;
            }
            protected override bool TryComputeLength(out long length)
            {
                length = 0;
                return true;
            }
        }
        //provides typical list of comments with next page token
        class viceoCommentsFrstPage : HttpContent
        {
            protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
            {
                var writer = new StreamWriter(stream);
                writer.Write(ApiJsonResponces.GetVideoCommentsFirstPage);
                writer.Flush();
                return Task.CompletedTask;
            }
            protected override bool TryComputeLength(out long length)
            {
                length = 0;
                return true;
            }
        }
        //provides typical last list of comments, not contains next page token
        class viceoCommentsLastPage : HttpContent
        {
            protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
            {
                var writer = new StreamWriter(stream);
                writer.Write(ApiJsonResponces.GetVideoCommentsLastPage);
                writer.Flush();
                return Task.CompletedTask;
            }
            protected override bool TryComputeLength(out long length)
            {
                length = 0;
                return true;
            }
        }
        public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.RequestUri.AbsolutePath == "/youtube/v3/search" && request.RequestUri.Query.Contains("type=channel"))
            {
                Task<HttpResponseMessage> result = new(() => new() { Content = new channelIdContent() });
                result.RunSynchronously();
                return result;
            }
            if (request.RequestUri.AbsolutePath == "/youtube/v3/search" && request.RequestUri.Query.Contains("type=video"))
            {
                Task<HttpResponseMessage> result = new(() => new() { Content = new videoIdsContent() });
                result.RunSynchronously();
                return result;
            }
            if (request.RequestUri.AbsolutePath == "/youtube/v3/commentThreads" &&
                !request.RequestUri.Query.Contains("pageToken"))
            {
                Task<HttpResponseMessage> result = new(() => new() { Content = new viceoCommentsFrstPage() });
                result.RunSynchronously();
                return result;
            };
            if (request.RequestUri.AbsolutePath == "/youtube/v3/commentThreads" &&
                request.RequestUri.Query.Contains($"pageToken={ApiJsonResponces.GetVideoCommentsFIrstPageNextPageToken}"))
            {
                Task<HttpResponseMessage> result = new(() => new() { Content = new viceoCommentsLastPage() });
                result.RunSynchronously();
                return result;
            }
            return null;
        }
        public override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return new() { Content = new channelIdContent() };
        }
    }
    [TestClass]
    public class ApiHandlingTests
    {
        HttpClient fakeClient;

        [TestInitialize]
        public void Init()
        {
            fakeClient = new myClient();
        }
        [TestMethod]
        public void GetVideosIdsByChannelId()
        {
            ApiWrapper.YouTubeApiWrapper wrapper = new() { Client = fakeClient };
            List<string> result = wrapper.GetVideosIdsByChannelId("Oc9Ue12Ft4Gjzvpd4GASk1wqaGI").Result;
            Assert.AreEqual(11, result.Count);
            Assert.AreEqual("XZjVzzdNKlE", result[0]);
            Assert.AreEqual("sNeBFnYAAXY", result[10]);
        }
        [TestMethod]
        public void GetChannelIdByName()
        {
            ApiWrapper.YouTubeApiWrapper wrapper = new() { Client = fakeClient };
            string result = wrapper.GetChannelIdByName("catty perry").Result;
            Assert.AreEqual("ExampleChannelId", result);
        }
        [TestMethod]
        public void GetCommentsByVideoId()
        {
            ApiWrapper.YouTubeApiWrapper wrapper = new() { Client = fakeClient };
            var result = wrapper.GetCommentsByVideoId("sNWoonYAAXY").Result;
            Assert.AreEqual(200, result.Count);
            Assert.AreEqual("Роман Воробьев", result[1].AuthorName);
            Assert.AreEqual("Привет, Денис!:)", result[197].CommentText);
        }
    }
}
