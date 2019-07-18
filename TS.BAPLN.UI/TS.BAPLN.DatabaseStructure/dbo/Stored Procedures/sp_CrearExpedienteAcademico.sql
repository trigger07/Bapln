-- =============================================
-- Author:		Giovanni Villavicencio Sandi
-- Create date: 23/04/2016
-- Description:	Genera Registros para un estudiante en una institucion,nivel, curso lectivo, periodo,
-- =============================================
CREATE PROCEDURE sp_CrearExpedienteAcademico
(
  @idCursoLectivo integer,
  @idEstudiante integer,
  @idInstitucion integer,
  @idNivel integer
)
AS 
BEGIN

	SET NOCOUNT ON;
	INSERT INTO [dbo].[HIS_HistorialAcademico]
           ([Id_Estudiante]
           ,[Id_Materia]
           ,[Id_Periodo]
           ,[Id_Nivel]
           ,[Nota]
           ,[Id_CursoLectivo]
           ,[Id_Institucion])
	select distinct @idEstudiante,mat.Id,per.Id,@idNivel,0, @idCursoLectivo, @idInstitucion
	from  CAT_Materia mat inner join REL_Materia_Institucion relM on mat.ID= relM.Id_Materia and relM.Id_Institucion = @idInstitucion
         , CAT_Periodo per inner join REL_Periodo_Institucion relP on per.Id = relP.Id_Periodo and relP.Id_Institucion = @idInstitucion 
		 , Cat_Nivel niv inner join REL_Nivel_Institucion relN on niv.Id= relN.Id_Nivel and relN.Id_Institucion = @idInstitucion and niv.Id=@idNivel
    SET NOCOUNT OFF
END