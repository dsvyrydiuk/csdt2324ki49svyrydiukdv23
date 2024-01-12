using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
//using System.Xml;

namespace test5
{
    public partial class Form1 : Form
    {
        public class RootObject
        {
            public RC rC { get; set; }
        }

        public class RC
        {
            public int stA { get; set; }
            public int rD { get; set; }
            public bool rW { get; set; }
            public int sI { get; set; }
            public int endA { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Збереження параметрів у конфігураційний файл
        /// </summary>
        public void button1_Click(object sender, EventArgs e)
        {
            string jsonFilePath = "C:\\Users\\ADMIN\\Desktop\\test5\\test5\\config.json";
            //string json = File.ReadAllText(jsonFilePath);
            RootObject rootObj = GetRootObj(jsonFilePath);

            rootObj.rC.stA = (int)numericUpDownStartAngle.Value;
            rootObj.rC.endA = (int)numericUpDownEndAngle.Value;
            rootObj.rC.rD = (int)numericUpDownRotationDelay.Value;
            rootObj.rC.sI = (int)numericUpDownStereoTone.Value;

            CheckRadioButton(rootObj);
            SendDataInJSON(rootObj, jsonFilePath);
        }

        public RootObject GetRootObj(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<RootObject>(json);
        }
        public void CheckRadioButton(RootObject rootObj)
        {
            if (radioButtonTrue.Checked == true)
            {
                rootObj.rC.rW = true;
            }
            else
            {
                rootObj.rC.rW = false;
            }
        }

        public void SendDataInJSON(RootObject rootObj, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject(rootObj, Formatting.Indented);
            File.WriteAllText(jsonFilePath, output);
        }

        /// <summary>
        /// Встановлення стартовийх параметрів у вікні
        /// </summary>
        public void Form1_Load(object sender, EventArgs e)
        {
            radioButtonTrue.Checked = true;
            radioButtonFalse.Checked = false;
        }

        /// <summary>
        /// Відправлення конфігурації до порту
        /// </summary>
        public void buttonSendData_Click(object sender, EventArgs e)
        {
            string jsonFilePath = "C:\\Users\\ADMIN\\Desktop\\test5\\test5\\config.json";
            using (SerialPort port = new SerialPort("COM9", 9600))
            {
                port.Open();
                string jsonData = File.ReadAllText(jsonFilePath);
                jsonData = jsonData.Replace("\r", "");
                jsonData = jsonData.Replace("\n", "");
                jsonData = jsonData.Replace(" ", "");
                port.Write(jsonData);
                Thread.Sleep(100);
                port.Close();
            }
        }
    }
}
