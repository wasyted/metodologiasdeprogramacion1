public abstract class FabricaDeComparables{
    //GeneradorAleatorio(Manejador manejadorGeneradorAleatorio) : Manejador (Agregar herencia)
    //LectorTeclado(Manejador manejadorLectorTeclado) : Manejador (Agregar herencia)
    //LectorDeArchivo
    
    Manejador responsable;
    static Comparable crearAleatorio(int opcion){
        responsable = new GeneradorAleatorio(null);
        responsable = new LectorTeclado(responsable);
        switch(opcion){
            case 1:
            // fabrica = new FabricaDeAlumnos();
            break;
            // ... 
            // fabrica.crearAleatorio();
        }
    }
    static Comparable lectorTeclado(int opcion){
        switch(opcion){
            case 1:
            // ...
        }
    }

    // ...
}

// Clase manejador practica 7:

public abstract class Manejador{

    private Manejador sucesor;

    public manejar(Manejador m){
        this.sucesor = m;
    }

    virtual generarIntAleatorio(/*...*/){
        if(sucesor != null){
            sucesor.generarIntAleatorio(/*...*/);
        }
    }
    
    virtual generarStringAleatorio(/*...*/){
        if(sucesor != null){
            sucesor.generarStringAleatorio(/*...*/);
        }
    }
}

// Clase GeneradorDeNumerosAleatorios

crearAleatorio(){
    return(new Numero(responsable.generarIntAleatorio()))
}

// Metodo Singleton Practica 7

public class LectorDeArchivo{
    private static LectorDeArchivo instancia = null;
    // Se modifica el acceso al constructor aunque no es parte del patrón Singleton
    // El new LectorDeArchivo(m) es inaccesible desde afuera de esta clase
    private LectorDeArchivo(Manejador m){
        this.responsable = m;
    }

    public static getInstance(Manejador m){
        if(instancia == null){
            instancia = new LectorDeArchivo(m);
        }
        return instancia;
    }
}

LectorDeArchivo L = LectorDeArchivo.getInstance(m);
LectorDeArchivo otra = new LectorDeArchivo(m);
