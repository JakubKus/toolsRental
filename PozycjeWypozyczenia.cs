//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toolsRental
{
    using System;
    using System.Collections.Generic;
    
    public partial class PozycjeWypozyczenia
    {
        public int IDwypozyczenia { get; set; }
        public int IDnarzedzia { get; set; }
        public double Rabat { get; set; }
    
        public virtual Narzedzia Narzedzia { get; set; }
        public virtual Wypozyczenia Wypozyczenia { get; set; }
    }
}
