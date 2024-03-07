
namespace KodOvningIG
{
    public abstract class Fordon
    {
        protected string märke;

        public string Märke{
            set{märke = value;}
            get{return märke;}
        }

        public Fordon(string märke){
            this.märke = märke;
        }
    }
}