/* Проект автор проекта MrMegaVolk
 * проект выложен на github https://github.com/MrMegaVolk/FindText
 */

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FindText
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

#region settings
		/* Load settings*/
		private void Form1_Load(object sender, EventArgs e)
		{
			PauseButton.Hide();
			ResumeButton.Hide();
			StopButton.Enabled = false;


			FolderDialog.SelectedPath = Properties.Settings.Default.Path;
			PathTextBox.Text = Properties.Settings.Default.Path;
			FindTextBox.Text = Properties.Settings.Default.TextFind;
			InFileCheckBox.Checked = Properties.Settings.Default.InFile;
			TemplateNameTextBox.Text = Properties.Settings.Default.TemplateName;
			Author.Text = "Автор " + Properties.Settings.Default.Author;
		}

		/* Save Settings*/
		private void PathTextBox_TextChanged(object sender, EventArgs e)
		{
			FolderDialog.SelectedPath = PathTextBox.Text;
			Properties.Settings.Default.Path = FolderDialog.SelectedPath;
		}
		private void PathButton_Click(object sender, EventArgs e)
		{
			if (FolderDialog.ShowDialog() == DialogResult.OK)
			{
				PathTextBox.Text = FolderDialog.SelectedPath;
				Properties.Settings.Default.Path = FolderDialog.SelectedPath;
			}
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
			if (ProcessThread != null && ProcessThread.IsAlive)
				ProcessThread.Abort();
		}
		private void FindTextBox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.TextFind = FindTextBox.Text;
		}
		private void InFileCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.InFile = InFileCheckBox.Checked;
		}
		private void TemplateNameTextBox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.TemplateName = TemplateNameTextBox.Text;
		}

#endregion

