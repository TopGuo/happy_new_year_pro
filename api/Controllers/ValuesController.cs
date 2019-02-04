using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 更具id反馈内容
        /// </summary>
        /// <param name="id">入参id</param>
        /// <returns></returns>
        [HttpGet]
        public Result GetName(int id)
        {
            Result re=new Result();
            if (id.Equals(1))
            {
                re.Data="你好";   
                Logger.Information("ValuesController",JsonConvert.SerializeObject(re));             
                return re;
            }
            re.Data="我很好";
            Logger.Information("ValuesController",JsonConvert.SerializeObject(re));
            return re;
        }
    }
}
