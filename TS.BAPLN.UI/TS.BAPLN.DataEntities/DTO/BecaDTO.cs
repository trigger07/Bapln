using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class BecaDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Descripción:")]
        public string Descripcion { get; set; }

        [Display(Name = "Tipo de Beca:")]
        public int Id_TipoBeca { get; set; }

        [Display(Name = "Monto Total:")]
        public decimal MontoTotal { get; set; }

        [Display(Name = "Monto Cuota:")]
        public decimal MontoCuota { get; set; }

        [Display(Name = "Cantidad Cuotas:")]
        public short CantidadCuotas { get; set; }

        [Display(Name = "Activa:")]
        public bool Activa { get; set; }

        [Display(Name = "Tipo de Beca:")]
        public string TipoBeca { get; set; }

        [Display(Name = "Tipo de Beca:")]
        [Required(ErrorMessage = "El campo Tipo de Beca es requerido")]
        public List<TipoBecaDTO> tipoBecas;
    }
}
