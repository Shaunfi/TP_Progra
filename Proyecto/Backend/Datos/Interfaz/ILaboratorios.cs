﻿namespace Backend.Datos.Interfaz
{
    public interface ILaboratorios
    {
        string Consultar(int codLaboratorio);
        List<object> Listar();
    }
}
