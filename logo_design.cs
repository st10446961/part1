using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace part1
{
    internal class logo_design
    {


        //construtor
        public logo_design()
        {

            //get full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace the bin\Debug
            string new_location = full_location.Replace("bin\\Debug\\", "");

            //then combine the path
            string full_path = Path.Combine(new_location, "logo20.jpg");

            //then time to use ASCII Art 


            //creating the BitMap class
            Bitmap image = new Bitmap(full_path);

            //then set the size
            image = new Bitmap(image, new Size(140, 200));

            //outer and inner loop
            for (int height = 0; height < image.Height; height++)
            {
                //inner loop
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                    Console.Write(asciiChar);


                }//end of inner loop

            }//end of outer loop 






        }//end of constructor
    }//end of class
}//end of namespace