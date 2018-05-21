/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLT')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLT') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLT]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLT]
GO

USE [QLT]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOI](
	[MaKhoi] [int] NOT NULL,
	[TenKhoi] [nvarchar](10) NOT NULL,
	[SoLuongLop] [int] NOT NULL,
	CONSTRAINT [PK_MaKhoi] PRIMARY KEY (MaKhoi)
);
CREATE TABLE [dbo].[LOP](
	[MaLop] [int] NOT NULL,
	[MaKhoi] [int] NOT NULL,
	[SiSo] [int] NOT NULL,
	[TenLop] [nvarchar](10) NOT NULL,
    CONSTRAINT [PK_MaLop] PRIMARY KEY (MaLop),
	CONSTRAINT [FK_MaKhoi] FOREIGN KEY (MaKhoi) REFERENCES [KHOI] (MaKhoi)
);
CREATE TABLE [dbo].[TINHTRANG](
	[MaTT] [int] NOT NULL,
	[TinhTrang] [nvarchar](10) NOT NULL,
	CONSTRAINT [PK_MaTT] PRIMARY KEY (MaTT)
);
CREATE TABLE [dbo].[TRE](
	[MaTre] [int] NOT NULL,
	[MaLop] [int] ,
	[HoTenTre] [nvarchar](30) NOT NULL,
	[TenNha] [nvarchar] (10) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[PhuHuynh] [nvarchar](30) NOT NULL,
	[DienThoai] [nvarchar] (11) NOT NULL,
	[DiaChi] [nvarchar] (60) NOT NULL,
	[Tuoi] [int] NOT NULL,
	[NgayNhapHoc] smalldatetime,
	[GhiChu] [nvarchar] (60) ,
	CONSTRAINT [PK_MaTre] PRIMARY KEY (MaTre),
	CONSTRAINT [FK_MaLop] FOREIGN KEY (MaLop) REFERENCES [LOP] (MaLop)
);
CREATE TABLE [dbo].[PHIEUTINHTRANG](
	[MaPhieu] [int] NOT NULL,
	[MaTT] [int] NOT NULL,	
	[MaTre] [int] NOT NULL,
	[Ngay] [smalldatetime] NOT NULL,
	CONSTRAINT [PK_MaPhieu] PRIMARY KEY (MaPhieu),
	CONSTRAINT [FK_MaTT] FOREIGN KEY (MaTT) REFERENCES [TINHTRANG] (MaTT),
	CONSTRAINT [FK_MaTre] FOREIGN KEY (MaTre) REFERENCES [TRE] (MaTre)
);
CREATE TABLE [dbo].[THAMSO](
	[TuoiMin] [int] NOT NULL,
	[TuoiMax] [int] NOT NULL,
	[SiSoMax] [int] NOT NULL,
);
GO

USE [QLT]
GO

INSERT INTO [dbo].[KHOI]([MaKhoi],[TenKhoi],[SoLuongLop]) VALUES (1,'mam',4)
GO
INSERT INTO [dbo].[KHOI]([MaKhoi],[TenKhoi],[SoLuongLop]) VALUES (2,'choi',4)
GO
INSERT INTO [dbo].[KHOI]([MaKhoi],[TenKhoi],[SoLuongLop]) VALUES (3,'la',4)
GO

USE [QLT]
GO

INSERT INTO [dbo].[THAMSO] ([TuoiMin],[TuoiMax],[SiSoMax]) VALUES (3,5,20)
GO

USE [QLT]
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (11,1,'mam 1',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (12,1,'mam 2',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (13,1,'mam 3',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (14,1,'mam 4',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (21,2,'choi 1',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (22,2,'choi 2',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (23,2,'choi 3',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (24,2,'choi 4',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (31,3,'la 1',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (32,3,'la 2',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (33,3,'la 3',0)
GO
INSERT INTO [dbo].[LOP]([MaLop],[MaKhoi],[TenLop],[SiSo]) VALUES (34,3,'la 4',0)
GO
