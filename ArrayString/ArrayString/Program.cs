using System;
using System.Text;

namespace ArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home work
            //Size size1 = new Size();
            //Console.Write("Enter the width of box: ");
            //size1.width = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Enter the length of box: ");
            //size1.length = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Enter the height of box: ");
            //size1.height = Convert.ToDecimal(Console.ReadLine());

            ////{
            ////    width =Convert.ToDecimal(Console.ReadLine()),
            ////    length = Convert.ToDecimal(Console.ReadLine()),
            ////    height = Convert.ToDecimal(Console.ReadLine())
            ////};

            //Console.WriteLine(volumeOfBox(size1));
            #endregion

            byte[] ages =
                {
                    15,29,26,75,41
                };


            //Console.WriteLine(Array.Exists(ages, age => age == 15));
            //Console.WriteLine(Array.Find(ages, age => age > 13));
            //byte[] newAges = Array.FindAll(ages, age => age > 26);
            //for (int i = 0; i < newAges.Length; i++)
            //{
            //    Console.WriteLine(newAges[i]);
            //}
            //Console.WriteLine(Array.FindIndex(ages, age => age > 150));
            //Array.ForEach(ages, elem => Console.WriteLine(elem));
            //Array.Resize(ref ages, 6);

            //ages[5] = 24;
            //Console.WriteLine(ages[5]);

            //bool exit = false;
            //while (exit == false)
            //{
            //    Console.WriteLine("Endet new element: ");
            //    byte newElem = Convert.ToByte(Console.ReadLine());
            //    Array.Resize(ref ages, ages.Length+1);
            //    ages[ages.Length-1] = newElem;

            //    for (int i = 0; i < ages.Length; i++)
            //    {
            //        Console.Write(ages[i]+", ");
            //    }
            //    Console.WriteLine();
            //}
            //Array.Sort(ages);
            //Array.Reverse(ages);

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}

            //Console.WriteLine(Array.TrueForAll(ages, age => age > 13));


            //Console.WriteLine(false);

            //ages[1] = 34;

            //int[,] address = new int[2, 3] {
            //    {15,29,34 },
            //    {32,4,71 }
            //};

            //Console.WriteLine(address.Rank);

            //address[1, 0] = 41;

            //for (int i = 0; i < address.GetLength(0); i++)
            //{
            //    for (int j = 0; j < address.GetLength(1); j++)
            //    {
            //        Console.WriteLine(address[i, j]);
            //    }
            //}

            //int[,,] threeDimentional = new int[2, 3, 2] {
            //    {
            //        {14,3 },
            //        { 32,4},
            //        { 4,7}
            //    },
            //    {
            //        {36,52 },
            //        {6,74 },
            //        {5,7 }
            //    }
            //};

            //int[][] address = new int[2][]
            //{
            //    new int[]{15,47,13,24},
            //    new int[]{ 4,72,42,1,9,13,5}
            //};

            //address[0][1] = 23;

            //for (int i = 0; i < address.Length; i++)
            //{
            //    for (int j = 0; j < address[i].Length; j++)
            //    {
            //        Console.WriteLine(address[i][j]);
            //    }
            //    Console.WriteLine("**********************************");
            //}


            //String
            //string text = "     Lorem ipsum     bla bla     ";
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text.Contains("bla "));
            //Console.WriteLine(text.EndsWith("bla"));
            //Console.WriteLine(text.StartsWith("bla"));
            //Console.WriteLine(text.Equals("Lorem"));
            //Console.WriteLine(text.IndexOf('m', 5));
            //Console.WriteLine(text.LastIndexOf('m',0));
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.Replace(" ", ""));
            //string[] textArr = text.Split(" ");
            ////foreach (var item in textArr)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(String.Join(" ", textArr));
            //if (text.Length>100)
            //{
            //    Console.WriteLine(text.Substring(0, 100)+"...");
            //}
            //else
            //{
            //    Console.WriteLine(text);
            //}

            //Console.WriteLine(text);
            //Console.WriteLine(text.TrimEnd());

            //int a = 15;

            //a = 20;

            //text = "testlkdfn";

            StringBuilder text = new StringBuilder();
            text.Append("Lorem ipsum");
            text.Append("Qazax ipsum");
            Console.WriteLine(text);
        }

        static decimal volumeOfBox(Size size)
        {
            return size.width * size.length * size.height;
        }
    }

    class Size
    {
        public decimal width;
        public decimal length;
        public decimal height;
    }
}
