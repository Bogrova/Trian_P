using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetr
{
    interface IModel
    {
        /// <summary>
        /// Метод возвращающий периметр по двум сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int GetP(int a,int b);
    }
}
