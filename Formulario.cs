using System;

public class Formulario <T>{
    public string titulo{get;set;}
    public  string fecha {get;set;}
    public  double Ni {get; set;} // deducimos que esta es la Nota
    T[] item = new T[10];

    //Random rnd = new Random();
    public Formulario(int num,T item,string titulo, string fecha){
        for(int i = 0; i<num;i++){
            this.item[i] = item;
        }
        this.titulo = titulo;
        this.fecha = fecha;
    }

    public void setNota(int num){
        this.Ni = num;
    }

    

}