using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class FileManager
    {
        public delegate void FileFoundHandler();
        public event FileFoundHandler FileFound;

        public void Search(bool isFound)
        {
            if (FileFound != null)
            {
                OnFileFound();
            }
        }

        protected virtual void OnFileFound()   // этот метод события можно будет переопределить в наследнике
        {
            if (FileFound != null)
            {
                FileFound();
            }
        }
    }
}
