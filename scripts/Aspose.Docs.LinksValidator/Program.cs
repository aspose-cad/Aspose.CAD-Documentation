using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

string sitemapUrl = args[0];
var processor = new SitemapProcessor();
await processor.ProcessSitemapAsync(sitemapUrl);