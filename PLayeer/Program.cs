using System;

namespace Player
{


    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии PRO");
        }


        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии PRO");
        }
    }


    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии EXPERT");
        }

    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ключь =  ");
            string key = Console.ReadLine();

            DocumentWorker docfree = new DocumentWorker();




            if (key == "pro")
            {
                docfree = new ProDocumentWorker();

            }
            else if (key == "exp")
            {
                docfree = new ExpertDocumentWorker();
            }
            else
            {
                docfree = new DocumentWorker();
            }

            docfree.OpenDocument();
            docfree.EditDocument();
            docfree.SaveDocument();


        }
    }
}
