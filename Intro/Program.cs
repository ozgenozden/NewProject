// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

CourseManager courseManager = new CourseManager();


foreach (var item in courseManager.GetAll())
{
    Console.WriteLine("Kursun adı " + item.Name + " --> Kursın Fiyatı " + item.Price);
}




Console.WriteLine("BITTI");



