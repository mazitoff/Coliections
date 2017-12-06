using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class FileManager2
    {
        public delegate void FileFound2Handler();

        private int _countEvents = 0;
        private event FileFound2Handler _fileFound;
        public event FileFound2Handler FileFound2
        {
            add
            {
                if(_countEvents < 1)
                {
                    _fileFound += value;
                    _countEvents = 1 + _countEvents;
                }
            }
            remove
            {
                if(_countEvents > 0)
                {
                    _countEvents = _countEvents - 1;
                }
                
                _fileFound -= value;
            }
        }

        public void Search2(bool isFound)
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
