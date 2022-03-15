using System;
using System.Collections.Generic;
using System.Text;
using Book_task;
namespace Book_task
{
    internal class Book : Product
    {
        public String Genre;

        public Book()
        {

        }
        public Book(string Name,int No , int Price, string Genre) : base(Name,No , Price)
        {
            this.Genre = Genre;
        }
    }
}