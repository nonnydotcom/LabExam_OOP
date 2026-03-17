ชานนท์ บุบปับพา 683450353-3

---

## Class Diagram

```mermaid
classDiagram
    class Person {
        <<abstract>>
        -name: string
        +Name: string
        +Person(name: string)
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
    
    Person <|-- Teacher : Inherits
    Person <|-- Student : Inherits
    Course o-- Teacher : Has an Instructor
    Course *-- Student : ContainsHas an I 

```mermaid
classDiagram
    class Person {
        <<abstract>>
        -name: string
        +Name: string
        +Person(name: string)
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
    
    Person <|-- Teacher : Inherits
    Person <|-- Student : Inherits
    Course o-- Teacher : Has an Instructor
    Course *-- Student : Contains Students
