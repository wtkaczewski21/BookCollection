using BookCollection.Core.ViewModels.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.Core.ViewModels.Pages
{
    public class BooksPageViewModel
    {
        public List<BookViewModel> Books { get; set; } = new List<BookViewModel>();

        public string NewBookTitle { get; set; }
        public string NewBookAuthor { get; set; }

        private void AddNewBook()
        {
            var newBook = new BookViewModel
            {
                Title = NewBookTitle,
                Author = NewBookAuthor,
            };

            Books.Add(newBook);
        }
    }
}
