using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    public class Drinks
    {
        public int Volume = 0;  
        public static Random rnd = new Random();
        public virtual string GetInfo()
        {
            var str = String.Format("\nОбъём в мл: {0}", this.Volume);
            return str;
        }
    }

    public enum FruitsType { Orange, Apple, Pear, Peach, Grapes }; // виды сока

    public class Juice : Drinks
    {
        public FruitsType type = FruitsType.Orange; // фрукты
        public bool WithPulp = false; // наличие мякоти
        public override String GetInfo()
        {
            var str = "Сок";
            str += base.GetInfo();
            str += String.Format("\nФрукт: {0}", this.type);
            str += String.Format("\nНаличие мякоти: {0}", this.WithPulp);
            return str;
        }
        public static Juice Generate()
        {
            var rnd = new Random();
            return new Juice
            {
                Volume = rnd.Next() % 1000, // объем от 0 до 1000
                type = (FruitsType)rnd.Next(5), // фрукт
                WithPulp = rnd.Next(2) == 0 // наличие мякоти
            };
        }
    }

    public enum SodaType { Cola, Sprite, Fanta, Baikal, Tarragon, Schweppes }; // виды газировки

    public class Soda : Drinks
    {
        public SodaType type = SodaType.Cola; // вид
        public int NumberOfBubbles = 0; // кол-во пузыриков 
        public override String GetInfo()
        {
            var str = "Газировка";
            str += base.GetInfo();
            str += String.Format("\nВид: {0}", this.type);
            str += String.Format("\nКоличество пузырьков: {0}", this.NumberOfBubbles);
            return str;
        }
        public static Soda Generate()
        {
            var rnd = new Random();
            return new Soda
            {
                Volume = rnd.Next() % 1000, // объем от 0 до 1000
                type = (SodaType)rnd.Next(6), // вид
                NumberOfBubbles = 1000 + rnd.Next(9000), // кол-во пузыриков от 1тыс до 10тыс
            };
        }
    }

    public enum AlcoType { Vodka, Rum, Champagne, Wine, Whiskey }; // виды алкашки

    public class Alcohol : Drinks
    {
        public AlcoType type = AlcoType.Vodka; // тип
        public int AlcoStrength = 0; // крепость
        public override String GetInfo()
        {
            var str = "Я алкоголь";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nГрадусы в %: {0}", this.AlcoStrength);
            return str;
        }
        public static Alcohol Generate()
        {
            var rnd = new Random();
            return new Alcohol
            {
                Volume = rnd.Next() % 1000, // объем от 0 до 1000
                type = (AlcoType)rnd.Next(5), // тип
                AlcoStrength = 8 + rnd.Next(67), // крепость от 8 до 67
            };
        }
    }
}