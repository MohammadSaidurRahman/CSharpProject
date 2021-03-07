using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _Repository_Domain;
using RepositoryPattern;

namespace Exam03Project
{ 
    class Program
    {
        static void Main(string[] args)
        {

            bool isRun = true;
            while (isRun) 
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("================= Select Your Process =================");
                Console.WriteLine("Press 1 : To Get a Trainee Information");
                Console.WriteLine("Press 2 : To Create a New Trainee Information"); 
                Console.WriteLine("Press 3 : To Exit The Application"); 
                string inputKey = Console.ReadLine();
                Console.Clear();
                if (inputKey == "1") { var source = RepositoryFactory.Create<StudentRepository>(ContextTypes.XMLSource);
                    var items = source.GetAll();
                    Console.WriteLine(); 
                    Console.WriteLine("=============Trainee Information==========="); 
                    foreach (var item in items) { Console.WriteLine(item.TraineeName + ", " + item.CourseName + ", " + item.RoundNo + ", " + item.CellPhoneNo);
                    } 

                    Console.Write("Press any key to continue..."); 
                    Console.ReadKey(); 
                }
                else if (inputKey == "2") { Trainee trn = new Trainee();
                    Console.Write("Trainee Name : "); 
                    trn.TraineeName = Console.ReadLine(); 
                    Console.Write("Course Name : "); 
                    trn.CourseName = Console.ReadLine();
                    Console.Write("Round No. : ");
                    trn.RoundNo = Console.ReadLine();
                    Console.Write("Cell Phone No. : "); 
                    trn.CellPhoneNo = Console.ReadLine();
                    Console.Clear();
                    StudentRepository source = RepositoryFactory.Create<StudentRepository>(ContextTypes.XMLSource); 
                    try 

                    { 
                        source.Insert(trn); 
                    } 
                    catch (Exception ex) 
                    { 
                        Console.Write(ex);
                        Console.ReadKey(); 
                        continue; 
                    }
                }
                else if (inputKey == "3") 
                { 
                    isRun = false; 
                }
            }
        }
    }
}
