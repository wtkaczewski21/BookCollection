using BookCollection.Core.ViewModels.Base;
using BookCollection.Core.ViewModels.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookCollection.Core.ViewModels.Pages
{
    public class BooksPageViewModel : BaseViewModel
    {
        public ObservableCollection<BookViewModel> BooksList { get; set; } = new ObservableCollection<BookViewModel>();

        public string NewBookTitle { get; set; }
        public string NewBookAuthor { get; set; }

        public ICommand AddNewBookCommand { get; set; }
        public ICommand DeleteSelectedBooksCommand { get; set; }


        
    }
}
