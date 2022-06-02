using System;
using System.Collections.Generic;
using Bai2Alogithms.Model;

namespace Bai2Alogithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menus = new List<Menu>();
            Menu m1 = new Menu(1, "The thao", 0);
            menus.Add(m1);
            Menu m2 = new Menu(2, "Xa hoi", 0);
            menus.Add(m2);
            Menu m3 = new Menu(3, "The thao trong nuoc", 1);
            menus.Add(m3);
            Menu m4 = new Menu(4, "Giao thong", 2);
            menus.Add(m4);
            Menu m5 = new Menu(5, "Moi truong", 2);
            menus.Add(m5);
            Menu m6 = new Menu(6, "the thao quoc the", 1);
            menus.Add(m6);
            Menu m7 = new Menu(7, "Moi truong do thi", 5);
            menus.Add(m7);
            Menu m8 = new Menu(8, "Un tac giao thong", 4);
            menus.Add(m8);
            Console.WriteLine(calMonthByRecursion(100, 20));
        }
        //Bài 21: "Hãy viết function calSalary(salary, n) , trả về lương của năm thứ n. Biết rằng cứ mỗi năm lương sẽ tăng bằng 10% năm liền trước.Viết bằng 2 cách, đệ qui và không dùng đệ qui"
        
        static float calSalaryByRecursion(float salary, int n) //Đệ qui
        {
            if (n == 1)
            {
                return salary;
            }
            else
            {
                return calSalaryByRecursion(salary, n - 1)*110/100;
            }
        }
        static float calSalary(float salary, int n) //Không đệ qui
        {
            float prevSalary= salary;
            float resultSalary= salary;
            for(int i= 2; i<=n; i++)
            {
                resultSalary = prevSalary * 110 / 100;
                prevSalary = resultSalary;
            }
            return resultSalary;
        }

        //Bài 22: "Hãy viết function calMonth(money, rate) , trả về số tháng tiền cần gửi tiết kệm để tiền gốc + lãi tăng gấp đôi so với tiền gốc.Money là số tiền gốc, rate là % lãi suất mỗi tháng. ví dụ calMount(1000, 5). Viết bằng 2 cách, đệ qui và không dùng đệ qui"
        static float a;
        static int calMonthByRecursion(float money, float rate)
        {
            // 0: 100       0
            // 1: 100       20
            // 2: 100       44
            // 3: 100       72.8
            // 4: 100       107.8
            //
            // (100, 107.8)= (100, 72.8)+1;
            // (100, 72.8)= (100, 44)+ 1;
            // (100, 44) = (100, 20) + 1;
            // pm= p*(100+r)
            //p=pm/(100+r)
            //1: 100 107.8
            //2: 100 72.8
            //3: 100 44
            //4: 100 20
            // 20, 100: (120)/100+ 12
            if (money*(100+rate)/100 >= 2*money)
            {
                return 1;
            }
            else
            {
                return calMonthByRecursion(money, rate)+1;
            }
           
            
        }

        static int calMonth(float money, float rate)
        {
            float newMoney= money;
            float prevMoney= money;
            int result = 0;
            while (newMoney <= 2 * money)
            {
                newMoney = prevMoney * (100 + rate)/100;
                prevMoney = newMoney;
                result++;
            }
            return result;
        }

        //Bài 23: "Hãy viết function printMenu(menus), đầu vào là mảng menu, in ra menu phân cấp cha con, mỗi menu con thụt vào hai '--' so với menu cha của nó."

        static void printMenu(List<Menu> menus)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                if (menus[i].Parent_id == 0)
                {
                    Console.WriteLine(menus[i].Title);
                    for (int j = 0; j < menus.Count; j++)
                    {
                        if (menus[i].Id == menus[j].Parent_id)
                        {
                            Console.WriteLine("--"+menus[j].Title);
                            for (int k = 0; k < menus.Count; k++)
                            {
                                if (menus[j].Id == menus[k].Parent_id)
                                {
                                    Console.WriteLine("----" + menus[k].Title);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
