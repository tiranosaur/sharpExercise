using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace sharpExercise.Models
{
    [XmlRoot("ValCurs")]
    public class ValCurs : List<Valute>
    {
        [XmlAttribute("Date")] public string Date { get; set; }
        [XmlAttribute("name")] public string Name { get; set; }
    }
    public class Valute
    {
        [Key] 
        [XmlIgnore]
        public int Id { get; set; }
        [XmlAttribute("ID")] 
        public string valuteID { get; set; }
        [XmlElement("NumCode")]
        public string numCode { get; set; }
        [XmlElement("Nominal")]
        public int nominal { get; set; }
        [XmlElement("CharCode")]
        public string сharCode { get; set; }
        [XmlElement("Name")]
        public string name { get; set; }
        [XmlElement("Value")]
        public string value { get; set; }
        [XmlElement("Date")]
        public DateTime date { get; set; }
    }
}