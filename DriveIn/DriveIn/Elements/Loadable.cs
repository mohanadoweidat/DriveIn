using System;
using System.Collections.Generic;
using System.Text;

namespace DriveIn.Elements
{
    public interface Loadable
    {
        void OnLoadStarted(string type);

        void OnLoadFinished(string type);
    }
}