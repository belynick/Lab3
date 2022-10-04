using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Content 
    {
        

        string content = "У книзі описується казковий світ, в який потрапляє маленька дівчинка Аліса. " +
                         "У цьому світі все перевернуто з ніг на голову. Люди і речі тут набувають " +
                         "зовсім інший сенс, а час і простір втрачають своє первісне значення, йдучи на " +
                         "другий план. Звичне для всіх подання про реальності зміщується і поступається місце " +
                         "абсурдності всього, що відбувається. Таким чином, дивовижна фантазія автора змушує " +
                         "працювати уяву читача, вимагаючи глибокого проникнення в зміст оповідання.";
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nЗміст: {content}");
        }
    }
}
