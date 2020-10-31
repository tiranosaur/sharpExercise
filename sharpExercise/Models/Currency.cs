using System;
using System.ComponentModel.DataAnnotations;

namespace sharpExercise.Models
{
    [Serializable]
    public class Currency
    {
        [Key] public int Id { get; set; }
        public string valuteID { get; set; }
        public int numCode { get; set; }
        public int nominal { get; set; }
        public string сharCode { get; set; }
        public string name { get; set; }
        public double value { get; set; }
        public DateTime date { get; set; }
    }
}