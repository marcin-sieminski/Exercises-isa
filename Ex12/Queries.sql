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
