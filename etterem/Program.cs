enum kategoria {
    Leves,
    Foetel,
    Desszert
}

class Etlap_Elem {
    public string nev;
    public float szenhidrat;
    public int ar;
    public kategoria etelkategoria;
}

class Forgalom_Elem {
    public string nev;
    public int adag;
    public DateTime datum;
}