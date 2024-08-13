using NotasAlumnos;
Asignatura asignatura = new Asignatura();
Console.WriteLine("Ingrese Nombre del Alumno:");
asignatura.NombreAlumno = Console.ReadLine();
Console.WriteLine("Ingrese Numero de Cuenta:");
asignatura.NumeroCuenta = Console.ReadLine();
Console.WriteLine("Ingrese Correo Electronico");
asignatura.Email = Console.ReadLine();
Console.WriteLine("Ingrese Nombre de la Clase");
asignatura.Clase = Console.ReadLine();
Console.WriteLine("Ingrese el Horario de Clases");
asignatura.HClase = Console.ReadLine();
Console.WriteLine("Ingrese Nombre del Docente");
asignatura.NDocente = Console.ReadLine();


Console.WriteLine("Ingrese primer Nota:");
bool validN1 = double.TryParse(Console.ReadLine(), out double Nota1);

Console.WriteLine("Ingrese segunda Nota:");
bool validN2 = double.TryParse(Console.ReadLine(), out double Nota2);

Console.WriteLine("Ingrese tercera Nota:");
bool validN3 = double.TryParse(Console.ReadLine(), out double Nota3);

Console.WriteLine();
if (validN1 && validN2 && validN3)
{
    if (Nota1 <= 30 && Nota2<=30 && Nota3<=40)
    {
        asignatura.Nota1 = Nota1;
        asignatura.Nota2 = Nota2;
        asignatura.Nota3 = Nota3;
        asignatura.CalcularNotaFinal();
        asignatura.CalcularNotaFinal(asignatura.Nota1, asignatura.Nota2, asignatura.Nota3);
        asignatura.Imprimir();
    }
    else if(Nota1 > 30 || Nota2 > 30) {
    
        Console.WriteLine("Las Notas del primer y segundo Parcial No deben pasar de 30");
    } else
    {
        Console.WriteLine("La Nota del tercer parcial no debe ser mayor que 40");
    }
}
else
{
    Console.WriteLine("Uno de los valores o los valores ingresados no tiene el formato correcto...");
}