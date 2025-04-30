namespace TP03.Models;
public class Disco{

public string nombre{get; private set;}
public string artista {get;private set;}
public string productor {get;private set;}
public string generoMusical {get;private set;}
public List<string> temas {get;private set;}
public int ID {get;private set;}
public string foto {get;private set;}

public Disco(string nombre, string artista, string productor, string generoMusical, List<string> temas, int ID, string foto)
{
this.nombre = nombre;
this.artista = artista;
this.productor = productor;
this.generoMusical = generoMusical;
this.temas = temas;
this.ID = ID;
this.foto = foto;
}
}

