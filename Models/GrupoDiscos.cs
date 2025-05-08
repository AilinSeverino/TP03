namespace TP03.Models;
public class GrupoDiscos
    {
        public static Dictionary<int, Disco> ListDiscos { get; private set; }

        public static void InicializarDiscos()
        {
            ListDiscos = new Dictionary<int, Disco>();
            
            // Inicialización de discos con tipos explícitos
            List<string> temasHarrysHouse = new List<string> { "1.Music for a sushi restaurant","2.Late night talking","3.Grapejuice","4.As it was","5.Daylight","6.Little freak","7.Matilda","8.Cinema","9.Daydreaming","10.Keep driving","11.Satellite","12.Boyfriends","13.Love of my life" };
            Disco HarrysHouse = new Disco("HarrysHouse","Harry styles", "Jose", "Pop", temasHarrysHouse, 1, "fotos/descargpostaH.jpg");
            agregarDisco(1, HarrysHouse);

            List<string> temasEspresso = new List<string> { "1.Espresso", "2.Nonsense", "3.Vicious", "4.Fast Times", "5.Fate", "6.Paris", "7.Funeral", "8.23" };
            Disco Espresso = new Disco("Espresso","Sabrina Carpenter", "Pablo", "Pop", temasEspresso, 2, "fotos/descargpostaS.jpg");
            agregarDisco(2, Espresso);

            List<string> temasSour = new List<string> { "1.Brutal", "2.Traitor", "3.Drivers License", "4.1 Step Forward", "5.Deja Vu", "6.Good 4 U", "7.Happier", "8.Illicit Affairs", "9.Favorite Crime", "10.Jealousy, Jealousy" };
            Disco Sour = new Disco("Sour","Olivia Rodrigo", "Pipi", "Pop Rock", temasSour, 3, "fotos/descargpostaO.jpg");
            agregarDisco(3, Sour);

            List<string> temasTakeMeHome = new List<string> { "1.Live While We're Young", "2.Kiss You", "3.Little Things", "4.C'mon, C'mon", "5.Last First Kiss", "6.Tell Me A Lie", "7.Moments", "8.I Would" };
            Disco TakeMeHome = new Disco("TakeMeHome", "One Direction", "Mauro", "Pop", temasTakeMeHome, 4,"fotos/descargposta1D.jpg");
            agregarDisco(4, TakeMeHome);

            List<string> temasCupido = new List<string> { "1.Cupido", "2.Las Jordans", "3.Mujeriego", "4.Te Pido", "5.Mi Lugar", "6.Loco" };
            Disco Cupido = new Disco("Cupido", "TINI", "Merlo", "Latin Pop", temasCupido, 5, "fotos/descargpostaT.jpg");
            agregarDisco(5, Cupido);

            List<string> temasWalls = new List<string> { "1.Killers", "2.Walls", "3.Defenceless", "4.Habit", "5.Too Young", "6.We Made It", "7.Falling In Love" };
            Disco Walls = new Disco("Walls","Louis Tomlinson", "Martin", "Rock", temasWalls, 6, "fotos/descargpostaL.jpg");
            agregarDisco(6, Walls);

            List<string> temasPositions = new List<string> { "1.Positions", "2.34+35", "3.POV", "4.My Hair", "5.Motive", "6.Nasty", "7.Worst Behavior", "8.Safety Net" };
            Disco Positions = new Disco("Positions", "Ariana Grande", "Benson", "Pop/R&B", temasPositions, 7, "fotos/descargpostaA.jpg");
            agregarDisco(7, Positions);

            List<string> temasShawnMendes = new List<string> { "1.In My Blood", "2.Nervous", "3.Lost in Japan", "4.Why", "5.Mutual", "6.When You're Ready", "7.Bad Reputation", "8.Queen" };
            Disco ShawnMendes = new Disco("Shawn Mendes", "Shawn Mendes", "Camilla", "Pop", temasShawnMendes, 8, "fotos/descargpostaSH.jpg");
            agregarDisco(8, ShawnMendes);

            List<string> temasObsesionario = new List<string> { "1.Obsesionario", "2.Mentira", "3.La Melodía de Dios", "4.Vos Sabés", "5.Noche Inolvidable", "6.Nada Se Pierde" };
            Disco Obsesionario = new Disco("Obsesionario","Tan Biónica", "Federico", "Pop Rock", temasObsesionario, 9, "fotos/descargpostaTB.jpg");
            agregarDisco(9, Obsesionario);

            List<string> temasBalasPerdidas = new List<string> { "1.No Se Va", "2.Mi Suerte", "3.Balas Perdidas", "4.Punto y Aparte", "5.Ya No Estás" };
            Disco BalasPerdidas = new Disco("Balas Perdidas","Morat", "Carla", "Pop Rock", temasBalasPerdidas, 10, "fotos/descargpostaM.jpg");
            agregarDisco(10, BalasPerdidas);

            List<string> temasMP3 = new List<string> { "1.Jagger.mp3", "2.No_Se_Ve", "3.La_Original.mp3", "4.Gta.mp3", "5.Todo Lo Que Quiero", "6.Primavera" };
            Disco MP3 = new Disco("MP3","Emilia Mernes", "Mario", "Pop Urbano", temasMP3, 11, "fotos/descargpostaE.jpg");
            agregarDisco(11, MP3);

            List<string> temasAmeri = new List<string> { "1.Rockstar 2.0", "2.HARA", "3.TE DIGO LA VERDAD", "4.Muero de fiesta este finde", "5.La Cama", "6.Vos y Yo" };
            Disco Ameri = new Disco("AMERI","Duki", "Lola", "Trap", temasAmeri, 12, "fotos/descargpostaD.jpg");
            agregarDisco(12, Ameri);
        }
        public static void agregarDisco (int ID, Disco nombreDisco)
        {
        if(ListDiscos.ContainsKey(ID))
        {
            Console.WriteLine("El disco ya existe");
        }
        else
        {
            ListDiscos.Add(ID, nombreDisco);
        }
        }
    }