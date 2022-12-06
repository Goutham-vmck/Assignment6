using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment6.BAL
{
    public class bal
    {
        DAL.dal objdal = new DAL.dal();



        private int pid;
        private string desg;
        private int desgid;

        public int DepId
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }
        }
        public string Desgination
        {
            get
            {
                return desg;
            }
            set
            {
                desg = value;
            }
        }
        public int DesgId
        {
            get
            {
                return desgid;
            }
            set
            {
                desgid = value;
            }
        }
       
        public DataTable getdeprt()
        {
            return objdal.Getdeprt(this);
        }

        public int insertDesig()
        {
            return objdal.InsertDesig(this);
        }
        public DataTable viewdesign()
        {
            return objdal.desigview(this);
        }

        public int Desigupdate()
        {
            return objdal.desgUpdate(this);
        }

        public int deletedesig()
        {
            return objdal.Deletedesig(this);
        }

    }
}