Student Manager Application

A desktop application built using WPF (.NET) following the MVVM (Model-View-ViewModel) design pattern.
This application allows users to add, edit, and view student records in a structured and user-friendly interface.

--> Features

- Add new student

- Edit existing student details

- Display students in DataGrid

- MVVM architecture (clean separation of concerns)

- Real-time UI updates using ObservableCollection

- Input validation (e.g., Age validation)

 - Image support for student profiles

--> Architecture

The application follows MVVM pattern:

Model

StudentInformation → Represents student data

View

MainWindow.xaml → Displays student list

EditStudentWindow.xaml → Add/Edit form

ViewModel

MainViewModel → Handles student list & commands

EditStudentViewModel → Handles form logic

--? Technologies Used

.NET (WPF)

C#

XAML

MVVM Design Pattern


--> Click Add Student

Fill details in popup

Click Update

Student appears in grid

--> Edit Student

Click edit icon

Modify details

Click Update

Changes reflected

📸 UI Preview

(You can add screenshots here late
