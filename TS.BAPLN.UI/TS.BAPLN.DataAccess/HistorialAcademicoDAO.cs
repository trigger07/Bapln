using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class HistorialAcademicoDAO
    {
        public List<vwHistorialAcademicoDTO> ObtenerHistorialAcademico(int idEstudiante, int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {

                var lResultados = entities.vwHistorialAcademicoes.Where(s => s.IdEstudiante == idEstudiante).Where(q => q.idInstitucion == idInstitucion).Select(x => new vwHistorialAcademicoDTO
                {
                    Id = x.Consecutivo,
                    Id_Estudiante = x.IdEstudiante,
                    Carne = x.CarnetEstudiante,
                    Nombre_Estudiante = x.NombreEstudiante,
                    Id_Institucion = x.idInstitucion,
                    DesInstitucion = x.DesInstitucion,
                    Id_CursoLectivo = x.IdCursoLectivo,
                    DesCursoLectivo = x.CursoLectivo,
                    Id_Nivel = x.IdNivel,
                    DesNivel = x.DesNivel,
                    Id_Periodo = x.IdPeriodo,
                    DesPeriodo = x.DesPeriodo,
                    Id_Materia = x.Materia,
                    Des_Materia = x.DesMateria,
                    Calificacion = x.Calificacion
                }).ToList();




                return lResultados;
            }
        }

        public void CrearHistorialAcademico(HistorialAcademicoDTO registro, bool nuevo)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {

                if (nuevo)
                {

                    HIS_HistorialAcademico newRow = new HIS_HistorialAcademico();
                    newRow.Id_CursoLectivo = registro.Id_Curso;
                    newRow.Id_Estudiante = registro.Id_Estudiante;
                    newRow.Id_Institucion = registro.Id_Institucion;
                    newRow.Id_Materia = registro.Id_Materia;
                    newRow.Id_Periodo = registro.Id_Periodo;
                    newRow.Id_Nivel = registro.Id_Nivel;
                    newRow.Nota = registro.Nota;
                    entities.HIS_HistorialAcademico.Add(newRow);
                    entities.SaveChanges();
                    entities.SaveChanges();
                }
                else
                {

                    HIS_HistorialAcademico editRow = entities.HIS_HistorialAcademico.FirstOrDefault(v => v.Id == registro.Id);
                    if (editRow != null)
                    {
                        editRow.Nota = registro.Nota;
                        entities.SaveChanges();
                    }
                }
            }
        }

        public void BorrarHistorialAcademico(HistorialAcademicoDTO registro)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {

                HIS_HistorialAcademico delRow = entities.HIS_HistorialAcademico.FirstOrDefault(v => v.Id == registro.Id);
                if (delRow != null)
                {
                    entities.HIS_HistorialAcademico.Remove(delRow);
                    entities.SaveChanges();
                }
            }
        }
    }
}

