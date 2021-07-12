using System;
using System.Collections.Generic;
public class Doctor
{
    public string Usuario{get;set;}
    public string Nombre {get;set;}
    public string Apellido{get;set;}
    public string Genero{get;set;}
    public string Nacionalidad{get;set;}
    public DateTime FechaNacimiento{get;set;}
    public string Especialidad{get;set;}
    public Doctor(string _usuario,string _nombre,string _apellido, string _genero, string _nacionalidad, DateTime _fecha, string _especialidad)
    {
        Usuario = _usuario;
        Nombre = _nombre;
        Apellido = _apellido;
        Genero = _genero;
        Nacionalidad = _nacionalidad;
        FechaNacimiento = _fecha;
        Especialidad = _especialidad;
    }
    public void Datos()
    {
        Console.WriteLine("-------------Mostrando datos------------------");
        Console.WriteLine("Usuario: " + Usuario);
        Console.WriteLine("Doctor: " + Nombre + " "+ Apellido);
        Console.WriteLine("Genero: " + Genero);
        Console.WriteLine("Nacionalidad: " + Nacionalidad);
        Console.WriteLine("Fecha de naciento: " + FechaNacimiento);
        Console.WriteLine("Especialidad: " + Especialidad);
    }
   
    public void VerCitas(List<Cita> citas)
    {
        foreach(var item in citas)
        {
            Console.WriteLine("Cita con el paciente: " + item.paciente + ", horario: " + item.horario);
        }
    }
    public void CitaAprovada(Cita nueva)
    {
        Console.WriteLine("Cita aprovada con el paciente:  "+ nueva.paciente );
        nueva.estado = "Aprovada";
    }
    public void CitaDenegada(Cita nueva)
    {
        Console.WriteLine("Cita denegada con el paciente:  "+ nueva.paciente );
        nueva.estado = "Aprovada";
    }

}