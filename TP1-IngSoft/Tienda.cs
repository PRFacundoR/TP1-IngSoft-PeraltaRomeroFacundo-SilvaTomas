namespace TP1_IngSoft;



public class Tienda
{
    // El inventario es una lista privada de objetos tipo Producto
    private List<Producto> inventario;

    // Constructor que inicializa la lista vacía
    public Tienda()
    {
        inventario = new List<Producto>();
    }

    // Método para agregar un producto
    public void AgregarProducto(Producto producto)
    {
        inventario.Add(producto);
    }

    // Método para buscar un producto por su nombre
    public Producto BuscarProducto(string nombre)
    {
        foreach (var producto in inventario)
        {
            if (producto.Nombre == nombre)
            {
                return producto; // Retorna el objeto encontrado
            }
        }
        return null; // Retorna null si no lo encuentra (equivalente a None en Python)
    }

    // Método para eliminar un producto por su nombre
    public bool EliminarProducto(string nombre)
    {
        foreach (var producto in inventario)
        {
            if (producto.Nombre == nombre)
            {
                inventario.Remove(producto);
                return true; // Eliminación exitosa
            }
        }
        return false; // No se encontró el producto
    }
}