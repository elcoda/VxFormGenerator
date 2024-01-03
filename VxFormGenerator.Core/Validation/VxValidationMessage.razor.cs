
namespace VxFormGenerator.Core.Validation
{
    public class VxValidationMessageComponent<TValue> : ValidationMessageBase<TValue>
    {
        public override string ValidClass { get; set; } = "valid-feedback";
        
        //TODO: check if we can change invalide-feedback style on scss to avoid using text-danger and have correct validation message behavior #1
        public override string InValidClass { get; set; } = "text-danger";
    }
}
