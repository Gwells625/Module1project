namespace Module1project;

class Program
{
    
    public static double AreaOfCircle(double radius)
    {   
        return Math.PI * Math.Pow(radius, 4);//Formula for Area of circle with radius of 4
    }

    public static double CalculateTriangleArea(double baseLength, double height)
    {      
        return (baseLength * height) / 2;//Formula for Area of triangle
    }

    public static double AreaOfRectangle(double width, double height)
    {
        return width * height; //Formula for area of a rectangle
    }

    public static double AreaOfSquare(double square)
    {
        return square * square; //Formula for the area of a square
    }

    static void Main(string[] args)
        {

            Console.WriteLine("What is the radius of your circle?"); //Asking users input for radius 
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(
                $"This area of a circle with a radius of {radius} is  {AreaOfCircle(radius)}"); //Solution to area of a circle 



            Console.WriteLine("What is the base length of your triangle?"); //Asking users input for length
            double baseLength = double.Parse(Console.ReadLine()); //
            Console.WriteLine("What is the height of your triangle?"); //Asking users input for height
            double triangleheight = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(baseLength, triangleheight);
            Console.WriteLine(
                $"The area of your triangle is: {area}"); //Solution to area of a triangle based on users input 


            Console.WriteLine("What is the width of your rectangle?"); //Asking users input for width
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of your rectangle?"); //Asking users input for height
            double height = double.Parse(Console.ReadLine());
            double rectanglearea = AreaOfRectangle(width, height);
            Console.WriteLine(
                $"The area of your rectangle is: {area}"); //Solution to area of a rectangle based on users input  


            Console.Write("Enter the side length of your square: "); //Asking user input for side lengths
            double sideLength = double.Parse(Console.ReadLine());
            double squarearea = sideLength * sideLength;
            Console.WriteLine("The area of your square is: " +
                              area); //Solution for the area of a square based on users input

        }
    }