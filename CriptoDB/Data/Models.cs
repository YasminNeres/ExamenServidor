using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cripto.Models
{
    public class Cartera
    {
        //Clave Principal NO AUTONUMERICA
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CarteraId { get; set; }
        public string Nombre { get; set; }
        public string Exchange { get; set; }

        //Escribe las propiedades de navegación a otras Entidades

        // A implementar
        public override string ToString() => $"A implementar";
    }
    public class Moneda
    {
        //Clave Principal String
        [Key]
        public string MonedaId { get; set; }
        public decimal Actual { get; set; }
        public decimal Maximo { get; set; }

        //Escribe las propiedades de navegación a otras Entidades

        // A implementar
        public override string ToString() => $"A implementar";
    }
    public class Contrato
    {     
      [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int IDcontrato {get;set;}   
       public int  CarteraId {get;set;}
       public string MonedaId  {get;set;}
       public int Cantidad { get; set; }

        //Escribe las propiedades de navegación a otras Entidades


        // A implementar
        public override string ToString() => $"A implementar";
    }

}