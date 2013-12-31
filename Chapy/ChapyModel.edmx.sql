
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/24/2013 21:07:50
-- Generated from EDMX file: D:\camon\Chapy\ChapyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [chapy];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CpClass_CpGradeCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpClass] DROP CONSTRAINT [FK_CpClass_CpGradeCode];
GO
IF OBJECT_ID(N'[dbo].[FK_CpClassStaff_CpClass]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpClassStaff] DROP CONSTRAINT [FK_CpClassStaff_CpClass];
GO
IF OBJECT_ID(N'[dbo].[FK_CpSchools_CpCorporation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpSchools] DROP CONSTRAINT [FK_CpSchools_CpCorporation];
GO
IF OBJECT_ID(N'[dbo].[FK_CpStaff_CpPosition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpStaff] DROP CONSTRAINT [FK_CpStaff_CpPosition];
GO
IF OBJECT_ID(N'[dbo].[FK_CpStaff_CpSchools]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpStaff] DROP CONSTRAINT [FK_CpStaff_CpSchools];
GO
IF OBJECT_ID(N'[dbo].[FK_CpStaff_CpStaffType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpStaff] DROP CONSTRAINT [FK_CpStaff_CpStaffType];
GO
IF OBJECT_ID(N'[dbo].[FK_CpStartEndDate_CpSchools]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpStartEndDate] DROP CONSTRAINT [FK_CpStartEndDate_CpSchools];
GO
IF OBJECT_ID(N'[dbo].[FK_CpTannin_CpSchools]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CpTannin] DROP CONSTRAINT [FK_CpTannin_CpSchools];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CpBuildings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpBuildings];
GO
IF OBJECT_ID(N'[dbo].[CpClass]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpClass];
GO
IF OBJECT_ID(N'[dbo].[CpClassStaff]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpClassStaff];
GO
IF OBJECT_ID(N'[dbo].[CpCorporation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpCorporation];
GO
IF OBJECT_ID(N'[dbo].[CpGradeCode]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpGradeCode];
GO
IF OBJECT_ID(N'[dbo].[CpGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpGroup];
GO
IF OBJECT_ID(N'[chappyModelStoreContainer].[CpHoliday]', 'U') IS NOT NULL
    DROP TABLE [chappyModelStoreContainer].[CpHoliday];
GO
IF OBJECT_ID(N'[dbo].[CpPosition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpPosition];
GO
IF OBJECT_ID(N'[dbo].[CpSchools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpSchools];
GO
IF OBJECT_ID(N'[dbo].[CpStaff]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpStaff];
GO
IF OBJECT_ID(N'[dbo].[CpStaffType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpStaffType];
GO
IF OBJECT_ID(N'[dbo].[CpStartEndDate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpStartEndDate];
GO
IF OBJECT_ID(N'[dbo].[CpTannin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpTannin];
GO
IF OBJECT_ID(N'[dbo].[CpTerm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpTerm];
GO
IF OBJECT_ID(N'[dbo].[CpTimeZone]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CpTimeZone];
GO
IF OBJECT_ID(N'[dbo].[JapanHolidays]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JapanHolidays];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CpClasses'
CREATE TABLE [dbo].[CpClasses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GradeCodeId] int  NOT NULL,
    [SchoolId] int  NOT NULL,
    [TermId] int  NOT NULL,
    [Name] nvarchar(255)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [Code] nchar(10)  NOT NULL
);
GO

-- Creating table 'CpClassStaffs'
CREATE TABLE [dbo].[CpClassStaffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassId] int  NOT NULL,
    [StaffId1] int  NOT NULL,
    [StaffId2] int  NULL,
    [StaffId3] int  NULL,
    [StaffId4] int  NULL,
    [StaffId5] int  NULL,
    [StaffId6] int  NULL,
    [NumberOfStaff] int  NULL,
    [TanninId] int  NOT NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpCorporations'
CREATE TABLE [dbo].[CpCorporations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [ChairManFirstName] nvarchar(255)  NULL,
    [ChairManLastName] nvarchar(255)  NULL,
    [PostCode] nvarchar(16)  NULL,
    [Address1] nvarchar(255)  NOT NULL,
    [Address2] nvarchar(255)  NOT NULL,
    [Tel] varchar(16)  NOT NULL,
    [Fax] varchar(64)  NULL,
    [Email] varchar(64)  NULL,
    [HomePage] varchar(max)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpPositions'
CREATE TABLE [dbo].[CpPositions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NULL,
    [Abbreviation] nvarchar(64)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [SchoolId] int  NULL,
    [Code] int  NULL
);
GO

-- Creating table 'CpSchools'
CREATE TABLE [dbo].[CpSchools] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CorporationId] int  NULL,
    [Name] nvarchar(255)  NULL,
    [Code] varchar(50)  NULL,
    [Representation] nvarchar(255)  NULL,
    [PrinceName1] nvarchar(50)  NULL,
    [PrinceName2] nvarchar(50)  NULL,
    [PostCode] nvarchar(16)  NULL,
    [Address1] nvarchar(255)  NOT NULL,
    [Address2] nvarchar(255)  NOT NULL,
    [Tel] varchar(16)  NOT NULL,
    [Fax] varchar(64)  NULL,
    [Email] varchar(64)  NULL,
    [HomePage] varchar(max)  NULL,
    [UsePass] tinyint  NULL,
    [Password] nvarchar(50)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpStaffs'
CREATE TABLE [dbo].[CpStaffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StaffTypeId] int  NOT NULL,
    [PositionId] int  NOT NULL,
    [SchoolId] int  NOT NULL,
    [Name] nvarchar(255)  NULL,
    [Hiragana] nvarchar(255)  NULL,
    [Abbreviation] nvarchar(64)  NULL,
    [Gender] tinyint  NULL,
    [BirthDay] datetime  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [Code] nchar(10)  NOT NULL
);
GO

-- Creating table 'CpStaffTypes'
CREATE TABLE [dbo].[CpStaffTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NULL,
    [Abbreviation] varchar(64)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [SchoolId] int  NULL,
    [Code] int  NULL
);
GO

-- Creating table 'CpStartEndDates'
CREATE TABLE [dbo].[CpStartEndDates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolId] int  NOT NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpTannins'
CREATE TABLE [dbo].[CpTannins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolId] int  NOT NULL,
    [Name] varchar(255)  NOT NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpTerms'
CREATE TABLE [dbo].[CpTerms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolId] int  NOT NULL,
    [Name] nvarchar(255)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [Code] nchar(10)  NOT NULL
);
GO

-- Creating table 'CpTimeZones'
CREATE TABLE [dbo].[CpTimeZones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolId] int  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Abbreviation] nvarchar(64)  NOT NULL,
    [Color] varchar(16)  NOT NULL,
    [DayOfWeeks] varchar(64)  NULL,
    [StartTime] datetime  NULL,
    [EndTime] datetime  NULL,
    [RestStartTime1] datetime  NULL,
    [RestEndTime1] datetime  NULL,
    [RestStartTime2] datetime  NULL,
    [RestEndTime2] datetime  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL,
    [Code] nchar(10)  NOT NULL,
    [ApplyClassed] nvarchar(50)  NULL,
    [ApplyClassed1] nvarchar(50)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'CpGroups'
CREATE TABLE [dbo].[CpGroups] (
    [Id] int  NOT NULL,
    [SchoolId] int  NULL,
    [Code] int  NULL,
    [Name] nvarchar(255)  NULL,
    [Abbreviation] nvarchar(64)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpHolidays'
CREATE TABLE [dbo].[CpHolidays] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [Reason] nvarchar(250)  NULL,
    [SchoolId] int  NULL
);
GO

-- Creating table 'JapanHolidays'
CREATE TABLE [dbo].[JapanHolidays] (
    [Id] int  NOT NULL,
    [Year] int  NULL,
    [Date] datetime  NULL,
    [Name] nvarchar(500)  NULL
);
GO

-- Creating table 'CpGradeCodes'
CREATE TABLE [dbo].[CpGradeCodes] (
    [Id] int  NOT NULL,
    [Code] nchar(10)  NOT NULL,
    [TermId] int  NOT NULL,
    [Name] nvarchar(255)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'CpBuildings'
CREATE TABLE [dbo].[CpBuildings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolId] int  NULL,
    [Code] int  NULL,
    [Name] nvarchar(255)  NULL,
    [Abbreviation] nvarchar(64)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- Creating table 'JapanHoliday1'
CREATE TABLE [dbo].[JapanHoliday1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] int  NULL,
    [Date] datetime  NULL,
    [Name] nvarchar(500)  NULL
);
GO

-- Creating table 'CpBuilding1'
CREATE TABLE [dbo].[CpBuilding1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolId] int  NULL,
    [Code] int  NULL,
    [Name] nvarchar(255)  NULL,
    [Abbreviation] nvarchar(64)  NULL,
    [CreatedAt] datetime  NULL,
    [UpdatedAt] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CpClasses'
ALTER TABLE [dbo].[CpClasses]
ADD CONSTRAINT [PK_CpClasses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpClassStaffs'
ALTER TABLE [dbo].[CpClassStaffs]
ADD CONSTRAINT [PK_CpClassStaffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpCorporations'
ALTER TABLE [dbo].[CpCorporations]
ADD CONSTRAINT [PK_CpCorporations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpPositions'
ALTER TABLE [dbo].[CpPositions]
ADD CONSTRAINT [PK_CpPositions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpSchools'
ALTER TABLE [dbo].[CpSchools]
ADD CONSTRAINT [PK_CpSchools]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpStaffs'
ALTER TABLE [dbo].[CpStaffs]
ADD CONSTRAINT [PK_CpStaffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpStaffTypes'
ALTER TABLE [dbo].[CpStaffTypes]
ADD CONSTRAINT [PK_CpStaffTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpStartEndDates'
ALTER TABLE [dbo].[CpStartEndDates]
ADD CONSTRAINT [PK_CpStartEndDates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpTannins'
ALTER TABLE [dbo].[CpTannins]
ADD CONSTRAINT [PK_CpTannins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpTerms'
ALTER TABLE [dbo].[CpTerms]
ADD CONSTRAINT [PK_CpTerms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpTimeZones'
ALTER TABLE [dbo].[CpTimeZones]
ADD CONSTRAINT [PK_CpTimeZones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'CpGroups'
ALTER TABLE [dbo].[CpGroups]
ADD CONSTRAINT [PK_CpGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpHolidays'
ALTER TABLE [dbo].[CpHolidays]
ADD CONSTRAINT [PK_CpHolidays]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JapanHolidays'
ALTER TABLE [dbo].[JapanHolidays]
ADD CONSTRAINT [PK_JapanHolidays]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpGradeCodes'
ALTER TABLE [dbo].[CpGradeCodes]
ADD CONSTRAINT [PK_CpGradeCodes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpBuildings'
ALTER TABLE [dbo].[CpBuildings]
ADD CONSTRAINT [PK_CpBuildings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JapanHoliday1'
ALTER TABLE [dbo].[JapanHoliday1]
ADD CONSTRAINT [PK_JapanHoliday1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CpBuilding1'
ALTER TABLE [dbo].[CpBuilding1]
ADD CONSTRAINT [PK_CpBuilding1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SchoolId] in table 'CpClasses'
ALTER TABLE [dbo].[CpClasses]
ADD CONSTRAINT [FK_CpClass_CpSchools]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[CpSchools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpClass_CpSchools'
CREATE INDEX [IX_FK_CpClass_CpSchools]
ON [dbo].[CpClasses]
    ([SchoolId]);
GO

-- Creating foreign key on [TermId] in table 'CpClasses'
ALTER TABLE [dbo].[CpClasses]
ADD CONSTRAINT [FK_CpClass_CpTerm]
    FOREIGN KEY ([TermId])
    REFERENCES [dbo].[CpTerms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpClass_CpTerm'
CREATE INDEX [IX_FK_CpClass_CpTerm]
ON [dbo].[CpClasses]
    ([TermId]);
GO

-- Creating foreign key on [ClassId] in table 'CpClassStaffs'
ALTER TABLE [dbo].[CpClassStaffs]
ADD CONSTRAINT [FK_CpClassStaff_CpClass]
    FOREIGN KEY ([ClassId])
    REFERENCES [dbo].[CpClasses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpClassStaff_CpClass'
CREATE INDEX [IX_FK_CpClassStaff_CpClass]
ON [dbo].[CpClassStaffs]
    ([ClassId]);
GO

-- Creating foreign key on [TanninId] in table 'CpClassStaffs'
ALTER TABLE [dbo].[CpClassStaffs]
ADD CONSTRAINT [FK_CpClassStaff_CpTannin]
    FOREIGN KEY ([TanninId])
    REFERENCES [dbo].[CpTannins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpClassStaff_CpTannin'
CREATE INDEX [IX_FK_CpClassStaff_CpTannin]
ON [dbo].[CpClassStaffs]
    ([TanninId]);
GO

-- Creating foreign key on [CorporationId] in table 'CpSchools'
ALTER TABLE [dbo].[CpSchools]
ADD CONSTRAINT [FK_CpSchools_CpCorporation]
    FOREIGN KEY ([CorporationId])
    REFERENCES [dbo].[CpCorporations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpSchools_CpCorporation'
CREATE INDEX [IX_FK_CpSchools_CpCorporation]
ON [dbo].[CpSchools]
    ([CorporationId]);
GO

-- Creating foreign key on [PositionId] in table 'CpStaffs'
ALTER TABLE [dbo].[CpStaffs]
ADD CONSTRAINT [FK_CpStaff_CpPosition]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[CpPositions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpStaff_CpPosition'
CREATE INDEX [IX_FK_CpStaff_CpPosition]
ON [dbo].[CpStaffs]
    ([PositionId]);
GO

-- Creating foreign key on [SchoolId] in table 'CpStaffs'
ALTER TABLE [dbo].[CpStaffs]
ADD CONSTRAINT [FK_CpStaff_CpSchools]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[CpSchools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpStaff_CpSchools'
CREATE INDEX [IX_FK_CpStaff_CpSchools]
ON [dbo].[CpStaffs]
    ([SchoolId]);
GO

-- Creating foreign key on [SchoolId] in table 'CpStartEndDates'
ALTER TABLE [dbo].[CpStartEndDates]
ADD CONSTRAINT [FK_CpStartEndDate_CpSchools]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[CpSchools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpStartEndDate_CpSchools'
CREATE INDEX [IX_FK_CpStartEndDate_CpSchools]
ON [dbo].[CpStartEndDates]
    ([SchoolId]);
GO

-- Creating foreign key on [SchoolId] in table 'CpTannins'
ALTER TABLE [dbo].[CpTannins]
ADD CONSTRAINT [FK_CpTannin_CpSchools]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[CpSchools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpTannin_CpSchools'
CREATE INDEX [IX_FK_CpTannin_CpSchools]
ON [dbo].[CpTannins]
    ([SchoolId]);
GO

-- Creating foreign key on [SchoolId] in table 'CpTimeZones'
ALTER TABLE [dbo].[CpTimeZones]
ADD CONSTRAINT [FK_CpTimeZone_CpSchools]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[CpSchools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpTimeZone_CpSchools'
CREATE INDEX [IX_FK_CpTimeZone_CpSchools]
ON [dbo].[CpTimeZones]
    ([SchoolId]);
GO

-- Creating foreign key on [StaffTypeId] in table 'CpStaffs'
ALTER TABLE [dbo].[CpStaffs]
ADD CONSTRAINT [FK_CpStaff_CpStaffType]
    FOREIGN KEY ([StaffTypeId])
    REFERENCES [dbo].[CpStaffTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpStaff_CpStaffType'
CREATE INDEX [IX_FK_CpStaff_CpStaffType]
ON [dbo].[CpStaffs]
    ([StaffTypeId]);
GO

-- Creating foreign key on [GradeCodeId] in table 'CpClasses'
ALTER TABLE [dbo].[CpClasses]
ADD CONSTRAINT [FK_CpClass_CpGradeCode]
    FOREIGN KEY ([GradeCodeId])
    REFERENCES [dbo].[CpGradeCodes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CpClass_CpGradeCode'
CREATE INDEX [IX_FK_CpClass_CpGradeCode]
ON [dbo].[CpClasses]
    ([GradeCodeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------