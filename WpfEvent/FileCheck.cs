using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace WpfEvent
{

    public delegate void FileCheckEventHandler(object sender, EventArgs e);

    class FileCheck
    {
        private bool _blastStatus = false;
        public FileCheck()
        {

        }
        public event FileCheckEventHandler FileCheckEvent;

        protected virtual void OnFileChange(EventArgs e)
        {
            if (FileCheckEvent != null)
            {
                FileCheckEvent(this, e);
            }

        }

        public void MonitorFile()
        {
            bool bCurrentStatus;
            while (true)
            {
                bCurrentStatus = File.Exists("test.txt");
                if (bCurrentStatus != _blastStatus)
                {
                    _blastStatus = bCurrentStatus;
                    OnFileChange(EventArgs.Empty);
                }
                Thread.Sleep(250);
            }
        }

        public bool getBool()
        {
            return _blastStatus;
        }
    }
}
