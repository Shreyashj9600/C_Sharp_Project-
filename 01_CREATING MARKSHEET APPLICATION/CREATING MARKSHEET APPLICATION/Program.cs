using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CREATING_MARKSHEET_APPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
            string name =  Console.ReadLine();  

            Console.WriteLine("Enter your PRN number :");
            string PRNno =  Console.ReadLine();

            Console.WriteLine("Enter your Standerd");
            string std =  Console.ReadLine();

            Console.WriteLine("Enter your Marathi marks");
            int mhr = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your English marks");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Physics marks");
            int phy = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Chemistry marks");
            int chem = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Math marks");
            int math = int.Parse(Console.ReadLine());

            int calcuRs  = mhr + eng + phy + chem + math;   
            int per = calcuRs * 100 / 500;
            
            // Show Result
            Console.WriteLine("------------Marksheet------------- \n" );

            Console.WriteLine("your name is: {0}", name);
            Console.WriteLine("your Roll no is : {0}", PRNno);
            Console.WriteLine("your standerd is :{0}", std);
            Console.WriteLine("your total marks are :{0}", calcuRs);
            Console.WriteLine("your precentage is :{0}", per);
            
            // if else if for Gread
            if (per >= 80)
            {   
                Console.WriteLine("Gread is: A+");
            } 
            else if (per >= 70)
            {
                Console.WriteLine("Gread is: A");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Gread is: B");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Gread is: C");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Gread is: D");
            }
            else if (per >= 33)
            {
                Console.WriteLine("Gread is: E");
            }
            else 
            {
                Console.WriteLine("Gread : F =(Fail)"); 
            }

            //if else if for Remarks
            if (per >= 80)
            {
                Console.WriteLine("Remarks: Excellent...!!");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Remarks: Very good...!!");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Remarks: Good...!!");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Remarks: Fair...!!");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Remarks: Poor...!!");
            }
            else if (per >= 33)
            {
                Console.WriteLine("Remarks: Needs lot of Improvement...!!");
            }
            else
            {
                Console.WriteLine("Remarks: Bring your parents tomorrow...!!");
            }

            //Student fail in how many subjecs
            int supply = 0;

            if (mhr < 33)
            {
                supply++;
            }
            if (eng < 33)
            {
                supply++;
            }
            if (phy < 33)
            {
                supply++;
            }
            if (chem < 33)
            {
                supply++;
            }
            if (math < 33)  
            {
                supply++;
            }

            Console.WriteLine("you are fail in : {0} subjects", supply);
            Console.ReadLine();

        }
    }
}