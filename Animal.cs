namespace Lab15_Repaso3_ZOO
{
    public class Animal
    {
        public string Nombre {  get; set; }
        public string Especie { get; set; }
        public string Alimentacion { get; set; }
        public string TiempoVida { get; set; }

        public Animal()
        {
            Nombre = string.Empty;
            Especie = string.Empty;
            Alimentacion = string.Empty;
            TiempoVida = string.Empty;
        }
    }
}
