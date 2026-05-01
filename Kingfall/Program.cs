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

string[] usuarios = { "jugador1", "jugador2", "jugador3" };
string[] contrasenas = { "1122", "1234", "4444" };

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

// Login
string usuario, contrasena;

do
{
    Console.Write("Ingrese su usuario: ");
    usuario = Console.ReadLine();

    if (!UsuarioExiste(usuario))
        Console.WriteLine("El usuario no existe, intenta de nuevo.\n");

} while (!UsuarioExiste(usuario));

do
{
    Console.Write("Ingrese su contraseña: ");
    contrasena = Console.ReadLine();

    if (!ContrasenaCorrecta(usuario, contrasena))
        Console.WriteLine("Contraseña incorrecta, intenta de nuevo.\n");

} while (!ContrasenaCorrecta(usuario, contrasena));

Console.Clear();
Console.WriteLine($"Acceso concedido...\n\nBienvenido {usuario}");

Thread.Sleep(2300);

Console.Clear();

int opcion = ValidacionEntradas($"Menú:\n1. Iniciar partida\r\n2. Ver reglas del juego\r\n3. Ver puntaje más alto\r\n4. Salir\n> ",1 ,4);


switch (opcion)
{
    case 1:
        break;
    case 2:
        break;
    case 3:
        break;
    case 4:
        Console.WriteLine("Saliendo del juego...");
        Thread.Sleep(2300);
        break;
}




