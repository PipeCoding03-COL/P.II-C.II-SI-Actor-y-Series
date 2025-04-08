namespace Program {
    //Datos de la serie de televisión
    class Serie {
        public int Codigo {
            get; set;
        }
        public string Nombre {
            get; set;
        }
        public string URLIMDB {
            get; set;
        }

        //Listado de códigos de actores que actúan en la serie
        public List<int> Actor = [];

        //Constructor
        public Serie(int Codigo, string Nombre, string URLIMDB) {
            this.Codigo=Codigo;
            this.Nombre=Nombre;
            this.URLIMDB="https://www.imdb.com/title/"+URLIMDB;
        }
    }

}
