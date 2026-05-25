using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class EmpleadoHonorarios : Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario
        {
            get
            {
                return SueldoBase * 0.84m;  // Sueldo base menos impuestos
            }
        }

        public EmpleadoHonorarios(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por honorarios.");
        }

    }
}
