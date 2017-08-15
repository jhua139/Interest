using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HtmlAgilityPack;

namespace Interest
{
    class Engine
    {
        public string GetAnzData()
        {
            {
                var html = @"http://www.anz.co.nz/";

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);

                var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

                string text = node.OuterHtml.ToString();
               
                return text;

            }
            // TODO: API call here
        }
    }
}