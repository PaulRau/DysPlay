using UnityEngine;
using System.Collections;

public class MotAleaPerso : MonoBehaviour
{

    public string[] liste = { "a" , "b", "c", "d","e","f"};
    public string[] liste2 = { "le", "la", "de", "ma", "si", "vu", "ah", "ce" , "je", "tu", "il", "me", "sa", "ta", "eu", "si", "lu", "es", "va" };
    public string[] liste3 = { "ail", "air", "aux", "axe", "bac", "bal", "bar", "bas", "bat", "boa", "bol", "bon", "cil", "col", "cri", "cru", "des", "dit", "duc", "duo", "dur", "eau", "est", "fil", "fin", "foi", "gai", "jet", "job", "jus", "lac", "les", "lot", "lui", "mes", "mon", "mou", "pli", "que", "qui", "sac", "sol"  };
    public string[] liste4 = { "main", "joli", "lieu", "ceux", "pain" };
    public string[] liste5 = { "absent", "aborde", "acheva", "affine", "allant", "allait", "alcool", "alarme", "baigne", "balade", "banane", "babine", "balais", "bandit", "balise", "bagage", "bajoue", "bambou", "bennes", "bidule", "beurre", "berner", "belote", "blabla", "blondi", "bobard", "blouse", "blonde", "blancs", "bocaux", "boeufs", "brader", "bougie", "boxant", "boulot", "bourde", "braise", "boudes", "brebis", "braies", "brasse", "brelan", "brises", "brouet", "brouta", "bruine", "bronze", "brouet", "butins", "bulles", "butome", "brumes", "bruies", "bureau", "cafard", "caille", "calcul", "cacher", "cabine", "cabane", "cabrer", "caducs", "cachez", "captif", "captai", "canyon", "canifs", "citron", "chaume", "charme", "chauds", "champi", "chanta", "chauve", "charge", "chenil", "chimie", "cigare", "ciller", "chrome", "chlore", "cibles", "chutes", "choque", "chopes", "choses", "chuter", "ciment", "cigale", "datais", "danses", "daigna", "dauber", "dalton", "dattes", "dagues", "devoir", "devise", "devons", "dicton", "dindon", "diluas", "dicton", "dettes", "disons", "divans", "dirent", "dirige", "disque", "doigts", "doigte", "dogmes", "drague", "dragon", "droite", "empire", "encart", "encave", "encens", "enclos", "emmena", "empois", "enroba", "enfoui", "enivra", "entama", "entour", "envers", "envahi", "enlise", "essora", "esprit", "espace", "espoir", "estime", "estima", "escroc", "erreur", "essuya", "ethnie", "exalte", "excuse", "exclue", "expire", "expira", "expier", "farces", "farter", "faucon", "fatale", "fatals", "ferrer", "feutra", "festin", "fermes", "fesses", "fermer", "fendit", "fichai", "fibres", "flocon", "floral", "fleuve", "flaque", "flamme", "forban", "fondue", "forage", "fluide", "fuyard", "fusera", "fumeux", "frotte", "gagnes", "galion", "gamine", "gadoue", "garage", "galons", "gibets", "gifler", "gisant", "girafe", "germes", "gendre", "genres", "gobent", "gloire", "gobera", "goulue", "gommes", "gonfle", "goujon", "grille", "griffe", "grimpe", "guidon", "guidai", "habile", "haleur", "harder", "hacher", "hareng", "habite", "homard", "hivers", "heurta", "hockey", "hymnes", "humble", "impair", "impoli", "impose", "inapte", "incuba", "isoler", "ironie", "intime", "intact", "inonda", "ivoire", "jaguar", "jarres", "jaunes", "jokers", "jauger", "jamais", "jasmin", "jambes", "jaunes", "jument", "jumeau", "jungle", "jurent", "jonque", "joueur", "jouent", "jonche", "kaolin", "koalas", "kimono", "kelvin", "kraken", "labour", "lagune", "lamine", "labeur", "labels", "laitue", "lavent", "lavera", "levure", "lierre", "ligues", "lieues", "lionne", "ligote", "lisage", "lisent", "lutins", "lovait", "loyale", "lutter", "lourde", "louves", "loyaux", "longue", "magnum", "malins", "mamies", "madame", "manioc", "manque", "mairie", "maigre", "menhir", "mentir", "meuble", "mettre", "mignon", "minime", "minute", "minuit", "mollir", "montre", "monter", "mixeur", "muffin", "mulets", "moudra", "mythes", "myopie", "mygale", "mutant", "muscat", "navale", "neveux", "niaise", "navale", "native", "notera", "nougat", "nuance", "normes", "nuques", "nuises", "normes", "nouent", "nymphe", "noyaux", "novice", "ondule", "ombrer", "opiner", "odorat", "odeurs", "oignon", "oiseau", "ongles", "office", "oxydes", "ovuler", "oublia", "oublie", "ouvrer", "oublis", "pagaye", "paille", "pagure", "panier", "papier", "panner", "pauvre", "pavane", "partez", "parler", "parfum", "penser", "perdue", "permis", "phoque", "photos", "permis", "picole", "pichet", "persil", "piquer", "piques", "pilule", "pileur", "piment", "pirate", "pocher", "poiler", "plisse", "pleuve", "pleine", "pondue", "pollue", "porche", "posant", "poivre", "police", "points", "poings", "pomper", "python", "puiser", "punira", "purger", "pronom", "pudeur", "pseudo", "quarts", "quotas", "quartz", "quinoa", "quiche", "rachat", "rafler", "raidir", "radian", "rasoir", "rebord", "ravale", "refond", "refila", "rejeta", "relate", "renoms", "renard", "rentre", "relaxe", "repars", "ridage", "rideau", "revenu", "revend", "robots", "rinces", "rodait", "rocher", "rivale", "ronger", "rosser", "rougir", "rythme", "russes", "router", "routes", "rougir", "royale", "safari", "salade", "salons", "sabord", "salami", "saison", "salade", "savons", "savent", "seiche", "second", "savane", "seules", "simule", "sirops", "singes", "sonner", "sonnet", "sortie", "sortir", "sommer", "subite", "stylos", "subtil", "statue", "statua", "succin", "surgit", "surgir", "surfer", "survie", "sushis", "sucent", "sueurs", "suffit", "sphinx", "suisse", "france", "italie", "survol", "sujets", "surent", "tajine", "tables", "tacots", "tabacs", "tamise", "tables", "tabler", "tendre", "tendue", "tennis", "tenues", "taurin", "temple", "teneur", "tenons", "tendre", "tatane", "tigres", "tiques", "timide", "thymus", "urbain", "utopie", "ultime", "uniras", "unions", "unifie", "unique", "usages", "userai", "usurpa", "utopie", "valent", "valide", "vannes", "vagues", "valise", "vanter", "vaccin", "vapeur", "vaincu", "vernis", "verrou", "vendue", "vessie", "virils", "virage", "visant", "viseur", "virils", "vident", "votera", "voulus", "voulut", "voleur", "voiler", "voulez", "voulue", "volcan", "wambat", "wagons", "yaourt", "yourte", "yachts", "zombie", "zigzag", "zouave", "zinzin" };
    public string[] liste6 = { "ballon", "enfant", "revoir", "reflex" };

