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

        public static void RazonComercial(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for(int i = 0; i<2; i++)
            {
                ObjDoc.Bookmarks["razoncomercial" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void RazonSocial(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            //Reemplaza todos los marcadores con un ciclo for
            for(int i = 0; i<14; i++)
            {
                ObjDoc.Bookmarks["razonsocial" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
            
        }

        public static void ActividadEmpresa(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["actividad" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Domicilio(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 5; i++)
            {
                ObjDoc.Bookmarks["domicilio" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Telefono(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["telefono" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Representante(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["representante" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Tabla(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                object marcador = "tabla" + i;
                Word.Range rango = ObjDoc.Bookmarks.get_Item(ref marcador).Range;
                ObjDoc.Tables.Add(rango, 3, 3);

            }

            ObjDoc.Tables[2].Borders.Enable = 1;
            //Word.Cell cell = ObjDoc.Tables[1].Cell(1,1);
            //cell.Range.Text = "Nombre";

        }
    }
}
