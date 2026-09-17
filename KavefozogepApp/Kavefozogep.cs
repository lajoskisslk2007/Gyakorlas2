using System;
using System.Collections.Generic;
using System.Text;

namespace KavefozogepApp
{
    public class Kavefozogep
    {
        private int vizKeszletMl;

        public static int Viztolt(int ml)
        {
            if(ml>0)
            {
                return ml;
            }
        }
        public  int KaveFozes()
        {
            if (vizKeszletMl==150)
            {
                return vizKeszletMl - 150;
            }
        }

    }
}
