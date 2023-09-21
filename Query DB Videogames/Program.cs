namespace Query_DB_Videogames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buongiorno caro utente, benvenuto nel gestionale per i videogiochi usati nei tornei");
            Console.WriteLine("Selezione l'opzione desiderata");

            int selectedOption = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
            - 1 inserire un nuovo videogioco
            - 2 ricercare un videogioco per id
            - 3 ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
            - 4 cancellare un videogioco
            - 5 chiudere il programma
            ");

            switch(selectedOption)
            {
                case 1:
            }
        }
    }
}