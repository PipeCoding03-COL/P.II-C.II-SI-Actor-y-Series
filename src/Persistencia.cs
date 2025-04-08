namespace Program {
    //La parte que simula la capa de persistencia
    class Persistencia {
        public List<ActorActriz> Actores;
        public List<Serie> Series;

        //Carga datos de prueba
        public Persistencia() {
            Actores= [];
            Series= [];

            //Un listado de actores y actrices
            ActorAdiciona(78, "Ana María Orozco", "nm0650450");
            ActorAdiciona(81, "Laura Londoño", "nm2256810");
            ActorAdiciona(84, "Carolina Ramírez", "nm1329835");
            ActorAdiciona(93, "Catherine Siachoque", "nm0796171");
            ActorAdiciona(98, "Carmenza González", "nm1863990");
            ActorAdiciona(99, "Andrés Londoño", "nm2150265");

            //Un listado de series
            Series.Add(new Serie(16, "Yo soy Betty, la fea", "tt0233127"));
            Series.Add(new Serie(43, "La reina del flow", "tt8560918"));
            Series.Add(new Serie(60, "Café con Aroma de Mujer", "tt14471346"));
            Series.Add(new Serie(62, "Los Briceño", "tt10348478"));
            Series.Add(new Serie(70, "Distrito Salvaje", "tt8105958"));
            Series.Add(new Serie(72, "Mil Colmillos", "tt9701670"));
            Series.Add(new Serie(83, "Perdida", "tt10064124"));

            //Obsérvese que un mismo actor o actriz puede
            //estar en dos series distintas
            Series[0].Actor.Add(78);
            Series[0].Actor.Add(93);
            Series[0].Actor.Add(98);
            Series[6].Actor.Add(78);
            Series[4].Actor.Add(78);
        }

        //Adicionar actor
        public bool ActorAdiciona(int Codigo, string Nombre, string URL) {
            for (int Cont = 0; Cont<Actores.Count; Cont++) {
                if (Actores[Cont].Codigo==Codigo)
                    return false;
            }
            Actores.Add(new ActorActriz(Codigo, Nombre, URL));
            return true;
        }

        //Editar actor
        public bool ActorEdita(int CodigoActor, string Nombre, string URL) {
            for (int Cont = 0; Cont<Actores.Count; Cont++) {
                if (Actores[Cont].Codigo==CodigoActor) {
                    Actores[Cont].Nombre=Nombre;
                    Actores[Cont].URLIMDB=URL;
                    return true;
                }
            }
            return false;
        }

        //Chequea si el actor está trabajando en alguna serie
        public bool ActorEnSerie(int CodigoActor) {
            for (int Cont = 0; Cont<Series.Count; Cont++)
                for (int Num = 0; Num<Series[Cont].Actor.Count; Num++)
                    if (Series[Cont].Actor[Num]==CodigoActor)
                        return true;
            return false;
        }

        //Borrar actor, si y solo si no está trabajando en alguna serie
        public bool ActorBorra(int CodigoActor) {
            if (ActorEnSerie(CodigoActor)==false) {
                for (int Cont = 0; Cont<Actores.Count; Cont++)
                    if (Actores[Cont].Codigo==CodigoActor) {
                        Actores.RemoveAt(Cont);
                        return true;
                    }
            }
            return false;
        }

        //Dado el código, retorna el nombre del actor/actriz
        public string NombreActor(int CodigoActor) {
            for (int cont = 0; cont<Actores.Count; cont++) {
                if (Actores[cont].Codigo==CodigoActor)
                    return Actores[cont].Nombre;
            }
            return "N/A";
        }

        //Retorna una lista de series donde el actor trabaja
        public List<string> ActorTrabaja(int CodigoActor) {
            List<string> ListaSeries = [];
            for (int cont = 0; cont<Series.Count; cont++) {
                for (int num = 0; num<Series[cont].Actor.Count; num++) {
                    if (Series[cont].Actor[num]==CodigoActor)
                        ListaSeries.Add(Series[cont].Nombre);
                }
            }
            return ListaSeries;
        }

        //Adicionar serie
        public bool SerieAdiciona(int CodigoSerie, string Nombre, string URL) {
            for (int Cont = 0; Cont<Series.Count; Cont++) {
                if (Series[Cont].Codigo==CodigoSerie)
                    return false;
            }
            Series.Add(new Serie(CodigoSerie, Nombre, URL));
            return true;
        }

        //Editar serie
        public bool SerieEdita(int CodigoSerie, string Nombre, string URL) {
            for (int Cont = 0; Cont<Series.Count; Cont++) {
                if (Series[Cont].Codigo==CodigoSerie) {
                    Series[Cont].Nombre=Nombre;
                    Series[Cont].URLIMDB=URL;
                    return true;
                }
            }
            return false;
        }

        //Borrar serie
        public bool SerieBorra(int CodigoSerie) {
            for (int Cont = 0; Cont<Series.Count; Cont++)
                if (Series[Cont].Codigo==CodigoSerie) {
                    Series.RemoveAt(Cont);
                    return true;
                }
            return false;
        }


        //Retornar los actores que trabajan en la serie
        public List<string> SerieActores(int CodigoSerie) {
            int Pos = PosSerie(CodigoSerie);
            List<string> Nombres = [];
            for (int Cont = 0; Cont<Series[Pos].Actor.Count; Cont++)
                Nombres.Add("["+Series[Pos].Actor[Cont]+"] "+NombreActor(Series[Pos].Actor[Cont]));
            return Nombres;
        }

        //Añade un actor a una serie
        public bool SerieAsocia(int CodigoSerie, int CodigoActor) {
            int PosSerial = PosSerie(CodigoSerie);
            if (PosSerial>=0) {
                if (Series[PosSerial].Actor.Contains(CodigoActor)==false) {
                    Series[PosSerial].Actor.Add(CodigoActor);
                    return true;
                } else
                    return false;
            }
            return false;
        }

        //Quita un actor de una serie
        public bool SerieDisocia(int CodigoSerie, int CodigoActor) {
            int PosSerial = PosSerie(CodigoSerie);
            if (PosSerial>=0) {
                if (Series[PosSerial].Actor.Contains(CodigoActor)==true) {
                    Series[PosSerial].Actor.Remove(CodigoActor);
                    return true;
                } else
                    return false;
            }
            return false;
        }

        //Dado el código de la serie, retorna su posición
        public int PosSerie(int CodigoSerie) {
            for (int Cont = 0; Cont<Series.Count; Cont++)
                if (Series[Cont].Codigo==CodigoSerie) {
                    return Cont;
                }
            return -1;
        }
    }

}
