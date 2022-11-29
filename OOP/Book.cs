using Books;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Books
{


    class Book
    {
        // Book Field variables

        private string _Title = "";
        private string _Author = "";
        private string _publishingHouse = "";
        private int _pagesCount;
        private int _publishmentYear;
        private float _Price;

        // Empty - New Object
        public Book()
        {
            Console.WriteLine("New book incoming...");
        }

        // Constructor - Book with parameters
        public Book(string _Title, string _Author, string _publishingHouse, int _pagesCount, int _publishmentYear, float _Price)
        {
            this._Title = _Title;
            this._Author = _Author;
            this._publishingHouse = _publishingHouse;
            this._pagesCount = _pagesCount;
            this._publishmentYear = _publishmentYear;
            this._Price = _Price;
        }


        // Introduction Method
        public void bookIntroduction()
        {
            Console.WriteLine($" Book Name - {_Title} \n ===========  \n Author - {_Author} \n ===========  \n Publishing house - {_publishingHouse} \n ===========  \n Number of pages = {_pagesCount} \n ===========  \n Publishment year = {_publishmentYear} \n ===========  \n Price = {_Price}zł \n\n\n ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Book Book_1 = new Book("Gdzie się zwierzę spać wybierze", "Marcin Brykczyński", "Literatura", 26, 2022, 15.04f);
            Book_1.bookIntroduction();
            Console.ForegroundColor = ConsoleColor.Blue;
            Book Book_2 = new Book("Zielona Mila", "Stephen King", "Albatros", 416, 2021, 36.47f);
            Book_2.bookIntroduction();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Book Book_3 = new Book("Bieguni", "Olga Tokarczuk", "Literackie", 460, 2019, 43.28f);
            Book_3.bookIntroduction();
            Console.ForegroundColor = ConsoleColor.White;           
        }
    }
}

