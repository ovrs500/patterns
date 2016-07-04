using System;

namespace Prototype
{
    public abstract class Shape : ICloneable
    {
        private string _id;
        protected string _type;

        public abstract string draw();

        public string getType()
        {
            return _type;
        }

        public string getId()
        {
            return _id;
        }

        public void setId(string id)
        {
            _id = id;
        }

        public object Clone()
        {
            Object clone = null;

            try
            {
                clone = this.Clone();
            }
            catch (Exception ex)
            {
                throw;
            }

            return clone;
        }
    }
}