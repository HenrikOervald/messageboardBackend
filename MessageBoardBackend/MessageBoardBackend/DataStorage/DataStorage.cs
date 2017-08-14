using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.DataStorage
{
    public class DataStorage
    {
        private static DataStorage instance;

        private DataStorage() { }

        //Singleton class
        public static DataStorage Instance {
            get{
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;

            }
        }




    }
}
