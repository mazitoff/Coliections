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

        private event FileFoundHandler _fileFound;
        public event FileFoundHandler FileFound
        {
            add { _fileFound += value; }
            remove { _fileFound -= value; }
        }

        public void Search(bool isFound)
        {
            if (_fileFound != null)
            {
                OnFileFound();
            }
        }

        protected virtual void OnFileFound()   // этот метод события можно будет переопределить в наследнике
        {
            if (_fileFound != null)
            {
                _fileFound();
            }
        }
    }
}
