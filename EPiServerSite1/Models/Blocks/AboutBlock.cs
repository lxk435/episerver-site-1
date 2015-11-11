using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServerSite1.Models.Blocks
{
    [ContentType(DisplayName = "AboutBlock", GUID = "b74d0c1e-d19a-47e6-918a-a0ca940a1923", Description = "")]
    public class AboutBlock : BlockData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual String Name { get; set; }

                [CultureSpecific]
                [Display(
                    Name = "Link",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual Url Link { get; set; }


    }
}