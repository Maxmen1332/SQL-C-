-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO


CREATE PROCEDURE SEARCH_FOR_RAPPORTEUR
@NAME nvarchar(50) AS
SELECT * FROM Rapporteur
WHERE FIO_of_rapporteur = @NAME; 

EXEC SEARCH_FOR_RAPPORTEUR 'Семенова Нина Петровна'


CREATE PROCEDURE SEARCH_FOR_RAPPORTEUR2
@NAME nvarchar(50) AS
SELECT * FROM Rapporteur
WHERE FIO_of_rapporteur like @NAME + '*'; 

EXEC SEARCH_FOR_RAPPORTEUR2 'Семенов'

CREATE PROCEDURE SEARCH_FOR_RAPPORTEUR3
@NAME nvarchar(50) AS
SELECT * FROM Rapporteur
WHERE FIO_of_rapporteur like @NAME + '%'; 

EXEC SEARCH_FOR_RAPPORTEUR3 'Семен'

CREATE PROCEDURE SEARCH_FOR_RAPPORTEUR4
@NAME nvarchar(50) AS
SELECT
ID_of_rapporteur as 'ID докладчика',
FIO_of_rapporteur as 'ФИО докладчика',
Organization as 'Организация',
Scientific_degree as 'Научная степень',
ID_of_scientific_adviser as 'ID научного руководителя'
FROM Rapporteur
WHERE FIO_of_rapporteur like @NAME + '%'; 

EXEC SEARCH_FOR_RAPPORTEUR4 'С'

CREATE PROCEDURE SEARCH_FOR_RAPPORTEUR5
@NAME nvarchar(50) AS
SELECT
ID_of_rapporteur as 'ID докладчика',
FIO_of_rapporteur as 'ФИО докладчика',
Organization as 'Организация',
Scientific_degree as 'Научная степень',
ID_of_scientific_adviser as 'ID научного руководителя'
FROM Rapporteur
WHERE 'ФИО докладчика' like @NAME + '%'; 

EXEC SEARCH_FOR_RAPPORTEUR5 'С'

CREATE PROCEDURE SEARCH_FOR_RAPPORTEUR_VIEW
@NAME nvarchar(50) AS
SELECT * FROM Rapporteur
WHERE ФИО_докладчика like @NAME + '%'; 

EXEC SEARCH_FOR_RAPPORTEUR_VIEW 'С'