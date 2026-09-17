using System;
using System.Collections.Generic;
using System.Text;

namespace KavefozogepApp
{
    public class Kavefozogep
    {
        private int vizKeszletMl;

        public void  VizTolt(int ml)
        {
            if (ml < 0)
            {
                ml += 0;
                Console.WriteLine("hiba");
            }
            else
            {
                vizKeszletMl += ml;
            }
        }
        public  void KaveFozes()
        {
            if (vizKeszletMl>=150)
            {
                vizKeszletMl -= 150;
            }
            else
            {
                Console.WriteLine("Nem áll rendelkezésre elég víz");
            }
        }

    }
}

