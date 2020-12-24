using System;
using System.Collections.Generic;

namespace SingletonHomework.Models
{
    public class Singleton
    {
        //= new Random().Next(-1000, 1000)
        public static Random rand = new Random();
        public List<int> LST = new List<int>(10000);

        private Singleton()
        {
            
        }

        public List<int> CreateOrGetLST()
        {
            if (LST == null)
            {
                for (int i = 0; i < LST.Count; i++)
                {
                    LST.Add(rand.Next(-1000, 1000));
                }
            }
            return LST;
        }
    }
}