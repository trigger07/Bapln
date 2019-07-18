using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;
namespace TS.BAPLN.DataAccess
{
    public class BecaEstudianteDAO
    {
        public void CrearBecaEstudiante(BecaEstudianteDTO beDto)
        {
            using(BAPLNEntities db = new BAPLNEntities())
            {
                LIS_BecaEstudiante be = new LIS_BecaEstudiante
                {
                    FechaInicio = beDto.FechaInicio ?? DateTime.MinValue,
                    FechaFinal = beDto.FechaFinal ?? DateTime.MinValue,
                    Id_Estudiante = beDto.Id_Estudiante,
                    Id_Beca = beDto.Id_Beca,
                    Activa = true,
                    MontoTotal = beDto.MontoTotal,
                    MontoCuota = beDto.MontoCuota,
                    CantidadCuotas = beDto.CantidadCuotas
                };
            }
        }
    }
}
