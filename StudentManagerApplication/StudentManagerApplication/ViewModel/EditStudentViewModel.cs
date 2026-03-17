using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagerApplication.Model;
using StudentManagerApplication.Enums;
using System.Windows;

namespace StudentManagerApplication.ViewModel
{
    public class EditStudentViewModel : DefaultViewModel
    {
        private StudentInformation originalStudent;
        private bool isEditMode;
        public StudentInformation TempStudent { get; set; }

        public Command Update { get; set; }
        public Command Close { get; set; }

        public EditStudentViewModel(StudentInformation student)
        {
            if (student != null)
            {
                isEditMode = true;
                originalStudent = student;

                TempStudent = new StudentInformation
                {
                    Name = student.Name,
                    Age = student.Age,
                    Stream = student.Stream,
                    TotalFee = student.TotalFee,
                    DueFee = student.DueFee,
                    JoiningDate = student.JoiningDate
                };
            }
            else
            {
                isEditMode = false;

                TempStudent = new StudentInformation
                {
                    JoiningDate = DateTime.Now   
                };
            }

            Update = new Command(UpdateStudent);
            Close = new Command(CloseWindow);
        }

        private void UpdateStudent(object obj)
        {
            if (TempStudent.Age < 18 || TempStudent.Age > 60)
            {
                MessageBox.Show("Age must be between 18 and 60");
                return;
            }

            System.Windows.Window window = obj as System.Windows.Window;

            if (isEditMode)
            {
                originalStudent.Name = TempStudent.Name;
                originalStudent.Age = TempStudent.Age;
                originalStudent.Stream = TempStudent.Stream;
                originalStudent.TotalFee = TempStudent.TotalFee;
                originalStudent.DueFee = TempStudent.DueFee;
                originalStudent.JoiningDate = TempStudent.JoiningDate;
            }

            if (window != null)
            {
                window.DialogResult = true; 
                window.Close();
            }
        }
        private void CloseWindow(object obj)
        {
            System.Windows.Window window = obj as System.Windows.Window;

            if (window != null)
                window.Close();
        }
    }
}