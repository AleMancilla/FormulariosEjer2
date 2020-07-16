using System;

public class Materia<T>{
    public string sigla {get;set;}
    public string docente {get;set;}
    public char paralelo {get;set;}
    public Estudiante<T>[] E = new Estudiante<T>[100];

    int index ;

    public Materia(string sigla, string doncente, char paralelo){
        this.sigla = sigla;
        this.docente = docente;
        this.paralelo = paralelo;
        this.index = 0;
    }

    public void adicionarEstudiante(Estudiante<T> e){
        this.E[index] = e;
        this.index++;
    }

    public void mostrarEstudiantesConMejorNota(){
        Console.WriteLine("\nLos  estudiantes que sacaron una nota superior a 70 (maximas notas) son:");
        for(int i = 0; i<this.index; i++){
            double nota = this.E[i].getNota();
            if(nota > 70){
                Console.WriteLine(" - {0} , con una nota de: {1}",this.E[i].Nombre,nota);
            }
        }
    }

    public void mostrarEstNoPresentaron(){
        Console.WriteLine("\nLos  estudiantes que NO PRESENTARON LA ENTREGA DE PROYECTO:");
        for(int i = 0; i<this.index; i++){
            double nota = this.E[i].getNota();
            if(nota == 0){
                Console.WriteLine(" - {0} , con una nota de: {1}",this.E[i].Nombre,nota);
            }
        }
    }
    public void materiasQueEvaluan(string tema){
        //Console.WriteLine("\nLos  estudiantes que Evaluan {0} son:", tema);
        for(int i = 0; i<this.index; i++){
            string titulo = this.E[i].getTitulo();
            //Console.WriteLine("\n########### t  {0}", titulo);
            //Console.WriteLine("\n########### te {0}", tema);

            if(titulo == tema){
                Console.WriteLine("\n########### {0}", sigla);
                Console.WriteLine(" - {0} , la materia evalua: {1}",sigla,tema);
                break;
            }
        }
    }

    
}