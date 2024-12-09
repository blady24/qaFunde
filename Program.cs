/*
name                : main_console_app.cs
author              : ELISEO FERNANDO ZULETA CANTI /BO OGBF998/
creation date       : 054120230424
DATEK_consultari v3.2 console ----ERROR REVISAR!
*/

using System;

namespace qa_funde
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Agenda Console App ===");
                Console.WriteLine("1. Register Person");
                Console.WriteLine("2. Update Person");
                Console.WriteLine("3. List Persons");
                Console.WriteLine("4. Register Contact");
                Console.WriteLine("5. Update Contact");
                Console.WriteLine("6. List Contacts");
                Console.WriteLine("7. Register Project");
                Console.WriteLine("8. Update Project");
                Console.WriteLine("9. List Projects");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RegisterPerson();
                        break;
                    case "2":
                        UpdatePerson();
                        break;
                    case "3":
                        ListPersons();
                        break;
                    case "4":
                        RegisterContact();
                        break;
                    case "5":
                        UpdateContact();
                        break;
                    case "6":
                        ListContacts();
                        break;
                    case "7":
                        RegisterProject();
                        break;
                    case "8":
                        UpdateProject();
                        break;
                    case "9":
                        ListProjects();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option :(, try again please :D");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void RegisterPerson()
        {
            var controller = new qa_funde.Controllers.cls_ctl_persona();
            Console.Write("\nEnter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();

            controller.CrearPersona(firstName, lastName, phone);
            Console.WriteLine("Person registered successfully!");
            Console.ReadKey();
        }

        static void UpdatePerson()
        {
            var controller = new qa_funde.Controllers.cls_ctl_persona();
            Console.Write("\nEnter Person ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();

            controller.ActualizarPersona(id, firstName, lastName, phone);
            Console.WriteLine("Person updated successfully!");
            Console.ReadKey();
        }

        static void ListPersons()
        {
            var controller = new qa_funde.Controllers.cls_ctl_persona();
            var data = controller.ListarPersonas();

            Console.WriteLine("\n=== Persons ===");
            foreach (System.Data.DataRow row in data.Rows)
            {
                Console.WriteLine($"ID: {row["id_persona"]}, Name: {row["nombre"]} {row["apellido"]}, Phone: {row["telefono"]}");
            }
            Console.ReadKey();
        }

        static void RegisterContact()
        {
            var controller = new qa_funde.Controllers.cls_ctl_contacto();
            Console.Write("\nEnter Contact Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Person ID: ");
            int personId = int.Parse(Console.ReadLine());

            controller.CrearContacto(name, email, personId);
            Console.WriteLine("Contact registered successfully!");
            Console.ReadKey();
        }

        static void UpdateContact()
        {
            var controller = new qa_funde.Controllers.cls_ctl_contacto();
            Console.Write("\nEnter Contact ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Contact Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Person ID: ");
            int personId = int.Parse(Console.ReadLine());

            controller.ActualizarContacto(id, name, email, personId);
            Console.WriteLine("Contact updated successfully!");
            Console.ReadKey();
        }

        static void ListContacts()
        {
            var controller = new qa_funde.Controllers.cls_ctl_contacto();
            var data = controller.ListarContactos();

            Console.WriteLine("\n=== Contacts ===");
            foreach (System.Data.DataRow row in data.Rows)
            {
                Console.WriteLine($"ID: {row["id_contacto"]}, Name: {row["nombre_contacto"]}, Email: {row["email"]}, Person ID: {row["id_persona"]}");
            }
            Console.ReadKey();
        }

        static void RegisterProject()
        {
            var controller = new qa_funde.Controllers.cls_ctl_proyecto();
            Console.Write("\nEnter Project Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            Console.Write("Enter Start Date (yyyy-MM-dd): ");
            string startDate = Console.ReadLine();
            Console.Write("Enter End Date (yyyy-MM-dd): ");
            string endDate = Console.ReadLine();
            Console.Write("Enter Person ID: ");
            int personId = int.Parse(Console.ReadLine());

            controller.CrearProyecto(name, description, startDate, endDate, personId);
            Console.WriteLine("Project registered successfully!");
            Console.ReadKey();
        }

        static void UpdateProject()
        {
            var controller = new qa_funde.Controllers.cls_ctl_proyecto();
            Console.Write("\nEnter Project ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Project Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            Console.Write("Enter Start Date (yyyy-MM-dd): ");
            string startDate = Console.ReadLine();
            Console.Write("Enter End Date (yyyy-MM-dd): ");
            string endDate = Console.ReadLine();
            Console.Write("Enter Person ID: ");
            int personId = int.Parse(Console.ReadLine());

            controller.ActualizarProyecto(id, name, description, startDate, endDate, personId);
            Console.WriteLine("Project updated successfully!");
            Console.ReadKey();
        }

        static void ListProjects()
        {
            var controller = new qa_funde.Controllers.cls_ctl_proyecto();
            var data = controller.ListarProyectos();

            Console.WriteLine("\n=== Projects ===");
            foreach (System.Data.DataRow row in data.Rows)
            {
                Console.WriteLine($"ID: {row["id_proyecto"]}, Name: {row["nombre"]}, Description: {row["descripcion"]}, Start Date: {row["fecha_inicio"]}, End Date: {row["fecha_fin"]}, Person ID: {row["id_persona"]}");
            }
            Console.ReadKey();
        }
    }
}
