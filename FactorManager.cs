using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    //نمیذارم inherite بشه
    public sealed class FactorManager : Person
    {

        #region روش اول
        private static readonly object _lock = new object();

        //نمیذارم کسی شی بسازه
        private FactorManager()
        {

        }

        //اجازه بدم یک شی داشته باشه
        [ThreadStatic]
        private static FactorManager _instance = null;

        public static FactorManager Instance
        {
            get
            {

                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {

                            _instance = new FactorManager();
                        }
                    }

                }
                return _instance;
            }

        }
        #endregion





        #region روش دوم 

        //private static readonly Dictionary<int, FactorManager> _Instances = new Dictionary<int, FactorManager>();

        //private static readonly object _lock = new object();

        //private FactorManager()
        //{
        //}

        //public static FactorManager Instance
        //{
        //    get
        //    {
        //        int threadId = Thread.CurrentThread.ManagedThreadId;

        //        lock (_lock)
        //        {
        //            if (!_Instances.ContainsKey(threadId))
        //            {
        //                _Instances[threadId] = new FactorManager();
        //            }
        //            return _Instances[threadId];
        //        }
        //    }
        //}

    }


    #endregion

}

    

