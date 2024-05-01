using System;
public class empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public int Tel { get; set; }
        public Boolean Estado { get; set; }

        public empleado(string nombre, String apellido, String rol, int tel, Boolean estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Rol = rol;
            Tel = tel;
            Estado = estado;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Rol: {Rol}, Telefono: {Tel}, Estado: {Estado}";
        }
    }
    class program
    {
        static void Main()
        {
            empleado[] empleados = new empleado[3];

            empleados[0] = new empleado("miguel", "perez", "admin", 5046759, true);
            empleados[1] = new empleado("jatdt", "tuiran", "gerente", 5032930, false);
            empleados[2] = new empleado("steven", "villa", "vendedor", 5407683, true);

            Console.WriteLine("Lista de empleados: ");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }
    }