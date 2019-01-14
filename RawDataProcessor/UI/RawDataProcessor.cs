using RawDataProcessor.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawDataProcessor
{
    public partial class RawDataProcessorForm : Form
    {
       

        public RawDataProcessorForm()
        {
            InitializeComponent();
        }

        public void RawDataProcessor_Load(object sender, EventArgs e)
        {

            messageBox.Text = "intializing assemblies";
            ExcelReader.Preload();
            messageBox.Text = "Intialization completed";
            messageBox.Text = "";
            loationtextBox.Text = "CAN";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (loationtextBox.Text.Equals("CAN"))
            {
                foreach (var item in ExcelReader.workSheetData_CAN)
                {
                    if (item.RawData.Contains(textBox1.Text))
                    {
                        processedData.Text = item.ProcessedData;
                        break;
                    }
                }
            }
            if (loationtextBox.Text.Equals("US"))
            {
                foreach (var item in ExcelReader.workSheetData_US)
                {
                    if (item.RawData.Contains(textBox1.Text))
                    {
                        processedData.Text = item.ProcessedData;
                        break;
                    }
                }
            }

        }

        private void processBtn_Click(object sender, EventArgs e)
        {

            if (loationtextBox.Text.Equals("CAN"))
            {
                foreach (var item in ExcelReader.workSheetData_CAN)
                {
                    if (item.RawData.Equals(textBox1.Text))
                    {
                        processedData.Text = item.ProcessedData;
                        break;
                    }
                }
            }
            if (loationtextBox.Text.Equals("US"))
            {
                foreach (var item in ExcelReader.workSheetData_US)
                {
                    if (item.RawData.Equals(textBox1.Text))
                    {
                        processedData.Text = item.ProcessedData;
                        break;
                    }
                }
            }
        }
    }
}


