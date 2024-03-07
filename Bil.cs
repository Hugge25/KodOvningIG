namespace KodOvningIG
{
    public class Bil : Fordon, IKörbar
    {
        private string modell;
        public string Modell{
            get{return modell;}
            set{modell = value;}
        }
        public Bil(string märke, string modell) : base(märke)
        {
            this.modell = modell;
        }

        public void Kör()
        {
            Console.WriteLine
            ($"Bilen {märke} kör som en {modell}!");
        }
    }
}