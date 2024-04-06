-- Создание таблицы Employees
CREATE TABLE Employees (
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(50),
    department_id INT
);

-- Вставка образцов данных в таблицу Employees
INSERT INTO Employees (employee_id, employee_name, department_id)
VALUES 
    (1, 'John Doe', 1),
    (2, 'Jane Smith', 2),
    (3, 'Michael Johnson', 1),
    (4, 'Emily Brown', NULL);

-- Создание таблицы Departments
CREATE TABLE Departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(50)
);

-- Вставка образцов данных в таблицу Departments
INSERT INTO Departments (department_id, department_name)
VALUES 
    (1, 'HR'),
    (2, 'Finance'),
    (3, 'IT');


	SELECT 
    Employees.employee_id, 
    Employees.employee_name, 
    Employees.department_id, 
    Departments.department_name
FROM 
    Employees
INNER JOIN 
    Departments ON Employees.department_id = Departments.department_id;


	SELECT 
    Employees.employee_id, 
    Employees.employee_name, 
    Employees.department_id, 
    Departments.department_name
FROM 
    Employees
FULL OUTER JOIN 
    Departments ON Employees.department_id = Departments.department_id;

	SELECT 
    Employees.employee_id, 
    Employees.employee_name, 
    Departments.department_name
FROM 
    Employees
LEFT JOIN 
    Departments ON Employees.department_id = Departments.department_id;

	SELECT 
    Employees.employee_id, 
    Employees.employee_name, 
    Departments.department_id,
    Departments.department_name
FROM 
    Departments
RIGHT JOIN 
    Employees ON Employees.department_id = Departments.department_id;