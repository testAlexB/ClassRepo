using System;

namespace EnumerationApp
{
    internal class Program
    {
        static void Main()
        {
            ВремяСуток ТекущееВремяСуток = EnumOperations.Приветствовать();
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Console.WriteLine(EnumOperations.ConvertEnumToString(ТекущееВремяСуток)+ ", " + user);

            Console.ReadKey();
        }
    }
}
