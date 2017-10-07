using System;

namespace simple_class
{
    class vector
    {
        public int X;
        public int Y;
        public int Z;

        public void vec()
        {
            Console.Write("Введите координату 'x': ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату 'y': ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату 'z': ");
            Z = Convert.ToInt32(Console.ReadLine());

        }
        public vector(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static vector operator +(vector l, vector r)
        {
            return new vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }

        public static vector operator -(vector l, vector r)
        {
            return new vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        public static double operator *(vector l, vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }

        public static double Cos(vector l, vector r)
        {
            return (l * r) / (l.GetLength() * r.GetLength());
        }

        public void Print()
        {
            Console.WriteLine("({0},{1},{2})", X, Y, Z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                vector v1 = new vector(0, 0, 0);
                Console.WriteLine("Координты 1 вектора\n");
                v1.vec();
                vector v2 = new vector(0, 0, 0);
                Console.WriteLine("\nКоординты 2 вектора\n");
                v2.vec();
                vector v3 = v1 + v2;
                vector v4 = v1 - v2;
                double m = v1 * v2;
                double c = vector.Cos(v1, v2);

                Console.WriteLine("\nКоординаты первого вектора: ");
                v1.Print();
                Console.WriteLine("Координаты второго вектора: ");
                v2.Print();
                Console.WriteLine("Координаты суммы векторов: ");
                v3.Print();
                Console.WriteLine("Координаты разности векторов: ");
                v4.Print();
                Console.WriteLine("Скалярное произведение векторов: " + m);
                Console.WriteLine("Косинус угла м/д ними: " + c);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
