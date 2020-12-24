using System;
using System.Collections.Generic;

namespace SingletonHomework.Models
{
    public class Singleton
    {
        //= new Random().Next(-1000, 1000)
        public static Random rand = new Random();
        public List<int> LST = new List<int>(100000);

        
    }
}