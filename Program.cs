using KodOvningIG;

List<IKörbar> körbarLista = new();

/*
    List<Körbar> körbarsLista;
    Bil f1 = new Bil("Nintendo", "PlaystationX");
    Fordon f2 = new Cykel("Speedtree");
    körbarsLista.Add(f1);
    körbarsLista.Add(f2);
    Spel doom = new Doom();
    körbarLista.Add(doom);
*/


IKörbar f1 = new Bil("Nintendo", "PlaystationX");
Cykel f2 = new Cykel("Speedtree");
Spel s = new Doom();
körbarLista.Add(s);
körbarLista.Add(f1);
körbarLista.Add(f2);

foreach (var körbar in körbarLista){
    körbar.Kör();
}