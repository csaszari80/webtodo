using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Contollers
{
    public class Feladat
    {
        [Required] //Ez az annotáció megmondja, hogy a következő tulajdonság(property) kötelező
        [MinLength(3)] //Ez a hosszát vizsgálja minimum 3
        //[MaxLength(5)] //eZ is maximum 5
        [DisplayName("A feladat megnevezése: ")] //ezzel az annotációval a címkét tudjuk átnevezni (amit a LabelFor-al kiteszünk a view-ban)
        public string Megnevezes { get; set; } //ez egy tulajdonság(property) (getter setter)
        public bool Elvegezve; //ez egy adatmező(field)
    }
}