    public int nb;


    private int i = 0;
    private int j = 0;
    public GameObject Clone;
    public GameObject letterPrefab;
    private GameObject[] letter = new GameObject[13];
    public Sprite[] alphabet;     // Contient tous les sprites (à compléter dans l'instructor)
    public int scoreValue = 1;
    public int scoreValue1 = 1;
    private int type = 0;
    private int currenttype = 0;
    private char[] characters;
    private int x = 0;
    public static bool success = false;
    private int rand = 0;
    private float vit;

    public AudioClip sonBonneLettre;
    public AudioClip sonMauvaiseLettre;

    private AudioSource source;

    void awake()
    {
       // source = GetComponent<AudioSource>();

      

    }



    // Use this for initialization
    void Start()
    {

        Clone.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        vit = PersonalisablePartie.vitesse;
        nb = (int)PersonalisablePartie.NbLettreAlea;
        Debug.Log(nb);
        switch (nb)
        {
            case 1: break;

            case 2: liste = liste2;
                break;
            case 3: liste = liste3;
                break;
            case 4: liste = liste4;
                break;
            case 5: liste = liste5;
                break;
            case 6: liste = liste6;
                break;
        }

        rand = Random.Range(0, liste.Length);
        success = false;

        for (j = 0; j < 12; j++)
        {
            letter[j] = null;           //Initialise le tableau de lettre

        }

        characters = liste[rand].ToCharArray();



        for (i = 0; i < liste[rand].Length; i++)
        {
            AfficheLettre(characters[i]);

        }
    }
    // Update is called once per frame
    void Update()
    {


        if (x < liste[rand].Length)
        {
            switch (characters[x])
            {
                case 'a':
                    currenttype = 0;
                    break;
                case 'b':
                    currenttype = 1;
                    break;
                case 'c':
                    currenttype = 2;
                    break;
                case 'd':
                    currenttype = 3;
                    break;
                case 'e':
                    currenttype = 4;
                    break;
                case 'f':
                    currenttype = 5;
                    break;
                case 'g':
                    currenttype = 6;
                    break;
                case 'h':
                    currenttype = 7;
                    break;
                case 'i':
                    currenttype = 8;
                    break;
                case 'j':
                    currenttype = 9;
                    break;
                case 'k':
                    currenttype = 10;
                    break;
                case 'l':
                    currenttype = 11;
                    break;
                case 'm':
                    currenttype = 12;
                    break;
                case 'n':
                    currenttype = 13;
                    break;
                case 'o':
                    currenttype = 14;
                    break;
                case 'p':
                    currenttype = 15;
                    break;
                case 'q':
                    currenttype = 16;
                    break;
                case 'r':
                    currenttype = 17;
                    break;
                case 's':
                    currenttype = 18;
                    break;
                case 't':
                    currenttype = 19;
                    break;
                case 'u':
                    currenttype = 20;
                    break;
                case 'v':
                    currenttype = 21;
                    break;
                case 'w':
                    currenttype = 22;
                    break;
                case 'x':
                    currenttype = 23;
                    break;
                case 'y':
                    currenttype = 24;
                    break;
                case 'z':
                    currenttype = 25;
                    break;
                case 'é':
                    currenttype = 26;
                    break;
                case 'è':
                    currenttype = 27;
                    break;
                case 'à':
                    currenttype = 28;
                    break;
                case 'ç':
                    currenttype = 29;
                    break;
            }
        }
        else
        {

            success = true;
            for (i = 0; i < liste[rand].Length; i++)
            {

                // Arrête le mouvement de chaque lettre 
                letter[i].GetComponent<LettreChoisie>().speed = new Vector2(0, 0);

                // Detruit chaque lettre après un délai de 0.5 secondes
                Destroy(letter[i], 0.5f);

            }
            // Ne pas oublier de detruire l'object mot éventuellement
            Destroy(Clone, 0.5f);
        }
        if (success == false) { clavier(); }

    }


