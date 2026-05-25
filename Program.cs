using ClasesAbstractas;

EmpleadoHonorarios eh = new EmpleadoHonorarios("Santiago", "Desarrollador", 50000);
eh.Trabajar();
Console.WriteLine("Salario: {0}", eh.Salario);

EmpleadoNomina en = new EmpleadoNomina("Ana", "RH", 30000);
en.Trabajar();
Console.WriteLine("Salario: {0}", en.Salario);