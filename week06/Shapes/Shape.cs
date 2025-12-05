using System;
using System.Drawing;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetShapeColor()
    {
        return _color;
    }

    public void SetShapeColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();


}