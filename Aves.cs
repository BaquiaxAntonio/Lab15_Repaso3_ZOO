﻿namespace Lab15_Repaso3_ZOO
{
    public class Aves:Animal
    {
        public bool Vuela { get; set; }
        public string PeriodoEncubacion { get; set; }

        public Aves()
        {
            Vuela = false;
            PeriodoEncubacion=string.Empty;
        }
    }
}
