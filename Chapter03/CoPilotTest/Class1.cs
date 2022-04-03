using System.Xml.Linq;

var doc = XDocument.Load("index.xhml");

// find all images 
var images = doc.Descendants("img");
// and give them a red boarder 
foreach (var image in images)
{
    image.SetAttributeValue("border", "1");
    image.SetAttributeValue("style", "border-color:red");
}