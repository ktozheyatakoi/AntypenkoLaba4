using System;
using System.Collections.Generic;

namespace _4ArtemProject
{
   
    abstract class Text
    {
        public string TextOnThisPage { get; private set; }
        public int FontSize { get; private set; }
        public string FontName { get; private set; }
        public string FontColor { get; private set; }

        public Text(string Text, int size, string FontName, string FontColor)
        {
            TextOnThisPage = Text;
            FontSize = size;
            this.FontName = FontName;
            this.FontColor = FontColor;
        }
        public virtual void OutputTextInfo()
        {
            Console.WriteLine($"Takes {TextOnThisPage.Length} letters" +
                $"\nFont: {FontName}, size: {FontSize}, color: {FontColor}");
        }
    }
    class Page : Text
    {
        public Page(string text, string fontcolor, string fontname, int size) :
                    base(text, size, fontname, fontcolor)
        {

        }
    }
    class PaperBook
    {
        public string BookName { get; private set; }
        public List<Page> Pages = new List<Page>();
        public PaperBook(string name)
        {
            BookName = name;
        }
        public void OutputInfo() =>
            Console.WriteLine($"Book name: {BookName}\nPages num: {Pages.Count}");
        
    }
    class Kindle : Text
    {
        public string NameOfKindleModel { get; private set; }
        public int NumOfElectroPages { get; private set; }
        public Kindle(string text, string fontcolor, string fontname, int size, string name,int num) :
                    base(text, size, fontname, fontcolor)
        {
            NameOfKindleModel = name;
            NumOfElectroPages = num;
        }
    }
    class Graffity : Text
    {
        public Graffity(string text, string fontcolor, string fontname, int size) :
                   base(text, size, fontname, fontcolor)
        {

        }
    }
}
