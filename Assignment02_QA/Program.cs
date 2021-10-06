using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            // make menu
            List<Option> options = new List<Option>();
            options.Add(new Option() { optionId = 1, optionNm = "1.Get Rectangle Length" });
            options.Add(new Option() { optionId = 2, optionNm = "2.Change Rectangle Length" });
            options.Add(new Option() { optionId = 3, optionNm = "3.Get Rectangle Width" });
            options.Add(new Option() { optionId = 4, optionNm = "4.Change Rectangle Width" });
            options.Add(new Option() { optionId = 5, optionNm = "5.Get Rectangle Height" });
            options.Add(new Option() { optionId = 6, optionNm = "6.Change Rectangle Height" });
            options.Add(new Option() { optionId = 7, optionNm = "7.Get Rectangle Volume" });
            options.Add(new Option() { optionId = 8, optionNm = "8.Exit" });

            while (true)
            {


                // optout Option list
                for (int i = 0; i < options.Count; i++)
                {
                    Option p = options[i];
                    Console.WriteLine(p.optionNm);
                }

                // Select Menu
                int inputMenuId;
                string _inputMenuId;
                while (true)
                {
                    do
                    {
                        Console.Write("**Please, input Menu number : ");
                        _inputMenuId = Console.ReadLine();
                    } while (!int.TryParse(_inputMenuId, out inputMenuId));

                    if (inputMenuId >= 1 && inputMenuId <= 8)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("!!! Worng Input Menu ID. ");
                        Console.WriteLine("");
                    }
                }

                //1.Get Rectangle Length
                if (inputMenuId == 1)
                {
                    Console.WriteLine("**Rectangle Length : " + r.GetLength());
                }

                //2.Change Rectangle Length
                if (inputMenuId == 2)
                {
                    int inputLength;
                    string _inputLength;
                    while (true)
                    {
                        do
                        {
                            Console.Write("**Please, input the Length : ");
                            _inputLength = Console.ReadLine();
                        } while (!int.TryParse(_inputLength, out inputLength));
                        if (inputLength >= 1)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("**Changing Rectangle Length to " + r.SetLength(inputLength));
                }

                //3.Get Rectangle Width
                if (inputMenuId == 3)
                {
                    Console.WriteLine("**Rectangle Width : " + r.GetWidth());
                }

                //4.Change Rectangle Width
                if (inputMenuId == 4)
                {

                    int inputWidth;
                    string _inputWidth;
                    while (true)
                    {
                        do
                        {
                            Console.Write("**Please, input the Width : ");
                            _inputWidth = Console.ReadLine();
                        } while (!int.TryParse(_inputWidth, out inputWidth));
                        if (inputWidth >= 1)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("**Changing Rectangle Width to " + r.SetWidth(inputWidth));
                }

                //5.Get Rectangle Height
                if (inputMenuId == 5)
                {
                    Console.WriteLine("**Rectangle Height : " + r.GetWidth());
                }

                //6.Change Rectangle Height
                if (inputMenuId == 6)
                {
                    int inputHeight;
                    string _inputHeight;
                    while (true)
                    {
                        do
                        {
                            Console.Write("**Please, input the Height : ");
                            _inputHeight = Console.ReadLine();
                        } while (!int.TryParse(_inputHeight, out inputHeight));
                        if (inputHeight >= 1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("**Changing Rectangle Height to " + r.SetHeight(inputHeight));

                }

                //7.Get Rectangle Volume
                if (inputMenuId == 7)
                {
                    Console.WriteLine("Volume of rectangle is " + r.GetVolume());
                }

                //8.Exit
                if (inputMenuId == 8)
                {
                    break;
                }

                Console.WriteLine("");
            }


        }
    }
}
