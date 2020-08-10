using System;

namespace NullObject
{
    public class PersonRepository
    {
        public IPerson RetrievePerson(int id)
        {
            try
            {
                //attempt to get the person 
                throw new Exception();
            }
            catch (Exception e)
            {
                return new NullPerson();
            }
        }
    }
}