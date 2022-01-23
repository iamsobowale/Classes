using System;
namespace Class_Exerecise
{
  public class Student
  {
   private string FullName;
    public int Age;
    public string Course;
    public string Subject;
    public string University;
    public string Email;
    public string PhoneNumber;

    public Student(){}
     // question2
    public Student(string fullName, string course)
    {
      this.FullName = fullName;
      this.Course = course;
      
    }
    public Student(string university, string email, string subject)
    {
     this.University = university;
      this.Email = email;
      this.Subject = subject;
    }

//question4
    public void Student1(string name, int age)
    {
      FullName = name;
       Console.WriteLine($"The Student name is {name} and {age} years old");
      this.Age = age;
    }
    // question5
    public void setFullName(string name)
    {
      this.FullName=name;      
    }
    public string getFullName()
    {
      return FullName;
    }

    //question6
    public class StudentTest
    {
            // Student student1 = new Student();
            // student1.setFullName("Bayo");
            // student1.Age =24;
            // student1.Course="English";
            // Console.WriteLine($"My name is {student1.getFullName()} and i am {student1.Age} and i studied {student1.Age}");
    } 
  }
  // MOBILEPHONE Question 8
  public class MobilePhone
  {
    private string Model{get;set;}
    private string Manufacturer{get;set;}
    public int? Price;
    public string Owner;
    public static string NokiaN95;
    public MobilePhone(){}
    public MobilePhone(string model, string manufacturer,int? price, string owner)
    {
      this.Model=model;
      this.Manufacturer=manufacturer;
      this.Price=price;
      this.Owner=owner;
    }
     public MobilePhone(string model, string manufacturer)
    {
      this.Model=model;
      this.Manufacturer=manufacturer;
    }

    // Question12
    public override string ToString()
    {
      return ($"The name of the phone is {Model} made by {Manufacturer} it cost {Price} naira and owned by {Owner} the phone model is {Model}");
    }
        public static string Getinfo()
        {
            return NokiaN95;
        }

        // Question14
        public void PrintInfo()
        {
            string[] arr=new string[]{Owner,Model,Manufacturer,Price.ToString()};
            Getinfo();
        }

        // Question15
        
        
  }
  public class FeaturesOfBattery
  {
   private int Model{get;set;}
   private int? IdleTime{get;set;}
   public int? HourTalk;
   public BatteryType battery;

   public FeaturesOfBattery(){}

  //  QUESTION9 and 11

  public FeaturesOfBattery(int model, int? idleTime, int? hourTalk, BatteryType battery)
  {
   Model = model;
   IdleTime = idleTime;
   HourTalk = hourTalk;
   this.battery = battery;
  }
    public FeaturesOfBattery(int model, int? idleTime)
    {
      this.Model=model;
      this.IdleTime=idleTime;
    }

 }
  
  public class FeaturesOfScreen
  {
   private int size{get;set;}
   public string color;
   public FeaturesOfScreen(){}
  }

  // Question15-19
   public class logs
    {
        public string number;
        public DateTime Date;
        public DateTime Begin;
        public DateTime End;

        public logs(string num)
        {
            number = num;

            Date = DateTime.Now;
            Begin = DateTime.UtcNow;
            End = DateTime.UtcNow;
        }
        public string  CallHistory()
        {
            string history = $"{number}   {Date} {Begin} {End}";
            return history;
        }
    }


    public class Call<T> where T : logs
    {
        
        public string logs(T details)
        {
            return (details.CallHistory());
        }
    }


    public class lisTcall
    {
        public static void Enlist()
        {
            logs log=new logs("0802370455");
            Call<logs> info=new Call<logs>();
            Console.WriteLine(info.logs(log));
        }


    }
   

}