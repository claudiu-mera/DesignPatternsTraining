namespace Prototype
{
    public class ConcretePrototype : Prototype
    {
        public override Prototype ShallowCopy()
        {
            return (Prototype) this.MemberwiseClone();
        }

        public override Prototype DeepCopy()
        {
            return new ConcretePrototype
            {
                Id = this.Id,
                Description = new PrototypeDescription
                {
                    Name = this.Description.Name,
                    Details = this.Description.Details
                }
            };
        }
    }
}
