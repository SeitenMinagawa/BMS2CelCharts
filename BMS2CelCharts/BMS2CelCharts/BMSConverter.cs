using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BMS2CelCharts
{
    class BMSConverter
    {
        const string b36magic = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        DataSet BMSData;

        public BMSConverter()
        {
            BMSData = new DataSet("BMS");

            DataTable htable = BMSData.Tables.Add("Header");
            htable.Columns.Add("Key");
            htable.Columns.Add("Contents");

            DataTable mtable = BMSData.Tables.Add("Main");
            mtable.Columns.Add("Measure");
            mtable.Columns.Add("Channel");
            mtable.Columns.Add("Content");
        }

        public void LoadBMS(string[] vs)
        {
            foreach (string s in vs)
            {
                //半角スペースでのスプリットを試みる
                string[] sps = s.Split(' ');

                if (sps.Length >= 2)
                {
                    DataTable htable = BMSData.Tables["Header"];

                    DataRow row = htable.Rows.Add(new object[] { sps[0], sps[1] });
                }
                else 
                {
                    //「:」でのスプリットを試みる
                    string[] spc = s.Split(':');

                    if (spc.Length >= 2)
                    {
                        long measure = -1;
                        string channel = spc[0].Substring(4, 2);

                        try
                        {
                            measure = long.Parse(spc[0].Substring(1, 3));
                        }
                        catch
                        {
                            continue;
                        }

                        DataTable mtable = BMSData.Tables["Main"];

                        DataRow row = mtable.Rows.Add(new object[] { measure, channel, spc[1] });
                    }
                }
            }
        }

        public DataSet GetData()
        {
            return BMSData;
        }

        static public long ConvertB36ToInt(string str)
        {
            long res = 0;

            //文字の順番を反転させる
            str = string.Join("", str.Reverse());

            for (int i = 0, isz = str.Length; i < isz; i++)
            {
                long add = b36magic.IndexOf(str[i]);

                if (add == -1) return -1;

                add = add * (long)Math.Pow(36, i);

                res += add;
            }

            return res;
        }
    };
}
