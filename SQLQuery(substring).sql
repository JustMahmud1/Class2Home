CREATE DATABASE Department
USE Department
CREATE TABLE Employees(
[ID] INT PRIMARY KEY IDENTITY(1,1),
[Fullname] NVARCHAR(255) NOT NULL,
[Age] INT NOT NULL,
CHECK (Age>0),
[Email] VARCHAR(100) UNIQUE NOT NULL,
[Salary] DECIMAL NOT NULL
CHECK(Salary>=300 AND Salary<=2000)
)

INSERT INTO Employees VALUES
('Mahmud' , 19 , 'mahmud.mirzezade03@code.edu.az' , 2000),
('Elsen' , 17 , 'elsen.abbasov@gmail.com' , 1500),
('Minaye' , 20 , 'minaye.memmedli@code.edu.az' , 1200),
('Tural' , 23 , 'tural.sefiyev@gmail.com' , 1600),
('Amil' , 23 , 'amil.memmedli@gmail.com' , 1000)

UPDATE Employees
SET Salary = 1999
WHERE ID = 1

SELECT * FROM Employees WHERE Salary>500 AND Salary<1500

SELECT Fullname, Email , Salary FROM Employees
ORDER BY Salary DESC

SELECT * FROM Employees
WHERE Fullname LIKE '%a%'

SELECT * FROM Employees
WHERE Email LIKE 'a%'

SELECT COUNT(Salary) as [Count]
FROM Employees
WHERE Salary>600;

DROP DATABASE Department

SELECT * FROM Employees

SELECT * FROM Employees
WHERE Email LIKE '%@code.edu.az'

SELECT SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email)) FROM Employees WHERE Email LIKE '%@code.edu.az'
