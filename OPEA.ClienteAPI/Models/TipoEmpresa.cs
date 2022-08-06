using OPEA.ClienteAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPEA.ClienteAPI.Models
{
    public class TipoEmpresa : BaseEntity
    {
        [Column(name: "tipo_empresa")]
        [StringLength(15)]
        public string Tipo { get; set; } = string.Empty;
    }
}
