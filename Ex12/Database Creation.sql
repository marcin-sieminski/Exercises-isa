--DATABASE

CREATE DATABASE BeautyStudios

USE BeautyStudios
GO

--TABLES 

CREATE TABLE [dbo].[Studio](
	[studio_id] [int] IDENTITY(1,1) NOT NULL,
	[studio_name] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone_number] [nvarchar](20) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Studio] PRIMARY KEY CLUSTERED 
(
	[studio_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Treatment](
	[treatment_id] [int] IDENTITY(1,1) NOT NULL,
	[treatment_name] [nvarchar](100) NOT NULL,
	[price] [money] NULL,
 CONSTRAINT [PK_Treatment] PRIMARY KEY CLUSTERED 
(
	[treatment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone_number] [nvarchar](20) NULL,
	[email] [nvarchar](50) NULL,
	[studio_id] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Studio] FOREIGN KEY([studio_id])
REFERENCES [dbo].[Studio] ([studio_id])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Studio]
GO

CREATE TABLE [dbo].[Customer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[phone_number] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Visit](
	[visit_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[visit_date] [date] NOT NULL,
	[visit_time] [time](7) NOT NULL,
	[treatment_id] [int] NOT NULL,
    [customer_id] [int] NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[visit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO

ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Employee]
GO

ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Treatment] FOREIGN KEY([treatment_id])
REFERENCES [dbo].[Treatment] ([treatment_id])
GO

ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Treatment]
GO

ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Customer] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([customer_id])
GO

ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Customer]
GO
