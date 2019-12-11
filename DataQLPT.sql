create database DataQLPT
go
use DataQLPT
go
create table tangphong(
tang int primary key,
)
drop table tangphong
drop table loaiphong
drop table khachtro
drop table phongtro
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
makt varchar(50),
mapt varchar(50),
hoten nvarchar(50),
cmnd varchar(15),
gioitinh nvarchar(10),
nghenghiep nvarchar(50),
sdt varchar(15)
)
go
create table thutien(
mathu varchar(50),
mapt varchar(50),
makt varchar(50),
tiendien int,
tiennuoc int,
tienmang int,
tienxe int,
tienphong int,
)
go
create table traphong(
matraphong nvarchar(50) primary key,
makt varchar(50),
mapt varchar(50),
ngaytra smalldatetime,
)
go
create table thuephong(
mathuephong varchar(50) primary key,
makt varchar(50),
ngaythue smalldatetime,
)

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

