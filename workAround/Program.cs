// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Person person1 = new Person();
person1.FirstName = "MURAT EMRE";
person1.LastName = "ATEŞ";
person1.DateOfBirthYear = 1995;
person1.NationalIdentity = 10022;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

