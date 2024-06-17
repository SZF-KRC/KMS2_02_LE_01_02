namespace KMS2_02_LE_01_02.ToDoManager
{
    public class Filter
    {
        /// <summary>
        /// Delegate-Definition
        /// </summary>
        /// <param name="number">Die Ganzzahl, die verarbeitet werden soll</param>
        /// <returns>Die verarbeitete Ganzzahl</returns>
        public delegate int MyDelegate(int number);

        /// <summary>
        /// Methode 1, die die Zahl mit 2 multipliziert
        /// </summary>
        /// <param name="number">Die Ganzzahl</param>
        /// <returns>Das Ergebnis der Multiplikation</returns>
        public int Method1(int number) => number * 2;

        /// <summary>
        /// Methode 2, die die Zahl mit 3 multipliziert
        /// </summary>
        /// <param name="number">Die Ganzzahl</param>
        /// <returns>Das Ergebnis der Multiplikation</returns>
        public int Method2(int number) => number * 3;

        /// <summary>
        /// Methode 3, die die Zahl mit 4 multipliziert
        /// </summary>
        /// <param name="number">Die Ganzzahl</param>
        /// <returns>Das Ergebnis der Multiplikation</returns>
        public int Method3(int number) => number * 4;
    }
}
