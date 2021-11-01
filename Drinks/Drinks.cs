using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace Drinks
{
                                            /*Для раздачи напитков(общее свойство: объем)

                                                Сок(используемый фрукт, наличие мякоти)
                                                Газировка(вид, количество пузыриков)
                                                Алкоголь(крепость, тип)*/
    public class Drinks
    {
        public int Value = 0;
        public virtual string GetInfo()
        {
            var str = "";
            str += String.Format("\nОбъем: {0}", this.Value);
            str += "\n";
            return str;
        }
        public static Random rnd = new Random();
    }

    public enum FruitsType { Orange, Apple, Pear, Peach, Grapes }; // виды cjrf

    public class Juice : Drinks
    {
        public FruitsType type = FruitsType.Orange; // фрукты
        public bool WithPulp = false; // наличие мякоти
    }

    public enum SodaType { Cola, Sprite, Fanta, Baikal, Tarragon, Schweppes }; // виды газировки

    public class Soda : Drinks
    {
        public SodaType type = SodaType.Cola; // вид
        public int NumberOfBubbles = 0; // кол-во пузыриков 
         
    }

    public enum AlcoType { Vodka, Rum, Champagne, Wine, Whiskey }; // виды алкашки

    public class Alcohol : Drinks
    {
        public int AlcoStrength = 0; // крепость
        public AlcoType type = AlcoType.Vodka; // тип
    }
}