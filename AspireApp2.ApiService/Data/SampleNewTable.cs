using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AspireApp2.ApiService.Data
{
    public class SampleNewTable
    {
        public int Id { get; set; }
        public bool AfterInitBool { get; set; } = false;
        [NotNull]
        [Required]
        public bool AfterInitBoolWithAttributes { get; set; } = false;
        [DefaultValue(false)]
        public bool AfterInitBoolWithDefaultValueAttribute { get; set; }
    }
}
