using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkness.Tools
{
    public class NameGenerator
    {
        public string GenerateName(int length)
        {
            char[] selbstlaute = { 'a', 'e', 'i', 'o', 'u' };
            char[] umlaute = "bcdfghjklmnpqrstvwxyz".ToCharArray();

            string name = "";

            Random selbstlautOderUmlaut = new Random();
            int decider = selbstlautOderUmlaut.Next(1, 3);
            for (int counter = 0; counter < length; counter++)
            {
                int umlautedecider = selbstlautOderUmlaut.Next(0, umlaute.Length);
                int selbstlautedecider = selbstlautOderUmlaut.Next(0, selbstlaute.Length);

             
                    if (decider == 1)
                    {
                        char umlautbuchstabe = umlaute[umlautedecider];
                        name += umlautbuchstabe;
                        decider = 2;
                    }
                    else
                    {
                        char selbstlautbuchstabe = selbstlaute[selbstlautedecider];
                        name += selbstlautbuchstabe;
                        decider = 1;
                    }
            }
            return name;
        }


        public string GenerateNameRandomLength(int from, int to)
        {
            Random selbstlautOderUmlaut = new Random();
            int length = selbstlautOderUmlaut.Next(from, to +1);

            char[] selbstlaute = { 'a', 'e', 'i', 'o', 'u' };
            char[] umlaute = "bcdfghjklmnpqrstvwxyz".ToCharArray();

            string name = "";

            int decider = selbstlautOderUmlaut.Next(1, 3);
            for (int counter = 0; counter < length; counter++)
            {
                int umlautedecider = selbstlautOderUmlaut.Next(0, umlaute.Length);
                int selbstlautedecider = selbstlautOderUmlaut.Next(0, selbstlaute.Length);


                if (decider == 1)
                {
                    char umlautbuchstabe = umlaute[umlautedecider];
                    name += umlautbuchstabe;
                    decider = 2;
                }
                else
                {
                    char selbstlautbuchstabe = selbstlaute[selbstlautedecider];
                    name += selbstlautbuchstabe;
                    decider = 1;
                }
            }
            return name;
        }
    }

}

