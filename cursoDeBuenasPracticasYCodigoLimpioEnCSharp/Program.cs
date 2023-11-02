using System;
using System.Collections.Generic;
using System.Diagnostics;

#region Clase 4 - Descarga y análisis del proyecto a trabajar
//namespace cursoDeBuenasPracticasYCodigoLimpioEnCSharp
//{
//    internal class Program
//    {
//        public static List<string> TL { get; set; }

//        static void Main(string[] args)
//        {
//            TL = new List<string>();
//            int variable = 0;
//            do
//            {
//                variable = ShowMainMenu();
//                if (variable == 1)
//                {
//                    ShowMenuAdd();
//                }
//                else if (variable == 2)
//                {
//                    ShowMenuDos();
//                }
//                else if (variable == 3)
//                {
//                    ShowMenuTres();
//                }
//            } while (variable != 4);
//        }
//        /// <summary>
//        /// Show the main menu 
//        /// </summary>
//        /// <returns>Returns option indicated by user</returns>
//        public static int ShowMainMenu()
//        {
//            Console.WriteLine("----------------------------------------");
//            Console.WriteLine("Ingrese la opción a realizar: ");
//            Console.WriteLine("1. Nueva tarea");
//            Console.WriteLine("2. Remover tarea");
//            Console.WriteLine("3. Tareas pendientes");
//            Console.WriteLine("4. Salir");

//            // Read line
//            string line = Console.ReadLine();
//            return Convert.ToInt32(line);
//        }

//        public static void ShowMenuDos()
//        {
//            try
//            {
//                Console.WriteLine("Ingrese el número de la tarea a remover: ");
//                // Show current taks
//                for (int i = 0; i < TL.Count; i++)
//                {
//                    Console.WriteLine((i + 1) + ". " + TL[i]);
//                }
//                Console.WriteLine("----------------------------------------");

//                string line = Console.ReadLine();
//                // Remove one position
//                int indexToRemove = Convert.ToInt32(line) - 1;
//                if (indexToRemove > -1)
//                {
//                    if (TL.Count > 0)
//                    {
//                        string task = TL[indexToRemove];
//                        TL.RemoveAt(indexToRemove);
//                        Console.WriteLine("Tarea " + task + " eliminada");
//                    }
//                }
//            }
//            catch (Exception)
//            {
//            }
//        }

//        public static void ShowMenuAdd()
//        {
//            try
//            {
//                Console.WriteLine("Ingrese el nombre de la tarea: ");
//                string task = Console.ReadLine();
//                TL.Add(task);
//                Console.WriteLine("Tarea registrada");
//            }
//            catch (Exception)
//            {
//            }
//        }

//        public static void ShowMenuTres()
//        {
//            if (TL == null || TL.Count == 0)
//            {
//                Console.WriteLine("No hay tareas por realizar");
//            }
//            else
//            {
//                Console.WriteLine("----------------------------------------");
//                for (int i = 0; i < TL.Count; i++)
//                {
//                    Console.WriteLine((i + 1) + ". " + TL[i]);
//                }
//                Console.WriteLine("----------------------------------------");
//            }
//        }
//    }
//}
#endregion

#region Clase 5 - Nombramiento
//namespace cursoDeBuenasPracticasYCodigoLimpioEnCSharp
//{
//    internal class Program
//    {
//        public static List<string> TaskList { get; set; }

//        static void Main(string[] args)
//        {
//            TaskList = new List<string>();
//            int menuSelected = 0;
//            do
//            {
//                menuSelected = ShowMainMenu();
//                if (menuSelected == 1)
//                {
//                    ShowMenuAdd();
//                }
//                else if (menuSelected == 2)
//                {
//                    ShowMenuRemove();
//                }
//                else if (menuSelected == 3)
//                {
//                    ShowMenuTaskList();
//                }
//            } while (menuSelected != 4);
//        }
//        /// <summary>
//        /// Show the main menu 
//        /// </summary>
//        /// <returns>Returns option indicated by user</returns>
//        public static int ShowMainMenu()
//        {
//            Console.WriteLine("----------------------------------------");
//            Console.WriteLine("Ingrese la opción a realizar: ");
//            Console.WriteLine("1. Nueva tarea");
//            Console.WriteLine("2. Remover tarea");
//            Console.WriteLine("3. Tareas pendientes");
//            Console.WriteLine("4. Salir");

//            // Read line
//            string numberMenuSelected = Console.ReadLine();
//            return Convert.ToInt32(numberMenuSelected);
//        }

//        public static void ShowMenuRemove()
//        {
//            try
//            {
//                Console.WriteLine("Ingrese el número de la tarea a remover: ");
//                // Show current taks
//                for (int i = 0; i < TaskList.Count; i++)
//                {
//                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
//                }
//                Console.WriteLine("----------------------------------------");

//                string indexTaskOfList = Console.ReadLine();
//                // Remove one position
//                int indexToRemove = Convert.ToInt32(indexTaskOfList) - 1;
//                if (indexToRemove > -1)
//                {
//                    if (TaskList.Count > 0)
//                    {
//                        string task = TaskList[indexToRemove];
//                        TaskList.RemoveAt(indexToRemove);
//                        Console.WriteLine("Tarea " + task + " eliminada");
//                    }
//                }
//            }
//            catch (Exception)
//            {
//            }
//        }

//        public static void ShowMenuAdd()
//        {
//            try
//            {
//                Console.WriteLine("Ingrese el nombre de la tarea: ");
//                string descriptionTask = Console.ReadLine();
//                TaskList.Add(descriptionTask);
//                Console.WriteLine("Tarea registrada");
//            }
//            catch (Exception)
//            {
//            }
//        }

