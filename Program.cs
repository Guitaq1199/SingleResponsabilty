using System;
using System.Collections.Generic;

namespace Ejemplo1A
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var Doct = new Doctor("000012","Roberto Pedro","Pelaez Gomez", "Masculino", "guatemalteco",  Convert.ToDateTime("10/03/1988"),"Cardiologo");
           var Pact = new Paciente("000014","Edgar Jose","Paredes Orellana", "Masculino", "mexicano",  Convert.ToDateTime("11/05/1998"));
           
           Pact.Datos();
           Doct.Datos();
           var cita =new Cita();
           Pact.Cita(cita,"17:04:00","Malestar en el pecho", "Roberto Pedro Pelaez Gomez");
           List<Cita> citas = new List<Cita>();
           citas.Add(cita);
           Doct.VerCitas(citas);
           Doct.CitaAprovada(cita);

        }
    }
}
