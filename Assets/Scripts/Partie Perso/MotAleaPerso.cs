using UnityEngine;
using System.Collections;

public class MotAleaPerso : MonoBehaviour
{
    public static bool spec;

    private string[] liste = { "a" , "b", "c", "d","e","f"};
    private string[] liste2 = { "le", "la", "de", "ma", "si", "vu", "ah", "ce" , "je", "tu", "il", "me", "sa", "ta", "eu", "si", "lu", "es", "va" };
    private string[] liste3 = { "ace", "agi", "aie", "ail", "air", "ais", "ait", "ale", "ami", "ana", "ans", "api", "arc", "aux", "bah", "bar", "bec", "ber", "bit", "bof", "bue", "cab", "cas", "chu", "col", "cou", "dam", "des", "dit", "dom", "dru", "duo", "eau", "axa", "bai", "bas", "bol", "box", "bus", "cal", "cep", "cil", "cri", "dan", "dey", "div", "don", "dur", "axe", "bal", "bat", "bel", "bic", "boa", "bon", "boy", "but", "cap", "ces", "coq", "cru", "dia", "dix", "dos", "duc", "dus", "ego", "ben", "bis", "bob", "bru", "bye", "car", "cet", "coi", "cor", "der", "der", "dis", "dot", "due", "dut", "eut", "fax", "gag", "hue", "las", "let", "ion", "gis", "jeu", "las", "let", "lie", "lob", "lue", "eue", "fia", "fil", "fur", "gaz", "gym", "ira", "job", "lac", "lin", "lui", "est", "far", "fer", "fou", "gel", "glu", "heu", "hum", "jus", "loi", "lus", "etc", "feu", "fie", "fut", "ici", "ils", "jet", "kit", "les", "lia", "lit", "lot", "lut", "mal", "mec", "met", "mir", "mol", "mut", "nom", "ope", "off", "pou", "pur", "que", "rat", "man", "mie", "mis", "mon", "mue", "nid", "non", "nul", "par", "peu", "plu", "pua", "pus", "qui", "ria", "mat", "mer", "mit", "nez", "nie", "nos", "osa", "pas", "pro", "pub", "rie", "max", "min", "moi", "nia", "ode", "oie", "ont", "ose", "oui", "pic", "pat", "pit", "pue", "ras", "ris", "rit", "roi", "rus", "ses", "ski", "son", "suc", "tas", "tes", "tir", "top", "sec", "ses", "sir", "sud", "toc", "tue", "une", "usa", "sel", "set", "sue", "tic", "toi", "tri", "uni", "six", "sol", "sur", "tel", "ton", "tus", "van", "vil", "won", "var", "via", "vin", "vos", "zen", "yak", "zut", "cas", "vie", "vis", "vue", "yen", "ver", "vit", "zoo" };
    private string[] liste4 = { "abas", "abat", "aboi", "abot", "abri", "abus", "accu", "aces", "ache", "acra", "acre", "acte", "ados", "afin", "afro", "agar", "agio", "agir", "ahan", "aide", "aigu", "aile", "aine", "aire", "airs", "aise", "alfa", "aloi", "alpe", "alto", "alun", "amas", "amen", "amer", "amie", "amis", "ange", "anis", "anse", "ante", "apte", "ardu", "aria", "arme", "arts", "asie", "aube", "auge", "aura", "auto", "aval", "avec", "aveu", "avez", "avis", "axer", "axes", "axoa", "azur", "baba", "baby", "bacs", "bada", "baie", "bail", "bain", "bals", "banc", "bang", "bani", "bans", "bard", "bars", "base", "baud", "baux", "bave", "beat", "beau", "becs", "berk", "beur", "bibi", "bide", "bien", "bile", "bips", "bise", "bled", "blet", "bleu", "bloc", "blog", "boas", "bobo", "bock", "body", "bœuf", "bois", "bols", "bond", "bons", "book", "boom", "boot", "bora", "bord", "bore", "boss", "bouc", "boue", "boum", "bout", "boxe", "boys", "brai", "bras", "bref", "brie", "brin", "brio", "bris", "broc", "brun", "brus", "brut", "bugs", "buis", "bure", "burg", "buse", "buts", "buzz", "byte", "cabs", "cage", "cake", "cale", "came", "camp", "cane", "cape", "caps", "cars", "case", "cash", "cata", "cave", "ceci", "cela", "cens", "cent", "ceps", "cerf", "ceux", "chai", "chan", "char", "chat", "chef", "cher", "chez", "chic", "chip", "choc", "chou", "chut", "ciao", "ciel", "cils", "cime", "cinq", "cire", "city", "cive", "clac", "clam", "clan", "clap", "clef", "clic", "clim", "clin", "clio", "clip", "clos", "clou", "club", "coca", "coco", "coda", "code", "coeur", "coin", "cois", "coke", "cola", "colo", "cols", "colt", "coma", "cool", "cops", "coqs", "cors", "cosy", "coup", "cour", "cous", "crac", "cran", "cric", "crin", "cris", "croc", "crue", "cube", "cuir", "cuit", "cure", "cuve", "cyan", "cyte", "dada", "daim", "dais", "dame", "dans", "dard", "date", "deal", "demi", "deux", "dico", "dieu", "ding", "dire", "dite", "diva", "dock", "dodo", "dodu", "doge", "doit", "dojo", "donc", "dons", "dont", "dopa", "dope", "dose", "doux", "drap", "drop", "drue", "dual", "duel", "dune", "duos", "dupe", "dure", "duse", "eaux", "elfe", "elle", "embu", "envi", "eues", "exil", "expo", "face", "facs", "fada", "fade", "faim", "fait", "fana", "fane", "fans", "faon", "fard", "faut", "faux", "fers", "feta", "feux", "fief", "fiel", "fier", "file", "film", "fils", "fine", "fini", "fins", "fisc", "fixe", "flac", "flan", "flic", "flip", "floc", "flop", "flot", "flou", "fluo", "flux", "foie", "foin", "fois", "folk", "fond", "foot", "fort", "four", "fous", "frai", "fret", "fric", "frit", "froc", "fuel", "fuir", "funk", "gaga", "gage", "gaie", "gain", "gala", "game", "gang", "gant", "gars", "gate", "gave", "gays", "gaze", "geek", "gens", "gent", "glam", "glas", "goal", "gobe", "gogo", "gold", "gore", "gras", "grau", "grec", "grip", "gris", "grog", "gros", "grue", "guet", "haha", "haie", "haka", "hall", "halo", "hard", "hier", "hors", "houx", "huis", "huit", "idem", "imam", "imbu", "inca", "inde", "indu", "info", "inox", "iode", "ions", "iota", "iris", "issu", "item", "ivre", "jack", "jade", "jean", "jeep", "jerk", "jets", "jeun", "jobs", "joie", "jojo", "joli", "jonc", "jota", "joue", "joug", "jour", "juan", "judo", "juge", "juif", "juin", "jump", "jupe", "jura", "jury", "jute", "kaki", "kart", "kata", "kilo", "kilt", "kiwi", "labo", "lacs", "laid", "laie", "lais", "lait", "lama", "lame", "land", "laps", "lard", "lave", "leur", "lias", "lice", "lido", "lime", "lion", "lire", "lits", "live", "lobe", "loft", "loge", "logo", "loin", "loir", "lois", "long", "look", "lors", "lote", "loto", "lots", "loup", "lues", "luge", "lulu", "luna", "lune", "luth", "luxe", "lynx", "lyon", "lyse", "macs", "mage", "maie", "mail", "main", "mais", "mali", "malt", "mana", "marc", "mare", "mari", "mars", "math", "mats", "maxi", "mela", "menu", "mers", "meta", "mets", "meuf", "meuh", "midi", "miel", "mile", "mime", "mimi", "mine", "mini", "mire", "miro", "mise", "miso", "miss", "mite", "mixe", "mode", "mois", "moka", "mono", "mont", "mors", "mort", "moto", "mots", "moue", "mous", "muer", "mues", "muet", "muge", "mule", "muni", "murs", "musc", "muse", "must", "nage", "nain", "nana", "nase", "nefs", "nerf", "nets", "neuf", "nida", "nids", "nier", "niet", "noce", "nœud", "noir", "noix", "noma", "nome", "noms", "none", "nord", "nori", "nota", "note", "noue", "nous", "nues", "nuit", "nuls", "obus", "ocre", "oeil", "oeuf", "ogre", "oies", "omis", "once", "onde", "onyx", "onze", "opus", "oral", "orbe", "ordi", "ordo", "orge", "orne", "oser", "oses", "ossu", "ouah", "ours", "oust", "pack", "pacs", "page", "paie", "pain", "pair", "paix", "pale", "pali", "paon", "papa", "pape", "papi", "papy", "para", "parc", "pari", "part", "paye", "pays", "peau", "peps", "peur", "peut", "peux", "piaf", "pied", "pies", "pieu", "pifs", "pige", "pile", "pils", "pins", "pion", "pipe", "pipi", "pipo", "pire", "plan", "plat", "plie", "plis", "ploc", "plot", "plus", "pneu", "pogo", "poil", "pois", "poix", "poli", "polo", "poly", "pont", "porc", "pore", "port", "pose", "pote", "pots", "pour", "poux", "pris", "prix", "prof", "puce", "puer", "puis", "puni", "punk", "pure", "purs", "quad", "quai", "quel", "quid", "quiz", "quoi", "race", "rade", "raft", "rage", "raid", "raie", "rail", "rais", "rame", "rang", "rare", "rasa", "rase", "rate", "rats", "ravi", "raya", "reçu", "rein", "repu", "rhum", "rias", "ride", "rien", "rifs", "rift", "rime", "ripe", "rire", "rive", "rixe", "robe", "rock", "rocs", "rois", "roms", "rond", "rosa", "rose", "rote", "rots", "roue", "roux", "rude", "ruer", "rues", "ruse", "rush", "ruts", "sacs", "saga", "sage", "sain", "sais", "sale", "sali", "sang", "sans", "sape", "sari", "sati", "sauf", "saur", "saut", "saxe", "saxo", "scie", "seau", "secs", "sein", "self", "sels", "sens", "sept", "sera", "serf", "sets", "seul", "silo", "sire", "site", "soda", "soeur", "sofa", "soft", "soie", "soif", "soin", "soir", "soit", "sole", "solo", "sols", "sons", "sont", "sort", "sots", "sous", "spam", "star", "stop", "suer", "sues", "suie", "suif", "sure", "surf", "suri", "tact", "talc", "tant", "taon", "tapa", "tape", "tapi", "tard", "tare", "tari", "tata", "taud", "taux", "taxe", "taxi", "team", "teck", "tels", "tenu", "test", "thon", "thym", "tian", "tics", "tifs", "tige", "tilt", "tipi", "tire", "tirs", "tofu", "toge", "toit", "tolu", "tome", "tong", "tons", "topo", "tors", "tort", "toto", "tour", "tous", "tout", "toux", "trac", "tram", "trio", "trip", "tris", "troc", "trop", "trot", "trou", "truc", "tsar", "tuba", "tube", "tubs", "tuer", "tupi", "turc", "type", "typo", "unes", "unie", "unir", "vain", "vans", "vaut", "vaux", "veau", "velu", "vent", "venu", "vers", "vert", "veto", "veuf", "vice", "vide", "vies", "vifs", "vins", "vire", "visa", "visu", "vite", "vive", "voeu", "voeux", "voie", "voir", "voix", "vole", "vols", "volt", "vomi", "vote", "vous", "vrac", "vrai", "vues", "yack", "yeux", "yoga", "zest", "zinc", "zona", "zone", "zoom", "zoos", "zouk" };
    private string[] liste5 = { "absent", "aborde", "acheva", "affine", "allant", "allait", "alcool", "alarme", "baigne", "balade", "banane", "babine", "balais", "bandit", "balise", "bagage", "bajoue", "bambou", "bennes", "bidule", "beurre", "berner", "belote", "blabla", "blondi", "bobard", "blouse", "blonde", "blancs", "bocaux", "boeufs", "brader", "bougie", "boxant", "boulot", "bourde", "braise", "boudes", "brebis", "braies", "brasse", "brelan", "brises", "brouet", "brouta", "bruine", "bronze", "brouet", "butins", "bulles", "butome", "brumes", "bruies", "bureau", "cafard", "caille", "calcul", "cacher", "cabine", "cabane", "cabrer", "caducs", "cachez", "captif", "captai", "canyon", "canifs", "citron", "chaume", "charme", "chauds", "champi", "chanta", "chauve", "charge", "chenil", "chimie", "cigare", "ciller", "chrome", "chlore", "cibles", "chutes", "choque", "chopes", "choses", "chuter", "ciment", "cigale", "datais", "danses", "daigna", "dauber", "dalton", "dattes", "dagues", "devoir", "devise", "devons", "dicton", "dindon", "diluas", "dicton", "dettes", "disons", "divans", "dirent", "dirige", "disque", "doigts", "doigte", "dogmes", "drague", "dragon", "droite", "empire", "encart", "encave", "encens", "enclos", "emmena", "empois", "enroba", "enfoui", "enivra", "entama", "entour", "envers", "envahi", "enlise", "essora", "esprit", "espace", "espoir", "estime", "estima", "escroc", "erreur", "essuya", "ethnie", "exalte", "excuse", "exclue", "expire", "expira", "expier", "farces", "farter", "faucon", "fatale", "fatals", "ferrer", "feutra", "festin", "fermes", "fesses", "fermer", "fendit", "fichai", "fibres", "flocon", "floral", "fleuve", "flaque", "flamme", "forban", "fondue", "forage", "fluide", "fuyard", "fusera", "fumeux", "frotte", "gagnes", "galion", "gamine", "gadoue", "garage", "galons", "gibets", "gifler", "gisant", "girafe", "germes", "gendre", "genres", "gobent", "gloire", "gobera", "goulue", "gommes", "gonfle", "goujon", "grille", "griffe", "grimpe", "guidon", "guidai", "habile", "haleur", "harder", "hacher", "hareng", "habite", "homard", "hivers", "heurta", "hockey", "hymnes", "humble", "impair", "impoli", "impose", "inapte", "incuba", "isoler", "ironie", "intime", "intact", "inonda", "ivoire", "jaguar", "jarres", "jaunes", "jokers", "jauger", "jamais", "jasmin", "jambes", "jaunes", "jument", "jumeau", "jungle", "jurent", "jonque", "joueur", "jouent", "jonche", "kaolin", "koalas", "kimono", "kelvin", "kraken", "labour", "lagune", "lamine", "labeur", "labels", "laitue", "lavent", "lavera", "levure", "lierre", "ligues", "lieues", "lionne", "ligote", "lisage", "lisent", "lutins", "lovait", "loyale", "lutter", "lourde", "louves", "loyaux", "longue", "magnum", "malins", "mamies", "madame", "manioc", "manque", "mairie", "maigre", "menhir", "mentir", "meuble", "mettre", "mignon", "minime", "minute", "minuit", "mollir", "montre", "monter", "mixeur", "muffin", "mulets", "moudra", "mythes", "myopie", "mygale", "mutant", "muscat", "navale", "neveux", "niaise", "navale", "native", "notera", "nougat", "nuance", "normes", "nuques", "nuises", "normes", "nouent", "nymphe", "noyaux", "novice", "ondule", "ombrer", "opiner", "odorat", "odeurs", "oignon", "oiseau", "ongles", "office", "oxydes", "ovuler", "oublia", "oublie", "ouvrer", "oublis", "pagaye", "paille", "pagure", "panier", "papier", "panner", "pauvre", "pavane", "partez", "parler", "parfum", "penser", "perdue", "permis", "phoque", "photos", "permis", "picole", "pichet", "persil", "piquer", "piques", "pilule", "pileur", "piment", "pirate", "pocher", "poiler", "plisse", "pleuve", "pleine", "pondue", "pollue", "porche", "posant", "poivre", "police", "points", "poings", "pomper", "python", "puiser", "punira", "purger", "pronom", "pudeur", "pseudo", "quarts", "quotas", "quartz", "quinoa", "quiche", "rachat", "rafler", "raidir", "radian", "rasoir", "rebord", "ravale", "refond", "refila", "rejeta", "relate", "renoms", "renard", "rentre", "relaxe", "repars", "ridage", "rideau", "revenu", "revend", "robots", "rinces", "rodait", "rocher", "rivale", "ronger", "rosser", "rougir", "rythme", "russes", "router", "routes", "rougir", "royale", "safari", "salade", "salons", "sabord", "salami", "saison", "salade", "savons", "savent", "seiche", "second", "savane", "seules", "simule", "sirops", "singes", "sonner", "sonnet", "sortie", "sortir", "sommer", "subite", "stylos", "subtil", "statue", "statua", "succin", "surgit", "surgir", "surfer", "survie", "sushis", "sucent", "sueurs", "suffit", "sphinx", "suisse", "france", "italie", "survol", "sujets", "surent", "tajine", "tables", "tacots", "tabacs", "tamise", "tables", "tabler", "tendre", "tendue", "tennis", "tenues", "taurin", "temple", "teneur", "tenons", "tendre", "tatane", "tigres", "tiques", "timide", "thymus", "urbain", "utopie", "ultime", "uniras", "unions", "unifie", "unique", "usages", "userai", "usurpa", "utopie", "valent", "valide", "vannes", "vagues", "valise", "vanter", "vaccin", "vapeur", "vaincu", "vernis", "verrou", "vendue", "vessie", "virils", "virage", "visant", "viseur", "virils", "vident", "votera", "voulus", "voulut", "voleur", "voiler", "voulez", "voulue", "volcan", "wambat", "wagons", "yaourt", "yourte", "yachts", "zombie", "zigzag", "zouave", "zinzin" };
    private string[] liste6 = { "absent", "abonne", "aborde", "acheva", "acides", "affame", "affine", "allant", "allait", "alcool", "alarme", "baigne", "balade", "banane", "babine", "balais", "bandit", "balise", "bagage", "bajoue", "bambou", "bennes", "bidule", "beurre", "berner", "belote", "blabla", "blondi", "bobard", "blouse", "blonde", "blancs", "bizuts", "bocaux", "boeufs", "brader", "bougie", "boxant", "boulot", "bourde", "braise", "boudes", "brebis", "braies", "brasse", "brelan", "brises", "brouet", "brouta", "bruine", "bronze", "brouet", "butins", "bulles", "butome", "brumes", "bruies", "bureau", "cafard", "caille", "calcul", "cacher", "cabine", "cabane", "cabrer", "caducs", "cachez", "captif", "captai", "canyon", "canifs", "citron", "chaume", "charme", "chauds", "champi", "chanta", "chauve", "charge", "chenil", "chimie", "cigare", "ciller", "chrome", "chlore", "cibles", "chutes", "choque", "chopes", "choses", "chuter", "ciment", "cigale", "datais", "danses", "daigna", "dauber", "dalton", "dattes", "dagues", "devoir", "devise", "devons", "dicton", "dindon", "diluas", "dicton", "dettes", "disons", "divans", "dirent", "dirige", "disque", "doigts", "doigte", "dogmes", "drague", "dragon", "droite", "empire", "encart", "encave", "encens", "enclos", "emmena", "empois", "enroba", "enfoui", "enivra", "entama", "entour", "envers", "envahi", "enlise", "essora", "esprit", "espace", "espoir", "estime", "estima", "escroc", "erreur", "essuya", "ethnie", "exalte", "excuse", "exclue", "expire", "expira", "expier", "farces", "farter", "faucon", "fatale", "fatals", "ferrer", "feutra", "festin", "fermes", "fesses", "fermer", "fendit", "fichai", "fibres", "flocon", "floral", "fleuve", "flaque", "flamme", "forban", "fondue", "forage", "fluide", "fuyard", "fusera", "fumeux", "frotte", "gagnes", "galion", "gamine", "gadoue", "garage", "galons", "gibets", "gifler", "gisant", "girafe", "germes", "gendre", "genres", "gobent", "gloire", "gobera", "goulue", "gommes", "gonfle", "goujon", "grille", "griffe", "grimpe", "guidon", "guidai", "habile", "haleur", "harder", "hacher", "hareng", "habite", "homard", "hivers", "heurta", "hockey", "hymnes", "humble", "impair", "impoli", "impose", "inapte", "incuba", "isoler", "ironie", "intime", "intact", "inonda", "ivoire", "jaguar", "jarres", "jaunes", "jokers", "jauger", "jamais", "jasmin", "jambes", "jaunes", "jument", "jumeau", "jungle", "jurent", "jonque", "joueur", "jouent", "jonche", "kaolin", "koalas", "kimono", "kelvin", "kraken", "labour", "lagune", "lamine", "labeur", "labels", "laitue", "lavent", "lavera", "levure", "lierre", "ligues", "lieues", "lionne", "ligote", "lisage", "lisent", "lutins", "lovait", "loyale", "lutter", "lourde", "louves", "loyaux", "longue", "magnum", "malins", "mamies", "madame", "manioc", "manque", "mairie", "maigre", "menhir", "mentir", "meuble", "mettre", "mignon", "minime", "minute", "minuit", "mollir", "montre", "monter", "mixeur", "muffin", "mulets", "moudra", "mythes", "myopie", "mygale", "mutant", "muscat", "navale", "neveux", "niaise", "navale", "nasale", "native", "notera", "nougat", "nuance", "normes", "nuques", "nuises", "normes", "nouent", "nymphe", "noyaux", "novice", "ondule", "ombrer", "opiner", "odorat", "odeurs", "oignon", "oiseau", "ongles", "office", "oxydes", "ovuler", "oublia", "oublie", "ouvrer", "oublis", "pagaye", "paille", "pagure", "panier", "papier", "panner", "pauvre", "pavane", "partez", "parler", "parfum", "penser", "perdue", "permis", "phoque", "photos", "permis", "picole", "pichet", "persil", "piquer", "piques", "pilule", "pileur", "piment", "pirate", "pocher", "poiler", "plisse", "pleuve", "pleine", "pondue", "pollue", "porche", "posant", "poivre", "police", "points", "poings", "pomper", "python", "puiser", "punira", "purger", "pronom", "pudeur", "pseudo", "quarts", "quotas", "quartz", "quinoa", "quiche", "rachat", "rafler", "raidir", "radian", "rasoir", "rebord", "ravale", "refond", "refila", "rejeta", "relate", "renoms", "renard", "rentre", "relaxe", "repars", "ridage", "rideau", "revenu", "revend", "robots", "rinces", "rodait", "rocher", "rivale", "ronger", "rosser", "rougir", "rythme", "russes", "router", "routes", "rougir", "royale", "safari", "salade", "salons", "sabord", "salami", "saison", "salade", "savons", "savent", "seiche", "second", "savane", "seules", "simule", "sirops", "singes", "sonner", "sonnet", "sortie", "sortir", "sommer", "subite", "stylos", "subtil", "statue", "statua", "succin", "surgit", "surgir", "surfer", "survie", "sushis", "sucent", "sueurs", "suffit", "sphinx", "suisse", "france", "italie", "survol", "sujets", "surent", "tajine", "tables", "tacots", "tabacs", "tamise", "tables", "tabler", "tendre", "tendue", "tennis", "tenues", "taurin", "temple", "teneur", "tenons", "tendre", "tatane", "tigres", "tiques", "timide", "thymus", "urbain", "utopie", "ultime", "uniras", "unions", "unifie", "unique", "usages", "userai", "usurpa", "utopie", "valent", "valide", "vannes", "vagues", "valise", "vanter", "vaccin", "vapeur", "vaincu", "vernis", "verrou", "vendue", "vessie", "virils", "virage", "visant", "viseur", "virils", "vident", "votera", "voulus", "voulut", "voleur", "voiler", "voulez", "voulue", "volcan", "wambat", "wagons", "yaourt", "yourte", "yachts", "zombie", "zigzag", "zouave", "zinzin" };

