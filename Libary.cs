using System;
using System.Collections.Generic;
namespace Class_Exerecise
{
 public class Libary
 {
  public string name{get;set;}
 }
 public class Book
 {
  public string Title{get;set;}
  public string Author{get;set;}
  public string Publisher{get;set;}
   public string Releasedate{get;set;}
   public string IdNumber{get;set;} 
   List<Book> books= new List<Book>();

  public Book(string title, string author, string publisher, string releasedate, string idNumber)
  {
   Title = title;
   Author = author;
   Publisher = publisher;
   Releasedate = releasedate;
   IdNumber=idNumber;
   AddBooks();
  }

  public void AddBooks()
   {
     books.Add(this);
   }
   public void Printinfo()
   {
     for (var i = 0; i < books.Count; i++)
     {
        Console.WriteLine($"The title of the book is {Title} and made by {Author} published by {Publisher} and released {Releasedate} the ISBN is {IdNumber}");
     }
   }
   public void CollectDetails()
   {
      Console.WriteLine("Book Title");
      string title=Console.ReadLine();
      Console.WriteLine("Name of Author");
      string author=Console.ReadLine();
      Console.WriteLine("Name of Publisher");
      string publisher=Console.ReadLine();
      Console.WriteLine("Release Date");
      string releasedate=Console.ReadLine();
      Console.WriteLine("ID Number");
      string idNumber=Console.ReadLine();
      Book books=new Book(title,author,publisher,releasedate,idNumber);
      books.Printinfo();
   }
   public void RemoveBook()
   {
     Console.WriteLine("IdNumber of book you are removing");
     string remove=Console.ReadLine();
     foreach (var item in books)
     {
       if (item.IdNumber==remove)
       {
         books.Remove(item);
         break;
       }
       else
       {
        Console.WriteLine("Invalid Id");
       }
     }
     Console.WriteLine("Book have been removed");
   
   }
   public void Search()
   {
      Console.WriteLine("Author of Book you need");
     string author=Console.ReadLine();
     foreach (var item in books)
     {
       if (item.IdNumber==author)
       {
         Console.WriteLine(item);
       }
       else
       {
        Console.WriteLine("Invalid Id");
       }
      }
   }
 }
}
