using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public static class Stocare
    {
        public static IStocareDate AdminStocare()
        {
            return new AdministrareMedicamente("medicamente.txt");
        }
    }
}
