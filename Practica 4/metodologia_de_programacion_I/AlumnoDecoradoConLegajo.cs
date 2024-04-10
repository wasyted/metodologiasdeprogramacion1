using System;

namespace metodologia_de_programacion_I

public class AlumnoDecoradoConLegajo : AlumnoDecorador {
  public override string mostrarCalificacion(){
    string res = base.mostrarCalificacion();
    res += AlumnoDecorado.getLegajo();
    return res;
  }
}