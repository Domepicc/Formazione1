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
    public class ToolMachineComboBoxViewModel : DataContextBase
    {
        Tool _ToolItem = new Tool();
        List<Machine> _Machines = new List<Machine>();
        List<Machine> _CodeMachines = new List<Machine>();
        Machine _SelectedItem;

        public Tool ToolItem
        {
            get
            {
                return _ToolItem;
            }
            set
            {
                _ToolItem = value;
                OnPropertyChanged("ToolItem");
            }
        }

        public Machine SelectedItem
        {
            get
            {
                return _SelectedItem;
            }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public List<Machine> CodeMachines
        {
            get
            {
                return _CodeMachines;
            }
            set
            {
                _CodeMachines = value;
                OnPropertyChanged("CodeMachines");
            }
        }


        public RelayCommand SearchTool_Command { get; set; }
        public RelayCommand AddMachineAtTool_Command { get; set; }
        public RelayCommand GetMachine_Command { get; set; }

        public ToolMachineComboBoxViewModel()
        {
            SearchTool_Command = new RelayCommand(SearchTool);
            AddMachineAtTool_Command = new RelayCommand(AddMachineAtTool);
            GetMachine_Command = new RelayCommand(GetMachine);
        }

        public void SearchTool (object sender)
        {
            List<string> machineExcept = new List<string>();
            List<Machine> machinesTemp = new List<Machine>();

            MyAPIClient myAPI = new MyAPIClient();

            var tool = myAPI.Get<Tool>(MyAPIClient.CONTROLLER.Tools, ToolItem.IdTool);

            if (tool == null)
            {
                MessageBox.Show($"IdTool:  {ToolItem.IdTool} non trovato");
            }
            else
            {
                ToolItem = tool;

                machineExcept = myAPI.GetMachinesCodeExcepted(MyAPIClient.CONTROLLER.Tools, tool.IdTool);
                CodeMachines.Clear();
                
                foreach ( string s in machineExcept)
                {
                    machinesTemp.Add(myAPI.Get<Machine>(MyAPIClient.CONTROLLER.Machines, s));
                }
                CodeMachines = machinesTemp;
                MessageBox.Show($"IdTool:  {ToolItem.IdTool} BoschCode:{tool.BoschCode} trovato");

            }
        }

        public void AddMachineAtTool(object sender)
        {
            MyAPIClient myAPI = new MyAPIClient();

            ToolMachine item = new ToolMachine(ToolItem.IdTool, SelectedItem.MachineCode);
            myAPI.Post<ToolMachine>(MyAPIClient.CONTROLLER.ToolMachine , item);
            MessageBox.Show($"Method AddMachineAtTool: {SelectedItem.MachineCode}");
            SearchTool(sender);
        }

        public void GetMachine(object sender)
        {
            MessageBox.Show("Method GetMachine");
        }
    }
}
