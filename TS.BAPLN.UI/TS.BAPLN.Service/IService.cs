using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.Service
{
    [ServiceContract]
    public interface IService
    {
        #region Estudiantes
        [OperationContract]
        List<EstudianteDTO> ObtenerEsudiantes();
        [OperationContract]
        EstudianteDTO ObtenerEsudiante(int id);
        [OperationContract]
        void CrearEstudiante(EstudianteDTO estudiante);
        [OperationContract]
        void InactivarEstudiante(int id);
        [OperationContract]
        void ActivarEstudiante(int id);
        [OperationContract]
        bool ActualizarEstudiante(EstudianteDTO estudiante);
        #endregion

        #region Nacionalidad
        [OperationContract]
        List<NacionalidadDTO> ObtenerNacionalidades();
        #endregion

        #region Becas
        [OperationContract]
        List<TipoBecaDTO> ObtenerTipoBecas();

        [OperationContract]
        List<BecaDTO> ObtenerBecas();

        [OperationContract]
        void InactivarBeca(int id);

        [OperationContract]
        void ActivarBeca(int id);

        [OperationContract]
        void CrearBeca(BecaDTO beca);

        [OperationContract]
        bool ActualizarBeca(BecaDTO beca);

        [OperationContract]
        BecaDTO ObtenerBecaPorId(int id);
        #endregion

        #region BecaEstudiante
        [OperationContract]
        void CrearBecaEstudiante(BecaEstudianteDTO beDto);

        [OperationContract]
        List<BecaDTO> ObtenerBecasActivas();

        [OperationContract]
        List<EstudianteDTO> ObtenerEstudiantesAutocomplete(string filtro);
        #endregion

        #region Donador
        [OperationContract]
        List<DonadorDTO> ObtenerDonadores();
        [OperationContract]
        DonadorDTO ObtenerDonador(int id);
        [OperationContract]
        void CrearDonador(DonadorDTO donador);
        [OperationContract]
        void InactivarDonador(int id);
        [OperationContract]
        void ActivarDonador(int id);
        [OperationContract]
        bool ActualizarDonador(DonadorDTO estudiante);
        #endregion

        #region Periodicidad
        [OperationContract]
        List<PeriodicidadDTO> ObtenerPeriodicidades();
        #endregion

        #region CursoLectivo

        [OperationContract]
        List<CursoLectivoDTO> ObtenerCursosLectivos(int idInstitucion);

        [OperationContract]
        CursoLectivoDTO ObtenerCursoLectivo(int idCurso, int idInstitucion);

        [OperationContract]
        List<CursoLectivoDTO> ObtenerCatalogoCursosLectivos();

        [OperationContract]
        void ActualizarCursoLectivo(CursoLectivoDTO cursoLectivo);

        [OperationContract]
        void EditarCursoLectivo(CursoLectivoDTO curso);

        [OperationContract]
        void ActivarCursoLectivo(int id);

        [OperationContract]
        void InactivarCursoLectivo(int id);

        [OperationContract]
        int BorrarCursoLectivo(int id);
        #endregion

        #region Materia
        [OperationContract]
        List<MateriaDTO> ObtenerCatalogoMaterias();

        [OperationContract]
        List<MateriaDTO> ObtenerMaterias(int idInstitucion);

        [OperationContract]
        MateriaDTO ObtenerMateria(int idCurso, int idInstitucion);

        [OperationContract]
        void ActualizarMateria(MateriaDTO materia);

        [OperationContract]
        void EditarMateria(MateriaDTO materia);

        [OperationContract]
        void ActivarMateria(int id);

        [OperationContract]
        void InactivarMateria(int id);

        [OperationContract]
        int BorrarMateria(int id);
        #endregion

        #region Periodo
        [OperationContract]
        List<PeriodoDTO> ObtenerCatalogoPeriodos();

        [OperationContract]
        List<PeriodoDTO> ObtenerPeriodos(int idInstitucion);

        [OperationContract]
        PeriodoDTO ObtenerPeriodo(int idPeriodo, int idInstitucion);

        [OperationContract]
        void ActualizarPeriodo(PeriodoDTO periodo);

        [OperationContract]
        void EditarPeriodo(PeriodoDTO periodo);

        [OperationContract]
        void ActivarPeriodo(int id);

        [OperationContract]
        void InactivarPeriodo(int id);

        [OperationContract]
        int BorrarPeriodo(int id);
        #endregion

        #region Nivel
        [OperationContract]
        List<NivelDTO> ObtenerCatalogoNiveles();

        [OperationContract]
        List<NivelDTO> ObtenerNiveles(int idInstitucion);

        [OperationContract]
        NivelDTO ObtenerNivel(int idNivel, int idInstitucion);

        [OperationContract]
        void ActualizarNivel(NivelDTO nivel);

        [OperationContract]
        void EditarNivel(NivelDTO nivel);

        [OperationContract]
        void ActivarNivel(int id);

        [OperationContract]
        void InactivarNivel(int id);

        [OperationContract]
        int BorrarNivel(int id);
        #endregion

        #region HistorialAcademico

        [OperationContract]
        List<vwHistorialAcademicoDTO> ObtenerHistorialAcademico(int idEstudiante, int idInstitucion);

        [OperationContract]
        void BorrarHistorialAcademico(HistorialAcademicoDTO registro);

        [OperationContract]
        void CrearHistorialAcademico(HistorialAcademicoDTO registro);

        [OperationContract]
        void EditarHistorialAcademico(HistorialAcademicoDTO registro);

        #endregion

        #region Instituciones
        [OperationContract]
        List<InstitucionDTO> ObtenerInstituciones();

        [OperationContract]
        InstitucionDTO ObtenerInstitucion(int id);

        [OperationContract]
        bool ActualizarInstitucion(InstitucionDTO institucion, int[] materiasIds, int[] periodosIds, int[] nivelesIds);
        #endregion
    }
}
