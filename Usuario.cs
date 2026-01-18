public class Usuario
{
    //public Nullable<string> Nombre {get; set;} //una forma de crear propiedades que pueden ser nulas
    public string? Nombre {get; set;} //La otra forma, mas sencilla
    public int Edad {get; set;}
    public double Salario {get; set;}
    public bool Jubilado {get; set;}

}