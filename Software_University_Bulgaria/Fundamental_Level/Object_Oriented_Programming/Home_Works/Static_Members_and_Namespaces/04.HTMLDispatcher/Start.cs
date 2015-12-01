using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispatcher
{
    class Start
    {
        static void Main(string[] args)
        {

            ElementBuilder div = new ElementBuilder("div");

            div.AddAttribute("id","page");
            div.AddAttribute("class","big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 3);

            // matched against list of valid tags
            ElementBuilder invalidTag = new ElementBuilder("dfd");
            ElementBuilder someTag = new ElementBuilder("someTag");
            // Empty attribute not accepted.
            someTag.AddAttribute("", "");
            someTag.AddAttribute("style","front-size: 5px;");
            Console.WriteLine(someTag);
            someTag.AddContent("this is a paragraph");
            Console.WriteLine(someTag);
            //Only a possitive values defined for operator.
            Console.WriteLine(someTag * 15);

            ElementBuilder image = HTMLDispatcher.CreateImage(@"http: //www.google.bg","missing","Google");
            Console.WriteLine(image);

            // self-closing tag does not have content;
            image.AddContent("can not do that");
            ElementBuilder link = HTMLDispatcher.CreateURL(@"https://facebook.com","Facebook","Click me!");
            Console.WriteLine(link);

            ElementBuilder input = HTMLDispatcher.CreateInput("radio","gender","0");
            Console.WriteLine(input);
            //input.AddContent("aluuu");

            string[] tags = ElementBuilder.GetValidHTMLTags();
            tags[0] = "removed";

            //List of valid tags can not be modified.
            // Console.WriteLine(ElementBuilder.ValidHTMLTags[0]); // Problem on ValidHTMLTags ?!
        }
    }
}
