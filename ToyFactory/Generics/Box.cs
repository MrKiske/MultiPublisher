using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace ToyFactory.Generics
{
    public class Box<T>
    {
        public T Content { get; private set; }
        
        private bool hasContent;

        public void Put(T content)
        {
            if (hasContent)
            {
                throw new Exception("Already exist some object in the box!.");
            }

            this.Content = content;
            hasContent = true;
        }

        public T Extract()
        {
            if (!hasContent)
            {
                throw new Exception("Doesn't exist nothing object in the box!.");
            }

            var content = this.Content;
            this.Content = default(T);
            hasContent = false;
            return content;
        }
    }
}
