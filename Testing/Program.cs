using Apollo;
namespace Testing;

public class Program
{
    public static void Main(string[] args)
    {
        ShaderTest();
    }

    public static void ShaderTest()
    {
        var surface = new ShaderSurface();
        Window window = new Window(surface, (1280, 720));
        
        var shader = PixelShader.FromFile("frag.glsl");
        surface.Shader = shader;

        shader.Uniforms = new Dictionary<string, GLData>
        {
            { "size", (1280,720) },
            { "mpos", (0,0) }
        };
        
        
        while (window.IsOpen)
        {
            Vec2 mpos = new Vec2(100f, 100f);
            shader.Uniforms["mpos"] = mpos;
            window.Update();
        }
    }
}