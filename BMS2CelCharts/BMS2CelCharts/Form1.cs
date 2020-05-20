using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BMS2CelCharts
{
    public partial class Form1 : Form
    {
        private class BPMObject
        {
            public double Beat { get; set; }
            public double BPM { get; set; }
            public double StopTime { get; set; }
        }

        //string lanename = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Form1()
        {
            InitializeComponent();

            //初期設定
            comChartStyle.SelectedIndex = 9;
            comJudgeLevel.SelectedIndex = 5;    //初期設定はレベル5
        }

        //変換処理
        private string GenerateCSChart(string path, DataSet ds)
        {
            int lanecount = 0;
            List<string> lanedealling = new List<string>();

            switch (comChartStyle.SelectedIndex)
            {
                case 0:
                    lanecount = 4;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    break;

                case 1:
                    lanecount = 5;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("15");
                    break;

                case 2:
                    lanecount = 6;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("15");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    break;

                case 3:
                    lanecount = 7;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("15");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    break;

                case 4:
                    lanecount = 8;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("15");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    lanedealling.Add("16");
                    break;

                case 5:
                    lanecount = 9;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("15");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    lanedealling.Add("16");
                    lanedealling.Add("26");
                    break;

                case 6:
                    lanecount = 8;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    lanedealling.Add("24");
                    lanedealling.Add("25");
                    break;

                case 7:
                    lanecount = 9;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    lanedealling.Add("24");
                    lanedealling.Add("25");
                    lanedealling.Add("16");
                    break;

                case 8:
                    lanecount = 9;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("15");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    lanedealling.Add("24");
                    lanedealling.Add("25");
                    break;

                case 9:
                    lanecount = 11;
                    lanedealling.Add("11");
                    lanedealling.Add("12");
                    lanedealling.Add("13");
                    lanedealling.Add("14");
                    lanedealling.Add("15");
                    lanedealling.Add("22");
                    lanedealling.Add("23");
                    lanedealling.Add("24");
                    lanedealling.Add("25");
                    lanedealling.Add("16");
                    lanedealling.Add("26");
                    break;
            }



            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);

            //レーン数、判定レベル、TOTAL値を書き込む
            writer.WriteLine("N," + comChartStyle.SelectedIndex.ToString());
            writer.WriteLine("J," + comJudgeLevel.SelectedIndex.ToString());
            writer.WriteLine("O," + numTotal.Value.ToString());

            writer.WriteLine("");

            //BPM情報をすべて書き込む
            foreach (DataGridViewRow dr in gridBPMSetting.Rows)
            {
                if (dr.IsNewRow) continue;

                if (dr.Cells[0].Value == null) continue;
                if (dr.Cells[1].Value == null) continue;
                if (dr.Cells[2].Value == null) continue;

                string beat = dr.Cells[0].Value.ToString();
                string bpm = dr.Cells[1].Value.ToString();
                string stop = dr.Cells[2].Value.ToString();

                string write = "B,";
                write += beat + ',';
                write += bpm + ',';
                write += stop;

                writer.WriteLine(write);
            }

            writer.WriteLine("");

            writer.WriteLine("");

            double accumulatebeat = 0.0;

            //999小節まで走査
            for (int i = 0; i <= numLastMeasure.Value; i++)
            {
                //その小節のデータをすべて取得
                DataRow[] measuredata = ds.Tables["Main"].Select("Measure='" + i.ToString() + "' and Channel='02'");

                double measurelength = 4.0;

                //先にその小節の情報を取得してから変換にかかる
                foreach (DataRow dr in measuredata)
                {
                    try
                    {
                        measurelength = double.Parse(dr.ItemArray[2].ToString()) * 4;
                    }
                    catch
                    {
                        continue;
                    }
                }

                //小節の設定があったら設定し、なかったら普通の小節線として出力
                bool hasset = false;
                foreach (DataGridViewRow dr in gridMeasureLineSetting.Rows)
                {
                    if (dr.IsNewRow) continue;

                    if (int.Parse(dr.Cells[0].Value.ToString()) != i) continue;

                    switch (dr.Cells[1].Value.ToString())
                    {
                        case "Standard":
                            writer.WriteLine("7," + accumulatebeat.ToString());
                            hasset = true;
                            break;

                        case "Fake":
                            writer.WriteLine("8," + accumulatebeat.ToString());
                            hasset = true;
                            break;

                        case "Hidden":
                            writer.WriteLine("9," + accumulatebeat.ToString());
                            hasset = true;
                            break;
                    }

                    if (hasset) break;
                }

                if (!hasset) writer.WriteLine("7," + accumulatebeat.ToString());

                //レーン設定に基づきノートを生成する
                for (int j = 0; j < lanecount; j++)
                {
                    DataRow[] contentdata = ds.Tables["Main"].Select("Measure='" + i.ToString() + "' and Channel='" + lanedealling[j] + "'");

                    foreach (DataRow dr in contentdata)
                    {
                        string content = dr.ItemArray[2].ToString();
                        double beatunit = measurelength / (content.Length / 2);

                        for (int k = 0, ksz = content.Length / 2; k < ksz; k++)
                        {
                            long obj = BMSConverter.ConvertB36ToInt(content.Substring(k * 2, 2).ToUpper());

                            switch (obj)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    writer.WriteLine(obj.ToString() + ',' + j.ToString() + ',' + (accumulatebeat + beatunit * k).ToString());
                                    break;
                            }
                        }
                    }
                }

                accumulatebeat += measurelength;
            }

            writer.Close();

            return "";
        }

        private void butBPMRowDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in gridBPMSetting.SelectedRows)
            {
                if (!dr.IsNewRow) gridBPMSetting.Rows.Remove(dr);
            }
        }

        private void butMeasureLineSettingDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in gridMeasureLineSetting.SelectedRows)
            {
                if (!dr.IsNewRow) gridMeasureLineSetting.Rows.Remove(dr);
            }
        }

        private void butSelectData_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) txtPath.Text = openFileDialog1.FileName;
        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(txtPath.Text, Encoding.UTF8);
                string[] vs = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray());
                BMSConverter conv = new BMSConverter();
                conv.LoadBMS(vs);
                GenerateCSChart(saveFileDialog1.FileName, conv.GetData());
                MessageBox.Show("出力完了", "", MessageBoxButtons.OK);
            }
        }

        private void butImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gridBPMSetting.Rows.Clear();
                gridMeasureLineSetting.Rows.Clear();

                StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                string[] vs = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray());
                foreach (string s in vs)
                {
                    string[] split = s.Split(',');

                    switch (s.Substring(0, 1))
                    {
                        case "B":
                            if (split.Length < 4) break;

                            gridBPMSetting.Rows.Add(new object[] { Decimal.Parse(split[1]), Decimal.Parse(split[2]), Decimal.Parse(split[3]) });
                            break;
                    }
                }

                MessageBox.Show("取込完了", "", MessageBoxButtons.OK);
            }
        }
    }
}

