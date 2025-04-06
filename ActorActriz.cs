namespace Program {
    //Datos del actor o actriz
    public class ActorActriz {
        public int Codigo {
            get; set;
        }
        public string Nombre {
            get; set;
        }
        public string URLIMDB {
            get; set;
        }

        //Constructor
        public ActorActriz(int Codigo, string Nombre, string URLIMDB) {
            this.Codigo=Codigo;
            this.Nombre=Nombre;
            this.URLIMDB="https://www.imdb.com/name/"+URLIMDB;
        }
    }
}
