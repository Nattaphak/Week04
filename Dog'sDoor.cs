public class DogDoor
{
    private bool open;

    public DogDoor()
    {
        this.open = false;
    }

    public void Open()
    {
        Console.WriteLine("The Dog's Door is Open!!!");
        this.open = true;
    }

    public void Close()
    {
        Console.WriteLine("This Dog's Door is Close.");
        this.open = false;
    }

    public bool Isopen()
    {
        return this.open;
    }
}