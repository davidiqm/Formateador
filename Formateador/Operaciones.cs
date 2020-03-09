using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Formateador
{
    class Operaciones
    {
        public static void Reglamento(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            if ( texto == "CALAKMUL")
            {
                string municipio = "Calakmul";
                texto = "Reglamento de Protección Civil del Municipio de Calakmul";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            } 
            else if (texto == "CALKINÍ")
            {
                string municipio = "Calkiní";
                texto = "Reglamento de Protección Civil para el Municipio de Calkiní, Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if (texto == "CAMPECHE")
            {
                string municipio = "Campeche";
                texto = "Reglamento de Protección Civil, Prevención y Atención de Desastres " +
                    "para el Municipio de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if(texto == "CANDELARIA")
            {
                string municipio = "Candelaria";
                texto = "Reglamento de la Ley de Protección Civil, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            } 
            else if (texto == "CARMEN")
            {
                string municipio = "Carmen";
                texto = "Reglamento Municipal de Protección Civil de Carmen, Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if (texto == "CHAMPOTÓN")
            {
                string municipio = "Champotón";
                texto = "Reglamento Municipal de Protección Civil del Municipio de Campotón," +
                    " Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if (texto == "ESCÁRCEGA")
            {
                string municipio = "Escárcega";
                texto = "Reglamento de Protección Civil de Escárcega, Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if (texto == "HECELCHAKÁN")
            {
                string municipio = "Hecelchakán";
                texto = "Reglamento de la Ley de Protección Civil, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if (texto == "HOPELCHÉN")
            {
                string municipio = "Hopelchén";
                texto = "Reglamento de la Ley de Protección Civil, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
            else if (texto == "PALIZADA")
            {
                string municipio = "Palizada";
                texto = "Reglamento de la Ley de Protección Civil, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            } 
            else if (texto == "TENABO")
            {
                string municipio = "Tenabo";
                texto = "Reglamento de la Ley de Protección Civil, Prevención y Atención de " +
                    "Desastres del Estado de Campeche";
                ReglamentoReemplazo(ObjWord, ObjDoc, ObjPlanes, texto);
                Municipio(ObjWord, ObjDoc, ObjPlanes, municipio);
            }
        }

        public static void ReglamentoReemplazo(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["reglamento" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }

            for (int i = 0; i < 2; i++)
            {
                ObjPlanes.Bookmarks["reglamento" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Ciudad(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 6; i++)
            {
                ObjDoc.Bookmarks["ciudad" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }

            for (int i = 0; i < 24; i++)
            {
                ObjPlanes.Bookmarks["ciudad" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void RazonComercial(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for(int i = 0; i<2; i++)
            {
                ObjDoc.Bookmarks["razoncomercial" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void RazonSocial(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            //Reemplaza todos los marcadores con un ciclo for
            for(int i = 0; i < 14; i++)
            {
                ObjDoc.Bookmarks["razonsocial" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }

            for (int i = 0; i < 35; i++)
            {
                ObjPlanes.Bookmarks["razonsocial" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }

        }

        public static void ActividadEmpresa(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 4; i++)
            {
                ObjDoc.Bookmarks["actividad" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Domicilio(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 6; i++)
            {
                ObjDoc.Bookmarks["domicilio" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }

            for (int i = 0; i < 26; i++)
            {
                ObjPlanes.Bookmarks["domicilio" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Telefono(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["telefono" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Representante(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["representante" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void RFC(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
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
        public static void PoblacionHabitualyTrabajadores(Word.Application ObjWord, Word.Document ObjDoc, string texto1, string texto2, string texto3)
        {
            ObjDoc.Bookmarks["habitual"].Select();
            ObjWord.Selection.TypeText(texto1);
            ObjDoc.Bookmarks["trabajadores"].Select();
            ObjWord.Selection.TypeText(texto2);
            ObjDoc.Bookmarks["discapacitado"].Select();
            ObjWord.Selection.TypeText(texto3);

        }

        public static void SuperficieTerreno(Word.Application ObjWord, Word.Document ObjDoc, string texto1, string texto2)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["superficie" + i].Select();
                ObjWord.Selection.TypeText(texto1);
            }

            ObjDoc.Bookmarks["superficieconstr"].Select();
            ObjWord.Selection.TypeText(texto2);
        }

        public static void ResponsableOperativo(Word.Application ObjWord, Word.Document ObjDoc, string texto)
        {
            for (int i = 0; i < 11; i++)
            {
                ObjDoc.Bookmarks["responsable" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }


        public static void Colindancias(Word.Application ObjWord, Word.Document ObjDoc, string texto1, string texto2, string texto3, string texto4)
        {
            ObjDoc.Bookmarks["colindancianorte"].Select();
            ObjWord.Selection.TypeText(texto1);
            ObjDoc.Bookmarks["colindanciasur"].Select();
            ObjWord.Selection.TypeText(texto2);
            ObjDoc.Bookmarks["colindanciaeste"].Select();
            ObjWord.Selection.TypeText(texto3);
            ObjDoc.Bookmarks["colindanciaoeste"].Select();
            ObjWord.Selection.TypeText(texto4);
        }



        public static void Municipio(Word.Application ObjWord, Word.Document ObjDoc, Word.Document ObjPlanes, string texto)
        {
            for (int i = 0; i < 2; i++)
            {
                ObjDoc.Bookmarks["municipio" + i].Select();
                ObjWord.Selection.TypeText(texto);

            }

            for (int i = 0; i < 3; i++)
            {
                ObjPlanes.Bookmarks["municipio" + i].Select();
                ObjWord.Selection.TypeText(texto);
            }
        }

        public static void Cuerpo(Word.Application ObjWord, Word.Document ObjDoc, DataGridView brigada)
        {
            string nombres = "";
            for (int i = 0; i < brigada.Rows.Count; i++)
            {
                nombres += brigada.Rows[i].Cells[0].Value.ToString() + ", ";
            }
            ObjDoc.Bookmarks["cuerpo0"].Select();
            ObjWord.Selection.TypeText(nombres);
        }

        public static void RecusosHumanos(Word.Application ObjWord, Word.Document ObjDoc, DataGridView recursosHumanos)
        {
            //Tabla 13
            Word.Table tbl13 = ObjDoc.Tables[13];

            for (int i = 0; i < recursosHumanos.Rows.Count; i++)
            {
                for (int j = 0; j < recursosHumanos.Columns.Count; j++)
                {
                    tbl13.Cell(i + 2, j + 1).Range.Text = recursosHumanos.Rows[i].Cells[j].Value.ToString();
                }

                if (i < recursosHumanos.Rows.Count - 1)
                {
                    tbl13.Rows.Add();
                }
            }
        }

        public static void Tablas(Word.Application ObjWord, Word.Document ObjDoc, DataGridView brigada)
        {

            //Tabla 2
            Word.Table tbl2 = ObjDoc.Tables[2];

            for (int i = 0; i < brigada.Rows.Count; i++)
            {
                for (int j = 0; j < brigada.Columns.Count-1; j++)
                {
                    tbl2.Cell(i + 2, j+1).Range.Text = brigada.Rows[i].Cells[j].Value.ToString();
                }

                if (i < brigada.Rows.Count - 1)
                {
                    tbl2.Rows.Add();
                }
            }

            //Tabla 3
            Word.Table tbl3 = ObjDoc.Tables[3];

            for (int i = 0; i < brigada.Rows.Count; i++)
            {
                tbl3.Cell(i + 2, 1).Range.Text = brigada.Rows[i].Cells[0].Value.ToString();
                
                if (i < brigada.Rows.Count - 1)
                {
                    tbl3.Rows.Add();
                }

            }

            //Tabla 4
            Word.Table tbl4 = ObjDoc.Tables[4];

            for (int i = 0; i < brigada.Rows.Count; i++)
            {
                for (int j = 0; j < brigada.Columns.Count-1; j++)
                {
                    tbl4.Cell(i + 2, j + 1).Range.Text = brigada.Rows[i].Cells[j].Value.ToString();
                }

                if (i < brigada.Rows.Count - 1)
                {
                    tbl4.Rows.Add();
                }
            }

            //Tabla 12
            Word.Table tbl12 = ObjDoc.Tables[12];

            for (int i = 0; i < brigada.Rows.Count; i++)
            {
                for (int j = 0; j < brigada.Columns.Count; j++)
                {
                    tbl12.Cell(i + 3, j + 1).Range.Text = brigada.Rows[i].Cells[j].Value.ToString();
                }

                if(i <brigada.Rows.Count - 1)
                {
                    tbl12.Rows.Add();
                }

            }

            //Tabla 56
            Word.Table tbl56 = ObjDoc.Tables[56];

            for (int i = 0; i < brigada.Rows.Count; i++)
            {
                tbl56.Cell(i + 2, 1).Range.Text = brigada.Rows[i].Cells[0].Value.ToString();

                if (i < brigada.Rows.Count - 1)
                {
                    tbl3.Rows.Add();
                }

            }

        }
        
        public static void LogoEncabezado(Word.Application ObjWord, Word.Document ObjDoc, string ruta)
        {
            object rango = "logo";
            Word.Range logoin = ObjDoc.Bookmarks.get_Item(ref rango).Range;
            ObjDoc.InlineShapes.New(logoin).Select();
            ObjWord.Selection.InlineShapes.AddPicture(ruta);

        }
    }

}
