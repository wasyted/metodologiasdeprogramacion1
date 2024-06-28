using System;

namespace MDPI
{
public class OrdenAulaLlena : OrdenEnAula1
{
    private Aula aula;

    public OrdenAulaLlena(Aula aula)
    {
        this.aula = aula;
    }

    public void ejecutar()
    {
        aula.claseLista();
    }
}
}
