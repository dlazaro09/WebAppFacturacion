using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFacturacion;
namespace WebAppFacturacion
{
    [TestClass]
    public class FacturacionTest
    {
        [TestMethod]
        public void testSetNombre(String nombre) { var comprobarNombre = new Facturacion(); String result = comprobarNombre.getNombre(); Assert.Fail(result, "Douglas"); }
        
    }
}
