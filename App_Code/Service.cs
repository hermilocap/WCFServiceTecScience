using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DBTecnoScienceModel;


// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{

    public void RegistraProducto(Productos producto)
    {
        try
        {

            using (DBTecnoScienceEntities2 entidad = new  DBTecnoScienceEntities2())
            {
                entidad.REGISTRARPRODUCTO(producto.IdProducto1, producto.Nombre_Producto1, producto.Cantidad_Existente1, producto.Precio_Unitario1,
                    producto.Categoria_Producto1, producto.Marca_Producto1,producto.Descripcion_Producto1,producto.ImagenMerc1);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }

    }

    public void RegistrarVentas(Ventas ventas)
    {
        try
        {

            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.REGISTRARVENTAS(ventas.Id_Ventas1, ventas.IdProducto1,ventas.Cantidad_Venta1,
                    ventas.Nombre_Producto1,ventas.FechaVenta1,ventas.Descuento1,ventas.Total_Venta1);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }
    }

    public void RegistrarProveedor(Proveedores proveedor)
    {
        try
        {

            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.REGISTRARPROVEEDORES(proveedor.IdProveedor1, proveedor.NombreProveedor1, proveedor.DireccionProveedor1, proveedor.TelefonoProveedor1, proveedor.CiudadProveedor1, proveedor.EstadoProveedor1);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }
    }

    public void RegistrarCompras(Compras compras)
    {
        try
        {

            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.REGISTRARCOMPRAS(compras.IdCompra1,compras.IdProducto1,compras.IdProveedor1,compras.NombreProveedor1,compras.FechaDeCompra1,compras.CantidadComprada1,compras.Total_Compra1);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }

    }

    public Productos ConsultaIndividualProducto(string IdProducto)
    {
        Productos producto = null; //Guardará los datos que se enviaran al cliente

        using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
        {
            var productoEncontrado = entidad.BUSCARPRODUCTO(IdProducto);
            if (productoEncontrado != null)
            {
                foreach (var item in productoEncontrado)
                {
                    producto = new Productos();
                    producto.IdProducto1 = item.IdProducto;
                    producto.Nombre_Producto1 = item.Nombre_Producto;
                    producto.Cantidad_Existente1 = item.Cantidad_Existente;
                    producto.Precio_Unitario1 = item.Precio_Unitario;
                    producto.Categoria_Producto1 = item.Categoria_Producto;
                    producto.Marca_Producto1 = item.Marca_Producto;
                    producto.Descripcion_Producto1 = item.Descripcion_Producto;
                    producto.ImagenMerc1 = item.ImagenMerc;

                }


            }
        }
        return producto;
    }


    public  Ventas ConsultaIndividualVentas(string IdVenta)
    {
        Ventas venta = null; //Guardará los datos que se enviaran al cliente

        using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
        {
            var ventaEncontrado = entidad.BUSCARVENTA(IdVenta);
            if (ventaEncontrado != null)
            {
                foreach (var item in ventaEncontrado)
                {
                    venta=new Ventas();
                    venta.Id_Ventas1 = item.Id_Ventas;
                    venta.IdProducto1 = item.IdProducto;
                    venta.Cantidad_Venta1 = item.Cantidad_Venta;
                    venta.Nombre_Producto1 = item.Nombre_Producto;
                    venta.FechaVenta1 = item.FechaVenta;
                    venta.Descuento1 = item.Descuento;
                    venta.Total_Venta1 = item.Total_Venta;

                }


            }
        }
        return venta;
    }

    public Proveedores ConsultaIndividualProveedores(string Idproveedor)
    {
        Proveedores proveedores = null; //Guardará los datos que se enviaran al cliente

        using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
        {
            var provEncontrado = entidad.BUSCARPROVEEDORES(Idproveedor);
            if (provEncontrado != null)
            {
                foreach (var item in provEncontrado)
                {
                    proveedores = new Proveedores();
                    proveedores.IdProveedor1 = item.IdProveedor;
                    proveedores.NombreProveedor1 = item.NombreProveedor;
                    proveedores.DireccionProveedor1 = item.DireccionProveedor;
                    proveedores.TelefonoProveedor1 = item.TelefonoProveedor;
                    proveedores.CiudadProveedor1 = item.CiudadProveedor;
                    proveedores.EstadoProveedor1 = item.EstadoProveedor;

                }


            }
        }
        return proveedores;
    }

    public Compras ConsultaIndividualCompras(string IdCompra)
    {
        Compras compra = null; //Guardará los datos que se enviaran al cliente

        using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
        {
            var compraEncontrado = entidad.BUSCARCOMPRAS(IdCompra);
            if (compraEncontrado != null)
            {
                foreach (var item in compraEncontrado)
                {
                    compra = new Compras();
                    compra.IdCompra1 = item.IdCompra;
                    compra.IdProducto1 = item.IdProducto;
                    compra.IdProveedor1 = item.IdProveedor;
                    compra.NombreProveedor1 = item.Nombre_Proveedor;
                    compra.FechaDeCompra1 = item.FechaDeCompra;
                    compra.CantidadComprada1 = item.CantidadComprada;
                    compra.Total_Compra1 = item.TotalCompra;

                }
            }
        }
        return compra;
    }


    public List<Productos> ConsultaGeneralProductos()
    {

        List<Productos> listaProductos = new List<Productos>();

        Productos producto = null;

        using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
        {
            var productoEncontrado = entidad.CONSULTAGENERALPRODUCTO();

            if (productoEncontrado != null)
            {
                foreach (var item in productoEncontrado)
                {
                    producto = new Productos();
                    producto.IdProducto1 = item.IdProducto;
                    producto.Nombre_Producto1 = item.Nombre_Producto;
                    producto.Cantidad_Existente1 = item.Cantidad_Existente;
                    producto.Precio_Unitario1 = item.Precio_Unitario;
                    producto.Categoria_Producto1 = item.Categoria_Producto;
                    producto.Marca_Producto1 = item.Marca_Producto;
                    producto.Descripcion_Producto1 = item.Descripcion_Producto;
                    producto.ImagenMerc1 = item.ImagenMerc;
                    listaProductos.Add(producto);

                }
            }
        }

        return listaProductos;
    }

    public void EliminarProductos(string IdProducto)
    {
        try
        {
            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.ELIMINARPRODUCTO(IdProducto);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }

    }

    public void EliminarVentas(string IdVenta)
    {
        try
        {
            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.ELIMINARVENTAS( IdVenta);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }

    }

    public void EliminarProveedor(string IdProveedor)
    {
        try
        {
            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.ELIMINARPROVEEDORES(IdProveedor);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        } 

    }


    public void EliminarCompras(string IdCompra)
    {
        try
        {
            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.ELIMINARCOMPRAS( IdCompra);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }

    }

    public void ModificarProductos(Productos producto)
    {
        try
        {
            using (DBTecnoScienceEntities2 entidad = new DBTecnoScienceEntities2())
            {
                entidad.MODIFICARPRODUCTO(producto.IdProducto1, producto.Nombre_Producto1, producto.Cantidad_Existente1, producto.Precio_Unitario1,
                    producto.Categoria_Producto1, producto.Marca_Producto1, producto.Descripcion_Producto1, producto.ImagenMerc1);
                entidad.SaveChanges();
            }
        }
        catch (Exception)
        {

        }

    }


}




