using SingleResponsability;

StudentRepository studentRepository = new();
// Al mover el método Export de la clase StudentRepository.cs a la clase "ExportHelper.cs"
// Ya no se requiere esta linea en el Program.cs
// studentRepository.Export();

// Para poder exportar esta información el cambio que se realiza es
// pasar la lista de estudiantes al método exportar de la clase "ExportHelper"
ExportHelper exportHelper = new ExportHelper(); //Se instancia la clase
exportHelper.ExportStudents(studentRepository.GetAll()); // Se pasa la lista al método de exportar.

Console.WriteLine("Proceso Completado");