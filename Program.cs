using System;

namespace Formulario_de_Evaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //instanciamos una carrera
            // inciso a
            Carrera<char> informatica = new Carrera<char>("Informatica");

            Formulario<char> evaluacion = new Formulario<char>(5, 'E', "Exposicion","03/09/2020");//5 items
            Formulario<char> evaluacion2 = new Formulario<char>(5, 'I', "Informe","03/10/2020");//5 items
            Estudiante<char> est1 = new Estudiante<char>("RU1754","2015","Alejandro",24,evaluacion);   est1.setNota(75);
            Estudiante<char> est2 = new Estudiante<char>("RU2453","2014","Karen",22,evaluacion);       est2.setNota(90);
            Estudiante<char> est3 = new Estudiante<char>("RU1546","2016","Lucy",23,evaluacion);        est3.setNota(65);
            Estudiante<char> est4 = new Estudiante<char>("RU1568","2018","Freddy",25,evaluacion);      est4.setNota(25);
            Estudiante<char> est5 = new Estudiante<char>("RU1964","2017","Wosito",20,evaluacion);      est5.setNota(0);

            
            Estudiante<char> mest1 = new Estudiante<char>("RU1754","2015","Alejandro2",24,evaluacion2);   est1.setNota(75);
            Estudiante<char> mest2 = new Estudiante<char>("RU2453","2014","Karen2",22,evaluacion2);       est2.setNota(90);
            Estudiante<char> mest3 = new Estudiante<char>("RU1546","2016","Lucy2",23,evaluacion2);        est3.setNota(65);

            Materia<char> LAB121 = new Materia<char>("LAB121","Lic Tarquino",'A');
            Materia<char> MAT114 = new Materia<char>("MAT114","Lic ERROZ",'C');

            LAB121.adicionarEstudiante(est1);
            LAB121.adicionarEstudiante(est2);
            LAB121.adicionarEstudiante(est3);
            LAB121.adicionarEstudiante(est4);
            LAB121.adicionarEstudiante(est5);

            MAT114.adicionarEstudiante(mest1);
            MAT114.adicionarEstudiante(mest2);
            MAT114.adicionarEstudiante(mest3);

            informatica.addMateria(LAB121);
            informatica.addMateria(MAT114);

            // inciso b
            LAB121.mostrarEstudiantesConMejorNota();

            // inciso c
            LAB121.mostrarEstNoPresentaron();

            // inciso d
            informatica.materiasQueEvaluan("Exposicion");

            
        }
    }
}
