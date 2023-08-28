using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplication
{
    internal class Atm
    {
        static void Main(string[] args)
        {
            bool isLogin = false;
            long balance = default;
            long amount = default; ;
            string password = "abc123";
            int choice = default;
            bool isRun = true;

            while (isRun)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("====Chao Mung Quy Khach====");
                Console.WriteLine("---------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Dang nhap vao he thong.");
                Console.WriteLine("2. Kiem tra so du trong tai khoan.");
                Console.WriteLine("3. Nap tien vao tai khoan.");
                Console.WriteLine("4. Rut tien");
                Console.WriteLine("0. Thoat");
                Console.ForegroundColor= ConsoleColor.Black;
                Console.WriteLine("------------------------");
                Console.WriteLine("Xin moi quy khach chon.");
                Console.WriteLine("------------------------");

                Console.Write("Nhap Lua Chon Cua Quy Khach: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Cam on Quy Khach.");
                        isRun = false;
                        break;
                    case 1:
                        if (isLogin)
                        {
                            Console.WriteLine("Ban da dang nhap.");
                        }
                        else
                        {
                            Console.Write("Nhap mat khau cua ban: ");
                            var pass = Console.ReadLine();
                            if (pass.CompareTo(password) == 0)
                            {
                                isLogin = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dang nhap thanh cong");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Mat khau sai");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }
                        break;
                    case 2:
                        if (isLogin)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"So du trong tai khoan: {balance}");
                            Console.ForegroundColor= ConsoleColor.Black;
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de su dung.");
                            Console.Write("Nhap mat khau cua ban: ");
                            var pass = Console.ReadLine();
                            if (pass.CompareTo(password) == 0)
                            {
                                isLogin = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dang nhap thanh cong");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"So du trong tai khoan: {balance}");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Mat khau sai");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }
                        break;
                    case 3:
                        if (isLogin)
                        {
                            Console.Write("Nhap so tien nap vao: ");
                            amount = long.Parse(Console.ReadLine());
                            balance += amount;
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("Nap tien thanh cong: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"So du hien tai la: {balance}");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de su dung.");
                            Console.Write("Nhap mat khau cua ban: ");
                            var pass = Console.ReadLine();
                            if (pass.CompareTo(password) == 0)
                            {
                                isLogin = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dang nhap thanh cong");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Mat khau sai");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }
                        break;
                    case 4:
                        if (isLogin)
                        {
                            Console.Write("Nhap so tien ban muon rut (Boi so cua 50k): ");
                            amount = long.Parse(Console.ReadLine());
                            if (amount % 50000 == 0 && amount <= balance - 50000)
                            {
                                Console.WriteLine("Giao dich hop le.");
                                Console.WriteLine("Dang thuc hien giao dich.");
                                Console.WriteLine($"Ban da rut so tien: {amount}");
                                balance -= amount;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"So du hien tai cua ban la: {balance}");
                            }else if (amount > balance)
                            {
                                Console.WriteLine("So du cua ban khong du, Vui long nap them tien vao tai khoan.");
                            }else if (amount % 50000 != 0)
                            {
                                Console.WriteLine("Vui long nhap so tien muon rut la boi so cua 50k");
                            }else if (amount > balance - 50000)
                            {
                                Console.WriteLine("So du trong tai khoan khong du (<50k)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de su dung.");
                            Console.Write("Nhap mat khau cua ban: ");
                            var pass = Console.ReadLine();
                            if (pass.CompareTo(password) == 0)
                            {
                                isLogin = true;
                                Console.ForegroundColor=ConsoleColor.Green;
                                Console.WriteLine("Dang nhap thanh cong");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Mat Khau Sai.");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Vui long chon lai.");
                        break;
                }

            }
        }
    }
}
