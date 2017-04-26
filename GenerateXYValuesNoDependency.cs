using System;
using System.Collections;

public class GenerateXYValues
{
        public struct Vector2
        {
            double x;
            double y;
        }
        
        private double Radius;
        private double Angle;
        public Vector2 SpawnPos;
        
        public double x;
        public double y;
        public double a = 1;
        public double b = 1;
        public double nOne;
        public double nTwo = 1;
        public double nThree = 1;
        
        public void GeneratePolar()
        {
                int i;
                for (i = 1; i <= 360; i++);
                {
                        Angle = i;
                        Radius = (Math.Pow(((Math.Cos(Angle / 4)) / a), nTwo)) + (Math.Pow(Math.Pow(((Math.Sin(Angle/ 4)) / b), -(1/nOne)), 1/nOne));
                        

                        Console.WriteLine("Generated Polar");
                        Console.WriteLine(i);
                        
                        ConvertToCartesian();
                }
        }
        
        public void ConvertToCartesian()
        {
                double x = 0;
                double y = 0;
                
                x = Radius * Math.Cos(Angle);
                y = Radius * Math.Sin(Angle);
                
                x = SpawnPos.x;
                y = SpawnPos.y;
                
                Console.WriteLine("ConvertedToCartesian");
                Instantiate();
        }
        
        public void Instantiate()
        {
            
                Console.WriteLine("Instantiated");
        }
}
