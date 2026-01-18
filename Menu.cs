public class Menu
{
    private List<Usuario> usuarios = new List<Usuario>();
    public void Opciones()
    {
        string? input;
        do
        {
            Console.Clear();
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Opciones------------");
            Console.WriteLine("1 para agregar usuario");
            Console.WriteLine("2 mostrar todos los usuarios");
            Console.WriteLine("Salir(cualquier otra tecla)");

            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    AgregarUsuario();
                    break;
                case "2":
                    Console.Clear();
                    MostrarUsuarios();
                    Console.WriteLine("\nPresione enter para continuar.");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("El programa ha terminado");
                    break;
            }
            
        } while (input == "1" || input == "2");
    } 
    private void MostrarUsuarios()
    {
        for(int i = 0; i < usuarios.Count; i++)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------------Usuarios-----------------");
            Console.WriteLine($"Usuario {i + 1}:");
            Console.WriteLine($"Nombre => {usuarios[i].Nombre}");
            Console.WriteLine($"Edad => {usuarios[i].Edad}");
            Console.WriteLine($"Ahorro => {(usuarios[i].Salario) * 0.15}");
            Console.WriteLine($"Estado jubilado: {usuarios[i].Jubilado}");
        }
    }
    public void AgregarUsuario() //No estoy seguro si esto deberia de estar en esta clase.
    {
        int opcion= 1;
        string? input; // ? permite que el objeto pueda ser null
        Usuario usuario = new(); //Parece que tambien se puede llamar al constructor de una clase asi

        while(opcion <= 4)
        {
            switch (opcion)
            {
                case 1:
                    opcion = 1;
                    Console.Clear();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Escribe nombre");
                    input = Console.ReadLine();
                    usuario.Nombre = input ?? input; // en teoria hace lo mismo que input == null ? "no nombre" : input
                    opcion++;
                    break;
                case 2:
                    opcion = 2;
                    Console.Clear();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Escribe Edad");
                    input = Console.ReadLine();
                    try
                    {
                        usuario.Edad = new Convertir(input).outputI;
                    }catch(CouldNotConvert ex)
                    {
                        Console.WriteLine(ex.Message + "\nPresione enter continuar");
                        Console.ReadLine();  
                        goto case 2;
                    }
                    finally {opcion++;}
                    break;
                case 3:
                    opcion = 3;
                    Console.Clear();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Escribe Salario");
                    input = Console.ReadLine();
                    try
                    {
                        usuario.Salario = new Convertir(input, "d").outputD;   
                    }catch(CouldNotConvert ex)
                    {
                        Console.WriteLine(ex.Message + "\nPresione enter continuar");
                        Console.ReadLine(); 
                        goto case 3;
                    }
                    finally {opcion++;}
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Es jubilado? s/n");
                    usuario.Jubilado = Console.ReadLine() == "s" ? true : false;
                    opcion++;
                    break;
            }
        }
        usuarios.Add(usuario);
    }
    
}   
