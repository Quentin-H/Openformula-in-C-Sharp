using System;
using System.Collections;

public class GenerateXYValues
{
        public struct Vector2
        {
            float x;
            float y;
        }
        
        private float Radius;
        private float Angle;
        private Vector2 SpawnPos;
        
        public float x;
        public float y;
        public float a = 1;
        public float b = 1;
        public float nOne;
        public float nTwo = 1;
        public float nThree = 1;
        
        public void GeneratePolar()
        {
                for (int i = 1; i <= 360; i++);
                {
                        Angle = i;
                        Radius = ((Math.Cos((y * Angle) / 4)/a) ^ nTwo) + ((Math.Sin((z * Angle) / 4) / b) ^ -(1/nOne))) ^ 1/nOne);
                        
                        Console.WriteLine("Generated Polar");
                        Console.WriteLine(i);
                        
                        ConvertToCartesian();
                }
        }
        
        public void ConvertToCartesian()
        {
                float x = 0;
                float y = 0;
                
                x = Radius * Math.Cos(Angle);
                y = Radius * Math.Sin(Angle);
                
                SpawnPos.Set(x,y);
                
                Console.WriteLine("ConvertedToCartesian");
                Instantiate();
        }
        
        public void Instantiate()
        {
            
                Console.WriteLine("Instantiated");
        }
}
