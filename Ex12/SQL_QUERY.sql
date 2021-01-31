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

--INSERT DATA

USE BeautyStudios
GO

INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Best Haircut', 'Warszawa', 'Puławska 15', '6041258798', 'salon@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('4You', 'Radom', 'Belgradzka 1', '562369874', 'salon2@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Ala', 'Piła', 'Wolna 3', '587965478', 'salon3@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Ola', 'Piła', 'Polna 4', '875698523', 'salon4@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Ela', 'Gdańsk', 'Rolna 98', '632587958', 'salon5@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Quick', 'Gdańsk', 'Główna 7', '444666666', 'salon6@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Quick4You', 'Gdańsk', 'Główna 45', '600001002', 'salon7@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Best', 'Katowice', 'Francuska 3', '600001003', 'salon8@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Yours', 'Katowice', 'Korfantego 4', '600001004', 'salon9@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('Haircut', 'Katowice', 'Gliwicka 22', '600001005', 'salon10@wp.pl')
INSERT INTO dbo.Studio (studio_name, city, address, phone_number, email) VALUES ('New', 'Katowice', 'Chorzowska 45', '600001006', 'salon11@wp.pl')

INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Strzyżenie męskie', 50)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Strzyżenie męskie maszynka', 30)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Strzyżenie i trymowanie brody', 80)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Strzyżenie damskie włosy krótkie', 80)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Strzyżenie damskie włosy średnie', 90)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Strzyżenie damskie włosy długie', 100)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Modelowanie damskie włosy krótkie', 60)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Modelowanie damskie włosy średnie', 70)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Modelowanie damskie włosy długie', 80)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Koloryzacja', 200)
INSERT INTO dbo.Treatment (treatment_name, price) VALUES ('Baleyage', 250)

INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Adam', 'Abacki', 'Warszawa', 'Puławska 1', '123456789', 'adam@wp.pl', 1)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Ola', 'Abacka', 'Warszawa', 'Puławska 1', '5555588878', 'ola@wp.pl', 1)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Anna', 'Wolna', 'Radom', 'Długa', '58965588852', 'anan@wp.pl', 2)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Marek', 'Dobry', 'Warszawa', 'Puławska 1', '123456789', 'fryzjer@wp.pl', 3)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Michał', 'Babacki', 'Katowice', 'Puławska 1', '123456789', 'fryzjer@wp.pl', 4)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Jola', 'Sama', 'Warszawa', 'Puławska 1', '123456789', 'fryzjer@wp.pl', 5)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Magda', 'Cabacka', 'Warszawa', 'Dobra 1', '123456789', 'fryzjer@wp.pl', 6)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Hanna', 'Abacki', 'Gdańsk', 'Główna 1', '123456789', 'fryzjer@wp.pl', 8)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Jan', 'Szybki', 'Warszawa', 'Nowa 1', '123456789', 'fryzjer@wp.pl', 10)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Marcin', 'Kowalski', 'Warszawa', 'Szybka 1', '123456789', 'fryzjer@wp.pl', 11)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Helena', 'Kowalska', 'Warszawa', 'Prosta 1', '123456789', 'fryzjer@wp.pl', 10)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Zuza', 'Nowak', 'Warszawa', 'Główna 1', '123456789', 'fryzjer@wp.pl', 9)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Wojciech', 'Nowacki', 'Warszawa', 'Polska 1', '123456789', 'fryzjer@wp.pl', 9)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Paweł', 'Nowakowski', 'Warszawa', 'Grecka 1', '123456789', 'fryzjer@wp.pl', 9)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Piotr', 'Nowy', 'Warszawa', 'Krótka 1', '123456789', 'fryzjer@wp.pl', 3)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Henryka', 'Kowal', 'Warszawa', 'Puławska 1', '123456789', 'fryzjer@wp.pl', 5)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Anna', 'Kowal', 'Warszawa', 'Puławska 1', '123456789', 'fryzjer@wp.pl', 8)
INSERT INTO dbo.Employee (first_name, last_name, city, address, phone_number, email, studio_id) VALUES ('Helena', 'Abacka', 'Warszawa', 'Puławska 1', '123456789', 'fryzjer@wp.pl', 1)

INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Marcin', 'Kowalski', '1236559525')
INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Anna', 'Kowalska', '1236559525')
INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Mariola', 'Polska', '43345344')
INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Helena', 'Nowak', '5432421321')
INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Włodzimierz', 'Abacki', '232332232')
INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Artur', 'Wolny', '323232')
INSERT INTO dbo.Customer (first_name, last_name, phone_number) VALUES ('Joanna', 'Wolny', '323232')

INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (1, '2020-10-20', '10:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (2, '2020-10-19', '11:00', 2, 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (3, '2020-10-18', '12:00', 3, 3)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (4, '2020-10-15', '13:00', 5, 4)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (5, '2020-10-01', '14:00', 11, 5)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (6, '2020-10-02', '14:00', 11, 6)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (7, '2020-10-05', '15:00', 5, 7)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (8, '2020-10-19', '16:00', 7, 8)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (9, '2020-10-16', '10:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (10, '2020-10-19', '10:00', 3)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (11, '2020-10-18', '12:00', 9, 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (12, '2020-10-09', '14:00', 7)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-10-19', '13:00', 7)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (2, '2020-10-05', '16:00', 8)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (1, '2020-10-12', '10:00', 3)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-10-19', '15:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (7, '2020-10-13', '10:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (5, '2020-10-19', '15:00', 4)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-10-15', '14:00', 6)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (9, '2020-10-19', '13:00', 8)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (10, '2020-10-01', '12:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (18, '2020-10-19', '11:00', 6)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (5, '2020-10-02', '10:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (8, '2020-10-03', '14:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (2, '2020-10-01', '16:00', 11)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (5, '2020-10-19', '13:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (1, '2020-10-08', '12:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (7, '2020-10-10', '11:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-10-12', '11:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (1, '2020-09-20', '10:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (2, '2020-09-19', '11:00', 2, 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (3, '2020-09-18', '12:00', 3, 3)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (4, '2020-09-15', '13:00', 5, 4)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (5, '2020-09-01', '14:00', 11, 5)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (6, '2020-09-02', '14:00', 11, 6)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (7, '2020-09-05', '15:00', 5, 7)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (8, '2020-09-19', '16:00', 7, 8)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (9, '2020-09-16', '10:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (10, '2020-09-19', '10:00', 3)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id, customer_id) VALUES (11, '2020-09-18', '12:00', 9, 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (12, '2020-09-09', '14:00', 7)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-09-19', '13:00', 7)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (2, '2020-09-05', '16:00', 8)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (1, '2020-09-12', '10:00', 3)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-09-19', '15:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (7, '2020-09-13', '10:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (5, '2020-09-19', '15:00', 4)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-09-15', '14:00', 6)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (9, '2020-09-19', '13:00', 8)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (10, '2020-09-01', '12:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (18, '2020-09-19', '11:00', 6)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (5, '2020-09-02', '10:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (8, '2020-09-03', '14:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (2, '2020-09-01', '16:00', 11)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (5, '2020-09-19', '13:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (1, '2020-09-08', '12:00', 2)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (7, '2020-09-10', '11:00', 1)
INSERT INTO dbo.Visit (employee_id, visit_date, visit_time, treatment_id) VALUES (3, '2020-09-12', '11:00', 2)

--QUERIES
USE BeautyStudios
GO

--a) Wyświetl ile pracowników ma każdy salon

SELECT s.studio_id AS "Studio ID", s.studio_name AS "Studio name", s.city AS "City", COUNT(e.employee_id) AS "Employee count"
FROM dbo.Studio s
LEFT JOIN dbo.Employee e ON e.studio_id = s.studio_id
GROUP BY s.studio_id, s.studio_name, s.city
ORDER BY s.studio_id

--b) Wyświetl ile godzin w miesiącu przepracował każdy pracownik (ile faktycznie wykonał usług)

SELECT	e.employee_id AS "Employee ID", e.first_name + ' ' + e.last_name AS "Emploee Name", 
		DATEPART(YEAR, visit_date) AS Year,
		DATEPART(MONTH, visit_date) AS Month,
		COUNT(v.employee_id) AS "Employee work count"
FROM dbo.Employee e 
INNER JOIN dbo.Visit v ON e.employee_id = v.employee_id
GROUP BY e.employee_id, e.first_name + ' ' + e.last_name, DATEPART(YEAR, visit_date), DATEPART(MONTH, visit_date)
ORDER BY "Emploee Name", Year, Month

--c) Wyświetl ile razy wykonane zostały poszczególne usługi

SELECT t.treatment_name AS "Treatment name", COUNT(v.treatment_id) "Treatment count"
FROM dbo.Treatment t 
INNER JOIN dbo.Visit v ON t.treatment_id = v.treatment_id
GROUP BY t.treatment_name
ORDER BY "Treatment name"

--d) Wyświetl ile poszczególne salony zarobiły na różnych usługach

SELECT s.studio_id AS "Studio ID", s.studio_name AS "Studio Name", t.treatment_name AS "Treatment Name", SUM(t.price) AS "Total income"
FROM dbo.Studio s
INNER JOIN dbo.Employee e ON s.studio_id = e.studio_id
INNER JOIN dbo.Visit v ON e.employee_id = v.employee_id
INNER JOIN dbo.Treatment t ON v.treatment_id = t.treatment_id
GROUP BY s.studio_id, s.studio_name, t.treatment_name
ORDER BY "Studio ID", "Studio Name", "Treatment Name"

--e) Wyświetl jakie usługi nie zostały wykonane ani razu

SELECT treatment_id, treatment_name AS "Unpopular Treatments"
FROM dbo.Treatment
WHERE treatment_id NOT IN (SELECT treatment_id FROM dbo.Visit)
ORDER BY treatment_name

--f) Wyświetl w jakich godzinach jest najwięcej rezerwacji

SELECT TOP 1 visit_time AS "Visit time", COUNT(*) AS "Visit time popularity"
FROM dbo.Visit
GROUP BY visit_time
ORDER BY "Visit time popularity" DESC
