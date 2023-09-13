

public class Media
{
    String titre;
    int numRef;
    int nbDispo;

    public Media(string titre, int numRef, int nbDispo)
    {
        this.titre = titre;
        this.numRef = numRef;
        this.nbDispo = nbDispo;
    }
}

public class Livre : Media
{
    String auteur;

    public Livre(string titre, int numRef, int nbDispo) : base(titre, numRef, nbDispo)
    {
    }
}

public class DVD : Media
{
    int duree;

    public DVD(string titre, int numRef, int nbDispo) : base(titre, numRef, nbDispo)
    {
    }
}

public class CD : Media
{
    String artiste;

    public CD(string titre, int numRef, int nbDispo) : base(titre, numRef, nbDispo)
    {
    }
}