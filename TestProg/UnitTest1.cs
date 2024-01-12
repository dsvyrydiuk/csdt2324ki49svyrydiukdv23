using Newtonsoft.Json;
using System.Windows.Forms;
using test5;
using static test5.Form1;

namespace TestProg
{
    public class UnitTest1
    {
        [Fact]
        public void SendDataInJSON_WritesExpectedJsonToFile()
        {
            var mockRootObj = new RootObject {};
            var testPath = "test.json";
            var form = new Form1();

            form.SendDataInJSON(mockRootObj, testPath);

            var writtenText = File.ReadAllText(testPath);
            var expectedJson = JsonConvert.SerializeObject(mockRootObj, Newtonsoft.Json.Formatting.Indented);
            Assert.Equal(expectedJson, writtenText);
            Assert.Equal(expectedJson, writtenText);

            File.Delete(testPath);
        }

        [Fact]
        public void GetRootObj_ReadsJsonFileAndReturnsRootObject()
        {
            var expectedRootObj = new RootObject { rC = new RC { stA = 10 } };
            var testPath = "test.json";
            File.WriteAllText(testPath, JsonConvert.SerializeObject(expectedRootObj));

            var form = new Form1();

            var result = form.GetRootObj(testPath);

            Assert.Equal(expectedRootObj.rC.stA, result.rC.stA);

            File.Delete(testPath);
        }

        [Fact]
        public void CheckRadioButton_SetsRWBasedOnRadioButtonState()
        {
            var form = new Form1();
            form.radioButtonTrue = new RadioButton();
            form.radioButtonFalse = new RadioButton(); 

            form.radioButtonTrue.Checked = true; 
            form.radioButtonFalse.Checked = false; 

            var rootObj = new RootObject { rC = new RC() };

            form.CheckRadioButton(rootObj);

            Assert.True(rootObj.rC.rW);
        }
    }
}