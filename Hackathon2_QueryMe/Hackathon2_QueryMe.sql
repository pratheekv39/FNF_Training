--Creating Table--
CREATE TABLE EmployeeManager (
    Emp_Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Salary INT,
    Manager_Id INT
);

--Inserting Records--
INSERT INTO EmployeeManager (Emp_Id, Name, Salary, Manager_Id) VALUES (1, 'Rohit', 20000, 3);
INSERT INTO EmployeeManager (Emp_Id, Name, Salary, Manager_Id) VALUES (2, 'Sangeeta', 12000, 5);
INSERT INTO EmployeeManager (Emp_Id, Name, Salary, Manager_Id) VALUES (3, 'Sanjay', 10000, 5);
INSERT INTO EmployeeManager (Emp_Id, Name, Salary, Manager_Id) VALUES (4, 'Arun', 25000, 3);
INSERT INTO EmployeeManager (Emp_Id, Name, Salary, Manager_Id) VALUES (5, 'Zaheer', 30000, NULL);

--Query using Self-Join--
SELECT
    e.Name AS emp_Name,
    m.Name AS mgr_Name
FROM 
    EmployeeManager e
LEFT JOIN 
    EmployeeManager m ON e.Manager_Id = m.Emp_Id
ORDER BY 
    e.Name;
