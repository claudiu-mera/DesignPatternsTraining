using Adapter.Interfaces;

namespace Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this._turkey = turkey;
        }

        public void Quack()
        {
            this._turkey.Gobble();
        }

        public void Fly()
        {
            // call Turkey Fly() 5 times to simulate longer Duck Flight
            for (var i = 0; i < 5; i++)
            {
                this._turkey.Fly();
            }
        }
    }
}
