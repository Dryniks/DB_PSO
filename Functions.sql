USE [PSO]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFIO]    Script Date: 22.11.2020 0:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetFIO](@id int)
	returns varchar(150)
	begin
	declare @fio varchar(150)
	select @fio=us.family + ' ' + us.name + ' ' + us.middleName
	from [PSO].[dbo].[user] as us
	where us.idUser =@id;
	return @fio
	end
GO
/****** Object:  UserDefinedFunction [dbo].[GetTeamData]    Script Date: 22.11.2020 0:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetTeamData]()
	returns @data table
	(idTeam INT PRIMARY KEY, teamName varchar(50), seniorLifeguard varchar(150) , doctor varchar(150), paramedic varchar(150), driver varchar(150), pyrotechnist varchar(150), gasWelder varchar(150), craneOperator varchar(150), scubaDriver varchar(150), hydraulicEquipmentTechnician varchar(150), scout varchar(150), electrician varchar(150), rescuer varchar(150) , regionAddress varchar(150), departmentAddress varchar(150), mainDepartmentAddress varchar(150))
	as
	begin
	INSERT @data
SELECT      team.idTeam AS [Номер комнады], team.teamName AS [Название команды], [PSO].[dbo].[GetFIO](teamPosition.seniorLifeguard) AS [Гл. спасатель], [PSO].[dbo].[GetFIO](teamPosition.doctor) AS Доктор, [PSO].[dbo].[GetFIO](teamPosition.paramedic) AS Фельдшер, 
                         [PSO].[dbo].[GetFIO](teamPosition.driver) AS Водитель, [PSO].[dbo].[GetFIO](teamPosition.pyrotechnist) AS Пиротехник, [PSO].[dbo].[GetFIO](teamPosition.gasWelder) AS Газосварщик, [PSO].[dbo].[GetFIO](teamPosition.craneOperator) AS [Оператор крана], [PSO].[dbo].[GetFIO](teamPosition.scubaDriver) AS Дайвер, 
                         [PSO].[dbo].[GetFIO](teamPosition.hydraulicEquipmentTechnician) AS Гидравлик, [PSO].[dbo].[GetFIO](teamPosition.scout) AS Разведчик, [PSO].[dbo].[GetFIO](teamPosition.electrician) AS Электрик, [PSO].[dbo].[GetFIO](teamPosition.rescuer) AS [Зам спасателя], region.address AS [Адрес региона], 
                         department.address AS [Адрес департамента], mainDepartment.address AS [Адрес главного департамента]
FROM             [PSO].[dbo].[team] INNER JOIN
                          [PSO].[dbo].[teamPosition] ON  [PSO].[dbo].[team].idTeam =  [PSO].[dbo].[teamPosition].idTeam INNER JOIN
                          [PSO].[dbo].[coordinator] ON  [PSO].[dbo].[team].idTeam =  [PSO].[dbo].[coordinator].idTeam INNER JOIN
                         [PSO].[dbo].[region] ON [PSO].[dbo].[coordinator].idRegion = [PSO].[dbo].[region].idRegion INNER JOIN
                         [PSO].[dbo].[department] ON [PSO].[dbo].[region].idDepartment =[PSO].[dbo].[department].idDepartment INNER JOIN
                         [PSO].[dbo].[mainDepartment] ON [PSO].[dbo].[department].idMainDepartment = [PSO].[dbo].[mainDepartment].idMainDepartment CROSS JOIN
                         [PSO].[dbo].[user]
GROUP BY        team.idTeam, team.teamName, teamPosition.seniorLifeguard, [PSO].[dbo].teamPosition.doctor, teamPosition.paramedic, 
                         teamPosition.driver, teamPosition.pyrotechnist, teamPosition.gasWelder, teamPosition.craneOperator, teamPosition.scubaDriver, 
                         teamPosition.hydraulicEquipmentTechnician, teamPosition.scout, teamPosition.electrician, teamPosition.rescuer, region.address, 
                         department.address, mainDepartment.address;

	return 
	end
GO
/****** Object:  UserDefinedFunction [dbo].[GetDisasterData]    Script Date: 22.11.2020 0:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetDisasterData]()
RETURNS TABLE 
AS
RETURN 
(
	(Select reason.idReason, reason.reason, reason.typeReason, disaster.city, disaster.country, disaster.date
	from [PSO].[dbo].[disaster] as disaster, [PSO].[dbo].[reason] as reason 
	where disaster.idDisaster = reason.idDisaster)
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetEquipmentData]    Script Date: 22.11.2020 0:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetEquipmentData]()
RETURNS TABLE 
AS
RETURN 
(
	(Select equipment.idEquipment, equipment.description, equipment.type, equipment.equipmentName,profession.position
	from [PSO].[dbo].[profession] as profession, [PSO].[dbo].[equipment] as equipment 
	where profession.idProfession = equipment.idProfession)
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetPeopleData]    Script Date: 22.11.2020 0:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetPeopleData]()
RETURNS TABLE 
AS
RETURN 
(
	(Select people.idPeople, people.family, people.name, people.middleName, people.dateOfBirth , missingPeople.dateOfLoss, missingPeople.lastLocation, missingPeople.specialSign
	from [PSO].[dbo].[missingPeople] as missingPeople, [PSO].[dbo].[people] as people 
	where people.idPeople = missingPeople.idPeople)
)
GO
