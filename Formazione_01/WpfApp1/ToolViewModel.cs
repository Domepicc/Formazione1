using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Formazione_01.Service;
using Formazione_01.Domain;
using System.Data.Linq;

namespace WpfApp
{
    public class ToolViewModel : DataContextBase
    {
   
        Tool _Tool = new Tool();

        public Tool Tool
        {
            get
            {
                return _Tool;
            }
            set
            {
                _Tool = value;
                OnPropertyChanged("Tool");
            }
        }

        public RelayCommand Save_Command { get; set; }
        public RelayCommand Search_Command { get; set; }

        public ToolViewModel()
        {
            Search_Command = new RelayCommand(Search);
            Save_Command = new RelayCommand(Save);
        }

        public ToolViewModel(Tool item)
        {
            Search_Command = new RelayCommand(Search);
            Save_Command = new RelayCommand(Save);
            UpdateDataGrid(item);
        }

        private void Search(object sender)
        {
            MyAPIClient myApi = new MyAPIClient();

            var tool = myApi.Get<Tool>(MyAPIClient.CONTROLLER.Tools, Tool.IdTool);

            if (tool == null)
            {
                MessageBox.Show($"IdTool:  {Tool.IdTool} non trovato");
            }
            else
            {
                UpdateDataGrid(tool);
                MessageBox.Show($"IdTool:  {Tool.IdTool} BoschCode:{Tool.BoschCode} trovato");
            }
        }

        private void Save(object sender)
        
        
        {
            MyAPIClient myApi = new MyAPIClient();            

            var modified = myApi.Put<Tool>(MyAPIClient.CONTROLLER.Tools, Tool);
            if (modified)
            {
                MessageBox.Show($"IdTool:  {Tool.IdTool} modificato");
            }
            else
            {
                MessageBox.Show($"IdTool:  {Tool.IdTool} non modificato");
            }

            Search(sender);
        }

        private void UpdateDataGrid(Tool item)
        {
            Tool = item;
        }
    }
}