//        public static void ShowMenuTaskList()
//        {
//            if (TaskList == null || TaskList.Count == 0)
//            {
//                Console.WriteLine("No hay tareas por realizar");
//            }
//            else
//            {
//                Console.WriteLine("----------------------------------------");
//                for (int i = 0; i < TaskList.Count; i++)
//                {
//                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
//                }
//                Console.WriteLine("----------------------------------------");
//            }
//        }
//    }
//}
#endregion

#region Clase 6 - Code Smells
//namespace cursoDeBuenasPracticasYCodigoLimpioEnCSharp
//{
//    internal class Program
//    {
//        public static List<string> TaskList { get; set; }

//        static void Main(string[] args)
//        {
//            TaskList = new List<string>();
//            int menuSelected = 0;
//            do
//            {
//                menuSelected = ShowMainMenu();
//                if ((Menu)menuSelected == Menu.Add)
//                {
//                    ShowMenuAdd();
//                }
//                else if ((Menu)menuSelected == Menu.Remove)
//                {
//                    ShowMenuRemove();
//                }
//                else if ((Menu)menuSelected == Menu.List)
//                {
//                    ShowMenuTaskList();
//                }
//            } while ((Menu)menuSelected != Menu.Exit);
//        }
//        /// <summary>
//        /// Show the main menu 
//        /// </summary>
//        /// <returns>Returns option indicated by user</returns>
//        public static int ShowMainMenu()
//        {
//            Console.WriteLine("----------------------------------------");
//            Console.WriteLine("Ingrese la opción a realizar: ");
//            Console.WriteLine("1. Nueva tarea");
//            Console.WriteLine("2. Remover tarea");
//            Console.WriteLine("3. Tareas pendientes");
//            Console.WriteLine("4. Salir");

//            // Read line
//            string numberMenuSelected = Console.ReadLine();
//            return Convert.ToInt32(numberMenuSelected);
//        }

//        public static void ShowMenuRemove()
//        {
//            try
//            {
//                Console.WriteLine("Ingrese el número de la tarea a remover: ");
//                // Show current taks
//                for (int i = 0; i < TaskList.Count; i++)
//                {
//                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
//                }
//                Console.WriteLine("----------------------------------------");

//                string indexTaskOfList = Console.ReadLine();
//                // Remove one position
//                int indexToRemove = Convert.ToInt32(indexTaskOfList) - 1;
//                if (indexToRemove > -1)
//                {
//                    if (TaskList.Count > 0)
//                    {
//                        string task = TaskList[indexToRemove];
//                        TaskList.RemoveAt(indexToRemove);
//                        Console.WriteLine("Tarea " + task + " eliminada");
//                    }
//                }
//            }
//            catch (Exception)
//            {
//            }
//        }

//        public static void ShowMenuAdd()
//        {
//            try
//            {
//                Console.WriteLine("Ingrese el nombre de la tarea: ");
//                string descriptionTask = Console.ReadLine();
//                TaskList.Add(descriptionTask);
//                Console.WriteLine("Tarea registrada");
//            }
//            catch (Exception)
//            {
//            }
//        }

//        public static void ShowMenuTaskList()
//        {
//            if (TaskList == null || TaskList.Count == 0)
//            {
//                Console.WriteLine("No hay tareas por realizar");
//            }
//            else
//            {
//                Console.WriteLine("----------------------------------------");
//                for (int i = 0; i < TaskList.Count; i++)
//                {
//                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
//                }
//                Console.WriteLine("----------------------------------------");
//            }
//        }
//    }

//    public enum Menu
//    {
//        Add = 1,
//        Remove = 2,
//        List = 3,
//        Exit = 4
//    }
//}
#endregion

#region Clase 7 - Principio DRY
namespace cursoDeBuenasPracticasYCodigoLimpioEnCSharp
{
    internal class Program
    {
        public static List<string> TaskList { get; set; }

        static void Main(string[] args)
        {
            TaskList = new List<string>();
            int menuSelected = 0;
            do
            {
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowTaskList(TaskList);
                }
            } while ((Menu)menuSelected != Menu.Exit);
        }
        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
        public static int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            // Read line
            string numberMenuSelected = Console.ReadLine();
            return Convert.ToInt32(numberMenuSelected);
        }

        public static void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                ShowTaskList(TaskList);

                string indexTaskOfList = Console.ReadLine();
                // Remove one position
                int indexToRemove = Convert.ToInt32(indexTaskOfList) - 1;
                if (indexToRemove > -1 && TaskList.Count > 0)
                {
                    string task = TaskList[indexToRemove];
                    TaskList.RemoveAt(indexToRemove);
                    Console.WriteLine("Tarea " + task + " eliminada");
                }
            }
            catch (Exception)
            {
            }
        }

        public static void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string descriptionTask = Console.ReadLine();
                TaskList.Add(descriptionTask);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception)
            {
            }
        }

        public static void ShowMenuTaskList()
        {
            if (TaskList == null || TaskList.Count == 0)
            {
                Console.WriteLine("No hay tareas por realizar");
            }
            else
            {
                ShowTaskList(TaskList);
            }
        }

        public static void ShowTaskList(List<string> taskList)
        {
            Console.WriteLine("----------------------------------------");
            int indexTask = 1;
            taskList.ForEach(element => Console.WriteLine((indexTask++) + ". " + element));
            
            Console.WriteLine("----------------------------------------");
        }
    }

    public enum Menu
    {
        Add = 1,
        Remove = 2,
        List = 3,
        Exit = 4
    }
}
#endregion