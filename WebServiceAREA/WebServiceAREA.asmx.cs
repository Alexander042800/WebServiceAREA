using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceAREA
{
    /// <summary>
    /// Descripción breve de WebServiceAREA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAREA : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string AreaDelCuadrado(double lado)
        {
            double area = lado * lado; 
            return  area.ToString(); 
        }

        [WebMethod]
        public string AreaDelTriangulo(double baseT, double altura)
        {
            double area = (baseT * altura) / 2.0; 
            return area.ToString(); 
        }

        [WebMethod]
        public string AreaDelCirculo(double radius)
        {
            double area = Math.PI * radius * radius; 
            return area.ToString(); 
        }
    }
}
