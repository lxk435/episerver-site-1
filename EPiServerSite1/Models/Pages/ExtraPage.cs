using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiServerSite1.Models.Pages
{

    //ContentType - This attribute tells EPiServer that this is content template
    //The DisplayName is the name shown in the EPiServer CMS when creating a new page and the Description is also shown there
    // The GUID is used by EPiServer to notice for example when you change the name of a class from StartPage to BlogPage for example. 
    //Without this GUID EPiServer cannot know that you changed the new. For EPiServer it would then mean that you deleted StartPage type 
    //and created a new BlogPage type. With the help of the GUID it can now recognize that you renamed your type instead of creating a new one.
    //Inheriting from PageData makes it a page type

    [ContentType(DisplayName = "ExtraPage", GUID = "0fce19ff-b79f-4c7a-a253-10a094df2aa2", Description = "")]
    public class ExtraPage : SitePageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
                //important for properties to be virtual or get error

                //cultureSpecific is related to languages, GroupName tells episerver which tab to put property in in the cms
         
    }
}