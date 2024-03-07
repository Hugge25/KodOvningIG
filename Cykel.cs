namespace KodOvningIG
{
    public class Cykel : Fordon, IKörbar
    {
        public Cykel(string märke) : base(märke){

        }

        public void Kör()
        {
            Console.WriteLine
            ($"Cykeln {märke} trampar!");
        }
    }
}