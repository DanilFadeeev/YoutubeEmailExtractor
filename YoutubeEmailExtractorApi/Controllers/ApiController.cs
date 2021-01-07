using ApiWrapper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeEmailExtractorApi.Models.Interfaces;
using static System.String;

namespace YoutubeEmailExtractorApi.Controllers
{
    public class ApiController : Controller
    {
        /// <summary>
        /// represents how many emails may be returnted from<para>
        /// <see cref="GetNewListOfEmails(int, ConcurrentBag{string})"/> method</para>
        /// </summary>
        const int emailsPerRequest = 50;
        public ApiController(IApiWrapper wrapper)
        {
            Wrapper = wrapper;
        }
        /// <summary>
        ///  abstractoin to simplify use youtube api
        /// </summary>
        public IApiWrapper Wrapper { get; }
        /// <summary>
        /// this method do noting. It will be delete soon
        /// </summary>
        /// <returns>some data</returns>
        public JsonResult Index()
        {
            List<string> test = new(){ "sldf", "woow", "dowe" };

            JsonResult result = new(new { strnigs = test });
            return result;
        }
        /// <summary>
        /// search cahnnels info by user inserted name
        /// </summary>
        /// <param name="channelName">string to search</param>
        /// <returns><see cref="ChannelInfo"/> collection with 10 or less most relevant results</returns>
        public async Task<IActionResult> GetChannels(string channelName)
        {
            if (IsNullOrWhiteSpace(channelName))
                return BadRequest();

            List<ChannelInfo> result = await Wrapper.GetChannelsInfoByName(channelName);
            return new JsonResult(result);
        }
        /// <summary>
        /// search all videos by channel id
        /// </summary>
        /// <param name="channelId">channel to find videos</param>
        /// <returns>json with <see cref="VideoInfo"/> collection</returns>
        public async Task<IActionResult> GetVideos(string channelId)
        {
            if (IsNullOrWhiteSpace(channelId))
                return BadRequest();

            List<VideoInfo> result = await Wrapper.GetVideosInfoByChannelId(channelId);
            return new JsonResult(result);
        }
        /// <summary>
        /// add task to extract emails from video
        /// </summary>
        /// <param name="videoId">video to extract emails from comments</param>
        /// <param name="emails">collection of eimails. It's supplied from DI</param>
        /// <returns>200 status code responce</returns>
        public IActionResult StartExtractEmails(string videoId, [FromServices] ConcurrentBag<string> emails)
        {
            Wrapper.ExtractEmailsAsync(emails, videoId);
            return Ok();
        }
        /// <summary>
        /// returns json with new portion of emails
        /// </summary>
        /// <param name="startIndex">index of first email to return</param>
        /// <param name="emails">collectoin of all now extracted emails. Supplied from DI</param>
        /// <returns>50 or smaller emails</returns>
        public IActionResult GetNewListOfEmails(int startIndex, [FromServices] ConcurrentBag<string> emails)
        {
            if (startIndex + emailsPerRequest < emails.Count)
                return new JsonResult(new { emails = emails.Distinct().ToArray()[startIndex..(startIndex + emailsPerRequest)] });
            else
                return new JsonResult(new { emails = emails.Distinct().ToArray()[startIndex..] });
        }
        /// <summary>
        /// add all extracted emails to file and return it
        /// </summary>
        /// <param name="emails"></param>
        /// <returns>text file with all emails. Every in new line</returns>
        public IActionResult DownloadAllEmails([FromServices] ConcurrentBag<string> emails)
        {
            //create and open file
            System.IO.File.Create("wwwroot/emails.txt").Close();
            FileStream fs = System.IO.File.Open("wwwroot/emails.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write);

            //escape changing iterable collection
            var emailsArray = emails.ToArray();
            //write emails to file
            foreach (var i in emailsArray)
                fs.WriteText(i + Environment.NewLine);
            fs.Flush();
            fs.Close();
            //return file
            fs = System.IO.File.Open("wwwroot/emails.txt", FileMode.Open);
            return new FileStreamResult(fs, "application/json")
            {
                FileDownloadName = "Emails.txt"
            };
        }
    }
}
/// <summary>
/// provide method to simple write strings into filestream
/// </summary>
public static class FileStreamExtensions
{
    public static void WriteText(this FileStream fs, string text)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(text);
        fs.Write(info, 0, info.Length);
    }
}