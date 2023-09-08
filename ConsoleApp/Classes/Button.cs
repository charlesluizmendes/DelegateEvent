namespace ConsoleApp.Classes
{

    // Events

    public class Button
    {
        public delegate void ButtonEventHandler(); // Define um delegate
        public event ButtonEventHandler Click; // Declara um evento usando o delegate

        public void SimularClick()
        {
            if (Click != null)
            {
                Click?.Invoke(); // Chama todos os manipuladores de evento registrados
            }
        }
    }
}
