USE [PSO]
GO
create trigger TeamPosistion
on [PSO].[dbo].[teamPosition]
after insert, update
as

if exists(select * from deleted)
begin

update [PSO].[dbo].[user]
Set idTeam = null
from deleted  as d
where [PSO].[dbo].[user].idUser = d.seniorLifeguard or [PSO].[dbo].[user].idUser = d.doctor or [PSO].[dbo].[user].idUser = d.paramedic or  
[PSO].[dbo].[user].idUser = d.driver or [PSO].[dbo].[user].idUser = d.pyrotechnist or [PSO].[dbo].[user].idUser = d.gasWelder or  
[PSO].[dbo].[user].idUser = d.craneOperator or [PSO].[dbo].[user].idUser = d.scubaDriver or [PSO].[dbo].[user].idUser = d.hydraulicEquipmentTechnician or  
[PSO].[dbo].[user].idUser =d.scout or [PSO].[dbo].[user].idUser = d.electrician or [PSO].[dbo].[user].idUser = d.rescuer  


    DECLARE @id2 AS INT
    SELECT @id2 = idTeam
    FROM INSERTED


update [PSO].[dbo].[user]
Set idTeam = @id2
from inserted  as i
where [PSO].[dbo].[user].idUser = i.seniorLifeguard or [PSO].[dbo].[user].idUser = i.doctor or [PSO].[dbo].[user].idUser = i.paramedic or  
[PSO].[dbo].[user].idUser = i.driver or [PSO].[dbo].[user].idUser = i.pyrotechnist or [PSO].[dbo].[user].idUser = i.gasWelder or  
[PSO].[dbo].[user].idUser = i.craneOperator or [PSO].[dbo].[user].idUser = i.scubaDriver or [PSO].[dbo].[user].idUser = i.hydraulicEquipmentTechnician or  
[PSO].[dbo].[user].idUser = i.scout or [PSO].[dbo].[user].idUser = i.electrician or [PSO].[dbo].[user].idUser = i.rescuer  

end
else
begin
    DECLARE @id AS INT
    SELECT @id = idTeam
    FROM INSERTED


update [PSO].[dbo].[user]
Set idTeam = @id
from inserted  as i
where [PSO].[dbo].[user].idUser = i.seniorLifeguard or [PSO].[dbo].[user].idUser = i.doctor or [PSO].[dbo].[user].idUser = i.paramedic or  
[PSO].[dbo].[user].idUser = i.driver or [PSO].[dbo].[user].idUser = i.pyrotechnist or [PSO].[dbo].[user].idUser = i.gasWelder or  
[PSO].[dbo].[user].idUser = i.craneOperator or [PSO].[dbo].[user].idUser = i.scubaDriver or [PSO].[dbo].[user].idUser = i.hydraulicEquipmentTechnician or  
[PSO].[dbo].[user].idUser = i.scout or [PSO].[dbo].[user].idUser = i.electrician or [PSO].[dbo].[user].idUser = i.rescuer  
end


--set users.idTeam
--from [PSO].[dbo].[user] as users
--inner join inserted as i
--on users.idTeam = i.idTeam

