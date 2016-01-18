using UnityEngine;
using System.Collections;

public class MotAleaPerso : MonoBehaviour
{
    public static bool spec;

    private string[] liste = { "a" , "b", "c", "d","e","f"};
    private string[] liste2 = { "le", "la", "de", "ma", "si", "vu", "ah", "ce" , "je", "tu", "il", "me", "sa", "ta", "eu", "si", "lu", "es", "va" };
    private string[] liste3 = { "ace", "agi", "aie", "ail", "air", "ais", "ait", "ale", "ami", "ana", "ans", "api", "arc", "aux", "bah", "bar", "bec", "ber", "bit", "bof", "bue", "cab", "cas", "chu", "col", "cou", "dam", "des", "dit", "dom", "dru", "duo", "eau", "axa", "bai", "bas", "bol", "box", "bus", "cal", "cep", "cil", "cri", "dan", "dey", "div", "don", "dur", "axe", "bal", "bat", "bel", "bic", "boa", "bon", "boy", "but", "cap", "ces", "coq", "cru", "dia", "dix", "dos", "duc", "dus", "ego", "ben", "bis", "bob", "bru", "bye", "car", "cet", "coi", "cor", "der", "der", "dis", "dot", "due", "dut", "eut", "fax", "gag", "hue", "las", "let", "ion", "gis", "jeu", "las", "let", "lie", "lob", "lue", "eue", "fia", "fil", "fur", "gaz", "gym", "ira", "job", "lac", "lin", "lui", "est", "far", "fer", "fou", "gel", "glu", "heu", "hum", "jus", "loi", "lus", "etc", "feu", "fie", "fut", "ici", "ils", "jet", "kit", "les", "lia", "lit", "lot", "lut", "mal", "mec", "met", "mir", "mol", "mut", "nom", "ope", "off", "pou", "pur", "que", "rat", "man", "mie", "mis", "mon", "mue", "nid", "non", "nul", "par", "peu", "plu", "pua", "pus", "qui", "ria", "mat", "mer", "mit", "nez", "nie", "nos", "osa", "pas", "pro", "pub", "rie", "max", "min", "moi", "nia", "ode", "oie", "ont", "ose", "oui", "pic", "pat", "pit", "pue", "ras", "ris", "rit", "roi", "rus", "ses", "ski", "son", "suc", "tas", "tes", "tir", "top", "sec", "ses", "sir", "sud", "toc", "tue", "une", "usa", "sel", "set", "sue", "tic", "toi", "tri", "uni", "six", "sol", "sur", "tel", "ton", "tus", "van", "vil", "won", "var", "via", "vin", "vos", "zen", "yak", "zut", "cas", "vie", "vis", "vue", "yen", "ver", "vit", "zoo" };
    private string[] liste4 = { "abas", "abat", "aboi", "abot", "abri", "abus", "accu", "aces", "ache", "acra", "acre", "acte", "ados", "afin", "afro", "agar", "agio", "agir", "ahan", "aide", "aigu", "aile", "aine", "aire", "airs", "aise", "alfa", "aloi", "alpe", "alto", "alun", "amas", "amen", "amer", "amie", "amis", "ange", "anis", "anse", "ante", "apte", "ardu", "aria", "arme", "arts", "asie", "aube", "auge", "aura", "auto", "aval", "avec", "aveu", "avez", "avis", "axer", "axes", "axoa", "azur", "baba", "baby", "bacs", "bada", "baie", "bail", "bain", "bals", "banc", "bang", "bani", "bans", "bard", "bars", "base", "baud", "baux", "bave", "beat", "beau", "becs", "berk", "beur", "bibi", "bide", "bien", "bile", "bips", "bise", "bled", "blet", "bleu", "bloc", "blog", "boas", "bobo", "bock", "body", "bœuf", "bois", "bols", "bond", "bons", "book", "boom", "boot", "bora", "bord", "bore", "boss", "bouc", "boue", "boum", "bout", "boxe", "boys", "brai", "bras", "bref", "brie", "brin", "brio", "bris", "broc", "brun", "brus", "brut", "bugs", "buis", "bure", "burg", "buse", "buts", "buzz", "byte", "cabs", "cage", "cake", "cale", "came", "camp", "cane", "cape", "caps", "cars", "case", "cash", "cata", "cave", "ceci", "cela", "cens", "cent", "ceps", "cerf", "ceux", "chai", "chan", "char", "chat", "chef", "cher", "chez", "chic", "chip", "choc", "chou", "chut", "ciao", "ciel", "cils", "cime", "cinq", "cire", "city", "cive", "clac", "clam", "clan", "clap", "clef", "clic", "clim", "clin", "clio", "clip", "clos", "clou", "club", "coca", "coco", "coda", "code", "coeur", "coin", "cois", "coke", "cola", "colo", "cols", "colt", "coma", "cool", "cops", "coqs", "cors", "cosy", "coup", "cour", "cous", "crac", "cran", "cric", "crin", "cris", "croc", "crue", "cube", "cuir", "cuit", "cure", "cuve", "cyan", "cyte", "dada", "daim", "dais", "dame", "dans", "dard", "date", "deal", "demi", "deux", "dico", "dieu", "ding", "dire", "dite", "diva", "dock", "dodo", "dodu", "doge", "doit", "dojo", "donc", "dons", "dont", "dopa", "dope", "dose", "doux", "drap", "drop", "drue", "dual", "duel", "dune", "duos", "dupe", "dure", "duse", "eaux", "elfe", "elle", "embu", "envi", "eues", "exil", "expo", "face", "facs", "fada", "fade", "faim", "fait", "fana", "fane", "fans", "faon", "fard", "faut", "faux", "fers", "feta", "feux", "fief", "fiel", "fier", "file", "film", "fils", "fine", "fini", "fins", "fisc", "fixe", "flac", "flan", "flic", "flip", "floc", "flop", "flot", "flou", "fluo", "flux", "foie", "foin", "fois", "folk", "fond", "foot", "fort", "four", "fous", "frai", "fret", "fric", "frit", "froc", "fuel", "fuir", "funk", "gaga", "gage", "gaie", "gain", "gala", "game", "gang", "gant", "gars", "gate", "gave", "gays", "gaze", "geek", "gens", "gent", "glam", "glas", "goal", "gobe", "gogo", "gold", "gore", "gras", "grau", "grec", "grip", "gris", "grog", "gros", "grue", "guet", "haha", "haie", "haka", "hall", "halo", "hard", "hier", "hors", "houx", "huis", "huit", "idem", "imam", "imbu", "inca", "inde", "indu", "info", "inox", "iode", "ions", "iota", "iris", "issu", "item", "ivre", "jack", "jade", "jean", "jeep", "jerk", "jets", "jeun", "jobs", "joie", "jojo", "joli", "jonc", "jota", "joue", "joug", "jour", "juan", "judo", "juge", "juif", "juin", "jump", "jupe", "jura", "jury", "jute", "kaki", "kart", "kata", "kilo", "kilt", "kiwi", "labo", "lacs", "laid", "laie", "lais", "lait", "lama", "lame", "land", "laps", "lard", "lave", "leur", "lias", "lice", "lido", "lime", "lion", "lire", "lits", "live", "lobe", "loft", "loge", "logo", "loin", "loir", "lois", "long", "look", "lors", "lote", "loto", "lots", "loup", "lues", "luge", "lulu", "luna", "lune", "luth", "luxe", "lynx", "lyon", "lyse", "macs", "mage", "maie", "mail", "main", "mais", "mali", "malt", "mana", "marc", "mare", "mari", "mars", "math", "mats", "maxi", "mela", "menu", "mers", "meta", "mets", "meuf", "meuh", "midi", "miel", "mile", "mime", "mimi", "mine", "mini", "mire", "miro", "mise", "miso", "miss", "mite", "mixe", "mode", "mois", "moka", "mono", "mont", "mors", "mort", "moto", "mots", "moue", "mous", "muer", "mues", "muet", "muge", "mule", "muni", "murs", "musc", "muse", "must", "nage", "nain", "nana", "nase", "nefs", "nerf", "nets", "neuf", "nida", "nids", "nier", "niet", "noce", "nœud", "noir", "noix", "noma", "nome", "noms", "none", "nord", "nori", "nota", "note", "noue", "nous", "nues", "nuit", "nuls", "obus", "ocre", "oeil", "oeuf", "ogre", "oies", "omis", "once", "onde", "onyx", "onze", "opus", "oral", "orbe", "ordi", "ordo", "orge", "orne", "oser", "oses", "ossu", "ouah", "ours", "oust", "pack", "pacs", "page", "paie", "pain", "pair", "paix", "pale", "pali", "paon", "papa", "pape", "papi", "papy", "para", "parc", "pari", "part", "paye", "pays", "peau", "peps", "peur", "peut", "peux", "piaf", "pied", "pies", "pieu", "pifs", "pige", "pile", "pils", "pins", "pion", "pipe", "pipi", "pipo", "pire", "plan", "plat", "plie", "plis", "ploc", "plot", "plus", "pneu", "pogo", "poil", "pois", "poix", "poli", "polo", "poly", "pont", "porc", "pore", "port", "pose", "pote", "pots", "pour", "poux", "pris", "prix", "prof", "puce", "puer", "puis", "puni", "punk", "pure", "purs", "quad", "quai", "quel", "quid", "quiz", "quoi", "race", "rade", "raft", "rage", "raid", "raie", "rail", "rais", "rame", "rang", "rare", "rasa", "rase", "rate", "rats", "ravi", "raya", "reçu", "rein", "repu", "rhum", "rias", "ride", "rien", "rifs", "rift", "rime", "ripe", "rire", "rive", "rixe", "robe", "rock", "rocs", "rois", "roms", "rond", "rosa", "rose", "rote", "rots", "roue", "roux", "rude", "ruer", "rues", "ruse", "rush", "ruts", "sacs", "saga", "sage", "sain", "sais", "sale", "sali", "sang", "sans", "sape", "sari", "sati", "sauf", "saur", "saut", "saxe", "saxo", "scie", "seau", "secs", "sein", "self", "sels", "sens", "sept", "sera", "serf", "sets", "seul", "silo", "sire", "site", "soda", "soeur", "sofa", "soft", "soie", "soif", "soin", "soir", "soit", "sole", "solo", "sols", "sons", "sont", "sort", "sots", "sous", "spam", "star", "stop", "suer", "sues", "suie", "suif", "sure", "surf", "suri", "tact", "talc", "tant", "taon", "tapa", "tape", "tapi", "tard", "tare", "tari", "tata", "taud", "taux", "taxe", "taxi", "team", "teck", "tels", "tenu", "test", "thon", "thym", "tian", "tics", "tifs", "tige", "tilt", "tipi", "tire", "tirs", "tofu", "toge", "toit", "tolu", "tome", "tong", "tons", "topo", "tors", "tort", "toto", "tour", "tous", "tout", "toux", "trac", "tram", "trio", "trip", "tris", "troc", "trop", "trot", "trou", "truc", "tsar", "tuba", "tube", "tubs", "tuer", "tupi", "turc", "type", "typo", "unes", "unie", "unir", "vain", "vans", "vaut", "vaux", "veau", "velu", "vent", "venu", "vers", "vert", "veto", "veuf", "vice", "vide", "vies", "vifs", "vins", "vire", "visa", "visu", "vite", "vive", "voeu", "voeux", "voie", "voir", "voix", "vole", "vols", "volt", "vomi", "vote", "vous", "vrac", "vrai", "vues", "yack", "yeux", "yoga", "zest", "zinc", "zona", "zone", "zoom", "zoos", "zouk" };
    private string[] liste5 = { "aboie", "abois", "abord", "about", "abuse", "accot", "achat", "acide", "acier", "acini", "acore", "actai", "acter", "adage", "adent", "adieu", "admis", "adore", "adret", "adule", "aequo", "agace", "agami", "agate", "agave", "agent", "agile", "agite", "agnat", "agora", "ahane", "aiche", "aidai", "aider", "aient", "aigle", "aigre", "aille", "aimai", "aimer", "ainsi", "airai", "airer", "ajonc", "ajour", "ajout", "album", "aldol", "aleph", "algie", "algol", "algue", "alias", "alibi", "alios", "alise", "alite", "allai", "aller", "allie", "alors", "alose", "alpax", "alpha", "alune", "aluni", "alyte", "amble", "ambon", "ambre", "amibe", "amict", "amide", "amome", "amont", "amour", "amphi", "ample", "ampli", "amure", "amuse", "amyle", "anche", "ancre", "aneth", "angle", "angon", "angor", "anime", "anion", "anise", "anode", "antan", "antre", "aorte", "aphte", "apiol", "apion", "aplat", "apode", "appas", "appel", "appui", "apure", "arabe", "arase", "arbre", "arche", "ardue", "argas", "argon", "argot", "argue", "argus", "aride", "arise", "armai", "armer", "armet", "armon", "arobe", "arque", "artel", "aryle", "asile", "aspic", "asple", "asque", "assai", "assez", "assis", "aster", "astre", "atlas", "atoll", "atome", "atone", "atour", "atout", "aubin", "aucun", "audio", "audit", "auget", "aulne", "aurai", "aussi", "autan", "autel", "autre", "avais", "avait", "avale", "avant", "avare", "avent", "avers", "avide", "aviez", "avine", "avion", "avise", "aviso", "avive", "avoir", "avons", "avoue", "avril", "axais", "axile", "axone", "ayant", "ayons", "azote", "azure", "azyme", "babil", "bacon", "bacul", "badge", "baffe", "bagad", "bagne", "bagou", "bague", "bahut", "baise", "balai", "balle", "balsa", "balte", "banco", "bande", "banjo", "banne", "barbe", "barde", "barge", "baril", "barre", "barri", "barye", "basai", "baser", "basic", "basin", "basse", "baste", "batik", "batte", "bauge", "baume", "bavai", "baver", "bayai", "bayer", "bayou", "bazar", "beauf", "becte", "bedon", "beige", "belge", "belle", "belon", "benne", "berce", "berge", "berme", "berne", "bette", "biais", "bible", "biche", "bicot", "bidet", "bidon", "biffe", "bigle", "bigre", "bigue", "bijou", "bilai", "bilan", "biler", "bille", "binai", "biner", "bingo", "biogr", "bique", "birbe", "bisai", "biser", "biset", "bison", "bisou", "bisse", "bitai", "biter", "bitos", "bitte", "bizut", "black", "blair", "blanc", "blaps", "blase", "bleue", "blues", "bluff", "blute", "bocal", "boche", "boeuf", "bogie", "bogue", "boire", "boise", "boite", "boldo", "bolet", "bombe", "bonde", "bondi", "bonne", "bonus", "bonze", "boots", "borax", "borde", "borne", "bosco", "boson", "bosse", "botte", "boude", "bouge", "bouif", "boule", "boume", "bourg", "bouse", "boute", "bovin", "boxai", "boxer", "boyau", "brade", "braie", "brait", "brame", "brase", "brave", "bravo", "braye", "break", "brick", "bride", "brife", "brime", "brise", "brize", "brode", "broie", "brome", "brook", "broum", "brout", "bruir", "bruis", "bruit", "bruma", "brume", "brune", "brute", "bubon", "buggy", "bugle", "buire", "bulbe", "bulle", "burin", "buron", "buste", "butai", "buter", "butin", "butor", "butte", "caban", "cabas", "cabot", "cabre", "cabri", "cabus", "cacao", "cache", "caddy", "cadre", "caduc", "cafre", "cafte", "caget", "cagne", "cahot", "cairn", "cajou", "cajun", "calai", "calao", "caler", "calme", "calmi", "calot", "calte", "calus", "calva", "camai", "camer", "campe", "camus", "canai", "canal", "caner", "canif", "canna", "canne", "canon", "canot", "canut", "caoua", "capot", "cappa", "capte", "caque", "carat", "carde", "carex", "cargo", "carie", "carme", "carne", "caron", "carpe", "carre", "carry", "carte", "casai", "caser", "casse", "caste", "catch", "catin", "catir", "catis", "cauri", "cause", "cavai", "caver", "cavet", "cedex", "ceins", "celai", "celer", "cella", "celle", "celte", "celui", "cerce", "cerne", "cesse", "ceste", "cette", "champ", "chant", "chaos", "chape", "chaut", "chaux", "cheik", "chiai", "chier", "chine", "chiot", "chipe", "chips", "choie", "choir", "chois", "choit", "choix", "chope", "chose", "chott", "chute", "chyle", "chyme", "cible", "cidre", "cieux", "cille", "cippe", "cirai", "cirer", "ciron", "cirre", "ciste", "citai", "citer", "clade", "claie", "clame", "clamp", "clape", "clapi", "clave", "clebs", "clerc", "clive", "clodo", "clone", "clope", "clore", "close", "cloue", "clown", "cluse", "coach", "coati", "cobol", "cobra", "coche", "cocon", "codai", "coder", "codex", "codon", "coeur", "cogne", "cohue", "coing", "coite", "colin", "colis", "colle", "colza", "combe", "comma", "comme", "comte", "conga", "conte", "copal", "copie", "copra", "copte", "coque", "coran", "corde", "corne", "coron", "corps", "corse", "cosse", "cotai", "coter", "cotir", "cotis", "coton", "cotte", "couac", "coude", "couds", "couic", "coule", "coupe", "cours", "couve", "coyau", "crabe", "crack", "crado", "craie", "crame", "crane", "crase", "crash", "crave", "crawl", "credo", "criai", "crier", "crime", "crise", "crois", "croix", "cross", "cubai", "cuber", "cucul", "cuire", "cuite", "culai", "culer", "culex", "culot", "culte", "cumin", "cumul", "curai", "curer", "curie", "curry", "cuvai", "cuver", "cycas", "cycle", "cygne", "dague", "dahir", "daine", "dalle", "dalot", "damai", "daman", "damer", "damne", "dandy", "danse", "darce", "darde", "darne", "darse", "datai", "dater", "datte", "daube", "delco", "delta", "demie", "dense", "derby", "derme", "derny", "dette", "deuil", "devin", "devis", "devon", "diane", "diapo", "dicte", "didot", "diffa", "digit", "digne", "digon", "digue", "dilue", "dinar", "dinde", "dingo", "diode", "dirai", "disco", "divan", "djinn", "docte", "dodue", "dogme", "dogue", "doigt", "dolai", "dolce", "doler", "dolic", "donne", "dopai", "doper", "dorai", "dorer", "doris", "dormi", "dosai", "doser", "dosse", "dotai", "doter", "douai", "douar", "douce", "douer", "douro", "doute", "douve", "douze", "draie", "drain", "drame", "drape", "drave", "draye", "drill", "dring", "drink", "drive", "drope", "drupe", "duale", "ducat", "duite", "dulie", "duodi", "dupai", "duper", "durai", "durer", "durit", "duvet", "dyade", "effet", "eider", "elbot", "embue", "empan", "encan", "encas", "encre", "endos", "enfer", "enfeu", "enfin", "enfle", "engin", "enjeu", "enlie", "ennui", "entai", "enter", "entre", "envie", "envoi", "envol", "ergot", "errai", "errer", "esche", "escot", "espar", "essai", "essor", "ester", "estoc", "exeat", "exige", "exigu", "exile", "exode", "expie", "extra", "fable", "facho", "facto", "fader", "fagne", "fagot", "faire", "fakir", "fallu", "falun", "fanai", "fanal", "faner", "fange", "fanon", "farad", "farce", "farde", "farte", "faste", "fatma", "fatum", "faune", "faute", "fauve", "favus", "faxai", "faxer", "fayot", "feins", "femme", "fends", "fenil", "fente", "ferai", "ferle", "ferme", "ferre", "ferry", "fesse", "feuil", "feule", "fiais", "fibre", "fiche", "ficus", "fifre", "figer", "figue", "filai", "filer", "filet", "filin", /* "fille", "filme", "filon", "filou", "finir", "finis", "fiole", "firme", "fixai", "fixer", "fjeld", "fjord", "flair", "flanc", "flash", "flein", "fleur", "flint", "flirt", "flood", "flore", "floue", "fluai", "fluer", "fluor", "flush", "fluxe", "foehn", "foire", "folie", "folio", "folle", "fonce", "fonde", "fonds", "fonte", "fonts", "forai", "force", "forci", "forer", "foret", "forge", "forme", "forte", "forum", "fosse", "fouet", "fouge", "fouir", "fouis", "foule", "foute", "foyer", "fraie", "frame", "franc", "frape", "fraye", "frein", "freux", "frigo", "frime", "fripe", "frire", "frise", "frite", "fritz", "front", "froue", "fruit", "fucus", "fugue", "fuite", "fumai", "fumer", "fumet", "funin", "funky", "furax", "furet", "furia", "furie", "fusai", "fusel", "fuser", "fusil", "futur", "gadin", "gaffe", "gager", "gagne", "gaine", "galbe", "galle", "gallo", "galon", "galop", "gamba", "gambe", "gamma", "gamme", "ganga", "ganse", "gante", "garai", "garce", "garde", "garer", "garou", "gatte", "gaude", "gaule", "gaupe", "gauss", "gavai", "gaver", "gayal", "gazai", "gazer", "gazon", "gecko", "geins", "gelai", "geler", "gemme", "genet", "genou", "genre", "gerbe", "gerce", "germe", "gesse", "geste", "gibet", "gibus", "gicle", "gifle", "gigot", "gigue", "gilde", "gilet", "gille", "girie", "giron", "giton", "givre", "glace", "glane", "glass", "glati", "globe", "glome", "glose", "gluau", "glume", "gnome", "gnose", "gobai", "gober", "gobie", "godai", "goder", "godet", "goglu", "golfe", "gombo", "gomme", "gonde", "gonze", "goret", "gorge", "gosse", "goton", "gouda", "gouet", "gouge", "goule", "goure", "goyim", "grade", "grave", "green", "grief", "grill", "grime", "grise", "grive", "groin", "grole", "groom", "group", "gruau", "gruge", "grume", "guais", "guano", "guide", "guipe", "guise", "guppy", "guzla", "gypse", "gyrin", "habit", "hable", "hache", "hadji", "haine", "haire", "halai", "halbi", "haler", "halle", "halte", "halva", "hamac", "hampe", "hanap", "hanse", "hante", "hapax", "happe", "haras", "harde", "harem", "haret", "harki", "harle", "harpe", "hasch", "haste", "haute", "havai", "haver", "havir", "havis", "havre", "hayon", "hecto", "hello", "henry", "herbe", "herpe", "herse", "hertz", "heure", "heurt", "hibou", "hindi", "hippy", "hisse", "hiver", "hobby", "hocco", "hoche", "homme", "honte", "horde", "horst", "hosto", "hotte", "houai", "houer", "houka", "houle", "hourd", "houri", "hoyau", "huais", "huard", "huart", "huche", "huile", "humai", "humer", "humus", "huppe", "hurle", "hutte", "hydne", "hydre", "hymen", "hymne", "iambe", "iceux", "ichor", "ictus", "idole", "igloo", "ilion", "ilote", "image", "imago", "imbue", "imide", "imite", "imper", "impie", "index", "indue", "infra", "inlay", "input", "inter", "inuit", "inule", "iodai", "ioder", "iodle", "ioule", "irise", "irone", "isard", "islam", "isole", "issue", "ixode", "jable", "jabot", "jacot", "jacte", "jadis", "jalap", "jalon", "jambe", "jante", "japon", "jappe", "jaque", "jarde", "jarre", "jasai", "jaser", "jaspe", "jatte", "jauge", "jaune", "javel", "jenny", "jerez", "jerke", "jetai", "jeter", "jeton", "jette", "jeudi", "jeune", "jodle", "joins", "joint", "joker", "jolie", "jonce", "jouai", "joual", "jouer", "jouet", "joule", "joute", "joyau", "juche", "judas", "juger", "juill", "juive", "julep", "jules", "jumbo", "jumel", "junte", "jupon", "jurai", "jurat", "jurer", "juron", "jusqu", "juste", "jutai", "juter", "kacha", "kache", "kapok", "kappa", "karma", "kayac", "kayak", "kendo", "ketch", "knout", "koala", "kraal", "krach", "kraft", "kriss", "ksour", "kurde", "kyrie", "kyste", "label", "labre", "labri", "lacer", "lacet", "lacis", "ladin", "ladre", "lagon", "laide", "laine", "laird", "laize", "lamai", "lamer", "lamie", "lampe", "lance", "lande", "lange", "lapai", "laper", "lapis", "laque", "larde", "large", "largo", "larme", "larve", "laser", "lasse", "lasso", "latex", "latte", "laure", "lavai", "laver", "lavis", "layai", "layer", "layon", "lazzi", "lebel", "ledit", "lemme", "lente", "lento", "leste", "leude", "levai", "lever", "lexie", "lexis", "liage", "liais", "liane", "liard", "liber", "libre", "liche", "licol", "licou", "lieue", "lieux", "lifte", "ligie", "ligne", "ligot", "ligue", "lilas", "limai", "liman", "limbe", "limer", "limon", "liner", "linga", "linge", "links", "linon", "lippe", "lirai", "liron", "lisse", "liste", "litai", "liter", "litho", "litre", "liure", "livet", "livre", "lobai", "lobby", "lober", "loche", "loden", "loess", "lofai", "lofer", "loger", "logis", "longe", "looch", "loofa", "lopin", "loque", "loran", "loris", "lorry", "lotir", "lotis", "lotte", "lotus", "louai", "louer", "loufe", "louis", "loupe", "loure", "louve", "lovai", "lover", "loyer", "lubie", "lucre", "lueur", "luffa", "luger", "luire", "lumen", "lunch", "lundi", "lupin", "lupus", "lusin", "lutai", "luter", "lutin", "lutte", "luxai", "luxer", "lycra", "lyric", "lysai", "lysat", "lyser", "macho", "macis", "macle", "macre", "macro", "mafia", "magie", "magma", "magne", "magot", "maire", "major", "malin", "malle", "malte", "malus", "maman", "mambo", "mamie", "mammy", "mande", "mange", "manie", "manne", "manse", "mante", "maque", "mardi", "marge", "marie", "marli", "marne", "marre", "marte", "maser", "masse", "mataf", "matai", "match", "mater", "matin", "matir", "matis", "matou", "matte", "maure", "mauve", "mayen", "melon", "menai", "mener", "mense", "menue", "merci", "merde", "merle", "merlu", "messe", "meule", "meurs", "meute", "mezzo", "miaou", "miche", "micro", "mieux", "migre", "milan", "mille", "mimai", "mimer", "minai", "mince", "minci", "miner", "minot", "minou", "minus", "mirai", "mirer", "misai", "miser", "mitai", "mitan", "miter", "miton", "mitre", "mixai", "mixer", "mixte", "moche", "modem", "modus", "moere", "moine", "moins", "moire", "moise", "moisi", "moite", "molle", "mollo", "momie", "monde", "monel", "monte", "moque", "mords", "morio", "morne", "morse", "morte", "morue", "morve", "motel", "motet", "motif", "motte", "motus", "mouds", "moule", "moult", "mouve", "moyeu", "muais", "muche", "mucor", "mucus", "mufle", "mufti", "mugir", "mugis", "mulet", "mulon", "mulot", "munir", "munis", "murai", "murer", "muret", "murex", "musai", "muser", "musse", "mutai", "muter", "myome", "myope", "myrte", "mythe", "nabab", "nacre", "nadir", "nager", "naine", "nanan", "nanar", "napel", "nappe", "narre", "nasse", "natte", "navet", "navre", "nazie", "nebka", "neige", "nenni", "nervi", "nette", "neume", "neuve", "neveu", "niais", "niche", "nicol", "nille", "nimbe", "ninas", "nippe", "nique", "nitre", "noble", "noeud", "noire", "noise", "nolis", "nomme", "nonce", "nonne", "nopai", "nopal", "noper", "nordi", "noria", "norme", "notai", "noter", "notre", "nouai", "nouba", "nouer", "novai", "nover", "noyai", "noyau", "noyer", "nuage", "nuais", "nuire", "nulle", "nuque", "nurse", "nylon", "oasis", "obier", "objet", "obole", "obvie", "ocrai", "ocrer", "octet", "odeur", "offre", "oflag", "ogive", "oille", "ointe", "oints", "oison", "okapi", "olive", "omble", "ombre", "omets", "omise", "oncle", "ongle", "opale", "opiat", "opine", "opium", "optai", "opter", "orage", "orale", "ordre", "orgie", "orgue", "oriel", "ornai", "orner", "orobe", "orpin", "orque", "ortie", "orvet", "osais", "oscar", "oside", "osier", "osque", "ossue", "otage", "otite", "ouais", "ouate", "oubli", "ouche", "ouest", "ourle", "ourse", "ouste", "outil", "outre", "ouvre", "ovale", "ovate", "ovine", "ovule", "oxyde", "oyais", "ozone", "pacha", "pacte", "paddy", "padou", "pagel", "pager", "pagne", "pagre", "pagus", "paire", "palan", "palis", "palle", "palme", "palot", "palpe", "palud", "palus", "pampa", "panai", "panax", "panca", "panda", "panel", "paner", "panic", "panka", "panne", "panse", "pante", "parai", "parce", "pardi", "parer", "parie", "parka", "parle", "parme", "parmi", "paroi", "paros", "parte", "parus", "passe", "pater", "patin", "patio", "patte", "paume", "pause", "pavai", "paver", "pavie", "pavot", "payai", "payer", "payse", "pedum", "peine", "peins", "pelai", "peler", "pelle", "pelta", "pends", "penne", "penny", "penon", "pense", "pente", "perce", "perds", "perle", "perse", "perte", "pesai", "peser", "peson", "pesse", "peste", "peton", "phage", "phare", "phase", "philo", "phlox", "phone", "phono", "photo", "piano", "picot", "pifai", "pifer", "piffe", "piger", "pigne", "pilaf", "pilai", "piler", "pilet", "pille", "pilon", "pilot", "pilou", "pilum", "pince", "pinne", "pinot", "pinte", "pipai", "piper", "pipit", "pique", "pisse", "piste", "piton", "pitre", "pivot", "pixel", "pizza", "place", "plage", "plaid", "plaie", "plais", "plane", "plate", "pleur", "pleut", "pliai", "plier", "ploie", "plomb", "plouc", "plouf", "plouk", "pluie", "plume", "poche", "pogne", "poids", "poile", "poing", "poins", "poire", "poise", "poker", "polar", "polio", "polir", "polis", "polka", "pomme", "pompe", "ponce", "ponds", "poney", "ponte", "poque", "porno", "porte", "porto", "posai", "poser", "poste", "potin", "potto", "pouah", "pouce", "poule", "pouls", "poupe", "prame", "preux", "priai", "prier", "prime", "primo", "prise", "prive", "probe", "proie", "prolo", "promo", "promu", "prose", "prote", "proue", "provo", "prude", "prune", "psitt", "psoas", "puais", "pubis", "puche", "puise", "puits", "pulpe", "pulse", "punch", "punir", "punis", "purge", "purin", "purot", "putti", "putto", "pyrex", "quand", "quant", "quark", "quasi", "queue", "queux", "quine", "quint", "quipo", "quipu", "quota", "raban", "rabat", "rabbi", "rabot", "racer", "racle", "radai", "radar", "rader", "radie", "radio", "radis", "rafle", "rager", "ragot", "rague", "raide", "raine", "rajah", "ralle", "ramai", "ramer", "ramie", "rampe", "rance", "ranch", "range", "raout", "rapin", "raque", "rasai", "raser", "rasta", "ratai", "ratel", "rater", "ratio", "raton", "ravir", "ravis", "rayai", "rayer", "rayon", "rebab", "rebec", "rebut", "recel", "recez", "recta", "recto", "redan", "refus", "reine", "rejet", "relax", "relie", "remue", "rends", "renie", "renne", "renom", "rente", "repas", "repic", "repli", "repos", "repue", "repus", "reste", "rhumb", "rhume", "riais", "rible", "riche", "ricin", "ridai", "rider", "rient", "rifle", "rimai", "rimer", "rince", "riote", "ripai", "riper", "rirai", "rital", "rivai", "river", "rivet", "robai", "rober", "robin", "robot", "roche", "rocou", "rodai", "roder", "rogne", "rogue", "roide", "roman", "romps", "ronce", "ronde", "rondo", "ronge", "roque", "rosai", "rosat", "roser", "rosir", "rosis", "rosse", "rotai", "roter", "rotin", "rotor", "rouai", "rouer", "rouge", "rouir", "rouis", "roule", "roumi", "round", "route", "ruade", "ruais", "ruban", "rubis", "ruche", "rugby", "rugir", "rugis", "ruile", "ruine", "rumba", "rumen", "rumex", "ruolz", "rusai", "ruser", "russe", "sabir", "sable", "sabot", "sabra", "sabre", "sacre", "safre", "sagou", "sagum", "sahel", "saine", "sajou", "salai", "salep", "saler", "salir", "salis", "salle", "salol", "salon", "salop", "salsa", "salse", "salue", "salut", "salve", "samba", "samit", "sampi", "sanie", "sanve", "sanza", "sapai", "saper", "sapin", "saque", "sarde", "saros", "sasse", "satin", "sauce", "sauge", "saule", "sauna", "saune", "saure", "saute", "sauve", "savon", "sayon", "sbire", "scalp", "scare", "sceau", "schah", "sciai", "scier", "scion", "scoop", "score", "scull", "scuta", "sebka", "secte", "seime", "seine", "seing", "seize", "selle", "selon", "seltz", "selve", "semai", "semer", "semis", "senau", "senne", "seoir", "serai", "serbe", "serge", "serif", "serpe", "serre", "serte", "seuil", "seule", "sevre", "sexte", "sexto", "shako", "shoot", "short", "shunt", "sicle", "sieur", "sigle", "sigma", "signe", "silex", "singe", "sinon", "sinus", "sioux", "sirex", "sirli", "sirop", "sisal", "sitar", "situe", "sixte", "skate", "skiai", "skier", "skiff", "slang", "slave", "sloop", "smala", "smalt", "smart", "smash", "smolt", "smurf", "snack", "sniff", "snobe", "sobre", "socle", "soeur", "solde", "solen", "solex", "solin", "somme", "sonar", "sonde", "songe", "sonne", "sorbe", "sosie", "sotch", "sotie", "sotte", "souci", "soude", "soupe", "souri", "soute", "soyer", "soyez", "spahi", "spart", "spath", "sphex", "spire", "spore", "sport", "sprat", "spray", "sprue", "squat", "squaw", "stade", "staff", "stage", "stand", "stase", "steak", "stemm", "stick", "stipe", "stock", "store", "stout", "stras", "strie", "strix", "style", "stylo", "suage", "suais", "suave", "suber", "subir", "subis", "sucer", "sucre", "sueur", "suife", "suint", "suite", "suive", "sulky", "sumac", "sunna", "super", "supin", "suppl", "supra", "surah", "surfe", "surgi", "surin", "surir", "suris", "suros", "sushi", "sutra", "swing", "sylve", "sympa", "tabac", "tabar", "table", "tabor", "tacca", "tacet", "tache", "tacon", "tacot", "tafia", "tagal", "taire", "talai", "taler", "talle", "talon", "talus", "tamia", "tamil", "tamis", "tance", "tango", "tanin", "tanne", "tante", "tapai", "taper", "tapin", "tapir", "tapis", "tapon", "taque", "tarai", "tarde", "tarer", "taret", "targe", "tarif", "tarin", "tarir", "taris", "tarot", "tarse", "tarte", "tarti", "tasse", "tatou", "taule", "taupe", "taure", "taxai", "taxer", "taxie", "taxon", "tchao", "teins", "telle", "tempe", "tempo", "temps", "tends", "tenir", "tenon", "tente", "terce", "terme", "terne", "terre", "terri", "terse", "teste", "tette", "texte", "thora", "thorn", "thune", "thuya", "tiare", "tibia", "tiens", "tiers", "tiffe", "tigre", "tilde", "tille", "timon", "tinte", "tique", "tirai", "tirer", "tisai", "tiser", "tison", "tisse", "tissu", "titre", "toast", "toile", "toise", "tokai", "tokay", "tolet", "tomai", "tombe", "tomer", "tomme", "tommy", "tonds", "tonie", "tonka", "tonna", "tonne", "tonte", "tonus", "topai", "toper", "toque", "torah", "tords", "torii", "toril", "toron", "torse", "torve", "totem", "toton", "touai", "touer", "tourd", "toute", "trabe", "trace", "tract", "train", "trais", "trame", "tramp", "triai", "trial", "tribu", "trick", "tridi", "trier", "trime", "trine", "triol", "tripe", "trois", "troll", "tronc", "trope", "troue", "truck", "truie", "trust", "tuage", "tuais", "tubai", "tuber", "tuile", "tulle", "tuner", "tuque", "turbe", "turbo", "turco", "turne", "tutie", "tutti", "tuyau", "tweed", "twist", "typai", "typer", "typha", "typon", "tyran", "ukase", "ultra", "ulule", "union", "urane", "urate", "urgea", "urger", "urubu", "usage", "usais", "usine", "usure", "utile", "uvale", "uvula", "uvule", "vache", "vagir", "vagis", "vague", "vaine", "valet", "valse", "valus", "valve", "vampe", "vanda", "vanne", "vante", "vaque", "varan", "varie", "varus", "varve", "vaste", "veine", "velot", "velte", "velue", "vends", "venge", "venin", "venir", "venta", "vente", "verbe", "verge", "verre", "verse", "verso", "verte", "vertu", "verve", "vesce", "vesse", "veste", "veule", "veuve", "vexai", "vexer", "vibre", "vichy", "vicie", "vidai", "vider", "vieil", "viens", "vieux", "vigie", "vigne", "villa", "ville", "vinai", "viner", "vingt", "viole", "virai", "virer", "virus", "visai", "viser", "vison", "visse", "vitae", "vitre", "vivat", "vivre", "vizir", "vogue", "voici", "voile", "voire", "volai", "voler", "volet", "volis", "volte", "volve", "vomer", "vomir", "vomis", "votai", "voter", "votre", "vouai", "vouer", "vouge", "voyer", "voyou", "vraie", "vulgo", "vulve", "wagon", "weber", "wharf", "whist", "winch", "xipho", "xyste", "yacht", "yeuse", "yucca" */ };
    private string[] liste6 = { "absent", "abonne", "aborde", "acheva", "acides", "affame", "affine", "allant", "allait", "alcool", "alarme", "baigne", "balade", "banane", "babine", "balais", "bandit", "balise", "bagage", "bajoue", "bambou", "bennes", "bidule", "beurre", "berner", "belote", "blabla", "blondi", "bobard", "blouse", "blonde", "blancs", "bizuts", "bocaux", "boeufs", "brader", "bougie", "boxant", "boulot", "bourde", "braise", "boudes", "brebis", "braies", "brasse", "brelan", "brises", "brouet", "brouta", "bruine", "bronze", "brouet", "butins", "bulles", "butome", "brumes", "bruies", "bureau", "cafard", "caille", "calcul", "cacher", "cabine", "cabane", "cabrer", "caducs", "cachez", "captif", "captai", "canyon", "canifs", "citron", "chaume", "charme", "chauds", "champi", "chanta", "chauve", "charge", "chenil", "chimie", "cigare", "ciller", "chrome", "chlore", "cibles", "chutes", "choque", "chopes", "choses", "chuter", "ciment", "cigale", "datais", "danses", "daigna", "dauber", "dalton", "dattes", "dagues", "devoir", "devise", "devons", "dicton", "dindon", "diluas", "dicton", "dettes", "disons", "divans", "dirent", "dirige", "disque", "doigts", "doigte", "dogmes", "drague", "dragon", "droite", "empire", "encart", "encave", "encens", "enclos", "emmena", "empois", "enroba", "enfoui", "enivra", "entama", "entour", "envers", "envahi", "enlise", "essora", "esprit", "espace", "espoir", "estime", "estima", "escroc", "erreur", "essuya", "ethnie", "exalte", "excuse", "exclue", "expire", "expira", "expier", "farces", "farter", "faucon", "fatale", "fatals", "ferrer", "feutra", "festin", "fermes", "fesses", "fermer", "fendit", "fichai", "fibres", "flocon", "floral", "fleuve", "flaque", "flamme", "forban", "fondue", "forage", "fluide", "fuyard", "fusera", "fumeux", "frotte", "gagnes", "galion", "gamine", "gadoue", "garage", "galons", "gibets", "gifler", "gisant", "girafe", "germes", "gendre", "genres", "gobent", "gloire", "gobera", "goulue", "gommes", "gonfle", "goujon", "grille", "griffe", "grimpe", "guidon", "guidai", "habile", "haleur", "harder", "hacher", "hareng", "habite", "homard", "hivers", "heurta", "hockey", "hymnes", "humble", "impair", "impoli", "impose", "inapte", "incuba", "isoler", "ironie", "intime", "intact", "inonda", "ivoire", "jaguar", "jarres", "jaunes", "jokers", "jauger", "jamais", "jasmin", "jambes", "jaunes", "jument", "jumeau", "jungle", "jurent", "jonque", "joueur", "jouent", "jonche", "kaolin", "koalas", "kimono", "kelvin", "kraken", "labour", "lagune", "lamine", "labeur", "labels", "laitue", "lavent", "lavera", "levure", "lierre", "ligues", "lieues", "lionne", "ligote", "lisage", "lisent", "lutins", "lovait", "loyale", "lutter", "lourde", "louves", "loyaux", "longue", "magnum", "malins", "mamies", "madame", "manioc", "manque", "mairie", "maigre", "menhir", "mentir", "meuble", "mettre", "mignon", "minime", "minute", "minuit", "mollir", "montre", "monter", "mixeur", "muffin", "mulets", "moudra", "mythes", "myopie", "mygale", "mutant", "muscat", "navale", "neveux", "niaise", "navale", "nasale", "native", "notera", "nougat", "nuance", "normes", "nuques", "nuises", "normes", "nouent", "nymphe", "noyaux", "novice", "ondule", "ombrer", "opiner", "odorat", "odeurs", "oignon", "oiseau", "ongles", "office", "oxydes", "ovuler", "oublia", "oublie", "ouvrer", "oublis", "pagaye", "paille", "pagure", "panier", "papier", "panner", "pauvre", "pavane", "partez", "parler", "parfum", "penser", "perdue", "permis", "phoque", "photos", "permis", "picole", "pichet", "persil", "piquer", "piques", "pilule", "pileur", "piment", "pirate", "pocher", "poiler", "plisse", "pleuve", "pleine", "pondue", "pollue", "porche", "posant", "poivre", "police", "points", "poings", "pomper", "python", "puiser", "punira", "purger", "pronom", "pudeur", "pseudo", "quarts", "quotas", "quartz", "quinoa", "quiche", "rachat", "rafler", "raidir", "radian", "rasoir", "rebord", "ravale", "refond", "refila", "rejeta", "relate", "renoms", "renard", "rentre", "relaxe", "repars", "ridage", "rideau", "revenu", "revend", "robots", "rinces", "rodait", "rocher", "rivale", "ronger", "rosser", "rougir", "rythme", "russes", "router", "routes", "rougir", "royale", "safari", "salade", "salons", "sabord", "salami", "saison", "salade", "savons", "savent", "seiche", "second", "savane", "seules", "simule", "sirops", "singes", "sonner", "sonnet", "sortie", "sortir", "sommer", "subite", "stylos", "subtil", "statue", "statua", "succin", "surgit", "surgir", "surfer", "survie", "sushis", "sucent", "sueurs", "suffit", "sphinx", "suisse", "france", "italie", "survol", "sujets", "surent", "tajine", "tables", "tacots", "tabacs", "tamise", "tables", "tabler", "tendre", "tendue", "tennis", "tenues", "taurin", "temple", "teneur", "tenons", "tendre", "tatane", "tigres", "tiques", "timide", "thymus", "urbain", "utopie", "ultime", "uniras", "unions", "unifie", "unique", "usages", "userai", "usurpa", "utopie", "valent", "valide", "vannes", "vagues", "valise", "vanter", "vaccin", "vapeur", "vaincu", "vernis", "verrou", "vendue", "vessie", "virils", "virage", "visant", "viseur", "virils", "vident", "votera", "voulus", "voulut", "voleur", "voiler", "voulez", "voulue", "volcan", "wambat", "wagons", "yaourt", "yourte", "yachts", "zombie", "zigzag", "zouave", "zinzin" };
    private string[] liste7 = { "abandon", "abdomen", "abeille", "abaissa", "accouru", "adopter", "alpiste", "amender", "amarrer", "alourdi", "annuels", "animons", "accorde", "assumer", "attiser", "auditif", "aveugle", "avocats", "avorton", "auteurs", "babille", "babines", "bailler", "baigner", "barbues", "banquer", "bambous", "besoins", "beurres", "biaiser", "bichons", "berceau", "blaguer", "bitures", "bizarre", "blouson", "blondir", "blouses", "boutons", "bourses", "bouleau", "bowling", "butinai", "budgets", "buffets", "cachant", "cadeaux", "cadreur", "cadenas", "cabanes", "caporal", "chatons", "chemine", "cherche", "choquer", "chopper", "choisir", "convive", "convins", "constat", "connota", "confuse", "coupler", "couguar", "cyclone", "cymbale", "cumuler", "culotte", "dactylo", "dallant", "dateras", "dateurs", "descend", "destins", "dessert", "deviner", "deviens", "devrais", "diabolo", "diables", "dorsale", "dormait", "dortoir", "douille", "doutent", "doublon", "draines", "duveter", "durcira", "enleves", "enlever", "enlevas", "emmenai", "emmener", "enlacer", "enlevai", "enneige", "environ", "envoler", "enviera", "envahir", "extrade", "extrais", "exultas", "excuser", "excusas", "exalter", "famille", "faluche", "faillis", "fallait", "fatigue", "fascina", "fatales", "faisait", "feulons", "feuilla", "feutres", "fiances", "ferreur", "fromage", "fougera", "fouilla", "forfais", "fouleur", "fourbie", "fumants", "fuiront", "galaxie", "galbant", "gagniez", "galopin", "gaffera", "gaminai", "gaminer", "gaulois", "gibbons", "germain", "germent", "glyphes", "gobelin", "glycine", "glousse", "gravas", "grappin", "gratter", "granula", "grainer", "gravure", "hancher", "hantise", "harcela", "haricot", "harnois", "harpera", "hindous", "hissera", "heurtas", "hiverna", "hochant", "hockeys", "hourras", "homards", "honorai", "hurlant", "hurleur", "humecte", "hublots", "huilera", "huilait", "immoler", "imposer", "implora", "impunie", "immigre", "incisif", "inceste", "imagent", "inflige", "influas", "infuser", "interna", "intimes", "insigne", "insolai", "intruse", "innovez", "insecte", "inocula", "intacte", "isolant", "jalonna", "jactait", "jardina", "jardine", "jaseras", "jardons", "jaillir", "jumelas", "jumeler", "jurerai", "jureras", "jumelle", "juniors", "jureurs", "judokas", "journal", "joyeuse", "jugeons", "juguler", "joueuse", "jouisse", "karting", "klaxons", "kouglof", "krypton", "kabyles", "kleenex", "kanakes", "kimonos", "kumquat", "ketchup", "laboura", "lactose", "laineur", "laissai", "laitier", "largeur", "larcins", "lardent", "larguer", "lancera", "langues", "lapides", "lampera", "lessive", "leucome", "lestera", "letchis", "lexique", "lestage", "leucose", "levures", "magasin", "malices", "malsain", "magenta", "maillot", "maisons", "malaise", "manades", "maigres", "malaxer", "magnats", "malaxer", "malotru", "marmite", "maigrie", "managea", "modules", "moindre", "moineau", "mitiger", "moderne", "nageras", "natales", "nargues", "navette", "nasales", "navigua", "navales", "navigue", "natives", "navires", "nouerai", "normand", "noteras", "nudiste", "normale", "notable", "nuirais", "nommant", "nourrit", "nuisent", "nymphes", "odorant", "occulte", "octroie", "offerts", "occuper", "obtiens", "obtenir", "offense", "offrant", "obturer", "odieuse", "ornerai", "oscilla", "oserais", "oseille", "ordonne", "opprima", "origine", "orteils", "osselet", "oscilla", "pactole", "paginas", "palette", "pactise", "pallier", "paillas", "palmait", "palmera", "palabre", "palmier", "palmera", "pilleur", "pimenta", "piloter", "pierres", "pigment", "pilotis", "prierai", "preniez", "prendra", "preneur", "quantum", "quarrer", "quartez", "queuter", "quitter", "quittes", "quottai", "queutas", "quinine", "quotter", "quintal", "railler", "raisins", "ragotai", "raflent", "rainera", "rafales", "radoube", "rajeuni", "raseurs", "rassura", "rasante", "rapiner", "refondu", "reluire", "reloges", "relevez", "rejuger", "reluira", "repassa", "reparle", "repasse", "sangles", "sapajou", "saouler", "samedis", "salages", "sanguin", "scanner", "sauvant", "souvent", "savonna", "scieras", "songera", "sondeur", "sonnets", "sombres", "soleils", "sombres", "sociale", "statues", "sportif", "stentor", "tanneur", "tamiser", "tallant", "talonne", "tannent", "tannins", "tendons", "tendras", "tendres", "taureau", "taurine", "tendoir", "trahira", "tracter", "toupets", "touffes", "traiter", "trafics", "trousse", "trouves", "troussa", "unirais", "usinage", "unifies", "unisses", "usurper", "urbaine", "unifiez", "usinera", "utopies", "usagers", "urbaine", "unitive", "vautour", "vendeur", "vendras", "vaudras", "veloute", "vendant", "vengiez", "veiller", "vendons", "vaudoue", "vengent", "vibreur", "vibrent", "vibrera", "vestons", "verrues", "veulent", "verrine", "viandes", "vibreur", "verseur", "whiskys", "wombats", "yaourts", "youyous", "zozoter", "zigotos", "zombies" };
    private string[] liste8 = {"abhorrer","abeilles","accident","accusera","accumula","affusion","affolant","aimerais","alchimie","albatros","ampoules","amuseras","anecdote","analyste","apeurant","antiques","antidote","applique","assourdi","autorise","autonome","auditive","baguages","badinent","baillera","baignade","baguette","barillet","baronnes","bifurque","bichonna","biftecks","bichonne","beurrent","blaguait","blanchit","blairent","blaguent","bittures","bitumant","blondine","bowlings","brandira","cachette","cafardes","cacaoyer","cagnotte","cambrant","camisole","calvaire","camarade","centaure","cessants","cercliez","cervelle","chapitre","charcute","chanteur","citoyens","citrines","clameurs","clochera","cumulent","culbuter","dansions","danserai","danseurs","diffamer","diamante","dialogue","diabolos","difforma","dilapida","digitaux","douchons","drainent","dressent","dresseur","douteuse","douleurs","dressage","douerais","duveteux","dureront","duvetant","emboucha","embrumer","embrunir","embouche","embolies","embrunis","embellit","embaumer","embroche","encourue","encontre","encolure","encombra","encodage","endenter","encuvent","engluent","extraire","extirper","exultera","explosif","exporter","fagotent","facturai","facetter","facilita","fameuses","falsifia","faillent","fanatisa","femelles","feintent","fendrait","fayotera","fendante","fendilla","fluctuer","flotteur","fluviale","flinguer","flexible","formules","fouetter","galettes","gagnasse","gagnants","gaffeurs","galopant","gauchira","gaufrant","gaspacho","garantis","gendarme","gazonner","grainent","gracieux","gouverna","gouttera","graisses","goupille","grisonna","grincher","grincera","grimoire","habitent","habituer","hacheurs","hamsters","haleines","handball","habitude","hilarant","heurtait","hideuses","histoire","hormonai","honorons","horaires","hongrois","homicide","horrifia","horreurs","hostiles","hydromel","hussarde","imagines","illicite","illusion","illumine","idiotisa","imbibera","imaginer","immeuble","indienne","incurver","inclinez","incuries","incurver","incluses","indolore","indivise","inductif","indirect","invalide","isochore","ionisera","irritons","italiens","jabotant","jacassai","jalonnai","jardines","jarreter","japonner","jalouser","jucheras","jongleur","jointure","jouterai","jouerais","juteuses","justifie","jumelait","juchoirs","jumpings","jugement","juchions","jupettes","jureront","kamikaze","kartings","kidnappa","kystique","kiosques","kouglofs","kumquats","kolkhoze","ketchups","klaxonne","labrador","labourer","lacerait","lactoses","lacrymal","lainerai","laitager","laissera","laissant","laquelle","lasserez","latteras","larguera","lavables","lauriers","lardonna","locution","louaient","louanges","louchais","lyonnais","macarons","magazine","magnolia","maculera","machette","magnions","magneras","marchait","merisier","mensurez","mensonge","mendient","millions","milliard","milliers","mimeront","migrerai","mijotant","myrmidon","mythique","mutinera","napperon","naissons","nagerons","national","nettoyai","niaisent","naviguer","navigues","nombrons","nominaux","noceuses","noircies","nombrils","nommerai","normands","noteront","noyauter","nuirions","nuisance","noveront","normande","objectes","observer","obstacle","obturera","obnubila","obligeas","objectif","obturons","obtenons","obnubile","offrande","ombragea","olfactif","olympien","omettant","offensas","omelette","orangera","oratoire","oreilles","orangers","pacagent","pagayera","paginais","paillait","paillent","pacifies","paillote","pactoles","paieront","panneras","paneront","panneaux","paludier","pandores","palpitas","puissant","pucerons","pruneaux","puissent","prouvera","puristes","quadrant","quartais","quatorze","queutent","quinaude","quittons","quartent","quinteux","quolibet","quarante","quittait","qualifie","quittant","quottent","quenotte","quelques","quittais","question","quittiez","quignons","quittait","raboteur","raccorda","racistes","rabattre","rabotage","rabouter","raclages","rabattis","racleras","racheter","rachetai","raffiner","ragotant","raffoler","ragerais","raideurs","raierons","radotera","radoteur","rythmons","roulerez","saccager","sabotier","sableuse","sacrifia","saucisse","saturera","satanent","servirez","services","serrures","soignais","soignent","sniffais","synonyme","suivants","superman","supposes","supprime","suivrais","syllabus","survivre","tacheter","talonnes","tamponna","taillera","tamisait","tactique","tombolas","titubait","tondrait","toilerez","toniques","tondeuse","toussent","tourisme","tourment","touchera","traduits","tullerie","tutrices","tunisien","troupeau","unifiant","uniforme","urbaines","urgences","usurpant","unicorne","urgentes","usuriers","unifient","ultrason","usuriers","usurpent","usurpant","vacances","vaccinai","valisera","valorisa","vachette","valonner","venimeux","vengerez","vengerai","vendeuse","ventouse","verdicts","voudrait","voterais","voyelles","voyeuses","voyances","voudriez","vouvoyer","voudrons","voyageur","walkyrie","wallonne","yoghourt","yachting","yachtman","zigzagua","zigoteau","zozotant"};

