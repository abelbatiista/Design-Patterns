using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObserver
    {
        void UpdatePush(string message);
        void UpdatePull();
    }
}
