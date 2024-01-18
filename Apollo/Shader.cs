namespace Apollo;

public class ShaderProgram
{

    public Dictionary<string, GLData> Uniforms;

    // reference actual OpenGL / Vulkan(?) stuff here
}

public class PixelShader : ShaderProgram
{
    public PixelShader(string shaderText)
    {
        // call necessary backend stuff
    }
    
    public static PixelShader FromFile(string fileName)
    {
        return new PixelShader(File.ReadAllText(fileName));
    }
}