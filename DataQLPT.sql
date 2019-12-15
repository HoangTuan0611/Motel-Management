create database DataQLPT
go
use DataQLPT
go
set dateformat dmy
go
create table tangphong(
tang int primary key,
)
go
create table loaiphong(
loai nvarchar(10) primary key,
soluong int,
)
go
create table phongtro(
mapt varchar (50) primary key,
tang int references tangphong ,
tenphong int,
loai nvarchar(10) references loaiphong,
sltoida int,
trangthai nvarchar(50),
songuoihientai int
)
go
create table khachtro(
makt varchar(50) primary key,
mapt varchar(50),
hoten nvarchar(50),
cmnd varchar(15),
gioitinh nvarchar(10),
nghenghiep nvarchar(50),
sdt varchar(15)
)
go
alter table khachtro add constraint Fk_khachtro FOREIGN KEY(mapt) REFERENCES phongtro(mapt)
go
create table thutien(
mathu int IDENTITY(1,1) primary key,
mapt varchar(50),
tiendien int,
tiennuoc int,
tienmang int,
tienxe int,
tienphong int,
ngaythu smalldatetime,
tongtien int,
)

go
create table thamso(
id int default 1 primary key,
tienphongnho int,
tienphonglon int,
tiendien int,
tiennuoc int,
tienxe int,
tienmang int,
tienrac int,
giamtienlenphong int,
)
alter table thutien add constraint Fk_thutien FOREIGN KEY(mapt) REFERENCES phongtro(mapt)
go
create table traphong(
matraphong nvarchar(50) primary key,
makt varchar(50),
mapt varchar(50),
ngaytra smalldatetime,
)
go
alter table traphong add constraint Fk_traphong FOREIGN KEY(makt) REFERENCES khachtro(makt)
go
alter table traphong add constraint Fk1_traphong FOREIGN KEY(mapt) REFERENCES phongtro(mapt)
go

create table DangNhap(
USERNAME varchar(20) primary key,
PASS varchar(20)
)

create proc DangNhap_Login
@username nchar(20),
@password nchar(20)
as
SELECT *
  FROM DangNhap
	where @username = USERNAME
			and @password = PASS

<<<<<<< HEAD
			
=======
Select phongtro.mapt from phongtro where trangthai != 'Da cho thue'

Select phongtro.mapt from phongtro,khachtro where phongtro.trangthai != 'Da cho thue' OR khachtro.mapt=phongtro.mapt
>>>>>>> f5ed90564833a98d930c2cf71d5aa7e000ce4a13
