namespace Apollo;

public class Window
{
    public Vec2 Size;
    public Surface Surface;
    public bool IsOpen = false;
    
    public Window(Vec2 size)
    {
        Size = size;
        Surface = new SoftwareSurface();
        Surface.Size = Size;
    }

    public Window(Surface surface, Vec2 size)
    {
        Size = size;
        Surface = surface;
    }

    public void Update()
    {
        
    }
}