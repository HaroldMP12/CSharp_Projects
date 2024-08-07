using CalcularSueldo.Calcular;
using CalcularSueldo.PrecioArticulo;
using CalcularSueldo.Producto_Suma;
using CalcularSueldo.SumaYPromedio;
using CalcularSueldo.Superficie;

CalcularSueldoOperario calcularSueldoOperario = new CalcularSueldoOperario();
CalcularPrecioArticulo calcularPrecioArticulo = new CalcularPrecioArticulo();
CalcularProducto calcularProducto = new CalcularProducto();
CalcularSumaYPromedio calcularSumaYPromedio = new CalcularSumaYPromedio();
CalcularSuperficie calcularSuperficie = new CalcularSuperficie();

calcularSueldoOperario.CalcularSueldo();
calcularPrecioArticulo.CalcularArticulo();
calcularProducto.CalcularProductoSuma();
calcularSumaYPromedio.CalcularSumaPromedio();
calcularSuperficie.CalcularLadosSuperficie();
Console.ReadLine();