<<<<<<< HEAD
﻿namespace TPPepas.Datos.Interfaz
=======
﻿namespace Backend.Datos.Interfaz
>>>>>>> fcad98686c3f9488ee4943b6662e3ae37574364a
{
    public interface ITablasAuxiliares
    {
        List<object> ListarTiposProductos();
        List<object> ListarTiposPresentacion();
        List<object> ListarBarrios(int codCiudad);
        List<object> ListarCiudades();
        List<object> ListarMutuales();
        List<object> ListarTiposDocumento();
        List<object> ListarTiposRecetas();
        List<object> ListarFormasDePago();
        string ConsultarTipoProductos(int codProducto);
        string ConsultarMutual(int codCliente);
        string ConsultarFormaPago(int codFormaPago);
        int ConsultarCiudades(int codBarrio);
    }
}
