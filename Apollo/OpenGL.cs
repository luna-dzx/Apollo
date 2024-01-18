

namespace Apollo;

public class GLData
{
    public float[] Data;
    
    public GLData(params float[] data)
    {
        Data = data;
    }

    public GLData((float, float) tuple) : this(tuple.Item1, tuple.Item2) { }

    public static implicit operator GLData(float v) => new GLData(v);
    public static implicit operator GLData((float,float) tuple) => new GLData(tuple);
    public static implicit operator GLData(float[] a) => new GLData(a);
    
    public override string ToString()
    {
        if (Data == null || Data.Length == 0) return "{}";

        string s = "{" + Data[0];
        
        for (int i = 1; i < Data.Length; i++)
        {
            s += ","+Data[i];
        }

        return s + "}";
    }
}