    private string[] sliste3 = { "âgé", "âge", "aïe", "âme", "âne", "avé", "bât", "bée", "blé", "clé", "côt", "dès", "dés", "èbe", "écu", "élu", "ému", "éon", "épi", "ère", "êta", "été", "ève", "fée", "fût", "gît", "gré", "gué", "île", "ipé", "kéa", "lès", "lié", "mât", "mée", "mél", "mûr", "née", "nié", "ohé", "oïl", "olé", "osé", "ôté", "pré", "réa", "rhô", "spé", "sué", "sûr", "tés", "têt", "thé", "tôt", "tué", "usé", "zée", "zoé" };
    private string[] sliste4 = { "abbé", "abée", "acmé", "acné", "âcre", "adné", "aéré", "âgée", "âges", "âgés", "aidé", "ailé", "aimé", "aîné", "aisé", "aléa", "allô", "âmes", "ânée", "ânes", "ânon", "ansé", "août", "âpre", "armé", "âtre", "basé", "bâte", "bâté", "bâti", "bâts", "béat", "bébé", "bédé", "béer", "bées", "bégu", "béké", "béni", "bêta", "bété", "bête", "blés", "bôme", "bômé", "buée", "buté", "café", "caïd", "calé", "caló", "camé", "capé", "casé", "cédé", "celé", "Cène", "cène", "cèpe", "chié", "ciné", "ciré", "cité", "clés", "cloé", "coït", "coïx", "cône", "côté", "côte", "coté", "Coué", "coût", "créé", "crée", "crêt", "curé", "déca", "deçà", "déci", "déçu", "défi", "déjà", "delà", "dème", "démo", "déni", "diêu", "dîme", "dôle", "dôme", "dông", "doré", "doté", "doué", "dupé", "ébat", "èche", "écho", "échu", "écor", "écot", "écru", "écus", "édam", "éden", "édit", "égal", "élan", "élue", "émeu", "émir", "émoi", "énol", "enté", "épar", "épée", "épié", "époi", "ères", "éros", "étai", "étal", "état", "étau", "étoc", "être", "étui", "évoé", "fadé", "famé", "fané", "faré", "féal", "fées", "fêlé", "féra", "féru", "fête", "fétu", "fève", "figé", "filé", "fixé", "foxé", "fumé", "futé", "garé", "gâté", "gavé", "gazé", "gelé", "gêne", "gêné", "géré", "gîte", "goïm", "goût", "gréé", "grés", "grès", "gués", "günz", "haïe", "haïk", "haïr", "hâle", "hâlé", "hâte", "hâté", "hâve", "hème", "hère", "holà", "hôte", "hoyé", "huée", "idée", "igné", "îles", "îlet", "îlot", "inné", "jeté", "jèze", "joué", "jubé", "jugé", "juré", "kalé", "kéké", "képi", "khôl", "kiné", "korê", "laïc", "lamé", "lavé", "lège", "léma", "lète", "lève", "levé", "liée", "lité", "lobé", "logé", "lône", "loué", "luxé", "mafé", "maïa", "mâle", "maté", "mâts", "méat", "mède", "méga", "mêlé", "mélo", "mémé", "même", "mémo", "mené", "mère", "mésa", "méso", "Méta", "méta", "méum", "miné", "môle", "môme", "moût", "moyé", "mûre", "muré", "muté", "naïf", "naïs", "Néel", "nées", "néné", "néon", "nèpe", "néré", "névé", "niée", "noté", "noué", "noyé", "nuée", "obéi", "ocré", "œuvé", "olpé", "ondé", "orée", "orné", "osée", "ôter", "ouïe", "ouïr", "palé", "pâle", "pâli", "pané", "paré", "pâté", "pâte", "pavé", "payé", "péan", "pécu", "pédé", "pelé", "pêne", "péon", "pépé", "père", "péri", "pesé", "pété", "pévé", "pèze", "pisé", "plié", "pôle", "posé", "prép", "prés", "près", "prêt", "prié", "racé", "raïs", "râle", "ramé", "râpe", "râpé", "rasé", "raté", "rayé", "réac", "réal", "redû", "réel", "réer", "régi", "rêne", "rêvé", "rêve", "ridé", "rivé", "rôle", "rosé", "rôti", "rôts", "roué", "ruée", "rusé", "saïs", "saké", "salé", "scié", "séga", "sème", "semé", "séné", "séré", "sève", "skaï", "Skaï", "sodé", "soûl", "suée", "sûre", "talé", "tapé", "taré", "taxé", "téju", "télé", "ténu", "tête", "têts", "têtu", "thaï", "tiré", "tôle", "tôlé", "tölt", "très", "trié", "typé", "urée", "usée", "uvée", "vécu", "vélo", "vêtu", "vexé", "vidé", "volé", "voué", "würm", "zébu", "zélé", "zèle", "zéro", "zêta", "zoné" };
    private string[] sliste5 = { "abbés", "abcès", "abêti", "abîmé", "abîme", "abusé", "accès", "acène", "acère", "acéré", "acmés", "acnés", "âcres", "actée", "adèle", "adoré", "adulé", "aèdes", "aérer", "affût", "agacé", "agité", "agréé", "agrès", "aiélé", "aïeul", "aïeux", "aimée", "aînée", "aînés", "aïnou", "aïoli", "aisée", "akène", "alaüs", "aléas", "alêne", "alène", "alésé", "alèse", "alézé", "alité", "alizé", "allée", "allié", "almée", "aloès", "ambré", "amené", "amène", "amère", "aminé", "amphé", "amuïr", "amusé", "ancré", "ânées", "ânier", "animé", "anisé", "année", "ânons", "apéro", "apidé", "apnée", "appât", "âpres", "après", "aréna", "arène", "arête", "armée", "armés", "arôme", "arqué", "arrêt", "asilé", "atémi", "athée", "âtres", "augée", "aunée", "avalé", "avéré", "aviné", "avisé", "avivé", "avoué", "awalé", "azéri", "azobé", "azuré", "bâché", "bâche", "bâcle", "bâclé", "bahaï", "baïle", "baïne", "bandé", "bardé", "barré", "bâsir", "batée", "bâter", "bâtie", "bâtir", "bâtis", "bâton", "baumé", "béant", "béate", "bébés", "bêche", "bécot", "bègue", "bégum", "békés", "bêler", "bémol", "bénef", "benêt", "bénin", "bénir", "bénit", "béret", "berné", "béroé", "bérot", "béryl", "bésef", "bêtas", "bétel", "bêtes", "béton", "bévue", "bézef", "bière", "bilié", "blâme", "blasé", "blême", "bluté", "bogué", "boïdé", "boisé", "boîte", "bolée", "bombé", "bondé", "bonté", "bordé", "borée", "borné", "bossé", "bouée", "bougé", "boulê", "boulé", "bravé", "brèle", "brêle", "brème", "brève", "briée", "brisé", "brodé", "broyé", "brûlé", "bûche", "bûché", "buées", "butée", "buvée", "câble", "câblé", "cabré", "caché", "cadré", "cafés", "cagée", "caïds", "caïeu", "câlin", "calmé", "camée", "caméo", "campé", "câpre", "cardé", "carné", "carpé", "carré", "cassé", "casté", "caudé", "cavée", "céans", "céder", "cèdre", "cégep", "celée", "cènes", "censé", "cépée", "cèpes", "cèphe", "cérat", "cerné", "césar", "césar", "cessé", "cétol", "châle", "chapé", "chasé", "chêne", "chère", "chéri", "chiée", "chiné", "choké", "chômé", "choyé", "cilié", "cinés", "cités", "cloué", "cobée", "coché", "cogné", "coïts", "colée", "collé", "côlon", "colón", "cômos", "comté", "condé", "congé", "conné", "copié", "corné", "corsé", "côtés", "côtes", "coudé", "coulé", "coupé", "coûts", "cramé", "crâne", "créer", "crème", "crémé", "crêpe", "crêpé", "crépi", "crépu", "crêté", "crête", "crêts", "crevé", "crève", "criée", "croît", "culée", "curée", "curés", "cuvée", "daïra", "dallé", "damné", "débat", "débet", "débit", "début", "décan", "décas", "décès", "dèche", "déchu", "décor", "décri", "dédié", "dédit", "défet", "défis", "dégât", "dégel", "dégou", "degré", "déité", "déjuc", "délai", "délié", "délit", "délot", "démis", "démon", "dénié", "dénis", "denté", "dénué", "dépit", "dépôt", "désir", "désis", "dévié", "dévot", "diène", "dièse", "diète", "dilué", "dîmée", "dîmer", "dîmes", "dîner", "dômes", "donné", "dorée", "douée", "drapé", "drège", "drève", "drôle", "duché", "durée", "ébahi", "ébats", "ébène", "écale", "écang", "écart", "échec", "échée", "èches", "échos", "écimé", "éclat", "éclos", "école", "écolo", "écope", "écopé", "écore", "écoté", "écots", "écran", "écrin", "écrit", "écrou", "écrue", "éculé", "écume", "édens", "édile", "édité", "édits", "éfrit", "égale", "égalé", "égard", "égaré", "égaux", "égéen", "égide", "égout", "éland", "élans", "élavé", "éléen", "élégi", "élémi", "élevé", "élève", "élimé", "élire", "élite", "éloge", "éludé", "éluer", "élues", "émail", "émaux", "embué", "émeri", "émois", "émues", "émule", "énard", "énéma", "enflé", "ényne", "épair", "épais", "épars", "épart", "épate", "épaté", "épave", "épées", "épelé", "éphod", "épice", "épicé", "épier", "épieu", "épigé", "épine", "épode", "épois", "époux", "époxy", "épris", "épure", "épuré", "équin", "érèse", "érigé", "érodé", "étage", "étagé", "étais", "étalé", "étale", "étals", "étang", "étant", "étape", "états", "étave", "étêté", "éteuf", "éther", "étier", "étiez", "étire", "étiré", "étole", "êtres", "étron", "étude", "étuis", "étuve", "évadé", "évasé", "éveil", "évent", "évidé", "évier", "évité", "excès", "exigé", "exilé", "fâché", "faîte", "fardé", "fascé", "féage", "féale", "fécal", "fèces", "fêler", "félin", "félon", "fémur", "féral", "férie", "férié", "férir", "fermé", "ferré", "ferté", "fêter", "fêtes", "fétus", "fèves", "fière", "figée", "filée", "filmé", "fixée", "flâne", "fléau", "flûte", "flûté", "foène", "folié", "foncé", "fondé", "forcé", "forêt", "forgé", "formé", "fossé", "foulé", "frayé", "frêle", "frère", "frèze", "fripé", "frisé", "fugué", "fumée", "fûmes", "fusée", "futée", "gâble", "gâché", "gâche", "gagné", "gaïac", "gaïta", "gaité", "galbé", "galée", "gardé", "gâtée", "gâter", "géant", "gébie", "gelée", "gélif", "gémir", "gemmé", "gênée", "gêner", "gênes", "genêt", "génie", "géode", "geôle", "gérer", "gésir", "gîter", "gîtes", "glacé", "glèbe", "glène", "gnôle", "golée", "gorgé", "goûté", "goûts", "goûtu", "grâce", "gradé", "gravé", "grèbe", "gréée", "gréer", "grège", "grêle", "grêlé", "grené", "grevé", "grève", "grèze", "grimé", "grisé", "guède", "guère", "guéri", "guèze", "guidé", "haché", "hâlée", "hâler", "hâles", "hanté", "hasté", "hâter", "hâtes", "hâtif", "havée", "hâves", "hecté", "hélas", "héler", "hélio", "hélix", "henné", "herbé", "hères", "héron", "héros", "hévéa", "hissé", "hôtel", "hôtes", "höyük", "huées", "huilé", "huppé", "ibère", "icône", "idéal", "idéel", "idées", "iléal", "iléon", "iléus", "îlien", "îlots", "imagé", "imité", "impôt", "innée", "innés", "inouï", "ipéca", "irisé", "isolé", "jacée", "jaspé", "jaugé", "jésus", "jetée", "jeûne", "jèzes", "jouée", "jubés", "jurée", "jusée", "képis", "koinè", "labié", "lâché", "lâche", "lacté", "laïcs", "laïka", "laité", "laïus", "lancé", "langé", "lapié", "laqué", "larvé", "lassé", "latès", "lauré", "lavée", "lèche", "légal", "légat", "léger", "lèges", "lèpre", "lérot", "léser", "lesté", "létal", "levée", "levés", "lèvre", "liège", "ligué", "lissé", "litée", "livré", "loupé", "lycée", "mâche", "maclé", "mâcon", "madré", "maïas", "mâles", "mandé", "mânes", "marée", "marié", "massé", "mâter", "mâtin", "méats", "mèche", "média", "médoc", "mégir", "mégis", "mégot", "Méker", "mêlée", "mêler", "méloé", "mémés", "mêmes", "menée", "mères", "méson", "métal", "métas", "météo", "métis", "Méton", "métré", "mètre", "métro", "meulé", "mézès", "mézig", "mirvé", "mitré", "moiré", "moïse", "môles", "mollé", "mômes", "monoï", "monté", "moqué", "morné", "moulé", "mûres", "mûrir", "mûron", "musée", "nacré", "naïfs", "naïve", "natté", "navré", "néant", "nèfle", "nègre", "négro", "négus", "nénés", "nèpes", "nervé", "niché", "niébé", "nièce", "niées", "nimbé", "noème", "noèse", "nommé", "nordé", "normé", "nouée", "nuées", "obéir", "obéré", "obèse", "océan", "odéon", "œdème", "œillé", "oeuvé", "ogoué", "oïdié", "oïdie", "oléum", "ombré", "oméga", "ondée", "onglé", "opéré", "ordré", "orées", "ornée", "ornés", "ortié", "osées", "osmié", "ôtées", "ouaté", "ouïes", "ourlé", "outré", "ouvré", "ovidé", "oviné", "oxydé", "ozène", "pacsé", "païen", "palée", "pâles", "pâlir", "palmé", "pâlot", "pâmer", "panné", "Pâque", "parée", "paréo", "parlé", "passé", "pâtée", "pâtés", "pâtes", "pâtir", "pâtis", "pâton", "pâtre", "patté", "paumé", "péage", "péans", "pêché", "pêche", "péché", "pêchu", "pédés", "pèger", "pègre", "peiné", "pékan", "pékin", "pelté", "pénal", "pênes", "pénil", "pénis", "penné", "penté", "péons", "pépée", "pépés", "pépie", "pépin", "pépon", "percé", "pères", "périf", "péril", "périr", "Pérou", "perré", "pesée", "péter", "pétré", "pétun", "pèzes", "phasé", "pièce", "piégé", "piège", "pietà", "piéta", "piété", "pièze", "pilée", "pincé", "pinée", "pinté", "pipée", "piqué", "pisés", "pitié", "placé", "plané", "plèbe", "poché", "poêle", "poème", "poète", "poiré", "pôles", "poljé", "pommé", "pongé", "porté", "posée", "posté", "potée", "préau", "prêle", "prèle", "prépa", "prête", "prêté", "prévu", "privé", "prôné", "prône", "ptôse", "puîné", "purée", "quête", "quiné", "râble", "râblé", "radié", "railé", "raïon", "râler", "râles", "ramée", "rangé", "râper", "râpes", "raphé", "raqué", "ratée", "réale", "rébus", "rêche", "récif", "récit", "récré", "récri", "recrû", "rédie", "réels", "régal", "régie", "régir", "réglé", "règle", "réglo", "règne", "régur", "relié", "rémiz", "remué", "rénal", "rênes", "renié", "répit", "résol", "resté", "rétif", "rétro", "réuni", "rêvée", "rêver", "rêves", "rêvés", "ridée", "rímur", "risée", "rodéo", "rôder", "rogué", "rôles", "ronéo", "rongé", "rosée", "rôtie", "rôtir", "rôtis", "rouée", "roulé", "ruché", "ruées", "ruiné", "rusée", "sablé", "sacré", "saïga", "saïte", "salée", "santé", "sassé", "sauté", "sauvé", "scène", "séant", "sébum", "séché", "sèche", "sédum", "séide", "sénat", "sensé", "sépia", "séqué", "sérac", "séran", "sergé", "série", "sérié", "serré", "sérum", "sésie", "séton", "sèves", "sévir", "sexué", "sézig", "shéol", "siège", "siglé", "signé", "sinué", "sitôt", "situé", "soldé", "soleá", "sommé", "sondé", "sonné", "soudé", "soûle", "soûlé", "spéos", "stèle", "sténo", "stère", "strié", "stylé", "sucré", "suédé", "suède", "suées", "suidé", "sûres", "tabès", "tablé", "taché", "tâche", "tâché", "tagué", "taïga", "talée", "tanné", "tapée", "tassé", "tâter", "télés", "télex", "ténia", "ténor", "tenté", "ténue", "testé", "tétée", "téter", "têtes", "tétin", "téton", "têtue", "tézig", "thaïs", "thème", "thèse", "thêta", "thête", "tiaré", "tiède", "tigré", "tildé", "tirée", "tissé", "tmèse", "toilé", "toisé", "tôles", "tollé", "tombé", "toqué", "touée", "tracé", "tramé", "tréaz", "tréma", "trêve", "trôle", "trône", "troué", "tufté", "türbe", "uléma", "unité", "uréna", "usagé", "usées", "usité", "usnée", "uvéal", "vairé", "valvé", "vanné", "varié", "vécés", "vécus", "vécut", "vécût", "veiné", "vélar", "vêler", "vélie", "vélin", "vélos", "vélum", "vénal", "venté", "vénus", "vergé", "vérin", "vérot", "verré", "versé", "vêtir", "vêtue", "vicié", "vidéo", "vièle", "vinée", "violé", "virée", "visée", "vissé", "vitré", "vivré", "voilà", "voilé", "voisé", "volée", "voûte", "voûté", "watté", "wengé", "xénie", "xénon", "xérus", "yémen", "zébré", "zèbre", "zéine", "zélée", "zèles", "zéros", "zoïde", "zoïle" };
    private string[] sliste6 = { };
    
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

