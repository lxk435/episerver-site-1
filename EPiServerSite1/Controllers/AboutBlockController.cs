using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServerSite1.Models.Blocks;

namespace EPiServerSite1.Controllers
{
    public class AboutBlockController : BlockController<AboutBlock>
    {
        public override ActionResult Index(AboutBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
