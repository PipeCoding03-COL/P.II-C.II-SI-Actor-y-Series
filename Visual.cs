namespace Program {
    //La parte visual del programa
    class Visual {
        public Persistencia Datos;

        //Conecta con la capa de persistencia
        public Visual(Persistencia objDatos) {
            Datos=objDatos;
        }

        //Menú principal
        public void Menu() {
            int Opcion;
            do {
                Console.Clear();
                Console.WriteLine("\nSoftware TV Show 1.7 (Marzo de 2025)");
                Console.WriteLine("1. CRUD de actores y actrices");
                Console.WriteLine("2. CRUD de series");
                Console.WriteLine("3. Salir");
                Console.Write("¿Opción? ");
                Opcion=Convert.ToInt32(Console.ReadLine());
                switch (Opcion) {
                    case 1:
                        CRUDactores();
                        break;
                    case 2:
                        CRUDseries();
                        break;
                }
            } while (Opcion!=3);
        }

        //Menú de actores y actrices
        public void CRUDactores() {
            int Opcion;
            do {
                Console.Clear();
                Console.WriteLine("\nSoftware TV Show. Actores/Actrices");
                for (int Cont = 0; Cont<Datos.Actores.Count; Cont++) {
                    Console.Write("["+Datos.Actores[Cont].Codigo+"] ");
                    Console.Write(Datos.Actores[Cont].Nombre);
                    Console.WriteLine(" URL: "+Datos.Actores[Cont].URLIMDB);
                }
                Console.WriteLine(" \n1. Adicionar");
                Console.WriteLine("2. Editar");
                Console.WriteLine("3. Borrar");
                Console.WriteLine("4. ¿En cuáles series trabaja?");
                Console.WriteLine("5. Volver a menú principal");
                Console.Write("¿Opción? ");
                Opcion=Convert.ToInt32(Console.ReadLine());
                switch (Opcion) {
                    case 1:
                        ActorAdiciona();
                        break;
                    case 2:
                        ActorEdita();
                        break;
                    case 3:
                        ActorBorra();
                        break;
                    case 4:
                        ActorTrabaja();
                        break;
                }
            } while (Opcion!=5);
        }

        //Menú de series de TV
        public void CRUDseries() {
            int Opcion;
            do {
                Console.Clear();
                Console.WriteLine("\nSoftware TV Show. Series");
                for (int Cont = 0; Cont<Datos.Series.Count; Cont++) {
                    Console.Write("["+Datos.Series[Cont].Codigo+"] ");
                    Console.Write(Datos.Series[Cont].Nombre);
                    Console.WriteLine(" URL: "+Datos.Series[Cont].URLIMDB);
                }
                Console.WriteLine("\n1. Adicionar");
                Console.WriteLine("2. Editar");
                Console.WriteLine("3. Borrar");
                Console.WriteLine("4. Detalles de la serie");
                Console.WriteLine("5. Asociar actor a serie");
                Console.WriteLine("6. Disociar actor a serie");
                Console.WriteLine("7. Volver a menú principal");
                Console.Write("¿Opción? ");
                Opcion=Convert.ToInt32(Console.ReadLine());
                switch (Opcion) {
                    case 1:
                        SerieAdiciona();
                        break;
                    case 2:
                        SerieEdita();
                        break;
                    case 3:
                        SerieBorra();
                        break;
                    case 4:
                        SerieDetalle();
                        break;
                    case 5:
                        SerieAsocia();
                        break;
                    case 6:
                        SerieDisocia();
                        break;
                }
            } while (Opcion!=7);
        }

        //Pantalla para adicionar actores
        public void ActorAdiciona() {
            Console.WriteLine("\tAdicionar actor al listado");
            Console.Write("¿Código? ");
            int CodigoActor = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Nombre? ");
            string Nombre = Console.ReadLine();
            Console.Write("¿URL de IMDB? ");
            string URL = Console.ReadLine();
            if (Datos.ActorAdiciona(CodigoActor, Nombre, URL))
                Console.WriteLine("\nActor adicionado.");
            else
                Console.WriteLine("\nError al adicionar el actor. El código ya existe.");
            Console.ReadKey();
        }

        //Pantalla para editar actores
        public void ActorEdita() {
            Console.WriteLine("\tEditar actor");
            Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
            int CodigoActor = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Nombre? ");
            string Nombre = Console.ReadLine();
            Console.Write("¿URL de IMDB? ");
            string URL = Console.ReadLine();
            if (Datos.ActorEdita(CodigoActor, Nombre, URL))
                Console.WriteLine("\nActor editado.");
            else
                Console.WriteLine("\nError al editar el actor");
            Console.ReadKey();
        }

        //Pantalla para borrar actores
        public void ActorBorra() {
            Console.WriteLine("\tBorrar actor o actriz");
            Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
            int CodigoActor = Convert.ToInt32(Console.ReadLine());
            if (Datos.ActorBorra(CodigoActor))
                Console.WriteLine("\nActor borrado.");
            else
                Console.WriteLine("\nError al borrar el actor. Código erróneo o el actor trabaja en series.");
            Console.ReadKey();
        }

        //Pantalla para mostrar en que series trabaja el actor
        public void ActorTrabaja() {
            List<string> ListaSeries;
            Console.WriteLine("\tListar series donde actúa");
            Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
            int CodigoActor = Convert.ToInt32(Console.ReadLine());
            ListaSeries=Datos.ActorTrabaja(CodigoActor);
            for (int Cont = 0; Cont<ListaSeries.Count; Cont++)
                Console.WriteLine(ListaSeries[Cont]);
            Console.WriteLine("\nPresione");
            Console.ReadKey();
        }

        //Pantalla para adicionar series
        public void SerieAdiciona() {
            Console.WriteLine("\tAdicionar serie al listado");
            Console.Write("¿Código? ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Nombre? ");
            string nombre = Console.ReadLine();
            Console.Write("¿URL en IMDB? ");
            string url = Console.ReadLine();
            if (Datos.SerieAdiciona(codigo, nombre, url))
                Console.WriteLine("\nSerie adicionada.");
            else
                Console.WriteLine("\nError al adicionar la serie");
            Console.ReadKey();
        }

        //Pantalla para editar series
        public void SerieEdita() {
            Console.WriteLine("\tEditar serie");
            Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Nombre? ");
            string nombre = Console.ReadLine();
            Console.Write("¿URL en IMDB? ");
            string url = Console.ReadLine();
            if (Datos.SerieEdita(codigo, nombre, url))
                Console.WriteLine("\nSerie editada.");
            else
                Console.WriteLine("\nError al editar la serie");
            Console.ReadKey();
        }

        //Pantalla para borrar series
        public void SerieBorra() {
            Console.WriteLine("\tBorrar serie");
            Console.Write("¿Cuál? Escriba el número que está entre [ ]: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            if (Datos.SerieBorra(codigo))
                Console.WriteLine("\nSerie borrada.");
            else
                Console.WriteLine("\nError al borrar la serie.");
            Console.ReadKey();
        }

        //Pantalla para ver el detalle de la serie
        public void SerieDetalle() {
            List<string> ListaActores;

            Console.WriteLine("\t === Detalle de una serie ===");
            Console.Write("¿Cuál? Número[ ]: ");
            int CodigoSerie = Convert.ToInt32(Console.ReadLine());
            int Pos = Datos.PosSerie(CodigoSerie);
            if (Pos>=0) {
                Console.WriteLine("Nombre: "+Datos.Series[Pos].Nombre);
                Console.WriteLine("URL: "+Datos.Series[Pos].URLIMDB);
                Console.WriteLine("Actores");
                ListaActores=Datos.SerieActores(CodigoSerie);
                for (int cont = 0; cont<ListaActores.Count; cont++)
                    Console.WriteLine("\t"+ListaActores[cont]);
            } else
                Console.WriteLine("Error en código de la serie");
            Console.WriteLine("\nENTER para continuar");
            Console.ReadKey();
        }

        //Asociar actor o actriz a una serie
        public void SerieAsocia() {
            Console.WriteLine("\tAsocia un actor o actriz a una serie");
            Console.Write("¿Cuál serie? Número[ ]: ");
            int CodigoSerie = Convert.ToInt32(Console.ReadLine());
            for (int cont = 0; cont<Datos.Actores.Count; cont++) {
                Console.Write("["+Datos.Actores[cont].Codigo+"] ");
                Console.Write(Datos.Actores[cont].Nombre);
                Console.WriteLine(" URL: "+Datos.Actores[cont].URLIMDB);
            }
            Console.Write("¿Cuál Actor? Número[ ]: ");
            int CodigoActor = Convert.ToInt32(Console.ReadLine());
            if (Datos.SerieAsocia(CodigoSerie, CodigoActor))
                Console.WriteLine("\nActor asociado a la serie.");
            else
                Console.WriteLine("\nError código del actor o ya estaba asociado a la serie");
            Console.ReadKey();
        }

        //Pantalla para disociar actor de alguna serie
        public void SerieDisocia() {
            List<string> ListaActores;

            Console.WriteLine("\t === Disociar actor de la serie ===");
            Console.Write("¿Cuál serie? Número[ ]: ");
            int CodigoSerie = Convert.ToInt32(Console.ReadLine());
            int Pos = Datos.PosSerie(CodigoSerie);
            if (Pos>=0) {
                ListaActores=Datos.SerieActores(CodigoSerie);
                for (int cont = 0; cont<ListaActores.Count; cont++)
                    Console.WriteLine(ListaActores[cont]);

                Console.Write("¿Cuál actor quiere quitar? Número[ ]: ");
                int CodigoActor = Convert.ToInt32(Console.ReadLine());

                if (Datos.SerieDisocia(CodigoSerie, CodigoActor)==true)
                    Console.WriteLine("\nActor retirado de la serie.");
                else
                    Console.WriteLine("\nError retirando actor de la serie");
            } else
                Console.WriteLine("Error en el código de la serie");
            Console.ReadKey();
        }

    }

}
