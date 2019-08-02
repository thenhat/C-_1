namespace T1809E_C
{
    public abstract class Phone
    {
        public abstract bool insertPhone(string name, string phone);
        public abstract bool removePhone(string name);
        public abstract bool updatePhone(string name, string newphone);
        public abstract PhoneNumber searchPhone(string name);
    }
}