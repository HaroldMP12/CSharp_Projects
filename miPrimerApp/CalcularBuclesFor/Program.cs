using CalcularBuclesFor.Calificaciones;
using CalcularBuclesFor.PromedioValores;
using CalcularBuclesFor.NotasAlumnos;

CalificacionesAlumnos buclesFor = new CalificacionesAlumnos();
buclesFor.CalcularCalificaciones();

CalcularSumaPromedioValores promedioValores = new CalcularSumaPromedioValores();
promedioValores.CalcularPromedio();

CalcularNotaAlumnos calcularNotaAlumnos = new CalcularNotaAlumnos();
calcularNotaAlumnos.CalcularCalifEstudiantes();

Console.ReadLine();
