﻿namespace Lab15_Repaso3_ZOO
{
    public class Serpiente:Animal
    {
        public bool Venenosa {  get; set; }
        public string Longitud { get; set; }

        public Serpiente()
        {
            Venenosa = false;
            Longitud = string.Empty;
        }
    }
}
