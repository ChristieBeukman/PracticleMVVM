using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Win10_MVVM.Models
{
    public class Person : INotifyPropertyChanged
    {

#region Properties
        private string firstName;
        private string lastName;
        private string fullName;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (firstName != null)
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (lastName != null)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                if (fullName != null)
                {
                    fullName = firstName + " " + lastName;
                    OnPropertyChanged("FullName");
                }
            }
        }

#endregion

        #region Property Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Constructor

        public Person()
        {
            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {

            }
        } 

#endregion
    }
}
