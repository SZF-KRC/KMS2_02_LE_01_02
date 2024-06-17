using System;

namespace KMS2_02_LE_01_02.ToDoManager
{
    public class ToDo
    {
        /// <summary>
        /// Führt die Hauptlogik des Programms aus.
        /// </summary>
        public void Run()
        {
            Filter filter = new Filter();

            // Multicast-Delegierten erstellen und Methoden zuweisen
            Filter.MyDelegate myDelegate = filter.Method1;
            myDelegate += filter.Method2;
            myDelegate += filter.Method3;

            int input = 5;
            int result = 0;

            // Die Methoden im Delegaten durchlaufen und die Ergebnisse akkumulieren
            foreach (Filter.MyDelegate md in myDelegate.GetInvocationList())
            {
                result += md(input);
            }

            // Den ursprünglichen Eingabewert hinzufügen
            result += input;

            Console.WriteLine("Das Ergebnis ist: "+result);

            Console.ReadKey();
        }
    }
}
