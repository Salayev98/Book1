using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Library 
    {
        public List<Book> Books;
        public void AddList(string name, string authorName, int pageCount)
        {
            Book books = new Book(name, authorName, pageCount);
            Books.Add(books);
        }
        public void FindAllBooksByName(string word) 
        {
            Books.FindAll(Book => Book.Name.Contains(word));
        }
        public void RemoveAllBookByName(string word) 
        {
            Books.RemoveAll(Book => Book.Name.Contains(word));
        }
        public void SearchBooks(string value) 
        {
            Books.FindAll(Book => Book.Name == value);
            Books.FindAll(Book => Book.AuthorName == value);
            Books.FindAll(Book =>
            {
                return Book.PageCount == int.Parse(value);
            });
        }
        public void FindAllBooksByPageCountRange(int mincount,int maxcount) 
        {
            Books.FindAll(Books => mincount < Book.PageCount && maxcount > Book.PageCount);
        }
        public void RemoveByNo(string code) 
        {
            Books.RemoveAll(Book => Book.Code == code);
        }
        public void List()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
