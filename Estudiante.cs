using System;

public class Estudiante <T>: Persona {
        public Estudiante(string matricula, string fecha) 
        {
            this.matricula = matricula;
                this.fecha = fecha;
               
        }
            public string matricula {get;set;}
    public string fecha {get; set;}

    Formulario<T> F {get;set;}
    //Random random = new Random();
    double nota ;
    public Estudiante(string matricula, string fecha, string nombre, int edad, Formulario<T> form){
        this.matricula = matricula;
        this.fecha = fecha;
        this.Nombre = nombre;
        this.edad = edad;
        this.F = form;
    }

    public void setNota( int nota){
        //this.F.setNota(random.Next(20,100));
        //this.F = f;
        this.nota =nota;
        
    }
    public double getNota(){

        return this.nota;
    }

    public string getTitulo(){
        return F.titulo;
    }
}