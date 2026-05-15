using System.ComponentModel.Design;

static int ValidacionEntradas(string mensaje, int min, int max)
{
    int valor;
    bool esValido;
    do
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine();
        esValido = int.TryParse(entrada, out valor) && valor >= min && valor <= max;
        if (!esValido)
        {
            Console.Clear();
            Console.WriteLine($"Por favor, ingresa un número.");
        }
    } while (!esValido);
    return valor;
}
//Los usuarios y contraseñas
string[] usuarios = { "jugador1", "jugador2", "jugador3" };
string[] contrasenas = { "Kingfa!!1", "Jugad0r#2", "Jueg0Kingfa!!" }; //Cambie las contraseñas por unas válidas

bool UsuarioExiste(string usuario)
{
    for (int i = 0; i < usuarios.Length; i++)
    {
        if (usuarios[i] == usuario)
            return true;
    }
    return false;
}

bool ContrasenaCorrecta(string usuario, string contrasena)
{
    for (int i = 0; i < usuarios.Length; i++)
    {
        if (usuarios[i] == usuario && contrasenas[i] == contrasena)
            return true;
    }
    return false;
}

Console.WriteLine("   ▄█   ▄█▄  ▄█  ███▄▄▄▄      ▄██████▄     ▄████████    ▄████████  ▄█        ▄█       \r\n  ███ ▄███▀ ███  ███▀▀▀██▄   ███    ███   ███    ███   ███    ███ ███       ███       \r\n  ███▐██▀   ███▌ ███   ███   ███    █▀    ███    █▀    ███    ███ ███       ███       \r\n ▄█████▀    ███▌ ███   ███  ▄███         ▄███▄▄▄       ███    ███ ███       ███       \r\n▀▀█████▄    ███▌ ███   ███ ▀▀███ ████▄  ▀▀███▀▀▀     ▀███████████ ███       ███       \r\n  ███▐██▄   ███  ███   ███   ███    ███   ███          ███    ███ ███       ███       \r\n  ███ ▀███▄ ███  ███   ███   ███    ███   ███          ███    ███ ███▌    ▄ ███▌    ▄ \r\n  ███   ▀█▀ █▀    ▀█   █▀    ████████▀    ███          ███    █▀  █████▄▄██ █████▄▄██ \r\n  ▀                                                               ▀         ▀         ");
Thread.Sleep(2500);
Console.Clear();
bool ValidarFormato(string contra)
{
    if (contra.Length < 8) return false;
    bool mayuscula = false, minuscula = false, numero = false, especial = false;
    foreach (char d in contra) // El foreach sirve para que revise letra por letra lo que se va a escribir de contraseña (en este caso).
    { //El char d significa que se va a guardar cada carácter de la contraseña en la variable d
        if (char.IsUpper(d)) mayuscula = true;
        else if (char.IsLower(d)) minuscula = true;
        else if (char.IsDigit(d)) numero = true;
        else especial = true;
    }
    return mayuscula && minuscula && numero && especial;
}

string LeerContra()
{
    string contra = "";
    ConsoleKeyInfo tecla; //Guarda el carácter especial

    do
    {
        tecla = Console.ReadKey(true);
        if (tecla.Key == ConsoleKey.Backspace && contra.Length > 0)
        {
            contra = contra.Substring(0, contra.Length - 1); //Si por accidente se confunden en escribir la contraseña entonces borra el carácter y no lo cuenta como parte de la contraseña
            Console.Write("\b \b"); //Borra el asterisco
        }

        else if (tecla.Key != ConsoleKey.Enter && contra.Length < 13)
        {
            contra += tecla.KeyChar;
            Console.Write("*");
        }
    } while (tecla.Key != ConsoleKey.Enter);
    Console.WriteLine();
    return contra;
}
//Pantalla de inicio
Console.WriteLine("===== BIENVENIDO AL JUEGO ====="); //Solo lo puse para que de un mensaje de bienvenida, pero si quieren lo pueden quitar
//Thread.Sleep(1500);
Console.Clear();

//Login
string usuario, contrasena;

do
{
    Console.Write("Ingrese su usuario: ");
    usuario = Console.ReadLine();

    if (!UsuarioExiste(usuario))
        Console.WriteLine("El usuario no existe, intenta de nuevo.\n");

}
while (!UsuarioExiste(usuario));

do
{
    Console.Write("Ingrese su contraseña: ");
    contrasena = LeerContra();

    if (!ValidarFormato(contrasena))
    {
        Console.WriteLine("No cumple con las reglas de seguridad.\n");
        continue;
    }
    if (!ContrasenaCorrecta(usuario, contrasena))
        Console.WriteLine("Contraseña incorrecta, intenta de nuevo.\n");

} while (!ContrasenaCorrecta(usuario, contrasena));

Console.Clear();
Console.WriteLine($"Acceso concedido...\n\nBienvenido {usuario}");

Thread.Sleep(2300);

Console.Clear();

bool salir=false;
do
{
    int opcion = ValidacionEntradas($"Menú:\n1. Iniciar partida\r\n2. Ver reglas del juego\r\n3. Ver puntaje más alto\r\n4. Salir\n> ", 1, 4);
    switch (opcion)
    {
        case 1:
            Console.Clear();
            

            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            
            Thread.Sleep(2300);
            break;
    }

} while (!salir);


Console.WriteLine("Saliendo del juego...");




