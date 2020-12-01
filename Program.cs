using System;
using LINQ.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax clss = new Syntax(); 
            //result = result.Select(x => x.ToLower());


            /*  

                        for (int y = 15; y <= 25; y++)
                        {
                           

                            for (int m = 1; m <= 12; m++)
                            {

                                string startdate = (2000 + y) + "-" + m + "-21";
                                string endate = string.Empty;

                                if (m == 12)
                                {
                                    endate = (2000 + (y + 1)) + "-" + (1) + "-20";
                                }
                                else
                                {
                                    endate = (2000 + y) + "-" + (m + 1) + "-20";
                                }

                                Console.WriteLine(startdate + "---" + endate + "---" + seq+ "---" + FiscalMonthOrder+ "---" + (2000 + y)+ "---" + (2000 + y)+""+m);
                                if (m == 12) { Console.WriteLine("######################"); }
                                seq  ++;
                                FiscalMonthOrder ++;
                            }


                        } */
            string FiscalYearInitialDate = string.Empty;
            int[] MonthOfFy = { 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] MonthYear = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
            int seq = 1;

            for (int y = 15; y <= 25; y++)
            {
                int FiscalMonthOrder = 1;


                foreach (int m in MonthOfFy)
                {

                    string startdate = string.Empty;
                    string endate = string.Empty;
                    string yearnumber = string.Empty;

                    if (m <= 9)
                    {
                        startdate = (2000 + (y + 1)) + "-" + m + "-21";
                        yearnumber = (2000 + (y + 1)).ToString();
                    }
                    else
                    {
                        startdate = (2000 + y) + "-" + m + "-21";
                        yearnumber = (2000 + y).ToString();
                    }

                    if (m == 12)
                    {
                        endate = (2000 + (y + 1)) + "-" + (1) + "-20";
                    }
                    else
                    {
                        endate = (2000 + y) + "-" + (m + 1) + "-20";

                        if (m <= 9)
                        {
                            endate = (2000 + (y + 1)) + "-" + (m + 1) + "-20";
                        }

                    }

                    string monthDescription = startdate + " à " + endate;
                    int fiscalyear = (2000 + (y + 1));
                    int MonthNumber = m;
                    string DHIS2MonthFormat = string.Empty;


                    if (m > 9)
                    {
                        DHIS2MonthFormat = ((2000 - 1) + (y + 1)) + "" + m;
                    }
                    else
                    {
                        DHIS2MonthFormat = (2000 + (y + 1)) + "" + m;
                    }

                    if (FiscalMonthOrder == 1)
                    {
                        FiscalYearInitialDate = startdate;
                    }
                    // Console.WriteLine(startdate + "," + endate + "," + seq + "," + FiscalMonthOrder + "---" + (2000 + (y + 1)) + "---" + (2000 + (y + 1)) + "" + m);
                    //+ "," +
                    Console.WriteLine(startdate + "," +
                                      endate + "," +
                                      seq + "," +
                                      monthDescription + "," +
                                      FiscalMonthOrder + "," +
                                      fiscalyear + "," +
                                      MonthNumber + "," +
                                      FiscalYearInitialDate + "," +
                                      DHIS2MonthFormat + "," +
                                      MonthYear[m - 1] + " - " + yearnumber + "," +
                                      yearnumber 
                                      );
                    if (m == 9) { Console.WriteLine("######################"); }


                    seq++;
                    FiscalMonthOrder++;

                    /*  INSERT INTO [Month] (StartDate,EndDate,Seq,monthDescription,fiscalmonthorder,fiscalyear,MonthNumber,FiscalYearInitialDate,DHIS2MonthFormat,MonthYear,yearnumber,state,syncstate,CreatedDate)
                     VALUES              (getdate(),getdate(),1, 'descrptionmon',1,2020,10,getdate(),20201, 'Out - 2019',2021,0,-1,getdate())
  */
                }
            }
            /*   for (int m = 1; m <= 12; m++)
              {

                  string startdate = (2000 + y) + "-" + m + "-21";


                  Console.WriteLine(startdate);


              } */



            //EscalarLastSingleFirst clss = new EscalarLastSingleFirst(); 

            //AnyAllAndAVG clss = new AnyAllAndAVG();
            /* 
            #region using Object class

            List<ObjectClass> obj = new List<ObjectClass>();


            // creating 10 objts
            foreach (int values in Enumerable.Range(0, 11)) // 0-10
                obj.Add(new ObjectClass() { Number = values, Text = "Elemnt " + values });

            //Covertsion to dicionary
            var Myobj = obj.ToDictionary(key => key.Number, value => value.Text); 
           // Console.WriteLine(string.Join("\n", Myobj.Values ));
            foreach(var i in Myobj)
            System.Console.WriteLine("Dicionary: "+ i.Key + " - "+ i.Value);
            endregion */

            // string.Join => join the list 
            //Console.WriteLine(string.Join(", ", obj.Where(x => x.Number < 5).Select(x => x.Text)));

        }
    }
}
