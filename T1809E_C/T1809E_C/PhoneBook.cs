using System.Collections.Generic;

namespace T1809E_C
{
    public class PhoneBook : Phone
    {
        public List<PhoneNumber> PhoneList;

        public override bool insertPhone(string name, string phone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (!p.Phone.Equals(phone))
                    {
                        p.Phone += ":" + phone;
                        return true;
                    }

                    return false;
                }
            }
            PhoneList.Add(new PhoneNumber(name,phone));
            return true;
        }

        public override bool removePhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public override bool updatePhone(string name, string newphone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    p.Phone = newphone;
                    return true;
                }
            }

            return false;
        }

        public override PhoneNumber searchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }

            return null;
        }
    }
}