    void AfficheLettre(char charactere)
    {


        switch (charactere)
        {
            case 'a':

                type = 0;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'b':
                type = 1;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'c':
                type = 2;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'd':
                type = 3;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'e':
                type = 4;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'f':
                type = 5;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'g':
                type = 6;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'h':
                type = 7;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'i':
                type = 8;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'j':
                type = 9;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'k':
                type = 10;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'l':
                type = 11;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'm':
                type = 12;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'n':
                type = 13;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'o':
                type = 14;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'p':
                type = 15;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'q':
                type = 16;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'r':
                type = 17;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 's':
                type = 18;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 't':
                type = 19;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'u':
                type = 20;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'v':
                type = 21;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'w':
                type = 22;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'x':
                type = 23;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'y':
                type = 24;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'z':
                type = 25;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type]; 
                break;
            case 'é':
                type = 26;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'è':
                type = 27;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'à':
                type = 28;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            
            case 'ç':
                type = 29;
                if (vit == 0)
                {

                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste[rand].Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];

                break;
        }
        
        if (liste[rand].Length > 5)
        {
            letter[i].GetComponent<Transform>().localScale = new Vector2(0.3f, 0.3f);

        }

        if (liste[rand].Length > 9)
        {
            letter[i].GetComponent<Transform>().localScale = new Vector2(0.25f, 0.25f);

        }


    }


    void BonneLettre()
    {

        ScoreManager.score += scoreValue;
        ScoreManager.bonneLettre += scoreValue1;


        letter[x].GetComponent<SpriteRenderer>().color = Color.green;

        //  source.PlayOneShot(sonBonneLettre,1.0f);
        x++;

    }

    void MauvaiseLettre()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
            else
            {
                letter[x].GetComponent<SpriteRenderer>().color = Color.red;
                ScoreManager.mauvaiseLettre += scoreValue1;
            }
        }
    }


    //Définie l'action à effectuer en cas d'appui sur le clavier

    void clavier()
    {

        switch (currenttype)
        {
            case 0:
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 1:
                if (Input.GetKeyDown("b"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 2:
                if (Input.GetKeyDown("c"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 3:
                if (Input.GetKeyDown("d"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 4:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 5:
                if (Input.GetKeyDown("f"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 6:
                if (Input.GetKeyDown("g"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 7:
                if (Input.GetKeyDown("h"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 8:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 9:
                if (Input.GetKeyDown("j"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 10:
                if (Input.GetKeyDown("k"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 11:
                if (Input.GetKeyDown("l"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 12:
                if (Input.GetKeyDown("m"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 13:
                if (Input.GetKeyDown("n"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 14:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 15:
                if (Input.GetKeyDown("p"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 16:
                if (Input.GetKeyDown("q"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 17:
                if (Input.GetKeyDown("r"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 18:
                if (Input.GetKeyDown("s"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 19:
                if (Input.GetKeyDown("t"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 20:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 21:
                if (Input.GetKeyDown("v"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 22:
                if (Input.GetKeyDown("w"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 23:
                if (Input.GetKeyDown("x"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 24:
                if (Input.GetKeyDown("y"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 25:
                if (Input.GetKeyDown("z"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 26:
                if (Input.GetKeyDown("2"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 27:
                if (Input.GetKeyDown("7"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 28:
                if (Input.GetKeyDown("0"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 29:
                if (Input.GetKeyDown("9"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            

        }
    }
}
