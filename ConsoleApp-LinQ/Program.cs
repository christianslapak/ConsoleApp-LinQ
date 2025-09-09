namespace ConsoleApp_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[] Alumnos =
            {
                new Alumno() {Id = 1, Nombre = "Juan", Edad = 18},
                new Alumno() {Id = 2, Nombre = "Pedro", Edad = 21},
                new Alumno() {Id = 3, Nombre = "Sergio", Edad = 23},
                new Alumno() {Id = 4, Nombre = "Alejandro", Edad = 14},
                new Alumno() {Id = 5, Nombre = "Cecilia", Edad = 28},
                new Alumno() {Id = 6, Nombre = "Gaston", Edad = 31},
                new Alumno() {Id = 7, Nombre = "Ayelen", Edad = 17},
                new Alumno() {Id = 8, Nombre = "Yamila", Edad = 15},
            };

            Alumno[] Proceso = new Alumno[10];
            int g = 0;
            foreach (Alumno item in Alumnos)
            {
                if (item.Edad > 12 && item.Edad < 19)
                {
                    Proceso[g] = item;
                    g++;
                }
            }


            for (int i = 0; i < g; i++)
            {
                Console.WriteLine("Nombre: " + Proceso[i].Nombre + "  Edad:" + Proceso[i].Edad);
            }
            Console.ReadKey();


            Console.WriteLine("LinQ - Expresion de Consulta");
            // Expresion de Consulta
            var conultaAlumnoQE = from alu in Alumnos where alu.Edad >= 13 && alu.Edad <= 18 select alu;
            foreach (var itemAlu in conultaAlumnoQE)
            {
                Console.WriteLine("Nombre:" + itemAlu.Nombre + " Edad: " + itemAlu.Edad);
            }

            Console.ReadKey();

            // Expresion Lambda
            Console.WriteLine("LinQ - Expresion Lambda");
            var consultaAlumnoEL = Alumnos.Where(alum => alum.Edad >= 13 && alum.Edad <= 18);

            foreach (var itemAlumno in consultaAlumnoEL)
            {
                Console.WriteLine("Nombre:" + itemAlumno.Nombre + " Edad: " + itemAlumno.Edad);
            }

            Console.ReadKey();
        }
    }
}
