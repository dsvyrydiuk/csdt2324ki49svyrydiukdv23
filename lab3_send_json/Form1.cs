using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace lab3_send_json
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

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonFilePath = "C:\\Users\\ADMIN\\Desktop\\lab3\\lab3_send_json\\config.json";
            string json = File.ReadAllText(jsonFilePath);

            RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(json);

            rootObj.rC.stA = (int)numericUpDownStartAngle.Value; // Замініть на ваше нове значення
            rootObj.rC.endA = (int)numericUpDownEndAngle.Value;
            rootObj.rC.rD = (int)numericUpDownRotationDelay.Value;
            rootObj.rC.sI = (int)numericUpDownStereoTone.Value;
            if (radioButtonTrue.Checked == true)
            {
                rootObj.rC.rW = true;  // Аналогічно для інших полів
            }else
            {
                rootObj.rC.rW = false;
            }
            // Серіалізуємо змінений об'єкт назад у рядок JSON
            string output = JsonConvert.SerializeObject(rootObj, Formatting.Indented);

            // Записуємо змінений JSON назад у файл
            File.WriteAllText("C:\\Users\\ADMIN\\Desktop\\lab3\\lab3_send_json\\config.json", output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonTrue.Checked = true; 
            radioButtonFalse.Checked = false;
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            string jsonFilePath = "C:\\Users\\ADMIN\\Desktop\\lab3\\lab3_send_json\\config.json";
            using (SerialPort port = new SerialPort("COM10", 9600))
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