#region logic
		/* control */
		Thread ProcessThread;
		private void StartButton_Click(object sender, EventArgs e)
		{
			ilock();
			StartButton.Hide();
			PauseButton.Show();
			StopButton.Enabled = true;

			Properties.Settings.Default.Save();
			OutTree.Nodes.Clear();
			this.Height = 600;

			ProgressBar.Value = 0;
			sec = min = hours = 0;
			WorkingTime.Enabled = true;

			ProcessThread = new Thread(new ThreadStart(ThreadProcess));
			ProcessThread.Start();
		}
		private void StopButton_Click(object sender, EventArgs e)
		{
			unilock();

			PauseButton.Hide();
			ResumeButton.Hide();
			StartButton.Show();
			StopButton.Enabled = false;

			WorkingTime.Enabled = false;

			if (sender != null)
			{
				if (ProcessThread.ThreadState == ThreadState.Suspended)
					ProcessThread.Resume();
				ProcessThread.Abort();
			}
		}
		private void PauseButton_Click(object sender, EventArgs e)
		{
			PauseButton.Hide();
			ResumeButton.Show();

			WorkingTime.Enabled = false;

			ProcessThread.Suspend();
		}
		private void ResumeButton_Click(object sender, EventArgs e)
		{
			ResumeButton.Hide();
			PauseButton.Show();

			ProcessThread.Resume();

			WorkingTime.Enabled = true;
		}

		/* timer */
		private int sec, min, hours;
		private void WorkingTime_Tick(object sender, EventArgs e)
		{
			sec += 1;
			if (sec == 60)
			{
				sec = 0;
				min += 1;
			}
			if (min == 60)
			{
				min = 0;
				hours += 1;
			}
			if (hours == 24)
			{
				WorkingTimeLabel.Text = "overflow, time >= 1 day";
				WorkingTime.Enabled = false;
			}
			WorkingTimeLabel.Text = "Прошедшее время: ";
			if (hours < 10)
				WorkingTimeLabel.Text += hours.ToString();
			else
				WorkingTimeLabel.Text += hours.ToString();
			if (min < 10)
				WorkingTimeLabel.Text += ":0" + min.ToString();
			else
				WorkingTimeLabel.Text += ":" + min.ToString();
			if (sec < 10)
				WorkingTimeLabel.Text += ":0" + sec.ToString();
			else
				WorkingTimeLabel.Text += ":" + sec.ToString();
		}

		// interface lock
		private void unilock()
		{
			PathTextBox.Enabled = true;
			FindTextBox.Enabled = true;
			TemplateNameTextBox.Enabled = true;
			InFileCheckBox.Enabled = true;
			StartButton.Enabled = true;
			PathButton.Enabled = true;
		}
		private void ilock()
		{
			PathTextBox.Enabled = false;
			FindTextBox.Enabled = false;
			TemplateNameTextBox.Enabled = false;
			InFileCheckBox.Enabled = false;
			StartButton.Enabled = false;
			PathButton.Enabled = false;
		}

		// processing
		private void ThreadProcess()
		{
			try
			{
				string[] Pattern = TemplateNameTextBox.Text.Split('.');
				string[][] SuitableFiles = new string[Pattern.Count()][];
				int totalCount = 0;
				int count = 0;
				string templ = "";
				string currentFile = "";
				for (int i = 0; i < Pattern.Count(); i++)
				{
					SuitableFiles[i] = System.IO.Directory.GetFiles(Properties.Settings.Default.Path,
						"*." + Pattern[i], System.IO.SearchOption.AllDirectories);

					totalCount += SuitableFiles[i].Count();

					Action UpdateMaxCount = () =>
					{
						templ = " / " + totalCount + " файлов";

						CountFileLabel.Text = "0" + templ;
					};
					Invoke(UpdateMaxCount);
				}

				TreeNode MainNode = new TreeNode(PathTextBox.Text);
				Action SetProgressBarAndMainNode = () => // set main node and total count files
				{
					ProgressBar.Minimum = 0;
					ProgressBar.Maximum = totalCount;
					OutTree.Nodes.Add(MainNode);
				};
				Invoke(SetProgressBarAndMainNode);

				for (int i = 0; i < SuitableFiles.Count(); i++)
				{
					foreach (string str in SuitableFiles[i])
					{
						string[] strsplit = str.Replace("\\", @"\").Replace(PathTextBox.Text + "\\", "").Split('\\');
						int[] pos = FindInFile(str);
						currentFile = str;

						if (strsplit[strsplit.Count() - 1].Contains(FindTextBox.Text) || pos != null)
						{
							int indx = 0;
							AddNode(indx, strsplit, Pattern[i], MainNode, pos);
						}

						count++;
						AddCount(count, templ, currentFile);
					}
				}

				Action actdone = () =>
				{
					StopButton_Click(null, null);
				};
				Invoke(actdone);
			}
			catch (Exception ex)
			{
				if (ex.GetType().ToString() != "System.Threading.ThreadAbortException")
					MessageBox.Show("Неверно введён начальный путь или шаблоны имени.");
			}
		}
		private void AddNode(int indx, string[] name, string template, TreeNode Node, int[] pos)
		{
			Action AddNodes = () =>
			{
				AddNode(ref indx, ref name, ref template, ref Node);

				if (pos != null)
					foreach (int str in pos)
						Node.Nodes.Add("В строке " + str.ToString());
				OutTree.Nodes[0].ExpandAll();
			};
			Invoke(AddNodes);
		}
		private void AddNode(ref int indx, ref string[] name, ref string template, ref TreeNode Node)
		{
			if (indx == name.Count() - 1) // make file
			{
				Node = Node.Nodes.Add(name[indx]);
				return;
			}

			for (int i = 0; i < Node.Nodes.Count; i++) // make directory
			{
				if (Node.Nodes[i].Text == name[indx])
				{
					Node = Node.Nodes[i];
					indx++;
					AddNode(ref indx, ref name, ref template, ref Node);
					return;
				}
			}
			Node = Node.Nodes.Add(name[indx++]);
			AddNode(ref indx, ref name, ref template, ref Node);

		}
		private int[] FindInFile(string file)
		{
			if (InFileCheckBox.Checked)
			{
				StreamReader str = new StreamReader(file, Encoding.Default);
				int[] pos = new int[0];
				int position = 0;
				while (!str.EndOfStream)
				{
					position++;
					string st = str.ReadLine();
					if (st.Contains(FindTextBox.Text))
					{
						Array.Resize(ref pos, pos.Length + 1);
						pos[pos.Length - 1] = position;
					}
				}

				if (pos.Length == 0)
					return null;
				return pos;
			}
			return null;
		}
		private void AddCount(int count, string templ, string current)
		{
			Action AddCount = () =>
			{
				CurrentFileLabel.Text = "Текущий файл: " + current;
				CountFileLabel.Text = count + templ;
				ProgressBar.Value = count;
			};
			Invoke(AddCount);
		}

#endregion


	}
}
