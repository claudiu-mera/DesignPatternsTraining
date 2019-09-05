namespace Prototype
{
    public class PrototypeDescription
    {
        public string Name { get; set; }

        public string Details { get; set; }

        public override string ToString()
        {
            return $"Name:{this.Name}, Details:{this.Details}";
        }
    }
}
