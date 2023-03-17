using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src
{
    internal interface Iterator <T>
    {
        bool hasNext();
        T next();
    }
}
