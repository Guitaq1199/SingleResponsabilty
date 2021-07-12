using System;
public class Paciente
{
    public string Usuario{get;set;}
    public string Nombre {get;set;}
    public string Apellido{get;set;}
    public string Genero{get;set;}
    public string Nacionalidad{get;set;}
    public DateTime FechaNacimiento{get;set;}

    public Paciente(string _usuario,string _nombre,string _apellido, string _genero, string _nacionalidad, DateTime _fecha)
    {
        Usuario = _usuario;
        Nombre = _nombre;
        Apellido = _apellido;
        Genero = _genero;
        Nacionalidad = _nacionalidad;
        FechaNacimiento = _fecha;
    }
    public void Datos()
    {
        Console.WriteLine("-------------Mostrando datos------------------");
        Console.WriteLine("Usuario: " + Usuario);
        Console.WriteLine("Paciente: " + Nombre + " "+ Apellido);
        Console.WriteLine("Genero: " + Genero);
        Console.WriteLine("Nacionalidad: " + Nacionalidad);
        Console.WriteLine("Fecha de naciento: " + FechaNacimiento);
    }
    public void Cita(Cita nueva, string horario, string causa, string doctor)
    {
        Console.WriteLine("Agendando cita");
        nueva.paciente = Nombre;
        nueva.horario = horario;
        nueva.causa = causa;
        nueva.doctor = doctor;
        nueva.estado = "Pendiente";
        Console.WriteLine("Esperar aprovación del médico");

    }
 

}