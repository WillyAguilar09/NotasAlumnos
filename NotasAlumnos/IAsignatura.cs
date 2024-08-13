

namespace NotasAlumnos
{
    internal interface IAsignatura
    {
        
        double CalcularNotaFinal(double nota1, double nota2, double nota3);
        string MensajeNotaFinal(double NotaFinal);
        void Imprimir();
    }
}
