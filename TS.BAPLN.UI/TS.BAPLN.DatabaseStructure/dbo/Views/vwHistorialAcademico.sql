

CREATE VIEW [dbo].[vwHistorialAcademico]
AS

SELECT       

			  HIS.Id as Consecutivo,
			  LE.Carne as CarnetEstudiante,
			  LE.Id as IdEstudiante,
			  LE.PrimerApellido + ' ' + LE.SegundoApellido + ' '+ LE.Nombre as NombreEstudiante,
			  LH.Id as idInstitucion,
			  LH.Nombre as DesInstitucion,
			  CCL.Id as IdCursoLectivo,
			  CCL.Descripcion as CursoLectivo,
			  CN.Id AS IdNivel, 
			  CN.Descripcion AS DesNivel, 
			  CP.Id AS IdPeriodo, 
			  CP.Descripcion as DesPeriodo,
			  CM.Id AS  Materia, 
			  CM.Descripcion AS DesMateria,
			  HIS.Nota as Calificacion

FROM            dbo.HIS_HistorialAcademico  HIS INNER JOIN
			 	dbo.LIS_Instituciones LH on HIS.Id_Institucion=LH.Id  Inner Join 
				dbo.LIS_Estudiante LE ON HIS.Id_Estudiante = LE.Id  inner join
				dbo.REL_Nivel_Institucion RN on RN.Id_Nivel= HIS.Id_Nivel and HIS.Id_Institucion =  RN.Id_Institucion inner join
                dbo.CAT_Nivel CN ON  RN.Id_Nivel = CN.Id inner join
				dbo.REL_Periodo_Institucion RP on HIS.Id_Periodo= RP.Id_Periodo and HIS.Id_Institucion =  RP.Id_Institucion inner join
				dbo.CAT_Periodo CP ON  RP.Id_Periodo = CP.Id inner join
				dbo.REL_Materia_Institucion RM on His.Id_Materia= RM.Id_Materia and HIS.Id_Institucion =  RM.Id_Institucion inner join
				dbo.CAT_Materia CM ON  RM.Id_Materia = CM.Id inner join
				[dbo].[REL_CursoLectivo_Institucion] RCI on His.Id_CursoLectivo= RCI.IdCursoLectivo and HIS.Id_Institucion =  RCI.[IdInstitucion]  inner join
               	dbo.CAT_CursoLectivo CCL ON  CCL.Id= RCI.[IdCursoLectivo]
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3) )"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 5
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = -27
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CAT_Materia"
            Begin Extent = 
               Top = 32
               Left = 423
               Bottom = 128
               Right = 593
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CAT_Nivel"
            Begin Extent = 
               Top = 241
               Left = 218
               Bottom = 337
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "HIS_HistorialAcademico"
            Begin Extent = 
               Top = 197
               Left = 629
               Bottom = 343
               Right = 802
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "LIS_Estudiante"
            Begin Extent = 
               Top = 255
               Left = 941
               Bottom = 385
               Right = 1128
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CAT_CursoLectivo"
            Begin Extent = 
               Top = 33
               Left = 38
               Bottom = 129
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CAT_Periodo"
            Begin Extent = 
               Top = 29
               Left = 865
               Bottom = 125
               Right = 1035
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 29
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwHistorialAcademico';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2835
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwHistorialAcademico';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwHistorialAcademico';

