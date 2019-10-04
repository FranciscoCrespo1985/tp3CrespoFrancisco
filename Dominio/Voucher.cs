using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Voucher
    {
        public long Id { get; set; }
        public long IdCliente { get; set; }
        public long IdProducto { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }


    }
}
