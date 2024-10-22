using System;

namespace EnumerationApp
{
    public enum ВремяСуток
    {
        Утро = 0,
        День,  // = 1
        Вечер, // = 2
        Ночь // 3
    }

    public class EnumOperations
    {
        public static string ConvertEnumToString(ВремяСуток t)
        {
            switch (t)
            {
                case ВремяСуток.Утро:
                    return "С добрым утром";

                case ВремяСуток.День:
                    return "Добрый день";

                case ВремяСуток.Вечер:
                    return "Добрый вечер";

                case ВремяСуток.Ночь:
                    return "Спокойной ночи";

            }

            return "";
        }

        public static ВремяСуток Приветствовать()
        {
            DateTime localDate = DateTime.Now;
            int hour = localDate.Hour;

            if(hour >= 6 && hour < 12)
                return ВремяСуток.Утро;

            if (hour >= 12 && hour < 17)
                return ВремяСуток.День;

            if (hour >= 23 || hour < 6)
                return ВремяСуток.Ночь;

            return ВремяСуток.Вечер;
        }
    }
}