    private string[] sliste3 = { "âgé", "âge", "aïe", "âme", "âne", "avé", "bât", "bée", "blé", "clé", "côt", "dès", "dés", "èbe", "écu", "élu", "ému", "éon", "épi", "ère", "êta", "été", "ève", "fée", "fût", "gît", "gré", "gué", "île", "ipé", "kéa", "lès", "lié", "mât", "mée", "mél", "mûr", "née", "nié", "ohé", "oïl", "olé", "osé", "ôté", "pré", "réa", "rhô", "spé", "sué", "sûr", "tés", "têt", "thé", "tôt", "tué", "usé", "zée", "zoé" };
    private string[] sliste4 = { "abbé", "abée", "acmé", "acné", "âcre", "adné", "aéré", "âgée", "âges", "âgés", "aidé", "ailé", "aimé", "aîné", "aisé", "aléa", "allô", "âmes", "ânée", "ânes", "ânon", "ansé", "août", "âpre", "armé", "âtre", "basé", "bâte", "bâté", "bâti", "bâts", "béat", "bébé", "bédé", "béer", "bées", "bégu", "béké", "béni", "bêta", "bété", "bête", "blés", "bôme", "bômé", "buée", "buté", "café", "caïd", "calé", "caló", "camé", "capé", "casé", "cédé", "celé", "Cène", "cène", "cèpe", "chié", "ciné", "ciré", "cité", "clés", "cloé", "coït", "coïx", "cône", "côté", "côte", "coté", "Coué", "coût", "créé", "crée", "crêt", "curé", "déca", "deçà", "déci", "déçu", "défi", "déjà", "delà", "dème", "démo", "déni", "diêu", "dîme", "dôle", "dôme", "dông", "doré", "doté", "doué", "dupé", "ébat", "èche", "écho", "échu", "écor", "écot", "écru", "écus", "édam", "éden", "édit", "égal", "élan", "élue", "émeu", "émir", "émoi", "énol", "enté", "épar", "épée", "épié", "époi", "ères", "éros", "étai", "étal", "état", "étau", "étoc", "être", "étui", "évoé", "fadé", "famé", "fané", "faré", "féal", "fées", "fêlé", "féra", "féru", "fête", "fétu", "fève", "figé", "filé", "fixé", "foxé", "fumé", "futé", "garé", "gâté", "gavé", "gazé", "gelé", "gêne", "gêné", "géré", "gîte", "goïm", "goût", "gréé", "grés", "grès", "gués", "günz", "haïe", "haïk", "haïr", "hâle", "hâlé", "hâte", "hâté", "hâve", "hème", "hère", "holà", "hôte", "hoyé", "huée", "idée", "igné", "îles", "îlet", "îlot", "inné", "jeté", "jèze", "joué", "jubé", "jugé", "juré", "kalé", "kéké", "képi", "khôl", "kiné", "korê", "laïc", "lamé", "lavé", "lège", "léma", "lète", "lève", "levé", "liée", "lité", "lobé", "logé", "lône", "loué", "luxé", "mafé", "maïa", "mâle", "maté", "mâts", "méat", "mède", "méga", "mêlé", "mélo", "mémé", "même", "mémo", "mené", "mère", "mésa", "méso", "Méta", "méta", "méum", "miné", "môle", "môme", "moût", "moyé", "mûre", "muré", "muté", "naïf", "naïs", "Néel", "nées", "néné", "néon", "nèpe", "néré", "névé", "niée", "noté", "noué", "noyé", "nuée", "obéi", "ocré", "œuvé", "olpé", "ondé", "orée", "orné", "osée", "ôter", "ouïe", "ouïr", "palé", "pâle", "pâli", "pané", "paré", "pâté", "pâte", "pavé", "payé", "péan", "pécu", "pédé", "pelé", "pêne", "péon", "pépé", "père", "péri", "pesé", "pété", "pévé", "pèze", "pisé", "plié", "pôle", "posé", "prép", "prés", "près", "prêt", "prié", "racé", "raïs", "râle", "ramé", "râpe", "râpé", "rasé", "raté", "rayé", "réac", "réal", "redû", "réel", "réer", "régi", "rêne", "rêvé", "rêve", "ridé", "rivé", "rôle", "rosé", "rôti", "rôts", "roué", "ruée", "rusé", "saïs", "saké", "salé", "scié", "séga", "sème", "semé", "séné", "séré", "sève", "skaï", "Skaï", "sodé", "soûl", "suée", "sûre", "talé", "tapé", "taré", "taxé", "téju", "télé", "ténu", "tête", "têts", "têtu", "thaï", "tiré", "tôle", "tôlé", "tölt", "très", "trié", "typé", "urée", "usée", "uvée", "vécu", "vélo", "vêtu", "vexé", "vidé", "volé", "voué", "würm", "zébu", "zélé", "zèle", "zéro", "zêta", "zoné" };
    private string[] sliste5 = { "abbés", "abcès", "abêti", "abîmé", "abîme", "abusé", "accès", "acène", "acère", "acéré", "acmés", "acnés", "âcres", "actée", "adèle", "adoré", "adulé", "aèdes", "aérer", "affût", "agacé", "agité", "agréé", "agrès", "aiélé", "aïeul", "aïeux", "aimée", "aînée", "aînés", "aïnou", "aïoli", "aisée", "akène", "alaüs", "aléas", "alêne", "alène", "alésé", "alèse", "alézé", "alité", "alizé", "allée", "allié", "almée", "aloès", "ambré", "amené", "amène", "amère", "aminé", "amphé", "amuïr", "amusé", "ancré", "ânées", "ânier", "animé", "anisé", "année", "ânons", "apéro", "apidé", "apnée", "appât", "âpres", "après", "aréna", "arène", "arête", "armée", "armés", "arôme", "arqué", "arrêt", "asilé", "atémi", "athée", "âtres", "augée", "aunée", "avalé", "avéré", "aviné", "avisé", "avivé", "avoué", "awalé", "azéri", "azobé", "azuré", "bâché", "bâche", "bâcle", "bâclé", "bahaï", "baïle", "baïne", "bandé", "bardé", "barré", "bâsir", "batée", "bâter", "bâtie", "bâtir", "bâtis", "bâton", "baumé", "béant", "béate", "bébés", "bêche", "bécot", "bègue", "bégum", "békés", "bêler", "bémol", "bénef", "benêt", "bénin", "bénir", "bénit", "béret", "berné", "béroé", "bérot", "béryl", "bésef", "bêtas", "bétel", "bêtes", "béton", "bévue", "bézef", "bière", "bilié", "blâme", "blasé", "blême", "bluté", "bogué", "boïdé", "boisé", "boîte", "bolée", "bombé", "bondé", "bonté", "bordé", "borée", "borné", "bossé", "bouée", "bougé", "boulê", "boulé", "bravé", "brèle", "brêle", "brème", "brève", "briée", "brisé", "brodé", "broyé", "brûlé", "bûche", "bûché", "buées", "butée", "buvée", "câble", "câblé", "cabré", "caché", "cadré", "cafés", "cagée", "caïds", "caïeu", "câlin", "calmé", "camée", "caméo", "campé", "câpre", "cardé", "carné", "carpé", "carré", "cassé", "casté", "caudé", "cavée", "céans", "céder", "cèdre", "cégep", "celée", "cènes", "censé", "cépée", "cèpes", "cèphe", "cérat", "cerné", "césar", "césar", "cessé", "cétol", "châle", "chapé", "chasé", "chêne", "chère", "chéri", "chiée", "chiné", "choké", "chômé", "choyé", "cilié", "cinés", "cités", "cloué", "cobée", "coché", "cogné", "coïts", "colée", "collé", "côlon", "colón", "cômos", "comté", "condé", "congé", "conné", "copié", "corné", "corsé", "côtés", "côtes", "coudé", "coulé", "coupé", "coûts", "cramé", "crâne", "créer", "crème", "crémé", "crêpe", "crêpé", "crépi", "crépu", "crêté", "crête", "crêts", "crevé", "crève", "criée", "croît", "culée", "curée", "curés", "cuvée", "daïra", "dallé", "damné", "débat", "débet", "débit", "début", "décan", "décas", "décès", "dèche", "déchu", "décor", "décri", "dédié", "dédit", "défet", "défis", "dégât", "dégel", "dégou", "degré", "déité", "déjuc", "délai", "délié", "délit", "délot", "démis", "démon", "dénié", "dénis", "denté", "dénué", "dépit", "dépôt", "désir", "désis", "dévié", "dévot", "diène", "dièse", "diète", "dilué", "dîmée", "dîmer", "dîmes", "dîner", "dômes", "donné", "dorée", "douée", "drapé", "drège", "drève", "drôle", "duché", "durée", "ébahi", "ébats", "ébène", "écale", "écang", "écart", "échec", "échée", "èches", "échos", "écimé", "éclat", "éclos", "école", "écolo", "écope", "écopé", "écore", "écoté", "écots", "écran", "écrin", "écrit", "écrou", "écrue", "éculé", "écume", "édens", "édile", "édité", "édits", "éfrit", "égale", "égalé", "égard", "égaré", "égaux", "égéen", "égide", "égout", "éland", "élans", "élavé", "éléen", "élégi", "élémi", "élevé", "élève", "élimé", "élire", "élite", "éloge", "éludé", "éluer", "élues", "émail", "émaux", "embué", "émeri", "émois", "émues", "émule", "énard", "énéma", "enflé", "ényne", "épair", "épais", "épars", "épart", "épate", "épaté", "épave", "épées", "épelé", "éphod", "épice", "épicé", "épier", "épieu", "épigé", "épine", "épode", "épois", "époux", "époxy", "épris", "épure", "épuré", "équin", "érèse", "érigé", "érodé", "étage", "étagé", "étais", "étalé", "étale", "étals", "étang", "étant", "étape", "états", "étave", "étêté", "éteuf", "éther", "étier", "étiez", "étire", "étiré", "étole", "êtres", "étron", "étude", "étuis", "étuve", "évadé", "évasé", "éveil", "évent", "évidé", "évier", "évité", "excès", "exigé", "exilé", "fâché", "faîte", "fardé", "fascé", "féage", "féale", "fécal", "fèces", "fêler", "félin", "félon", "fémur", "féral", "férie", "férié", "férir", "fermé", "ferré", "ferté", "fêter", "fêtes", "fétus", "fèves", "fière", "figée", "filée", "filmé", "fixée", "flâne", "fléau", "flûte", "flûté", "foène", "folié", "foncé", "fondé", "forcé", "forêt", "forgé", "formé", "fossé", "foulé", "frayé", "frêle", "frère", "frèze", "fripé", "frisé", "fugué", "fumée", "fûmes", "fusée", "futée", "gâble", "gâché", "gâche", "gagné", "gaïac", "gaïta", "gaité", "galbé", "galée", "gardé", "gâtée", "gâter", "géant", "gébie", "gelée", "gélif", "gémir", "gemmé", "gênée", "gêner", "gênes", "genêt", "génie", "géode", "geôle", "gérer", "gésir", "gîter", "gîtes", "glacé", "glèbe", "glène", "gnôle", "golée", "gorgé", "goûté", "goûts", "goûtu", "grâce", "gradé", "gravé", "grèbe", "gréée", "gréer", "grège", "grêle", "grêlé", "grené", "grevé", "grève", "grèze", "grimé", "grisé", "guède", "guère", "guéri", "guèze", "guidé", "haché", "hâlée", "hâler", "hâles", "hanté", "hasté", "hâter", "hâtes", "hâtif", "havée", "hâves", "hecté", "hélas", "héler", "hélio", "hélix", "henné", "herbé", "hères", "héron", "héros", "hévéa", "hissé", "hôtel", "hôtes", "höyük", "huées", "huilé", "huppé", "ibère", "icône", "idéal", "idéel", "idées", "iléal", "iléon", "iléus", "îlien", "îlots", "imagé", "imité", "impôt", "innée", "innés", "inouï", "ipéca", "irisé", "isolé", "jacée", "jaspé", "jaugé", "jésus", "jetée", "jeûne", "jèzes", "jouée", "jubés", "jurée", "jusée", "képis", "koinè", "labié", "lâché", "lâche", "lacté", "laïcs", "laïka", "laité", "laïus", "lancé", "langé", "lapié", "laqué", "larvé", "lassé", "latès", "lauré", "lavée", "lèche", "légal", "légat", "léger", "lèges", "lèpre", "lérot", "léser", "lesté", "létal", "levée", "levés", "lèvre", "liège", "ligué", "lissé", "litée", "livré", "loupé", "lycée", "mâche", "maclé", "mâcon", "madré", "maïas", "mâles", "mandé", "mânes", "marée", "marié", "massé", "mâter", "mâtin", "méats", "mèche", "média", "médoc", "mégir", "mégis", "mégot", "Méker", "mêlée", "mêler", "méloé", "mémés", "mêmes", "menée", "mères", "méson", "métal", "métas", "météo", "métis", "Méton", "métré", "mètre", "métro", "meulé", "mézès", "mézig", "mirvé", "mitré", "moiré", "moïse", "môles", "mollé", "mômes", "monoï", "monté", "moqué", "morné", "moulé", "mûres", "mûrir", "mûron", "musée", "nacré", "naïfs", "naïve", "natté", "navré", "néant", "nèfle", "nègre", "négro", "négus", "nénés", "nèpes", "nervé", "niché", "niébé", "nièce", "niées", "nimbé", "noème", "noèse", "nommé", "nordé", "normé", "nouée", "nuées", "obéir", "obéré", "obèse", "océan", "odéon", "œdème", "œillé", "oeuvé", "ogoué", "oïdié", "oïdie", "oléum", "ombré", "oméga", "ondée", "onglé", "opéré", "ordré", "orées", "ornée", "ornés", "ortié", "osées", "osmié", "ôtées", "ouaté", "ouïes", "ourlé", "outré", /* "ouvré", "ovidé", "oviné", "oxydé", "ozène", "pacsé", "païen", "palée", "pâles", "pâlir", "palmé", "pâlot", "pâmer", "panné", "Pâque", "parée", "paréo", "parlé", "passé", "pâtée", "pâtés", "pâtes", "pâtir", "pâtis", "pâton", "pâtre", "patté", "paumé", "péage", "péans", "pêché", "pêche", "péché", "pêchu", "pédés", "pèger", "pègre", "peiné", "pékan", "pékin", "pelté", "pénal", "pênes", "pénil", "pénis", "penné", "penté", "péons", "pépée", "pépés", "pépie", "pépin", "pépon", "percé", "pères", "périf", "péril", "périr", "Pérou", "perré", "pesée", "péter", "pétré", "pétun", "pèzes", "phasé", "pièce", "piégé", "piège", "pietà", "piéta", "piété", "pièze", "pilée", "pincé", "pinée", "pinté", "pipée", "piqué", "pisés", "pitié", "placé", "plané", "plèbe", "poché", "poêle", "poème", "poète", "poiré", "pôles", "poljé", "pommé", "pongé", "porté", "posée", "posté", "potée", "préau", "prêle", "prèle", "prépa", "prête", "prêté", "prévu", "privé", "prôné", "prône", "ptôse", "puîné", "purée", "quête", "quiné", "râble", "râblé", "radié", "railé", "raïon", "râler", "râles", "ramée", "rangé", "râper", "râpes", "raphé", "raqué", "ratée", "réale", "rébus", "rêche", "récif", "récit", "récré", "récri", "recrû", "rédie", "réels", "régal", "régie", "régir", "réglé", "règle", "réglo", "règne", "régur", "relié", "rémiz", "remué", "rénal", "rênes", "renié", "répit", "résol", "resté", "rétif", "rétro", "réuni", "rêvée", "rêver", "rêves", "rêvés", "ridée", "rímur", "risée", "rodéo", "rôder", "rogué", "rôles", "ronéo", "rongé", "rosée", "rôtie", "rôtir", "rôtis", "rouée", "roulé", "ruché", "ruées", "ruiné", "rusée", "sablé", "sacré", "saïga", "saïte", "salée", "santé", "sassé", "sauté", "sauvé", "scène", "séant", "sébum", "séché", "sèche", "sédum", "séide", "sénat", "sensé", "sépia", "séqué", "sérac", "séran", "sergé", "série", "sérié", "serré", "sérum", "sésie", "séton", "sèves", "sévir", "sexué", "sézig", "shéol", "siège", "siglé", "signé", "sinué", "sitôt", "situé", "soldé", "soleá", "sommé", "sondé", "sonné", "soudé", "soûle", "soûlé", "spéos", "stèle", "sténo", "stère", "strié", "stylé", "sucré", "suédé", "suède", "suées", "suidé", "sûres", "tabès", "tablé", "taché", "tâche", "tâché", "tagué", "taïga", "talée", "tanné", "tapée", "tassé", "tâter", "télés", "télex", "ténia", "ténor", "tenté", "ténue", "testé", "tétée", "téter", "têtes", "tétin", "téton", "têtue", "tézig", "thaïs", "thème", "thèse", "thêta", "thête", "tiaré", "tiède", "tigré", "tildé", "tirée", "tissé", "tmèse", "toilé", "toisé", "tôles", "tollé", "tombé", "toqué", "touée", "tracé", "tramé", "tréaz", "tréma", "trêve", "trôle", "trône", "troué", "tufté", "türbe", "uléma", "unité", "uréna", "usagé", "usées", "usité", "usnée", "uvéal", "vairé", "valvé", "vanné", "varié", "vécés", "vécus", "vécut", "vécût", "veiné", "vélar", "vêler", "vélie", "vélin", "vélos", "vélum", "vénal", "venté", "vénus", "vergé", "vérin", "vérot", "verré", "versé", "vêtir", "vêtue", "vicié", "vidéo", "vièle", "vinée", "violé", "virée", "visée", "vissé", "vitré", "vivré", "voilà", "voilé", "voisé", "volée", "voûte", "voûté", "watté", "wengé", "xénie", "xénon", "xérus", "yémen", "zébré", "zèbre", "zéine", "zélée", "zèles", "zéros", "zoïde", "zoïle" */ }; 
    private string[] sliste6 = { "tonnât", "émotif", "bâclât", "aoûtés", "pannés", "logées", "minoré", "vissés", "frétas", "farcît", "brimât", "élirez", "évinça", "décimé", "visées", "avivât", "élirez", "évinça", "usitée", "coloré", "chassé", "égorge", "digité", "métrât", "pécher", "pâtura", "testée", "séduis", "coursé", "songée", "étirai", "tagète", "méchez", "dodiné", "ancrés", "galbée", "élidât", "cordée", "chipée", "gigoté", "bétyle", "élégie", "accoté", "réglez", "fémurs", "eschée", "sacrés", "blairé", "lésées", "normée", "fermât", "décadi", "dépits", "éosine", "dardée", "étalai", "éviers", "tigrés", "laquât", "jurées", "essoré", "unifié", "allumé", "pèches", "dénuas", "râblez", "fêlera", "vêpres", "enroué", "enrêna", "enrêne", "enrêné", "enrôla", "enrôle", "enrôlé", "espèce", "espère", "espéra", "espéré" };
    private string[] sliste7 = { "jonglés", "asséché", "brûlage", "ajourné", "nocuité", "guêtras", "exténue", "pensées", "chaînée", "écoeuras", "récusât", "lâchons", "créchée", "vésanie", "viduité", "codifié", "ouvragé", "décalés", "métissé", "châties", "régleur", "hanchée", "remmène", "détecta", "abîmiez", "reposée", "pivotés", "décriez", "faculté", "déminés", "déminée", "élongée", "martèle", "mésusez", "castrât", "accouât", "cloquât", "décevra", "assîtes", "madrées", "aggravé", "emmètre", "regelât", "dévoilé", "insolés", "méchoui", "déplias", "écotées", "enlevée", "ravisés", "éclatât", "dérivée", "dérivés", "délivré", "délivre", "délivra" };
    private string[] sliste8 = {"terminés","crétoise","grésâmes","décernez","dévalise","dévalisa","régleurs","obombrée","talochés","élogieux","ramarrée","écaleras","débridai","empannât","décriant","aoûterai","minaudée","ébrouiez","erronées","gagnâtes","fouettée","dégluant","berçasse","mâtereau","dépitent","éraillat","arrêtera","pancréas","susvisée","coryphée","vinosité","dégèlera","lésèrent","glavioté","tutoyées","ressayée","esbignés","démunira","rempiéta","initiées","trépigne","préfixât","gouaillé","insultât","vousoyés","électrum","encroûté","devancés","éclopent","débâcler","décrépit","baquetée","étincelé","restâmes","regrimpé","inféoder","tablâtes","frustrât","étoffées","enchaîna"};
    
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
