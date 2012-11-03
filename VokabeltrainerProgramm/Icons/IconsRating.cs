using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhillipKuhrt.VoTra.Icons
{
    public static class IconsRating
    {
        public static Image GetImage(int rating)
        {
            switch (rating)
            {
                case 1:
                    return Properties.Resources._1_256x256_32;
                case 2:
                    return Properties.Resources._2_256x256_32;
                case 3:
                    return Properties.Resources._3_256x256_32;
                case 4:
                    return Properties.Resources._4_256x256_32;
                case 5:
                    return Properties.Resources._5_256x256_32;
                default:
                    return null;
            }
        }
    }
}
