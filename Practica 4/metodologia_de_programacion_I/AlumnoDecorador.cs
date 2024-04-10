using System;

namespace metodologia_de_programacion_I

public abstract class AlumnoDecorador : IAlumno {
  protected Ialumno alumnoDecorado;
  public AlumnoDecorador(Ialumno a){
    alumnoDecorado = a;
  }

  public string getNombre() {
    return alumnoDecorado.getNombre();
  }

  //TODO: getLegajo
}