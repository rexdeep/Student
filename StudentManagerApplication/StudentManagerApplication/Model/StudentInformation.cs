using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagerApplication.Enums;
using System.ComponentModel;


namespace StudentManagerApplication.Model
{
    public class StudentInformation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        private Stream stream;

        public Stream Stream
        {
            get { return stream; }
            set
            {
                stream = value;
                OnPropertyChanged("Stream");
            }
        }

        private int totalFee;
        public int TotalFee
        {
            get { return totalFee; }
            set
            {
                totalFee = value;
                OnPropertyChanged("TotalFee");
            }
        }

        private int dueFee;
        public int DueFee
        {
            get { return dueFee; }
            set
            {
                dueFee = value;
                OnPropertyChanged("DueFee");
            }
        }

        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        private System.DateTime joiningDate;
        public System.DateTime JoiningDate
        {
            get { return joiningDate; }
            set
            {
                joiningDate = value;
                OnPropertyChanged("JoiningDate");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}