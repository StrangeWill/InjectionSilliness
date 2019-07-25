namespace InjectionSilliness.App
{
    public class InjectedItem
    {
        public IThing1 IThing1 { get; }

        public IThing2 IThing2 { get; }


        public InjectedItem(IThing1 thing1, IThing2 thing2)
        {
            IThing1 = thing1;
            IThing2 = thing2;
        }
    }
}