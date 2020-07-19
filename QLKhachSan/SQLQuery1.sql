create database Quanlykhachsan2
use Quanlykhachsan2
go

create table khachhang(
	makh varchar(50),
	tenkh varchar(50),
	gioitinh varchar(50),
	ngaysinh varchar(50),
	cmnd varchar(50),
	sdt varchar(50),
	diachi varchar(50),
	ghichu varchar(50),
	primary key (makh)
)
select * from PhieuThuePHong
go
create table loaiphong(
	maloai varchar(50),
	songuoi varchar(50),
	gia varchar(50),
	primary key (maloai)
)
go
create table tinhtrang(
	matinhtrang varchar(50),
	tentinhtrang varchar(50),
	primary key(matinhtrang)
)
alter table tinhtrang
alter column tentinhtrang nvarchar(50)

go
create table phong (
	maphong varchar(50),
	matinhtrang varchar(50),
	maloai varchar(50),
	primary key (maphong),
	foreign key (maloai) references loaiphong(maloai),
	foreign key (matinhtrang) references tinhtrang(matinhtrang)
)


create table phieuthuephong (
	matp varchar(50),
	maphong varchar(50),
	makh varchar(50),
	ngaythue varchar(50),
	--madv varchar(50),
	soluong varchar(50),													
	primary key (matp),
	foreign key (makh) references khachhang(makh)
)

create table dichvu (
	madv varchar(50),
	tendv varchar(50),
	gia varchar(50),
	donvitinh varchar(50),
	primary key (madv)
)
go
create table chucvu(
	machucvu nvarchar(50),
	tenchucvu nvarchar(50),
	hesoluong nvarchar(50),
	primary key (machucvu)
)
create table nhanvien(
	manv varchar(50),
	
	tennv varchar(50),
	gioitinh varchar(50),
	ngaysinh varchar(50),
	sdt varchar(50),
	diachi varchar(50),
	chucvu varchar(50),
	luong varchar(50),
	primary key (manv),
	

)
go
alter table nhanvien
 add CONSTRAINT machucvu
   FOREIGN KEY (machucvu)
   REFERENCES chucvu (machucvu)

go
alter table nhanvien
add   machucvu nvarchar(50);

alter table nhanvien
add  tongluong nvarchar(50)

go
create table hoadon (
	mahd varchar(50),
	maphieuthue varchar(50),
	ngaythuephong varchar(50),
	Gia varchar(50),
	Soluongngaythue varchar(50),
	ngaythanhtoan varchar(50),
	tongtien varchar(50),
	
	
	makh varchar(50),
	manv varchar(50),
	
	primary key (mahd),
	foreign key (manv) references nhanvien(manv)

)


go
create table nguoidung(
	taikhoan varchar(50),
	matkhau varchar(50),
	chucvu varchar(50),
	primary key (taikhoan)
)
go
create table chucvu(
	machucvu nvarchar(50),
	tenchucvu nvarchar(50),
	hesoluong nvarchar(50),
	primary key (machucvu)
)





go

--Proc tìm kiếm
go
alter proc seaching 
	@valuaToFind nvarchar(50)
as
begin
select  hd.mahd,hd.maphieuthue,hd.Gia,hd.Soluongngaythue,hd.tongtien,hd.ngaythanhtoan,hd.makh from hoadon hd
where ConCat(hd.ngaythanhtoan,hd.ngaythuephong) like  '%' + @valuaToFind + '%' 
end

go
select  * from hoadon


go
create proc seachingKh 
	@valuaToFind nvarchar(50)
as
begin
select  kh.makh,kh.tenkh,kh.gioitinh,kh.ngaysinh,kh.cmnd,kh.sdt,kh.diachi,kh.ghichu from khachhang kh
where ConCat(kh.makh,kh.tenkh) like  '%' + @valuaToFind + '%' 
end

go
create proc seachingNv
	@valuaToFind nvarchar(50)
as
begin
select nv.manv, nv.tennv, nv.gioitinh, nv.ngaysinh, nv.sdt, nv.diachi, nv.luong, nv.machucvu, nv.tongluong from nhanvien nv
where ConCat(nv.manv, nv.tennv) like  '%' + @valuaToFind + '%' 
end




