using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace App.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class InfoController: ControllerBase
    {

        
        public JsonResult Get()
        {
            var nome = Environment.MachineName;
            var host = Dns.GetHostEntry(nome);

            Contador.Numero++; 

            return new JsonResult(new { HostName = host.HostName,  contador = Contador.Numero});
        }
    }
}
