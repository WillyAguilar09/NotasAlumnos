
namespace NotasAlumnos
    
{
   
    public class Asignatura: Alumno,IAsignatura
    {
            

        public double Nota1 {  get; set; }

        public double Nota2 {  get; set; }
        
        public double Nota3 {  get; set; }
        public double notaFinal { get; set; }
        public string Mensaje {  get; set; }
        public string Clase {  get; set; }
        public string HClase {  get; set; }
        public string NDocente { get; set; }
        public double CalcularNotaFinal(double Nota1, double Nota2, Double Nota3)
        {
            notaFinal=Nota1 + Nota2+Nota3;
            return notaFinal;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal <= 59)
            {
                return "Reprobado";
            }else if (notaFinal <= 79)
            {
                return "Bueno";
            }else if (notaFinal <= 89)
            {
                return "Muy Bueno";
            }else if (notaFinal <= 100)
            {
                return "Sobresaliente";
            }else { return "Nota no Valida";
            }

        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre del Estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico: {Email}");
            Console.WriteLine($"Nombre de la Clase: {Clase}");
            Console.WriteLine($"Horario: {HClase}");
            Console.WriteLine($"Nombre del Docente: {NDocente}");
            Console.WriteLine($"Nota Final: {notaFinal}, - {MensajeNotaFinal}");

        }
    }
 }

