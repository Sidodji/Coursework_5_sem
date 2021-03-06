USE [master]
GO

/****** Object:  Database [HotelsBase]    Script Date: 16.12.2021 19:18:36 ******/
CREATE DATABASE [HotelsBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelsBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HotelsBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelsBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HotelsBase_log.ldf' , SIZE = 466944KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelsBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [HotelsBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [HotelsBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [HotelsBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [HotelsBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [HotelsBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [HotelsBase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [HotelsBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [HotelsBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [HotelsBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [HotelsBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [HotelsBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [HotelsBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [HotelsBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [HotelsBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [HotelsBase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [HotelsBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [HotelsBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [HotelsBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [HotelsBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [HotelsBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [HotelsBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [HotelsBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [HotelsBase] SET RECOVERY FULL 
GO

ALTER DATABASE [HotelsBase] SET  MULTI_USER 
GO

ALTER DATABASE [HotelsBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [HotelsBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [HotelsBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [HotelsBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [HotelsBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [HotelsBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [HotelsBase] SET QUERY_STORE = OFF
GO

ALTER DATABASE [HotelsBase] SET  READ_WRITE 
GO


