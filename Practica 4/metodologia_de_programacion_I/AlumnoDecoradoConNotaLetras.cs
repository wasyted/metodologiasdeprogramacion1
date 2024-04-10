using System;

namespace metodologia_de_programacion_I

public class AlumnoDecoradoConNotaLetras : AlumnoDecorador {
  AlumnoDecorado alumnoDecorado = new AlumnoDecorado();
  public override string mostrarCalificacion(){
    string[] notas = new string[] {"UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ"}
    string res = base.mostrarCalificacion();
    res += notas[alumnoDecorado.getCalificacion()];
  }
}