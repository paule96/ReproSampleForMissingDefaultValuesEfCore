using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AspireApp2.ApiService.Data
{
    public class SampleData
    {
        public int Id { get; set; }
        public bool InitBool { get; set; } = false;
        [NotNull]
        [Required]
        public bool InitBoolWithAttributes { get; set; } = false;
        [DefaultValue(false)]
        public bool InitBoolWithDefaultValueAttribute { get; set; }

        public bool AfterInitBool { get; set; } = false;
        [NotNull]
        [Required]
        public bool AfterInitBoolWithAttributes { get; set; } = false;
        [DefaultValue(false)]
        public bool AfterInitBoolWithDefaultValueAttribute { get; set; }
    }
}
