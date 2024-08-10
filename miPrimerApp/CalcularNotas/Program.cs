using CalcularNotas;
using CalcularNotas.Impuestos;
using CalcularNotas.Promedio;
using CalcularNotas.Test;

Calificaciones calificaciones = new Calificaciones();
calificaciones.CalcularNumeros();

CalcularSueldo sueldo = new CalcularSueldo();
sueldo.CalcularAbonoImpuesto();

CalificacionesYPromedio promedio = new CalificacionesYPromedio();
promedio.PromedioNotas();

CalcularNivelPostulante postulante = new CalcularNivelPostulante();
postulante.CalcularNivel();


Console.ReadLine(); 