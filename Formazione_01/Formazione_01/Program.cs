using Formazione_01.Domain;
using Formazione_01.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Formazione_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // In ambienti di produzione non instanziamo mai direttamente la classe service.
            // Utilizziamo un approccio chiamato IoC (Inversion of control) che vedremo più avanti
            var toolService = new ToolService();
            var turretService = new TurretService();
            var partNumberToolService = new PartNumberToolService();

            var tools = toolService.GetAll();
            var turrets = turretService.GetAll();


            var numberRow = toolService.GetNumberROw();

            //WriteLine("\nTest Tool\n");

            //foreach (var tool in tools)
            //    WriteLine(tool.IdTool + " " + tool.Description);

            //WriteLine("Total row: " + numberRow + "\n");
            //foreach (var turret in turrets)
            //    WriteLine(turret.TurretCode + " " + turret.Description);


            WriteLine("\nTest Turret\n");

            string idTest = "test";

            // test getById
            var newTurret = turretService.Create("test", "descrizione");

  

            // test add
            WriteLine("Add: " + turretService.Add(newTurret));

            var turretGetById = turretService.GetById(idTest);

            // test modifify
            turretGetById.Description = "descrizione cambiata";
            WriteLine("Mod: " + turretService.Modify(turretGetById, turretGetById.TurretCode));

          
            // test remove
            WriteLine("Rem: " + turretService.Remove(newTurret.TurretCode));

        


            string idTest2 = "test";
            string idTest3 = "descrizione";

            WriteLine("\nTest PartNumberTool\n");
            // test getById
            var item = partNumberToolService.Create(idTest2, idTest3);



            // test add
            WriteLine("Add: " + partNumberToolService.Add(item));

            var itemGetById = partNumberToolService.GetById(idTest2, idTest3);
          
            // test remove
            WriteLine("Rem: " + partNumberToolService.Remove(itemGetById.PartNumber, itemGetById.ToolCode));

            var partNumber = new PartNumberService();
            partNumber.PrintAll();

            var tool = toolService.GetById("1000");

            WriteLine($"Test tool.GetById {tool.BoschCode} {tool.Description}");

            var machineService = new MachineService();

            var machine = machineService.GetById("EMAG 1");

            var toolMachine = toolService.GetById("1016");

            var toolMachineService = new ToolMachineService();

            var machineList = toolMachineService.GetByIdTool("1014");

            foreach ( var m in machineList)
            {
                var mac = machineService.GetById(m.MachineCode);
                WriteLine($"\nmachine: {m.MachineCode} {mac.Description} {mac.Line} {mac.StoreToolsFileName}");
            }

            WriteLine($"test Machine: {machine.MachineCode} {machine.Description} {machine.Line} {machine.StoreToolsFileName}");
            
            foreach ( var m in machineService.GetAllMachineCode())
            {
                WriteLine($"test ReadAllCodeMachine: {m}");
            }


            ReadKey();
        }
    }
}
