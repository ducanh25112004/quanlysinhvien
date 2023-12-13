CREATE DATABASE asm2

use asm2

CREATE TABLE Users
(
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

INSERT INTO Users (Username, Password, Role) VALUES
('admin', 'admin', 'admin'),
('user', 'user', 'user');

-- Tạo bảng Students trong cơ sở dữ liệu
CREATE TABLE Students(
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(255),
    Gender VARCHAR(10),
    ClassID INT
);

CREATE TABLE Lecturers (
    LecturerID INT PRIMARY KEY IDENTITY(1,1),
    LecturerName NVARCHAR(255),
    Department NVARCHAR(100)
);

CREATE TABLE Classes (
    ClassID INT PRIMARY KEY IDENTITY(1,1),
    ClassName NVARCHAR(255),
    Room NVARCHAR(50)
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(255),
    Description NVARCHAR(MAX)
);
-- Tạo bảng điểm danh
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY,
    StudentID INT,
    AttendanceDate DATE,
    IsPresent BIT, -- Có thể là bit để biểu thị có hoặc không có mặt
    CONSTRAINT FK_Student_Attendance FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);