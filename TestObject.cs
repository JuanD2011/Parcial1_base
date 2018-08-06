using System;
using System.Collections.Generic;

namespace Parcial1_logic
{
    public class TestObject
    {
        public static void Main(string[] args)
        {
            //Puede hacer llamados aquí para probar su código, aunque se recomienda correr las pruebas.

            

            Console.ReadKey();
        }

        #region DATA_STRUCTURES

        /*
         * Esta sección del examen evalúa el dominio de las estructuras de datos lineales básicas.
         * VALOR: 2.5 (0.625 cada ejercicio)
         */

        /// <summary>
        /// Reemplaza todas las ocurrencias del número 'lookupValues'
        /// con el valor de 'replaceValue'.
        /// La cola debe retornarse en el mismo orden entregado.
        /// </summary>
        /// <param name="inputQueue">La cola con los valores originales</param>
        /// <param name="lookupValue">Número a reemplazar</param>
        /// <param name="replaceValue">Nuevo valor a insertar</param>
        /// <returns>La lista de entrada con los valores modificados</returns>
        public Queue<int> ReplaceInQueue(Queue<int> inputQueue, int lookupValue, int replaceValue)
        {
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().

            List<int> temporalList = new List<int>(inputQueue.Count);

            temporalList = inputQueue.ToList();
            inputQueue.Clear();

            int i = 0;

            while (i < temporalList.Count)
            {
                if (temporalList[i] == lookupValue)
                {
                    temporalList[i] = replaceValue;
                }
                i++;
            }

            int j = 0;

            while(j < temporalList.Count)
            {
                inputQueue.Enqueue(temporalList[j]);
                j++;
            }

            return inputQueue;
        }

        /// <summary>
        /// Invierte el contenido de la pila 'stack'
        /// </summary>
        /// <param name="stack">La pila de entrada</param>
        /// <returns>Una pila con los valores de 'stack' invertidos</returns>
        public Stack<string> InverseStack(Stack<string> stack)
        {
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().

            Stack<string> nuevo = new Stack<string>();

            while(stack.Count > 0)
            {
                nuevo.Push(stack.Pop());
            }

            return nuevo;
        }

        /// <summary>
        /// Intercala igual número de elementos de 'stack' y 'queue' en una lista.
        /// La mezcla empieza insertando un elemento de 'stack', luego uno de 'queue' y así sucesivamente.
        /// </summary>
        /// <param name="stack">La pila que contiene parte de los datos</param>
        /// <param name="queue">La cola que contiene parte de los datos</param>
        /// <returns>Una lista con datos intercalados de 'stack' y 'queue'</returns>
        public List<string> MixData(Stack<string> stack, Queue<string> queue)
        {
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().

            int length;

            if(stack.Count < queue.Count)
            {
                length = stack.Count * 2;
            }
            else
            {
                length = queue.Count * 2;
            }

            List<string> list = new List<string>(length);
            int intercalator = 1;

            int i = 0;
            while (i < length)
            {
                switch (intercalator)
                {
                    case 1:
                        list.Add(stack.Pop());
                        intercalator *= -1;
                        break;

                    case -1:
                        list.Add(queue.Dequeue());
                        intercalator *= -1;
                        break;
                    default:
                        break;
                }
                i++;
            }

            return list;
        }

        /// <summary>
        /// Retorna el conteo de las llaves en el diccionario 'dict' que tienen como valor a 'lookupValue'.
        /// Retorna 0 si 'lookupValue' no está presente en el diccionario.
        /// Type1 y Type2 son dos clases cualquiera.
        /// </summary>
        /// <param name="dict">Diccionario con los datos</param>
        /// <param name="lookupValue">El valor a buscar en el diccionario</param>
        /// <returns></returns>
        public int RepeatedTimesInDictionary<Type1, Type2>(Dictionary<Type1, Type2> dict, Type2 lookupValue)
        {
            int count = 0;

            foreach(KeyValuePair<Type1, Type2> k in dict)
            {
                if(k.Key.Equals(lookupValue))
                {
                    count++;
                }
            }

            return count;
        }

        #endregion DATA_STRUCTURES

        #region BONUS

        /*
         * Este ejercicio de bonificación agrega 0.5 sobre la nota original obtenida,
         * siempre que la nota sea de 3.5 o superior.
         *
         *
         */

        #endregion BONUS
    }
}