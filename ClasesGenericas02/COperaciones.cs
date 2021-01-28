using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericas02
{
    class COperaciones<T>
    {
        public T Suma(T a, T b)
        {
            dynamic da = a, db = b;
            return da+db;
        }

        public T Resta(T a, T b)
        {
            dynamic da = a, db = b;
            return da - db;
        }

        public T Div(T a, T b)
        {
            dynamic da = a, db = b;
            return da / db;
        }

        public T Multi(T a, T b)
        {
            dynamic da = a, db = b;
            return da * db;
        }
    }

    /*class COperaciones<T>
    {
        public T Suma(T a, T b)
        {
            return a + b;
        }

        public T Resta(T a, T b)
        {
            return a - b;
        }

        public T Div(T a, T b)
        {
            return a / b;
        }

        public T Multi(T a, T b)
        {
            return a * b;
        }
    }*/
}
