public class Convertir
{
    public int outputI;
    public double outputD;
    public Convertir(string input)
    {
        if(int.TryParse(input, out int numero))
            this.outputI = numero;
        else
            throw new CouldNotConvert("Solo puedes escribir numeros");
    }
    public Convertir(string input, string D)
    {
        if(double.TryParse(input, out double numero))
            this.outputD = numero;
        else
            throw new CouldNotConvert("Solo puedes escribir numeros");
    }
}