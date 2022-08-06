using OPEA.ClienteAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OPEA.ClienteAPI.Models
{
    public class Cliente : BaseEntity
    {
        [Column(name:"nome_empresa")]
        [StringLength(100)]
        public string? NomeEmpresa { get; set; }

        [Column(name: "tipo_empresa_id")]
        public int TipoEmpresaID { get; set; }

        [JsonIgnore]
        public TipoEmpresa? TipoEmpresa { get; set; }


    }
}
