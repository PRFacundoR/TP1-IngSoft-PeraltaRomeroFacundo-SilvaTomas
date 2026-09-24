namespace TP1_IngSoft;

using System.Reflection;
using Xunit;



public class UnitTest1
{
    

    [Fact]
    public void TestAgregarYBuscarProducto()
    {
        
        Tienda tienda = new Tienda();
        Producto producto = new Producto("Producto1", 10.0, "Categoria1");
        Producto producto2 = new Producto("Producto2", 20.0, "Categoria2");
        
        
        
        tienda.AgregarProducto(producto);

        Assert.NotNull(tienda.BuscarProducto("Producto1"));

        Assert.Equal(producto, tienda.BuscarProducto("Producto1"));

        Assert.NotEqual(producto, tienda.BuscarProducto("Producto2"));
        
        Assert.Null(tienda.BuscarProducto("ProductoInexistente"));
        
    }

    [Fact]
    public void TestEliminarProducto()
    {
        Tienda tienda = new Tienda();
        Producto producto = new Producto("Teclado", 2500, "Electronica");

        tienda.AgregarProducto(producto);

        Assert.NotNull(tienda.BuscarProducto("Teclado"));

        // Act: eliminamos el producto
        bool resultado2 = tienda.EliminarProducto("ProductoInexistente");
        bool resultado = tienda.EliminarProducto("Teclado");
        
        //assert: Verificamos resultado.
        Assert.True(resultado);
        Assert.False(resultado2);
        Assert.Null(tienda.BuscarProducto("Teclado"));
    }


    /*
    Preguntas conceptuales:
- ¿Puedes identificar pruebas de unidad y de integración en la práctica que se realizó?
    Si, las pruebas de unidad se enfoncan en probar modulos individaules, mientras que las pruebas de integración se enfocan en probar la interacción entre modulos
    
    */






}
