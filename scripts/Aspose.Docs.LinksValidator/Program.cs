using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

/// <summary>
/// Validate and fix SITEMAP, RELATIVE and IMAGE LINKS via SITEMAP and LOCALHOST
/// </summary>

string sitemapUrl = args[0];
var processor = new SitemapProcessor();
await processor.ProcessSitemapAsync(sitemapUrl);