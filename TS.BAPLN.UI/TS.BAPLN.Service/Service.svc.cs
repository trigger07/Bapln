using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TS.BAPLN.BusinessLogic;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.Service
{
    public class Service : IService
    {
        #region Estudiantes
        public List<EstudianteDTO> ObtenerEsudiantes()
        {
            EstudianteDAL estudianteDal = new EstudianteDAL();
            return estudianteDal.ObtenerEstudiantes();
        }

        public EstudianteDTO ObtenerEsudiante(int id)
        {
            EstudianteDAL estudianteDal = new EstudianteDAL();
            return estudianteDal.ObtenerEsudiante(id);
        }

        public void CrearEstudiante(EstudianteDTO estudiante)
        {
            EstudianteDAL estudianteDal = new EstudianteDAL();
            estudianteDal.CrearEstudiante(estudiante);
        }

        public void InactivarEstudiante(int id)
        {
            EstudianteDAL estudianteDal = new EstudianteDAL();
            estudianteDal.InactivarEstudiante(id);
        }

        public void ActivarEstudiante(int id)
        {
            EstudianteDAL estudianteDal = new EstudianteDAL();
            estudianteDal.ActivarEstudiante(id);
        }

        public bool ActualizarEstudiante(EstudianteDTO estudiante)
        {
            EstudianteDAL estudianteDal = new EstudianteDAL();
            return estudianteDal.ActualizarEstudiante(estudiante);
        }
        #endregion

        #region Nacionalidad
        public List<NacionalidadDTO> ObtenerNacionalidades()
        {
            NacionalidadDAL nacionalidadDal = new NacionalidadDAL();
            return nacionalidadDal.ObtenerNacionalidades();
        }
        #endregion

        #region Becas
        public List<TipoBecaDTO> ObtenerTipoBecas()
        {
            TipoBecaDAL tb = new TipoBecaDAL();
            return tb.ObtenerTipoBeca();
        }

        public List<BecaDTO> ObtenerBecas()
        {
            BecaDAL b = new BecaDAL();
            return b.ObtenerBecas();
        }

        public void InactivarBeca(int id)
        {
            BecaDAL b = new BecaDAL();
            b.Inactivar(id);
        }

        public void ActivarBeca(int id)
        {
            BecaDAL b = new BecaDAL();
            b.Activar(id);
        }

        public void CrearBeca(BecaDTO beca)
        {
            BecaDAL be = new BecaDAL();
            be.CrearBeca(beca);
        }

        public bool ActualizarBeca(BecaDTO beca)
        {
            BecaDAL b = new BecaDAL();
            return b.ActualizarBeca(beca);
        }

        public BecaDTO ObtenerBecaPorId(int id)
        {
            BecaDAL b = new BecaDAL();
            return b.ObtenerBecaPorId(id);
        }
        #endregion

        #region BecaEstudiante
        public void CrearBecaEstudiante(BecaEstudianteDTO beDto)
        {
            BecaEstudianteDAL beD = new BecaEstudianteDAL();
            beD.CrearBecaEstudiante(beDto);
        }

        public List<BecaDTO> ObtenerBecasActivas()
        {
            BecaDAL b = new BecaDAL();
            return b.ObtenerBecasActivas();
        }

        public List<EstudianteDTO> ObtenerEstudiantesAutocomplete(string filtro)
        {
            EstudianteDAL e = new EstudianteDAL();
            return e.ObtenerEstudiantesAutocomplete(filtro);
        }

        #endregion

        #region Donador
        public List<DonadorDTO> ObtenerDonadores()
        {
            DonadorDAL donadorDal = new DonadorDAL();
            return donadorDal.ObtenerDonadores();
        }

        public DonadorDTO ObtenerDonador(int id)
        {
            DonadorDAL donadorDal = new DonadorDAL();
            return donadorDal.ObtenerDonador(id);
        }

        public void CrearDonador(DonadorDTO donador)
        {
            DonadorDAL donadorDal = new DonadorDAL();
            donadorDal.CrearDonador(donador);
        }

        public void InactivarDonador(int id)
        {
            DonadorDAL donadorDal = new DonadorDAL();
            donadorDal.InactivarDonador(id);
        }

        public void ActivarDonador(int id)
        {
            DonadorDAL donadorDal = new DonadorDAL();
            donadorDal.ActivarDonador(id);
        }

        public bool ActualizarDonador(DonadorDTO donador)
        {
            DonadorDAL donadorDal = new DonadorDAL();
            return donadorDal.ActualizarDonador(donador);
        }
        #endregion

        #region Periodicidad
        public List<PeriodicidadDTO> ObtenerPeriodicidades()
        {
            PeriodicidadDAL periodicidadDal = new PeriodicidadDAL();
            return periodicidadDal.Periodicidades();
        }
        #endregion
        
        #region CursoLectivo

        public List<CursoLectivoDTO> ObtenerCatalogoCursosLectivos()
        {
            CursoLectivoDAL n = new CursoLectivoDAL();
            return n.ObtenerCatalogoCursosLectivos();
        }
        public List<CursoLectivoDTO> ObtenerCursosLectivos(int idInstitucion)
        {
            CursoLectivoDAL n = new CursoLectivoDAL();
            return n.ObtenerCursoLectivos(idInstitucion);
        }

        public CursoLectivoDTO ObtenerCursoLectivo(int idCurso, int idInstitucion)
        {
            CursoLectivoDAL n = new CursoLectivoDAL();
            return n.ObtenerCursoLectivo(idCurso, idInstitucion);
        }

        public void ActualizarCursoLectivo(CursoLectivoDTO cursoLectivo)
        {
            CursoLectivoDAL n = new CursoLectivoDAL();
            n.ActualizarCursoLectivo(cursoLectivo);
        }

        public void EditarCursoLectivo(CursoLectivoDTO curso)
        {
            CursoLectivoDAL n = new CursoLectivoDAL();
            n.EditarCursoLectivo(curso);
        }

        public void InactivarCursoLectivo(int id)
        {
            CursoLectivoDAL cursoLectivoDal = new CursoLectivoDAL();
            cursoLectivoDal.InactivarCursoLectivo(id);
        }

        public void ActivarCursoLectivo(int id)
        {
            CursoLectivoDAL cursoLectivoDal = new CursoLectivoDAL();
            cursoLectivoDal.ActivarCursoLectivo(id);
        }

        public int BorrarCursoLectivo(int id)
        {
            CursoLectivoDAL cursoLectivoDal = new CursoLectivoDAL();
            return cursoLectivoDal.BorrarCursoLectivo(id);
        }
        #endregion

        #region Materia
        public List<MateriaDTO> ObtenerCatalogoMaterias()
        {
            MateriaDAL n = new MateriaDAL();
            return n.ObtenerCatalogoMaterias();
        }

        public List<MateriaDTO> ObtenerMaterias(int idInstitucion)
        {
            MateriaDAL n = new MateriaDAL();
            return n.ObtenerMaterias(idInstitucion);
        }

        public MateriaDTO ObtenerMateria(int idMateria, int idInstitucion)
        {
            MateriaDAL n = new MateriaDAL();
            return n.ObtenerMateria(idMateria, idInstitucion);
        }

        public void ActualizarMateria(MateriaDTO materia)
        {
            MateriaDAL n = new MateriaDAL();
            n.ActualizarMateria(materia);
        }

        public void EditarMateria(MateriaDTO materia)
        {
            MateriaDAL n = new MateriaDAL();
            n.EditarMateria(materia);
        }

        public void InactivarMateria(int id)
        {
            MateriaDAL materiaDal = new MateriaDAL();
            materiaDal.InactivarMateria(id);
        }

        public void ActivarMateria(int id)
        {
            MateriaDAL materiaDal = new MateriaDAL();
            materiaDal.ActivarMateria(id);
        }

        public int BorrarMateria(int id)
        {
            MateriaDAL materiaDal = new MateriaDAL();
            return materiaDal.BorrarMateria(id);
        }
        #endregion

        #region Periodo
        public List<PeriodoDTO> ObtenerCatalogoPeriodos()
        {
            PeriodoDAL n = new PeriodoDAL();
            return n.ObtenerCatalogoPeriodos();
        }

        public List<PeriodoDTO> ObtenerPeriodos(int idInstitucion)
        {
            PeriodoDAL n = new PeriodoDAL();
            return n.ObtenerPeriodos(idInstitucion);
        }

        public PeriodoDTO ObtenerPeriodo(int idPeriodo, int idInstitucion)
        {
            PeriodoDAL n = new PeriodoDAL();
            return n.ObtenerPeriodo(idPeriodo, idInstitucion);
        }

        public void ActualizarPeriodo(PeriodoDTO periodo)
        {
            PeriodoDAL n = new PeriodoDAL();
            n.ActualizarPeriodo(periodo);
        }

        public void EditarPeriodo(PeriodoDTO periodo)
        {
            PeriodoDAL n = new PeriodoDAL();
            n.EditarPeriodo(periodo);
        }

        public void InactivarPeriodo(int id)
        {
            PeriodoDAL periodoDal = new PeriodoDAL();
            periodoDal.InactivarPeriodo(id);
        }

        public void ActivarPeriodo(int id)
        {
            PeriodoDAL periodoDal = new PeriodoDAL();
            periodoDal.ActivarPeriodo(id);
        }

        public int BorrarPeriodo(int id)
        {
            PeriodoDAL periodoDal = new PeriodoDAL();
            return periodoDal.BorrarPeriodo(id);
        }
        #endregion

        #region Nivel
        public List<NivelDTO> ObtenerCatalogoNiveles()
        {
            NivelDAL n = new NivelDAL();
            return n.ObtenerCatalogoNiveles();
        }

        public List<NivelDTO> ObtenerNiveles(int idInstitucion)
        {
            NivelDAL n = new NivelDAL();
            return n.ObtenerNiveles(idInstitucion);
        }

        public NivelDTO ObtenerNivel(int idNivel, int idInstitucion)
        {
            NivelDAL n = new NivelDAL();
            return n.ObtenerPeriodo(idNivel, idInstitucion);
        }

        public void ActualizarNivel(NivelDTO nivel)
        {
            NivelDAL n = new NivelDAL();
            n.ActualizarNivel(nivel);
        }

        public void EditarNivel(NivelDTO nivel)
        {
            NivelDAL n = new NivelDAL();
            n.EditarNivel(nivel);
        }

        public void InactivarNivel(int id)
        {
            NivelDAL nivelDal = new NivelDAL();
            nivelDal.InactivarNivel(id);
        }

        public void ActivarNivel(int id)
        {
            NivelDAL nivelDal = new NivelDAL();
            nivelDal.ActivarNivel(id);
        }

        public int BorrarNivel(int id)
        {
            NivelDAL nivelDal = new NivelDAL();
            return nivelDal.BorrarNivel(id);
        }
        #endregion

        #region HistorialAcademico

        public List<vwHistorialAcademicoDTO> ObtenerHistorialAcademico(int idEstudiante, int idInstitucion)
        {
          HistorialAcademicoDAL n = new HistorialAcademicoDAL();
          return n.ObtenerHistorialAcademico(idEstudiante, idInstitucion);
        }

        public void BorrarHistorialAcademico(HistorialAcademicoDTO registro)
        {
            HistorialAcademicoDAL n= new HistorialAcademicoDAL();
            n.BorrarHistorialAcademico(registro);
        }

        public void EditarHistorialAcademico(HistorialAcademicoDTO registro)
        {
            HistorialAcademicoDAL n = new HistorialAcademicoDAL();
            n.EditarCursoLectivo(registro);
        }

        public void CrearHistorialAcademico(HistorialAcademicoDTO registro)
        {
            HistorialAcademicoDAL n = new HistorialAcademicoDAL();
            n.CrearHistorialAcademico(registro);
        }
        #endregion

        #region Instituciones
        public List<InstitucionDTO> ObtenerInstituciones()
        {
            InstitucionDAL institucionDal = new InstitucionDAL();
            return institucionDal.ObtenerInstituciones();
        }

        public InstitucionDTO ObtenerInstitucion(int id)
        {
            InstitucionDAL institucionDal = new InstitucionDAL();
            return institucionDal.ObtenerInstitucion(id);
        }

        public bool ActualizarInstitucion(InstitucionDTO institucion, int[] materiasIds, int[] periodosIds, int[] nivelesIds) {
            InstitucionDAL institucionDal = new InstitucionDAL();
            return institucionDal.ActualizarInstitucion(institucion, materiasIds, periodosIds, nivelesIds);
        }
        #endregion
    }
}
