// <copyright file="Program.cs" company="Big Data for Everybody">
// Copyright (c) Big Data for Everybody. All rights reserved.
// </copyright>

namespace WebCrawlerBigDataForEverybody.WebCrawler
{
    using HtmlAgilityPack;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var webget = new HtmlWeb();
            var htmldoc = webget.Load("http://www.cuantogano.com/");

            var a = htmldoc.DocumentNode.Descendants()
                .Where(x => x.Name == "div")
                .Where(x => x.Attributes.Any())
                .Where(x => x.Attributes["class"]);

            Console.Write(a);

            Console.ReadLine();
        }
    }
}
