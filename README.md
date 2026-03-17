ชานนท์ บุบปับพา 683450353-3

---

## Class Diagram

```mermaid
classDiagram
    class User {
        <<abstract>>
        -name: string
        +Name: string
        +User(name: string)
        +DisplayInfo()*
    }
    
    class Teacher {
        +Teacher(name: string)
        +DisplayInfo()
    }
    
    class Student {
        -studentId: string
        -score: double
        -grade: string
        +StudentId: string
        +Score: double
        +Grade: string
        +Student(name: string, studentId: string, score: double)
        -CalculateGrade()
        +DisplayInfo()
    }
    
    class Course {
        -courseId: string
        -courseName: string
        -courseTeacher: Teacher
        -students: List~Student~
        +CourseId: string
        +CourseName: string
        +Course(courseId: string, courseName: string, teacher: Teacher)
        +AddStudent(student: Student)
        +DisplayCourseReport()
    }
    
    User <|-- Teacher
    User <|-- Student
    Course o-- Teacher
    Course *-- Student
    C 
    class User {
        <<abstract>>
        -name: string
        +Name: string
        +User(name: string)
        +DisplayInfo()*
    }
    
    class Teacher {
        +Teacher(name: string)
        +DisplayInfo()
    }
    
    class Student {
        -studentId: string
        -score: double
        -grade: string
        +StudentId: string
        +Score: double
        +Grade: string
        +Student(name: string, studentId: string, score: double)
        -CalculateGrade()
        +DisplayInfo()
    }
    
    class Course {
        -courseId: string
        -courseName: string
        -courseTeacher: Teacher
        -students: List~Student~
        +CourseId: string
        +CourseName: string
        +Course(courseId: string, courseName: string, teacher: Teacher)
        +AddStudent(student: Student)
        +DisplayCourseReport()
    }
    
    User <|-- Teacher
    User <|-- Student
    Course o-- Teacher
    Course *-- Student
