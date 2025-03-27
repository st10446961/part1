using System.IO;
using System.Media;
using System;

namespace part1
{
    public class voice_greeting
    {
        //constructor
        public voice_greeting()
        {
            //getting full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;


            //replace the bin\debug folder in the full_location
            string new_path = full_location.Replace("bin\\Debug\\", "");

            string full_path = Path.Combine(new_path, "greeting.wav");

            PlaySync(full_path);

        }//End of constructor

        //method to play the sound
        private void PlaySync (string full_path)
        {
            //try and catch
            try
            {
                using (SoundPlayer play = new SoundPlayer(full_path))
                {
                    //playin the sound
                    play.PlaySync();
                }//end of using
            }//end of try
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }//end of catch
        }//end of method

    }//End of class
}//End of namespace

        