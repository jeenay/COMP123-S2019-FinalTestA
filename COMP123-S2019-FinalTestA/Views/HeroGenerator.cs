using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: Jeenay Patel
 * STUDENT ID: 301045488
 * DESCRIPTION: This is the Hero Generator Form
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

		public static void LoadNames()
		{
			//Inputing First Name
			string[] lines;
			List<string> fname = new List<string>();
			lines = File.ReadAllLines("firstNames.txt");


			//Inputing Last Name
			string[] Lines;
			List<string> lname = new List<string>();
			Lines = File.ReadAllLines("lastNames.txt");

		}

		private static void GenerateNames()
		{
			//inputing Random variable
			string[] lines;
			List<string> fname = new List<string>();
			lines = File.ReadAllLines("..\\..\\data\\firstNames.txt");
			Random rand = new Random();
			int index = rand.Next(lines.Length);
			Program.heroGenerator.FirstNameDataLabel.Text = lines[index];

			//inputing random variable for last name 
			string[] Lines;
			List<string> lname = new List<string>();
			Lines = File.ReadAllLines("..\\..\\data\\lastNames.txt");
			Random rand1 = new Random();
			int no = rand1.Next(Lines.Length);
			Program.heroGenerator.LastNameDataLabel.Text = lines[no];
		}

        private void GenerateNameButton_Click(object sender, EventArgs e)
		{
			GenerateNames();
		}

		private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			FightingDataLabel.Text = random.Next(10, 50).ToString();
			AgilityDataLabel.Text = random.Next(10, 50).ToString();
			StrengthDataLabel.Text = random.Next(10, 50).ToString();
			EnduranceDataLabel.Text = random.Next(10, 50).ToString();
			ReasonDataLabel.Text = random.Next(10, 50).ToString();
			IntuitionDataLabel.Text = random.Next(10, 50).ToString();
			PsycheDataLabel.Text = random.Next(10, 50).ToString();
			PopularityDataLabel.Text = random.Next(10, 50).ToString();
		}


		private static void LoadPowers()
		{
			//Inputing Power List
			string[] line;
			List<string> Power = new List<string>();
			line = File.ReadAllLines("..\\..\\Objects\\Power.txt");
		}

		private static void GenerateRandomPowers()
		{
			//Inputing Power List
		    string[] line;
		    List<string> Power = new List<string>();
		    line = File.ReadAllLines("..\\..\\Objects\\Power.txt");
			Random rand = new Random();
			int index = rand.Next(line.Length);
			Program.heroGenerator.Powertxt.Text = line[index];

			string[] Lines;
			List<string> Power2 = new List<string>();
			line = File.ReadAllLines("..\\..\\Objects\\Power.txt");
			Random rand1 = new Random();
			int index1 = rand1.Next(Lines.Length);
			Program.heroGenerator.Powertxt.Text = line[index1];
		}


		private void GeneratePowerbtn_Click(object sender, EventArgs e)
		{
			LoadPowers();
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//open streamwrtiter to write
			using (StreamWriter outputString = new StreamWriter(
				File.Open(PowerSaveDialog.FileName, FileMode.Create)))
			{
				outputString.WriteLine(Program.heroGenerator.textBox1.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox2.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox3.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox4.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox5.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox6.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox7.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox8.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox9.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox10.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox11.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox12.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox13.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox14.ToString());
				outputString.WriteLine(Program.heroGenerator.textBox15.ToString());

			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (StreamWriter outputString = new StreamWriter(
				File.Open(PowerOpenDialog.FileName, FileMode.Open)))
			{
				//writing strings to file
				Program.heroGenerator.textBox1 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox2 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox3 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox4 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox5 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox6 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox7 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox8 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox9 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox10 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox11 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox12 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox13 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox14 = short.Parse(inputStream.Readline());
				Program.heroGenerator.textBox15 = short.Parse(inputStream.Readline());
			}

		}
	}
}
