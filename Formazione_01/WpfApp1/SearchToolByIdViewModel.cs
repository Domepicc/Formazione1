using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Formazione_01.Domain;
using Formazione_01.Service;

namespace WpfApp
{
    public class SearchToolByIdViewModel : DataContextBase
    {
        Tool _ToolSelectedItem = new Tool();
        Tool _ToolSelectedItemGrid = new Tool();

        public List<Tool> _ToolItemsSource;

        public List<Tool> ToolItemsSource
        {
            get
            {
                return _ToolItemsSource;
            }
            set
            {
                _ToolItemsSource = value;
                OnPropertyChanged("ToolItemsSource");
            }
        }

        public Tool ToolSelectedItem
        {
            get
            {
                return _ToolSelectedItem;
            }
            set
            {
                _ToolSelectedItem = value;
                OnPropertyChanged("ToolSelectedItem");
            }
        }

        public Tool ToolSelectedItemGrid
        {
            get
            {
                return _ToolSelectedItemGrid;
            }
            set
            {
                _ToolSelectedItemGrid = value;
                OnPropertyChanged("ToolSelectedItemGrid");
            }
        }


        public RelayCommand SearchWithPartialId_Command { get; set; }
        public RelayCommand Modify_Command { get; set; }

        public SearchToolByIdViewModel()
        {
            SearchWithPartialId_Command = new RelayCommand(SearchWithPartialId);
            Modify_Command = new RelayCommand(ModifyRow);
        }


        private void ModifyRow(object sender)
        {
            Tool item = (Tool) ToolSelectedItemGrid;

            MainWindow mainWindow = new MainWindow(item);

            mainWindow.Show();
        }

        private void SearchWithPartialId(object sender)
        {
   
            MyAPIClient myAPI = new MyAPIClient();
            List<Tool> ToolItemFind = myAPI.GetToolsByPartialId(MyAPIClient.CONTROLLER.Tools, ToolSelectedItem.IdTool);

            if (ToolItemFind == null)
            {
                MessageBox.Show($"IdTool:  {ToolSelectedItem.IdTool} non trovato");
            }
            else
            {
                ToolItemsSource = ToolItemFind;
               
                MessageBox.Show($"IdTool:  {ToolSelectedItem.IdTool} trovato");
                
            }

        }

    }
}
