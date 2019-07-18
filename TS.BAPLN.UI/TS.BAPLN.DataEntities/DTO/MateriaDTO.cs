using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class MateriaDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Descripcion:")]
        public string Descripcion { get; set; }

        [Display(Name = "IdInstitucion:")]
        public int? IdInstitucion { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }
    }
}