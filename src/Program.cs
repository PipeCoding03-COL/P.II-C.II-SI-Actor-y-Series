namespace Program {
    class Program { /**
        static void Main() {
            //Se debe llamar primero la capa de persistencia
            //(carga datos de ejemplo)
            Persistencia objDatos = new();

            //Luego se llama la capa visual
            Visual objVisual = new(objDatos);
            objVisual.Menu();
        }**/
    }
}
