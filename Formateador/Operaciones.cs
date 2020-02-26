using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Formateador
{
    class Operaciones
    {

        //Reemplaza la razon social en el texto
        public static void RazonSocial(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for(int i = 0; i<20; i++)
            {
                ObjDoc.Bookmarks["razonsocial" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Domicilio()
        {

        }
    }
}
