//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SKLEP_NOWY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkty
    {
        public string producent { get; set; }
        public string model { get; set; }
        public string typ { get; set; }
    
        public virtual Drukarki Drukarki { get; set; }
        public virtual Laptop Laptop { get; set; }
        public virtual PC PC { get; set; }
    }
}
