using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public static int Count = 0;
        public string Code;
        public static string Name;
        public static string AuthorName;
        public static int PageCount;

        public Book( string name, string authorName, int pageCount)
        {
            Code = Name.Substring(0, 2).ToUpper() + Count;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
