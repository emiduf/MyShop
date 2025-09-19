using System;
namespace MyShop.Models
{

    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}

/*
public class Item: deklarerer en offentlig klasse. 
Gjør klassen tilgjengelig for andre klasser og komponenter. 
Klassen er en mal for objekter som inneholder felt, egenskaper, metoder og andre medlemmer. 

ItemId: Egenskapen ItemId er av typen int (heltall). 
Den er public som gjør den tilgjengelig utenfor klassen 
get og set definerer auto-implementert egenskap med en offentlig getter og setter,
slik at verdien kan både leses og endres.  

Description: er av typen string? som indikerer at egenskapen Description kan være
null, at den enten kan inneholde en streng eller null. 
*/