using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca_de_Música
{
    public partial class About : Page
    {
        static List<Canciones> NotasTemp = new List<Canciones>();
        static List<Archivo_Álbumes> AlumnosTemp = new List<Archivo_Álbumes>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(AlumnosTemp);
            string archivo = Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Canciones can 

        }
    }
}