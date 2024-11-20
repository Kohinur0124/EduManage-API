# EduManage-API
EduManage API is a comprehensive RESTful Web API designed to efficiently manage educational institutions' data and operations. It provides seamless functionality for handling students, teachers, departments, subjects, and related activities.

## Features
- **Student Management**: CRUD operations to handle student data.
- **Teacher Management**: CRUD operations to manage teacher data.
- **Department and Subject Management**: Organize and manage departments and subjects.
- **Advanced Filters**: Filter by gender, department, age, etc.
- **Performance Tracking**: Get top students/teachers based on marks.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Kohinur0124/EduManage-API.git
   cd EduManage-API
2. **Change Connection String**:<br>
      src/EduManage.API/appsettings.json
   
3. **Add migration and update migration**:
     консоль диспетчера пакетов :
   ```bash
   add-migration migrationName
   update-database
4. **Run the application:
   ```bash
   dotnet run        

## API Endpoints

### Students

- **GET** `/api/students`: Retrieves a list of all students.
- **GET** `/api/students/{id}`: Retrieves a specific student by their ID.
- **POST** `/api/students`: Creates a new student record.
- **PUT** `/api/students/{id}`: Updates an existing student record by ID.
- **DELETE** `/api/students/{id}`: Deletes a student by their ID.
  
#### Filter Students:
- **GET** `/api/students/filter`: Filter students by various criteria such as gender, department, age, etc.
  - Example: `/api/students/filter?gender=Male&departmentId=2`

### Teachers

- **GET** `/api/teachers`: Retrieves a list of all teachers.
- **GET** `/api/teachers/{id}`: Retrieves a specific teacher by their ID.
- **POST** `/api/teachers`: Creates a new teacher record.
- **PUT** `/api/teachers/{id}`: Updates an existing teacher record by ID.
- **DELETE** `/api/teachers/{id}`: Deletes a teacher by their ID.
  
#### Filter Teachers:
- **GET** `/api/teachers/filter`: Filter teachers by criteria such as gender, age, or subject.
  - Example: `/api/teachers/filter?gender=Female&subjectId=3`

### Departments

- **GET** `/api/departments`: Retrieves a list of all departments.
- **GET** `/api/departments/{id}`: Retrieves a specific department by ID.
- **POST** `/api/departments`: Creates a new department.
- **PUT** `/api/departments/{id}`: Updates an existing department.
- **DELETE** `/api/departments/{id}`: Deletes a department by ID.

### Subjects

- **GET** `/api/subjects`: Retrieves a list of all subjects.
- **GET** `/api/subjects/{id}`: Retrieves a specific subject by ID.
- **POST** `/api/subjects`: Creates a new subject.
- **PUT** `/api/subjects/{id}`: Updates an existing subject.
- **DELETE** `/api/subjects/{id}`: Deletes a subject by ID.

