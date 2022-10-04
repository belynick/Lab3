using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Book
    {
        Author author = new Author();
        Title title = new Title();
        Content content = new Content();

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

  
}
