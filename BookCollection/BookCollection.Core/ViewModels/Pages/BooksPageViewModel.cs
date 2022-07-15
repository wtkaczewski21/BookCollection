using BookCollection.Core.Commands;
using BookCollection.Core.ViewModels.Base;
using BookCollection.Core.ViewModels.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace BookCollection.Core.ViewModels.Pages
{
    public class BooksPageViewModel : BaseViewModel
    {
        public ObservableCollection<BookViewModel> Books { get; set; } = new ObservableCollection<BookViewModel>();

        public string NewBookTitle { get; set; }
        public string NewBookAuthor { get; set; }

        public ICommand AddNewBookCommand { get; set; }

        public BooksPageViewModel()
        {
            AddNewBookCommand = new RelayCommand(AddNewBook);
        }

        private void AddNewBook()
        {
            var newBook = new BookViewModel
            {
                Title = NewBookTitle,
                Author = NewBookAuthor,
            };

            Books.Add(newBook);

            NewBookTitle = string.Empty;
            NewBookAuthor = string.Empty;

            OnPropertyChanged(nameof(NewBookTitle));
            OnPropertyChanged(nameof(NewBookAuthor));
        }
    }
}
