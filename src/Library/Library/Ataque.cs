using Library.Interface;

namespace Library;

public class Ataque: IAtaque
{ 
    public Ataque(int poder, bool especial, string nombre)
    {
        Poder = poder;
        Especial = especial;
        Nombre = nombre;
    }
    public int Poder { get; set; }
    public bool Especial { get; set; }
    public string Nombre { get; set; }
    
   
}