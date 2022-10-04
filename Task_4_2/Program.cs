using System;

namespace Task_4_2
{
    interface GeoObject
    {
        int CooX { get; set; }
        int CooY { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        void ShowInfo();
        
    }

    class River : GeoObject
    {
        public int CooX { get; set; }
        public int CooY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Speed { get; set; }
        public double Length { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Назва: {0}", Name);
            Console.WriteLine("Координати: {0} , {1}", CooX, CooY);
            Console.WriteLine("Опис: {0}", Description);
            Console.WriteLine("Швидкість: {0}", Speed);
            Console.WriteLine("Довжина: {0}\n", Length);
        }
    }
    class Mountain : GeoObject
    {
        public int CooX { get; set; }
        public int CooY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HighestPoint { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Назва: {0}", Name);
            Console.WriteLine("Координати: {0} , {1}", CooX, CooY);
            Console.WriteLine("Опис: {0}", Description);
            Console.WriteLine("Найвища точка: {0} м \n", HighestPoint);
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
