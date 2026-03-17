using System;
using System.Collections.ObjectModel;
using System.Text;
using StudentManagerApplication.Model;
using StudentManagerApplication.Enums;
using StudentManagerApplication.Views;
using System.Windows;


namespace StudentManagerApplication.ViewModel
{
    public class MainViewModel : DefaultViewModel
    {
        public ObservableCollection<StudentInformation> Students { get; set; }

        public Command EditStudent { get; set; }

        public Command Add { get; set; }

        public MainViewModel()
        {
            Students = new ObservableCollection<StudentInformation>();
            Students.Add(new StudentInformation
            {
                Name = "Jack",
                Age = 23,
                Stream = Stream.Arts,
                JoiningDate = new System.DateTime(2019, 2, 20),
                DueFee = 500,
                TotalFee = 5000,
                ImagePath = "Images/user1.png"
            });

            Students.Add(new StudentInformation
            {
                Name = "Dom",
                Age = 33,
                Stream = Stream.Science,
                JoiningDate = new System.DateTime(2019, 2, 20),
                DueFee = 2000,
                TotalFee = 5000,
                ImagePath = "Images/user2.png"
            });
            Add = new Command(OpenAddStudentWindow);
            EditStudent = new Command(OpenEditStudentWindow);
        }

        private void OpenEditStudentWindow(object obj)
        {
            StudentInformation student = obj as StudentInformation;

            EditStudentWindow window = new EditStudentWindow();
            window.DataContext = new EditStudentViewModel(student);

            window.ShowDialog();
        }

        private void OpenAddStudentWindow(object obj)
        {
            EditStudentWindow window = new EditStudentWindow();

            var vm = new EditStudentViewModel(null);
            window.DataContext = vm;

            if (window.ShowDialog() == true)
            {
                Students.Add(vm.TempStudent);  
            }
        }
    }
}