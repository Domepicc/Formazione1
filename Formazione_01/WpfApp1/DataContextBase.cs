using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace WpfApp
{
    public class DataContextBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged (string nameProperty)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (nameProperty));
            MessageBox.Show($"name property changed: {nameProperty}");
        }
    }
}
