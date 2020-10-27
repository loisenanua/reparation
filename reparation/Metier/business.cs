using ServiceStack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparation.Metier
{
    public class business
    {
        public static ObservableCollection<reparationPhone> reparations { get; }

        static business()
        {
            reparations = new ObservableCollection<reparationPhone>();
            reparationPhone loise = new reparationPhone("NANUA", "Loïse", "Samsung", 87202020, "fuhqs,klm@", new DateTime(1955, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone maryse = new reparationPhone("bb", "Maryse", "Alcatel", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone blondine = new reparationPhone("cc", "Blondine", "Nokia", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone marc = new reparationPhone("dd", "Marc", "Samsung", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone fred = new reparationPhone("ee", "Fred", "xpedia", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone hiva = new reparationPhone("ff", "Hiva", "banane", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone martin = new reparationPhone("gg", "Martin", "kira", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone nathan = new reparationPhone("hh", "Nathan", "haoe", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone meryl = new reparationPhone("ii", "Meryl", "samsung", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);
            reparationPhone cathy = new reparationPhone("jj", "Cathy", "Nokia", 87202020, "sdgcqyutsjfgqsjh", new DateTime(1982, 07, 12), "xxxxxxxx", "hs", 3000);

            reparations.Add(loise);
            reparations.Add(maryse);
            reparations.Add(blondine);
            reparations.Add(marc);
            reparations.Add(fred);
            reparations.Add(hiva);
            reparations.Add(martin);
            reparations.Add(nathan);
            reparations.Add(meryl);
            reparations.Add(cathy);
            string csv = reparations.ToCsv();
        }

        public static void Enregistrer(string cheminFichier)
        {
            string csv = reparations.ToCsv();
            //enregistrer dans le fichier 
            // if(saveFileDialog.ShowDialog() == true)
            // {
            //     string[] content = new string[this.ListBoxHist.Items.Count];
            //
            //         for(int index = 0; index < this.ListBoxHist.Items.Count; index++)
            //         {
            //             Console.WriteLine(content[index]);
            //             content[index] = this.ListBoxHist.Items[index].ToString();
            //         }    
            // }
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
         

           
        }
    }
}
