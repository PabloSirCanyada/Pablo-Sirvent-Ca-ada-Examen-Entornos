namespace Pablo_Sirvent_Cañada
{
    class Deposito
    {
        /*Clase que representa la gestión de los depósitos de una granja.
         * Tiene dos depósitos: pienso y agua. 
         * La propiedad devuelve el nivel de agua y pienso. 
         * Los métodos permiten reponer o consumir tanto pienso como agua.
         * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
         */
        private decimal niveldeagua;
        private decimal niveldepienso;
        private decimal cantidadmaxima;
        private decimal tamañodeposito;
        public decimal Niveldeagua
        {
            get { return niveldeagua; }
        }
        public decimal Niveldepienso
        {
            get { return niveldepienso; }
        }
        public void reponer1(decimal cantidadareponerdeagua)
        {
            decimal res;
            tamañodeposito = 10000;
            res = ObtenerNivelSuminstro(cantidadareponerdeagua, tamañodeposito, niveldeagua);

        }

        private decimal ObtenerNivelSuminstro(decimal cantidadareponer, decimal tamañodeposito, decimal niveldesuministro)
        {
            cantidadmaxima = cantidadareponer + niveldesuministro;
            if (cantidadareponer > 0 && cantidadmaxima < tamañodeposito) ;  //Tamaño del depósito de pienso es de 1000 l.
            niveldesuministro = niveldesuministro + cantidadareponer;

            return niveldesuministro;
        }

        public void reponer2(decimal cantidadareponerdepienso)
        {
            decimal res;
            tamañodeposito = 5000;
            res = ObtenerNivelSuminstro(cantidadareponerdepienso, tamañodeposito, Niveldepienso);
        }


        public decimal consumo1(decimal cantidadaretirardeagua)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= niveldeagua)
            {
                retirado1 = cantidadaretirardeagua;
                niveldeagua = niveldeagua - cantidadaretirardeagua;
            }

            return retirado1;
        }
        public decimal consumo2(decimal cantidadaretirardepienso)
        {
            decimal retirado2 = 0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= niveldepienso)
            {
                retirado2 = cantidadaretirardepienso;
                niveldepienso = niveldepienso - cantidadaretirardepienso;
            }
            return retirado2;
        }








    }
}
