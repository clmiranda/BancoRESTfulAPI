using Domain.Common;

namespace Domain.Entities
{
    public class Cliente:AuditableBaseEntity
    {
        private int _edad;
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
        public required string Direccion { get; set; }
        public int Edad
        {
            get {
                if (_edad <= 0) {
                    _edad = new DateTime(DateTime.Now.Subtract(this.FechaNacimiento).Ticks).Year - 1;
                }
                return _edad;
            }
        }
    }
}