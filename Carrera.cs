using System;

public class  Carrera<T>{
    string nm {get;set;} //nombre
    Materia<T> [] m = new Materia<T>[100];
    int index ;

    public Carrera(string nombre){
        this.nm = nombre;
        this.index = 0;
    }

    public void addMateria(Materia<T> mat){
        m[index] = mat;
        index++;
    }

    public void materiasQueEvaluan(string tema){
        Console.WriteLine("\nLas Materias que Evaluan {0} son:", tema);
        for(int i = 0; i<this.index; i++){
            string sigla = this.m[i].sigla;
            this.m[i].materiasQueEvaluan(tema);
        }
    }
}