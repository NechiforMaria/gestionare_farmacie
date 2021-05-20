using gestionarea_farmaciei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    public interface IStocareDate
    {
        void AddMedicament(Medicament m);
        ArrayList GetMedicament();
        void ModificareMadicament(string LinieDeModificat, string LiniaModificata, ArrayList medicamente);
    }
}
