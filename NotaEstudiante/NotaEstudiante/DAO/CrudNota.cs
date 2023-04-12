using NotaEstudiante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaEstudiante.DAO
{
    public class CrudNota
    {
        public void AgregarNota(Notum ParametroNota)
        {
            using (NotaEstudianteContext db =
                new NotaEstudianteContext())
            {
                Notum notum = new Notum();
                notum.NombreEstudiante = ParametroNota.NombreEstudiante;
                notum.Materia = ParametroNota.Materia;
                notum.Lab1 = ParametroNota.Lab1;
                notum.Parcial1 = ParametroNota.Parcial1;
                notum.Lab2 = ParametroNota.Lab2;
                notum.Parcial2 = ParametroNota.Parcial2;
                notum.Lab3 = ParametroNota.Lab3;
                notum.Parcial3 = ParametroNota.Parcial3;
                notum.Resultado = ParametroNota.Resultado;
                db.Add(notum);
                db.SaveChanges();
            }
        }

     
            decimal NotaF1;
            decimal NotaF2;
            decimal NotaF3;
            decimal PorcentajeLab = 0.4M;
            decimal PorcentajePar = 0.6M;

            public decimal Total(Notum nota)
            {
               NotaF1 = nota.Lab1 * PorcentajeLab + nota.Parcial1 * PorcentajePar;
               NotaF2 = nota.Lab2 * PorcentajeLab + nota.Parcial2 * PorcentajePar;
               NotaF3 = nota.Lab3 * PorcentajeLab + nota.Parcial3 * PorcentajePar;

               nota.Resultado.ToString("F1");
               return nota.Resultado = (NotaF1 + NotaF2 + NotaF3) / 3;
            }

    }
}