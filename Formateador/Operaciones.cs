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
        public static void Reglamento(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            if ( texto == "CALAKMUL")
            {
                texto = "Reglamento de Protección Civil del Municipio de Calakmul";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            } 
            else if (texto == "CALKINÍ")
            {
                texto = "Reglamento de Protección Civil para el Municipio de Calkiní, Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if (texto == "CAMPECHE")
            {
                texto = "Reglamento de Protección Civil, Prevención y Atención de Desastres " +
                    "para el Municipio de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if(texto == "CANDELARIA")
            {
                texto = "Reglamento de la Ley de Protección Civi, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            } 
            else if (texto == "CARMEN")
            {
                texto = "Reglamento Municipal de Protección Civil de Carmén, Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if (texto == "CHAMPOTÓN")
            {
                texto = "Reglamento Municipal de Protección Civil del Municipio de Campotón," +
                    " Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if (texto == "ESCÁRCEGA")
            {
                texto = "Reglamento de Protección Civil de Escárcega, Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if (texto == "HECELCHAKÁN")
            {
                texto = "Reglamento de la Ley de Protección Civi, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if (texto == "HOPELCHÉN")
            {
                texto = "Reglamento de la Ley de Protección Civi, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
            else if (texto == "PALIZADA")
            {
                texto = "Reglamento de la Ley de Protección Civi, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            } 
            else if (texto == "TENABO")
            {
                texto = "Reglamento de la Ley de Protección Civi, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, texto);
            }
        }

        public static void ReglamentoReemplazo(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["reglamento" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

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

        public static void RFC(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["rfc" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void PoblacionFija(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["poblacionfija" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void PoblacionFlotante(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["poblacionflotante" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void SuperficieTerreno(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["superficie" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void ResponsableOperativo(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["responsableoperativo" + i].Select();
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
