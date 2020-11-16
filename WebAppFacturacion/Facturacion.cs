using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFacturacion
{
    public class Facturacion
    {
        String nombre;
        String metodoDePago;
        Double total;

        public void setNombre(String nombre) {

            this.nombre = nombre;
        }

        public String getNombre() {
            return nombre;
        }

        public void setMetodoDePago(String metodoPago) {

            this.metodoDePago = metodoPago;
        }

        public String getMetdoDepago() { return metodoDePago; }

        public void setTotal(Double total) { this.total = total; }

        public Double getTotal() { return total; }

    }
}
