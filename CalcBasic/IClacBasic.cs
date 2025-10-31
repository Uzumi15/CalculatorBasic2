using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СalcBasic
{
    public interface IClacBasic
    {
        /// <summary>
        /// Плюс
        /// </summary>
        /// <param name="Value1">1е Число</param>
        /// <param name="Value2">2е Число</param>
        /// <returns>сумма</returns>
        double Add(double Value1, double Value2);
        /// <summary>
        /// Минус
        /// </summary>
        /// <param name="Value1">1е Число</param>
        /// <param name="Value2">2е Число</param>
        /// <returns>Ответ после вычетания</returns>
        double Sub(double Value1, double Value2);
        /// <summary>
        /// умножение
        /// </summary>
        /// <param name="Value1">1е Число</param>
        /// <param name="Value2">2е Число</param>
        /// <returns>ответ(после умножения)</returns>
        double Mult(double Value1, double Value2);
        /// <summary>
        /// деление
        /// </summary>
        /// <param name="Value1">1е Число</param>
        /// <param name="Value2">2е число</param>
        /// <returns>ответ(после деления)</returns>
        double Dive(double Value1, double Value2);
        /// <summary>
        /// синус
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>вычесления синуса</returns>
        double Sin(double Value);
        /// <summary>
        /// косинус
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>вычесления косинуса</returns>
        double Cos(double Value);
        /// <summary>
        /// тангенс
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>вычесления тангенса</returns>
        double Tan(double Value);
        /// <summary>
        /// Квадрат числа
        /// </summary>
        /// <param name="value"></param>
        /// <returns>вычесления Квадрат числа</returns>
        double Square(double value);
    }
}