    // utiles pour les caractères spéciaux
    private bool caret;
    private int Ctype;
    private bool activationCaret;

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
        activationCaret = false;

        Clone.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        vit = PersonalisablePartie.vitesse;
        nb = (int)PersonalisablePartie.NbLettreAlea;
        Debug.Log(nb);

        if (spec == false)
        {


            switch (nb)
            {
                case 1: break;

                case 2:
                    liste = liste2;
                    break;
                case 3:
                    liste = liste3;
                    break;
                case 4:
                    liste = liste4;
                    break;
                case 5:
                    liste = liste5;
                    break;
                case 6:
                    liste = liste6;
                    break;
            }
        }else {
            switch (nb)
            {
                case 1: break;

                case 2:
                    liste = liste2;
                    break;
                case 3:
                    liste = sliste3;
                    break;
                case 4:
                    liste = sliste4;
                    break;
                case 5:
                    liste = sliste5;
                    break;
                case 6:
                    liste = liste6;
                    break;
            }
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
                case 'ê':
                    currenttype = 30;
                    Ctype = 0;
                    break;
                case 'â':
                    currenttype = 31;
                    Ctype = 1;
                    break;
                case 'û':
                    currenttype = 32;
                    Ctype = 2;
                    break;
                case 'î':
                    currenttype = 33;
                    Ctype = 3;
                    break;
                case 'ô':
                    currenttype = 34;
                    Ctype = 4;
                    break;
                case 'ë':
                    currenttype = 35;
                    Ctype = 5;
                    break;
                case 'ü':
                    currenttype = 36;
                    Ctype = 6;
                    break;
                case 'ï':
                    currenttype = 37;
                    Ctype = 7;
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

        if (activationCaret == true) { CaracSpeciaux(); }

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
            case 'ê':

                type = 30;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'â':

                type = 31;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'û':

                type = 32;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'î':

                type = 33;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ô':

                type = 34;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ë':

                type = 35;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ü':

                type = 36;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ï':

                type = 37;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste[rand].Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
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
        caret = false;
        activationCaret = false;

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
            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
                if (caret == false)
                {
                    if (Input.GetKeyDown(KeyCode.RightBracket) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
                    {
                        activationCaret = true;
                        letter[x].GetComponent<SpriteRenderer>().color = Color.cyan;
                        caret = true;
                    }
                    else MauvaiseLettre();
                }

                break;
            case 35:
            case 36:
            case 37:
                if (caret == false)
                {
                    if (Input.GetKeyDown(KeyCode.RightBracket) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
                    {
                        activationCaret = true;
                        letter[x].GetComponent<SpriteRenderer>().color = Color.cyan;
                        caret = true;
                    }
                    else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) { } else MauvaiseLettre();
                }

                break;


        }
    }
    void CaracSpeciaux()
    {

        switch (Ctype)
        {
            case 0:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }


                break;
            case 1:
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }

                break;
            case 2:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }

                break;
            case 3:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }

                break;
            case 4:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }

                break;
            case 5:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }

                break;
            case 6:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }

                break;
            case 7:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }

                break;
        }
    }
}
