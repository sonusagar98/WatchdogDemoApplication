using GalaSoft.MvvmLight.Command;
using LibraryManagement.Models;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace LibraryManagement.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ObservableCollection<Book> Books { get; set; }
        public ICommand AddNewBookCommand { get; set; }

        public string BookTitle { get; set; }

        public string Author { get; set; }
        public string Publication { get; set; }

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            Books = new ObservableCollection<Book>();
            AddNewBookCommand = new RelayCommand(() => {
                this.Books.Add(new Book(this.BookTitle,this.Author, this.Publication));
            });
            LoadSomeBooks();
        }

        private void LoadSomeBooks()
        {
            Book newBook1 = new Book("b11", "a1", "p1");
            Book newBook2 = new Book("b2", "a2", "p2");
            Book newBook3 = new Book("b3", "a3", "p3");
            Book newBook4 = new Book("b4", "a4", "p4");
            Book newBook5 = new Book("b5", "a5", "p5");
            Books.Add(newBook1);
            Books.Add(newBook2);
            Books.Add(newBook3);
            Books.Add(newBook4);
            Books.Add(newBook5);
        }
    }
}
