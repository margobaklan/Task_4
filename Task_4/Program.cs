using System;

namespace Task_4
{
    abstract class GeoObject
    {
        public int CooX;
        public int CooY;
        public string Name;
        public string Description;

        public virtual void ShowInfo()
        {
            Console.WriteLine("Назва: {0}", Name);
            Console.WriteLine("Координати: {0} , {1}", CooX, CooY);
            Console.WriteLine("Опис: {0}", Description);
        }
    }

    class River : GeoObject
    {
        public double Speed;
        public double Length;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Швидкість: {0} м/с", Speed);
            Console.WriteLine("Довжина: {0} км\n", Length);
        }
    }
    class Mountain : GeoObject
    {
        public int HighestPoint;

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Найвища точка: {0}\n", HighestPoint);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            GeoObject dnipro = new River()
            {
                CooX = 0,
                CooY = 0,
                Name = "Дніпро",
                Description = "четверта за довжиною і третя за площею басейну річка Європи",
                Speed = 1.2,
                Length = 2201
            };
            GeoObject Goverla = new Mountain()
            {
                CooX = 1,
                CooY = 1,
                Name = "Говерла",
                Description = "найвища вершина Українських Карпат і найвища точка України",
                HighestPoint = 2061
            };

            dnipro.ShowInfo();
            Goverla.ShowInfo();
        }
    }
}
