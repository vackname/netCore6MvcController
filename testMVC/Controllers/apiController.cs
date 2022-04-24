using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testMVC.Confing;
using testMVC.DBFormat;
using testMVC.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testMVC.Controllers
{
    [Route("api/")]
    [ApiController]
    public class api2Controller : Controller
    {

        // GET api/values/5
        [HttpGet("test/{id1}/{id2?}")]
        public IActionResult Get(int id1,string? id2)
        {
            return Json(new { aa=1,bb=id1,cc=id2 });
        }

        // GET api/values/5
        [HttpGet("mb")]
        public IActionResult MBInfo()
        => Json(new MemberInfo().MBAddress());
        

        // POST api/values
        [HttpPost("hipost")]
        public IActionResult PostApi([FromBody]tblMember value)
        {
            /* javascript
function verPost(url, GetFromBody, Func)
{//防偽驗證 Post ajax
    var json = JSON.stringify(GetFromBody);
    var xhr = new XMLHttpRequest();å
    xhr.open("POST", url);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE) {
            Func(JSON.parse(xhr.responseText));//進入api json (response json)
        }
    }
    xhr.send(json);
}

verPost("/api/hipost",{"ac":"dddd","n":"小鬼","uid":"dddUid","pass":"pss","extend1":1},function(e)
{
    console.log(e);
});
             */
            string jsonStr = JsonSerializer.Serialize(value);

            tblMember newData = JsonSerializer.Deserialize<tblMember>(jsonStr);
            if (value.Name.Length < 5)
            {
                return Json(API.Fail(code:errorCode.errorInput,Mes:"匿稱輸入錯誤"));
            }
            object obj = value;
            return Json(new MemberInfo().MBAddress());
        }
    }
}

