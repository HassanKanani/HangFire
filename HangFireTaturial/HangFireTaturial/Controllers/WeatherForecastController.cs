using Hangfire;
using Hangfire.Common;
using HangFireTaturial.Implamation;
using Microsoft.AspNetCore.Mvc;

namespace HangFireTaturial.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class WeatherForecastController : ControllerBase
    {
        IHang _h;
        private readonly IBackgroundJobClient _backgroundJobClient;
        public WeatherForecastController(IHang h,IBackgroundJobClient backgroundJobClient)
        {
            _h = h;
            _backgroundJobClient = backgroundJobClient;
        }
        //Job job = null;
        //اجرا در لحظه
        [HttpGet("forget")]
        public string getforget()
        {

           var s= _backgroundJobClient.Enqueue(()=>_h.FireAndForget());
            return _h.FireAndForget();
        }
        //اجرا در مقدار داده شده
        [HttpGet("delayaddtime")]
        public IActionResult delayaddtime(int time,int t2)
        {

            var s = _backgroundJobClient.Schedule(() => _h.delayedinasaddtime(),TimeSpan.FromSeconds(time));
            var s1 = _backgroundJobClient.Schedule(() => _h.delayedinasaddtime(),TimeSpan.FromSeconds(t2));
            return Ok($"done in seconds{time}+{s1}{s}");
        }
        //اجرا در تاریخ ست شده
        [HttpGet("delaytimeOfSet")]
        public IActionResult delaytimeOfSet(DateTime t)
        {
          
            

            t=DateTime.Now;
            var s = _backgroundJobClient.Schedule(() => _h.delayedinsettime(),t);
            //var s1 = _backgroundJobClient.Schedule(() => _h.delayedinasaddtime(), TimeSpan.FromSeconds(t2));
            return Ok($"done in seconds{s}");
        }

        ////اجرا در تاریخ ست شده
        //[HttpGet("updateouradd")]
        //public IActionResult updateouradd()
        //{



           
        //    var s = _backgroundJobClient.Create("test",() => _h.delayedinsettime(),Cron.Minutely);
        //    //var s1 = _backgroundJobClient.Schedule(() => _h.delayedinasaddtime(), TimeSpan.FromSeconds(t2));
        //    return Ok($"done in seconds{s}");
        //}


    }
}