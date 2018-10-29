using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W3_2018_2C_TP.Models.View
{
    public class PedidoVal
    {
        [Required(ErrorMessage = "El nombre del negocio es obligatorio")]
        [StringLength(50, ErrorMessage = "Ingrese un nombre mas corto")]
        public string NombreNegocio { get; set; }
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio por unidad es obligatorio")]
        public string PrecioUnidad { get; set; }
        [Required(ErrorMessage = "El precio por docena es obligatorio")]
        public string PrecioDocena { get; set; }
        [Required(ErrorMessage = "El gusto de las empanadas es obligatorio")]
        public string GustoEmpanada { get; set; }
        [Required(ErrorMessage = "La invitacion es obligatoria")]
        public string InvitacionPedido { get; set; }
    }
}
