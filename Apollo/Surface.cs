namespace Apollo;

public abstract class Surface
{
    public Vec2 Size;
}

public class SoftwareSurface : Surface
{
    public SoftwareSurface()
    {
        
    }
}

public class ShaderSurface : Surface
{
    public PixelShader Shader = null;

    public ShaderSurface()
    {
    }

    public ShaderSurface(PixelShader shader)
    {
        Shader = shader;
    }
}