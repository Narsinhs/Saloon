USE [Saloon]
GO
/****** Object:  StoredProcedure [dbo].[Add_Admin]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Admin]
@name nvarchar(50), @password nvarchar(50)
AS 
begin
insert into [Admin] values(@name,@password)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Appointment_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Appointment_Facilities]
@apid int,@fid int
As
Begin
insert into Appointment_Facilities values(@apid,@fid)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Add_Appointment_Master]
@date nvarchar(50),@eid int,@status bit,@uid int
As
Begin
insert into Appointment_Master values(@eid,@uid,@date,@status)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Appointment_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Appointment_Package]
@apid int,@pid int
As
Begin
insert into Appointment_Package values(@apid,@pid)
end

GO
/****** Object:  StoredProcedure [dbo].[Add_Appointment_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Appointment_Product]
@apid int,@pid int
As
Begin
insert into Appointment_Product values(@apid,@pid)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Department]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Department]
@name nvarchar(50)
As
Begin
insert into Department values(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Designation]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Designation]
@name nvarchar(50),@salary decimal(18,0)
As
Begin
insert into Designation values(@name,@salary)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Employee]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Employee]
@name nvarchar(50),@email nvarchar(50),@contact nvarchar(50),@nic nvarchar(50),@did int,@depid int
As
Begin
insert into Employee values(@name,@email,@contact,@nic,@did,@depid)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Exp_Cat]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Add_Exp_Cat]
@name nvarchar(50)
As
Begin
insert into Exp_Cat values(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Expense]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Expense]
@name nvarchar(50),@amount decimal,@date nvarchar(50),@ecid int,@addby nvarchar(50)
As
Begin
insert into Expense values(@name,@amount,@date,@ecid,@addby)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Facilities]
@fid int,@name nvarchar(50),@cost decimal 
As
Begin
insert into Facilities values(@fid,@name,@cost)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Add_Package]
@name nvarchar(50),@status bit 
As
Begin
insert into Package values(@name,@status)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Packfac]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Packfac]
@fid int,@pid int
As
Begin
insert into Package_Facilities values(@fid,@pid)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_Product]
@name nvarchar(50), @cost decimal(18,0)
AS 
begin
insert into Product values(@name,@cost)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_User]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Add_User]
@name nvarchar(50), @email nvarchar(50),@password nvarchar(50),@contact nvarchar(50),@address nvarchar(50),@age int
AS 
begin
insert into [User] values(@name,@email,@password,@contact,@address,@age)
end
GO
/****** Object:  StoredProcedure [dbo].[All_Admin]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Admin]
AS 
begin
select * from [Admin]
end
GO
/****** Object:  StoredProcedure [dbo].[All_Appointment_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Appointment_Facilities]
As
Begin
select * from Appointment_Facilities
end
GO
/****** Object:  StoredProcedure [dbo].[All_Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Appointment_Master]
As
Begin
select * from Appointment_Master
end
GO
/****** Object:  StoredProcedure [dbo].[All_Appointment_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Appointment_Package]
As
Begin
select * from Appointment_Package
end
GO
/****** Object:  StoredProcedure [dbo].[All_Appointment_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Appointment_Product]
As
Begin
select * from Appointment_Product
end

GO
/****** Object:  StoredProcedure [dbo].[All_Department]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Department]
As
Begin
select * from Department
end

GO
/****** Object:  StoredProcedure [dbo].[All_Designation]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Designation]
As
Begin
select * from Designation
end
GO
/****** Object:  StoredProcedure [dbo].[All_Employee]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Employee]
As
Begin
select * from Employee
end
GO
/****** Object:  StoredProcedure [dbo].[All_Exp_Cat]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Exp_Cat]
As
Begin
select * from Exp_Cat
End
GO
/****** Object:  StoredProcedure [dbo].[All_Expense]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Expense]
As
Begin
select * from Expense
end
GO
/****** Object:  StoredProcedure [dbo].[All_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Facilities]
As
Begin
select * from Facilities
end
GO
/****** Object:  StoredProcedure [dbo].[All_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Package]
As
Begin
select * from Package
end
GO
/****** Object:  StoredProcedure [dbo].[All_Packfac]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Packfac]
As
Begin
select * from Package_Facilities
end
GO
/****** Object:  StoredProcedure [dbo].[All_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_Product]
AS 
begin
select * from Product
end
GO
/****** Object:  StoredProcedure [dbo].[All_User]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[All_User]
AS 
begin
select * from [User]
end
GO
/****** Object:  StoredProcedure [dbo].[AllFacilities_Apointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AllFacilities_Apointment_Master]
@aid int
AS
Begin
select * from Facilities where F_ID in (select p.F_ID from Appointment_Facility ap inner join Facilities p on ap.F_ID = p.F_ID and ap.Ap_ID = @aid)
end
GO
/****** Object:  StoredProcedure [dbo].[AllPackages_Apointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AllPackages_Apointment_Master]
@aid int
AS
Begin
select * from Package  pp where pp.P_id in (select p.P_ID from Appointment_Package ap inner join Package p on ap.P_ID = p.P_ID and ap.Ap_ID = @aid)
end
GO
/****** Object:  StoredProcedure [dbo].[AllProducts_Apointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AllProducts_Apointment_Master]
@aid int
AS
Begin
select * from Product  pp where pp.P_id in (select p.P_ID from Appointment_Product ap inner join Product p on ap.P_ID = p.P_ID and ap.Ap_ID = @aid)
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Admin]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Admin]
@aid int
AS 
begin
delete from Admin where A_ID = @aid
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Appointment_Master]
@apid int
As
Begin
Delete from Appointment_Master where Ap_id = @apid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Appointment_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Appointment_Package]
@apid int,@pid int
As
Begin
Delete from Appointment_Package where Ap_ID = @apid 
end

GO
/****** Object:  StoredProcedure [dbo].[Delete_Appointment_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Appointment_Product]
@apid int,@pid int
As
Begin
Delete from Appointment_Product where AP_ID = @apid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Department]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Department]
@depid int
As
Begin
Delete from Department where Dep_ID = @depid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Designation]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Designation]
@did int
As
Begin
Delete from Designation where D_ID = @did 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Employee]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Employee]
@eid int
As
Begin
Delete from Employee where E_ID = @eid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Exp_Cat]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Exp_Cat]
@ecid int
As
Begin
Delete from Exp_Cat where EC_ID = @ecid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Expense]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Expense]
@eid int
As
Begin
Delete from Expense where E_ID = @eid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Facilities]
@fid int
As
Begin
Delete from Facilities where F_ID = @fid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Package]
@pid int
As
Begin
Delete from Package where P_ID = @pid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Package_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Package_Facilities]
@fid int
As
Begin
Delete from Package_Facilities where F_id = @fid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Packfac]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Packfac]
@fid int
As
Begin
Delete from Package_Facilities where F_ID = @fid 
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_Product]
@pid int
AS 
begin
delete from Product where P_ID = @pid
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_User]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Delete_User]
@uid int
AS 
begin
delete from [User] where U_ID = @uid
end
GO
/****** Object:  StoredProcedure [dbo].[GetLastId]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetLastId]
As
begin
select Top 1 * from Appointment_Master order by Ap_ID desc
End
GO
/****** Object:  StoredProcedure [dbo].[Search_Admin]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Admin]
@aid int
AS 
begin
select * from Admin where A_ID = @aid
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Appointment_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Appointment_Facilities]
@apid int
As
Begin
select * from Appointment_Facilities where Ap_ID = @apid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Appointment_Master]
@apid int
As
Begin
select * from Appointment_Master where Ap_id = @apid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Appointment_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Appointment_Package]
@apid int
As
Begin
select * from Appointment_Package where Ap_ID = @apid 
end

GO
/****** Object:  StoredProcedure [dbo].[Search_Appointment_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Appointment_Product]
@apid int
As
Begin
select * from Appointment_Product where AP_ID = @apid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Department]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Department]
@depid int
As
Begin
select * from Department where Dep_ID = @depid 
end

GO
/****** Object:  StoredProcedure [dbo].[Search_Designation]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Designation]
@did int
As
Begin
select * from Designation where D_ID = @did 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Employee]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Employee]
@eid int
As
Begin
select * from Employee where E_ID = @eid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Exp_Cat]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Exp_Cat]
@ecid int
As
Begin
select * from Exp_Cat where EC_ID = @ecid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Expense]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Expense]
@eid int
As
Begin
select * from Expense where E_ID = @eid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Facilities]
@fid int
As
Begin
select * from Facilities where F_ID = @fid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Package]
@pid int
As
Begin
select * from Package where P_ID = @pid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Packfac]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Packfac]
@fid int
As
Begin
select * from Package_Facilities where F_ID = @fid 
end
GO
/****** Object:  StoredProcedure [dbo].[Search_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_Product]
@pid int
AS 
begin
select * from Product where P_id = @pid
end
GO
/****** Object:  StoredProcedure [dbo].[Search_User]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search_User]
@uid int
AS 
begin
select * from [User] where U_ID = @uid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Admin]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Admin]
@name nvarchar(50), @aid int, @password nvarchar(50)
AS 
begin
update Admin set Name = @name, Password = @password where A_ID = @aid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Appointment_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Appointment_Facilities]
@apid int,@fid int
As
Begin
Update Appointment_Facilities set F_ID = @fid where Ap_ID = @apid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Update_Appointment_Master]
@date nvarchar(50),@eid int,@status bit,@apid int,@uid int
As
Begin
Update Appointment_Master set Date = @date,U_ID = @uid,E_ID = @eid,Status = @status where Ap_id = @apid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Appointment_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Appointment_Package]
@apid int,@pid int
As
Begin
Update Appointment_Package set P_ID = @pid where Ap_ID = @apid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Appointment_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Appointment_Product]
@apid int,@pid int
As
Begin
Update Appointment_Product set P_ID = @pid where AP_ID = @apid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Department]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Department]
@depid int,@name nvarchar(50)
As
Begin
Update Department set Dep_Name = @name where Dep_ID = @depid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Designation]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Designation]
@did int,@name nvarchar(50),@salary decimal(18,0)
As
Begin
Update Designation set D_Name = @name,Salary = @salary where D_ID = @did
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Employee]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Employee]
@eid int,@name nvarchar(50),@email nvarchar(50),@contact nvarchar(50),@nic nvarchar(50),@did int,@depid int

As
Begin
Update Employee set Name = @name,Email = @email,Contact = @contact ,NIC  = @nic ,D_ID = @did , Dep_ID = @depid where E_ID = @eid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Exp_Cat]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Exp_Cat]
@ecid int,@name nvarchar(50)
As
Begin
Update Exp_Cat set Name = @name where EC_ID = @ecid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Expense]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Expense]
@eid int,@name nvarchar(50),@amount decimal,@date nvarchar(50),@ecid int,@addby nvarchar(50)
As
Begin
Update Expense set Name = @name, Amount = @amount , Date = @date , EC_ID = @ecid , Add_by = @addby  where E_ID = @eid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Facilities]
@fid int,@name nvarchar(50),@cost decimal 
As
Begin
Update Facilities set F_Name = @name, F_Cost = @cost  where F_ID = @fid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Package]
@pid int,@name nvarchar(50),@status bit 
As
Begin
Update Package set P_Name = @name, Status = @status  where P_ID = @pid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Packfac]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Packfac]
@fid int,@pid int
As
Begin
Update Package_Facilities set P_ID = @pid where F_ID = @fid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_Product]
@name nvarchar(50), @pid int, @cost decimal(18,0)
AS 
begin
update Product set P_Name = @name, P_Cost = @cost where P_id = @pid
end
GO
/****** Object:  StoredProcedure [dbo].[Update_User]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Update_User]
@name nvarchar(50), @email nvarchar(50),@password nvarchar(50),@contact nvarchar(50),@address nvarchar(50),@age int,@uid int
AS 
begin
update [User] set Name = @name, Email = @email , Password = @password , Contact = @contact, Address = @address , Age = @age where U_ID = @uid 
end
GO
/****** Object:  StoredProcedure [dbo].[User_Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[User_Appointment_Master]
@uid int
AS
Begin
select * from Appointment_Master where U_ID = @uid
End
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[A_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[A_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Appointment_Facility]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Facility](
	[Ap_ID] [int] NOT NULL,
	[F_ID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Appointment_Master]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Master](
	[Ap_ID] [int] IDENTITY(1,1) NOT NULL,
	[U_ID] [int] NOT NULL,
	[E_ID] [int] NOT NULL,
	[Date] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Appointment_Master] PRIMARY KEY CLUSTERED 
(
	[Ap_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Appointment_Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Package](
	[Ap_ID] [int] NOT NULL,
	[P_ID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Appointment_Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Product](
	[AP_ID] [int] NOT NULL,
	[P_ID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Dep_ID] [int] IDENTITY(1,1) NOT NULL,
	[Dep_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Dep_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Designation]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[D_ID] [int] IDENTITY(1,1) NOT NULL,
	[D_Name] [nvarchar](50) NOT NULL,
	[Salary] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Designation] PRIMARY KEY CLUSTERED 
(
	[D_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[E_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[NIC] [nvarchar](50) NOT NULL,
	[D_ID] [int] NOT NULL,
	[Dep_ID] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[E_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exp_Cat]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exp_Cat](
	[EC_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Exp_Cat] PRIMARY KEY CLUSTERED 
(
	[EC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Expense]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[E_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Date] [nvarchar](50) NOT NULL,
	[EC_ID] [int] NOT NULL,
	[Add_by] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[E_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facilities](
	[F_ID] [int] IDENTITY(1,1) NOT NULL,
	[F_Name] [nvarchar](50) NOT NULL,
	[F_Cost] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Facilities] PRIMARY KEY CLUSTERED 
(
	[F_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Package]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Package](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_Name] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Package] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Package_Facilities]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Package_Facilities](
	[F_ID] [int] NOT NULL,
	[P_ID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[P_id] [int] IDENTITY(1,1) NOT NULL,
	[P_Name] [nvarchar](50) NOT NULL,
	[P_Cost] [decimal](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 4/22/2019 1:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[U_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[U_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
