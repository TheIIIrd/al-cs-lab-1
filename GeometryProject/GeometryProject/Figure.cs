using System;
using System.Collections.Generic;

// Класс, представляющий геометрическую фигуру
public class Figure
{
    // Имя фигуры
    public string Name { get; set; }
    
    // Список точек, представляющих вершины фигуры
    private List<Point> Points { get; }

    // Конструктор для треугольника
    public Figure(Point p1, Point p2, Point p3) 
        : this("Треугольник", new List<Point> { p1, p2, p3 }) { }

    // Конструктор для четырехугольника
    public Figure(Point p1, Point p2, Point p3, Point p4) 
        : this("Четырехугольник", new List<Point> { p1, p2, p3, p4 }) { }

    // Конструктор для пятиугольника
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) 
        : this("Пятиугольник", new List<Point> { p1, p2, p3, p4, p5 }) { }

    // Приватный конструктор для инициализации имени и списка точек
    private Figure(string name, List<Point> points)
    {
        Name = name;  // Установка имени фигуры
        Points = points; // Установка вершин фигуры
    }

    // Метод для вычисления длины стороны между двумя точками
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Метод для вычисления периметра фигуры
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        // Суммируем длины всех сторон
        for (int i = 0; i < Points.Count; i++)
        {
            perimeter += LengthSide(Points[i], Points[(i + 1) % Points.Count]);
        }
        return perimeter;
    }
}
