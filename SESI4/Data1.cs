using System;

    class Data1
    {
        public static void Main()
        {
            int[] aAngka = new int[5];
            string[] aNama = new string[] { "Joni", "Meri", "David" };
            object[] aObjek = { 20.33, "Lorem ipsum", DateTime.Now, true, 'D' };

            //aAngka insert and show data
            for (int i = 0; i < 5; i++)
            {
                aAngka[i] = i;
            }

            foreach (var item in aAngka)
            {
                Console.WriteLine(item);
            }

            //aNama show data
            foreach (var item in aNama)
            {
                Console.WriteLine(item);
            }

            //aObjek show data
            foreach (var item in aObjek)
            {
                Console.WriteLine(item);
            }
        }

    }