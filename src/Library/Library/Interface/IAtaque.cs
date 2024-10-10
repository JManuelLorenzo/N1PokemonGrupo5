namespace Library.Interface;

public interface IAtaque
{
    int Poder { get; set; }
    bool Especial { get; set; }
    string Nombre { get; set; }
}