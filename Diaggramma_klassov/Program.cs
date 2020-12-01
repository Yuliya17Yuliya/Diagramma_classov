using System;

namespace Diaggramma_klassov
{
    class printedition //обявл класс и описываем поля
    {
        public string name;
        public int year;
        public int circulation;

        public printedition(string name, int year, int circulation) // конструктор - порядок полей
        {
            this.name = name; //разрш доступ к экземплярам класса по полям
            this.year = year;
            this.circulation = circulation;
        }

        public void PRINT_NAME() // 3 метода созд // описываем методы
        {
            Console.Write(""+this.name);
        }

        public void PRINT_YEAR() // 3 метода созд
        {
            Console.Write("" + this.year);
        }

        public void PRINT_CIRCULATION() // 3 метода созд
        {
            Console.Write("" + this.circulation);
        }
    }

    class journal
        : printedition
    {
        public int number;
        public int cuntpage;

        public journal(string name, int year, int circulation, int number, int cuntpage)
            : base(name, year, circulation)
        {
            this.number = number;
            this.cuntpage = cuntpage;
        }
        public void PRINT_NUMBER()
        {
            Console.Write("" + this.number);
        }
        public void PRINT_CUNTPAGE()
        {
            Console.Write("" + this.cuntpage);
        }
    }

    class book
        : printedition // с указание базового класса
    {
        public string author;
        public int cuntpg;

        public book(string name, int year, int circulation, string author, int cuntpg)
            : base(name, year, circulation)// поля которые наслед из базы
        {
            this.author = author;
            this.cuntpg = cuntpg;
        }

        public void PRINT_AUTHOR()
        {
            Console.Write("" + this.author);
        }
        public void PRINT_CUNTPG()
        {
            Console.Write("" + this.cuntpg);
        }
    }

    class textbook
        : printedition
    {
        public string subject;
        public int numberclass;

        public textbook(string name, int year, int circulation, string subject, int numberclass)
            : base(name, year, circulation)
        {
            this.subject = subject;
            this.numberclass = numberclass;
        }

        public void PRINT_SUBJECT()
        {
            Console.Write("" + this.subject);
        }
        public void PRINT_NUMBERCLASS()
        {
            Console.Write("" + this.numberclass);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            printedition v = new printedition("hjjkkkk", 2020, 12);
            v.PRINT_NAME();
            v.PRINT_YEAR();
            v.PRINT_CIRCULATION();
            journal c = new journal( v, );
            c.PRINT_NUMBER();
            c.PRINT_CUNTPAGE();
            book m = new book();
            m.PRINT_AUTHOR();
            m.PRINT_CUNTPG();
            textbook s = new textbook();
            s.PRINT_SUBJECT();
            s.PRINT_NUMBERCLASS();


            Console.ReadKey();
        }
    }
}
