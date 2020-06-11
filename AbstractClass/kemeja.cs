using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Abtraction.abtractionClass
{
    public class kemeja : baju
    {
        public override void jenisBaju()
        {
            Console.WriteLine("Kemeja adalah salah pakaian atas yang menutupi bagian lengan, dada, bahu, berkerah dan menutupi tubuh sampai bagian perut.");
        }
    }
}