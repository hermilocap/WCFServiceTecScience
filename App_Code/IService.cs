using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

    [OperationContract]
    void RegistraProducto(Productos producto);

    [OperationContract]
    void RegistrarVentas(Ventas ventas);

    [OperationContract]
    void RegistrarProveedor(Proveedores proveedor);

    [OperationContract]
    void RegistrarCompras(Compras compras);

    [OperationContract]
    Productos ConsultaIndividualProducto(string IdProducto);
    
    //nuevo
    [OperationContract]
    Ventas ConsultaIndividualVentas(string IdVenta);
    
    //nuevo
    [OperationContract]
    Proveedores ConsultaIndividualProveedores(string Idproveedor);
    
    //nuevo
    [OperationContract]
    Compras ConsultaIndividualCompras(string IdCompra);

    [OperationContract]
    List<Productos> ConsultaGeneralProductos();
    
    [OperationContract]
    void EliminarProductos(string IdProducto);

    [OperationContract]
    void EliminarVentas(string IdVenta);

    [OperationContract]
    void EliminarProveedor(string Idproveedor);

    [OperationContract]
    void EliminarCompras(string IdCompra);

    [OperationContract]
    void ModificarProductos(Productos producto);

}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class Productos
{
    [DataMember]
    string IdProducto;

    public string IdProducto1
    {
        get { return IdProducto; }
        set { IdProducto = value; }
    }

    [DataMember]
    string Nombre_Producto;

    public string Nombre_Producto1
    {
        get { return Nombre_Producto; }
        set { Nombre_Producto = value; }
    }
    [DataMember]
    string Cantidad_Existente;

    public string Cantidad_Existente1
    {
        get { return Cantidad_Existente; }
        set { Cantidad_Existente = value; }
    }

    [DataMember]
    string Precio_Unitario;

    public string Precio_Unitario1
    {
        get { return Precio_Unitario; }
        set { Precio_Unitario = value; }
    }

    [DataMember]
    string Categoria_Producto;

    public string Categoria_Producto1
    {
        get { return Categoria_Producto; }
        set { Categoria_Producto = value; }
    }

    [DataMember]
    string Marca_Producto;

    public string Marca_Producto1
    {
        get { return Marca_Producto; }
        set { Marca_Producto = value; }
    }
 

    [DataMember]
    string Descripcion_Producto;

    public string Descripcion_Producto1
    {
        get { return Descripcion_Producto; }
        set { Descripcion_Producto = value; }
    }

    [DataMember]
    string ImagenMerc;

    public string ImagenMerc1
    {
        get { return ImagenMerc; }
        set { ImagenMerc = value; }
    }
}

[DataContract]
public class Proveedores
{

    [DataMember]
string IdProveedor;

public string IdProveedor1
{
  get { return IdProveedor; }
  set { IdProveedor = value; }
}

    [DataMember]
string NombreProveedor;

public string NombreProveedor1
{
  get { return NombreProveedor; }
  set { NombreProveedor = value; }
}

    [DataMember]
string DireccionProveedor;

public string DireccionProveedor1
{
  get { return DireccionProveedor; }
  set { DireccionProveedor = value; }
}

    [DataMember]
string TelefonoProveedor;

public string TelefonoProveedor1
{
  get { return TelefonoProveedor; }
  set { TelefonoProveedor = value; }
}

    [DataMember]
string CiudadProveedor;

public string CiudadProveedor1
{
  get { return CiudadProveedor; }
  set { CiudadProveedor = value; }
}

    [DataMember]
string EstadoProveedor;

public string EstadoProveedor1
{
  get { return EstadoProveedor; }
  set { EstadoProveedor = value; }
}

}

[DataContract]
public class Compras
{
    [DataMember]
    string IdCompra;

    public string IdCompra1
    {
        get { return IdCompra; }
        set { IdCompra = value; }
    }

    [DataMember]
    string IdProducto;

    public string IdProducto1
    {
        get { return IdProducto; }
        set { IdProducto = value; }
    }

    [DataMember]
    string IdProveedor;

    public string IdProveedor1
    {
      get { return IdProveedor; }
      set { IdProveedor = value; }
    }

    [DataMember]
    string NombreProveedor;

    public string NombreProveedor1
    {
      get { return NombreProveedor; }
      set { NombreProveedor = value; }
    }

    [DataMember]
    string FechaDeCompra;

    public string FechaDeCompra1
    {
        get { return FechaDeCompra; }
        set { FechaDeCompra = value; }
    }

    [DataMember]
    string CantidadComprada;

    public string CantidadComprada1
    {
        get { return CantidadComprada; }
        set { CantidadComprada = value; }
    }

    [DataMember]
    string Total_Compra;

    public string Total_Compra1
    {
        get { return Total_Compra; }
        set { Total_Compra = value; }
    } 
}

[DataContract]
public class Ventas
{
    [DataMember]
    string Id_Ventas;

    public string Id_Ventas1
    {
        get { return Id_Ventas; }
        set { Id_Ventas = value; }
    }

    [DataMember]
    string IdProducto;

    public string IdProducto1
    {
        get { return IdProducto; }
        set { IdProducto = value; }
    }

    [DataMember]
    string Cantidad_Venta;

    public string Cantidad_Venta1
    {
        get { return Cantidad_Venta; }
        set { Cantidad_Venta = value; }
    }

    [DataMember]
    string Nombre_Producto;

    public string Nombre_Producto1
    {
        get { return Nombre_Producto; }
        set { Nombre_Producto = value; }
    }

    [DataMember]
    string FechaVenta;

    public string FechaVenta1
    {
        get { return FechaVenta; }
        set { FechaVenta = value; }
    }

    [DataMember]
    string Descuento;

    public string Descuento1
    {
        get { return Descuento; }
        set { Descuento = value; }
    }

    [DataMember]
    string Total_Venta;

    public string Total_Venta1
    {
        get { return Total_Venta; }
        set { Total_Venta = value; }
    }
}




	

