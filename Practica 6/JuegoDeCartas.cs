namespace MDP1
{
    public abstract class JuegoDeCartas
    {
        public void jugar(){
            mezclar();
            repartirCartas();
            while(!hayGanador()){
                tomarCarta();
                descartar();
            }
        }
    private abstract void mezclar();
    // implementar metodos
    }

    public class Truco : JuegoDeCartas 
    {
        private void mezclar()
        {
            console.writeLine("Estoy mezclando")
        }
    }
}

