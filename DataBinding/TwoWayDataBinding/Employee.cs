﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwoWayDataBinding
{
    class Employee : INotifyPropertyChanged
        {
            private string name;

            public string Name
            {
                get => name;

                set
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
            private string title;

            public string Title
            {
                get => title;

                set
                {
                    title = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public static Employee GetEmployee()
            {
                var emp = new Employee()
                {
                    Name = "Tom",
                    Title = "Developer"
                };
                return emp;
            }

            private void OnPropertyChanged(
                [CallerMemberName] string caller = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,new PropertyChangedEventArgs(caller));
                }
            }
    }
}
