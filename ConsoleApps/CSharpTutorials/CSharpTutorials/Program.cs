using HtmlAgilityPack;

HtmlWeb web= new HtmlWeb();
HtmlDocument doc = web.Load("https://example.com/");

var title = doc.DocumentNode.SelectNodes("//div/h1").First().InnerText;
var desc = doc.DocumentNode.SelectNodes("//div/p").First().InnerText;

Console.WriteLine(title);
Console.WriteLine(desc);
