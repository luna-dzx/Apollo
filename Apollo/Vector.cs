using System.Numerics;

namespace Apollo;

public class Vec2 : GLData
{
    public Vec2() : base(new float[2]) { }
    public Vec2(float v) : base(new [] {v,v}) { }
    public Vec2(float x, float y) : base(new [] {x,y}) { }
    public Vec2(float[] data) : base(data) { }

    public float X
    {
        get => Data[0];
        set => Data[0] = value;
    }
    public float Y
    {
        get => Data[1];
        set => Data[1] = value;
    }
    
    // tuple casting
    public static implicit operator Vec2((float,float) v) => new (v.Item1,v.Item2);
    public static implicit operator (float,float)(Vec2 v) => (v.X,v.Y);
}