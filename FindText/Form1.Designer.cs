/* Проект автор проекта MrMegaVolk
 * проект выложен на github https://github.com/MrMegaVolk/FindText
 */


namespace FindText
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.OutTree = new System.Windows.Forms.TreeView();
			this.StopButton = new System.Windows.Forms.Button();
			this.StartButton = new System.Windows.Forms.Button();
			this.PathTextBox = new System.Windows.Forms.TextBox();
			this.FindTextBox = new System.Windows.Forms.TextBox();
			this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.PathButton = new System.Windows.Forms.Button();
			this.PauseButton = new System.Windows.Forms.Button();
			this.ResumeButton = new System.Windows.Forms.Button();
			this.PathLabel = new System.Windows.Forms.Label();
			this.FindLabel = new System.Windows.Forms.Label();
			this.CurrentFileLabel = new System.Windows.Forms.Label();
			this.CountFileLabel = new System.Windows.Forms.Label();
			this.WorkingTimeLabel = new System.Windows.Forms.Label();
			this.TemplateNameTextBox = new System.Windows.Forms.TextBox();
			this.TemplateNameLabel = new System.Windows.Forms.Label();
			this.InFileCheckBox = new System.Windows.Forms.CheckBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.WorkingTime = new System.Windows.Forms.Timer(this.components);
			this.Author = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OutTree
			// 
			this.OutTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OutTree.Location = new System.Drawing.Point(12, 164);
			this.OutTree.Name = "OutTree";
			this.OutTree.Size = new System.Drawing.Size(760, 385);
			this.OutTree.TabIndex = 0;
			// 
			// StopButton
			// 
			this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StopButton.Image = global::FindText.Properties.Resources.stop;
			this.StopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StopButton.Location = new System.Drawing.Point(702, 63);
			this.StopButton.Margin = new System.Windows.Forms.Padding(0);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(70, 30);
			this.StopButton.TabIndex = 2;
			this.StopButton.Text = "Stop";
			this.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// StartButton
			// 
			this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartButton.Image = global::FindText.Properties.Resources.start;
			this.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StartButton.Location = new System.Drawing.Point(702, 12);
			this.StartButton.Name = "StartButton";
			this.StartButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartButton.Size = new System.Drawing.Size(70, 30);
			this.StartButton.TabIndex = 1;
			this.StartButton.Text = "Start";
			this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// PathTextBox
			// 
			this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PathTextBox.Location = new System.Drawing.Point(134, 12);
			this.PathTextBox.Name = "PathTextBox";
			this.PathTextBox.Size = new System.Drawing.Size(501, 20);
			this.PathTextBox.TabIndex = 3;
			this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
			// 
			// FindTextBox
			// 
			this.FindTextBox.Location = new System.Drawing.Point(134, 38);
			this.FindTextBox.Name = "FindTextBox";
			this.FindTextBox.Size = new System.Drawing.Size(405, 20);
			this.FindTextBox.TabIndex = 4;
			this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
			// 
			// FolderDialog
			// 
			this.FolderDialog.Description = "Выберите папку начала поиска";
			// 
			// PathButton
			// 
			this.PathButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.PathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PathButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PathButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PathButton.Location = new System.Drawing.Point(634, 12);
			this.PathButton.Name = "PathButton";
			this.PathButton.Size = new System.Drawing.Size(16, 20);
			this.PathButton.TabIndex = 5;
			this.PathButton.Text = "…";
			this.PathButton.UseVisualStyleBackColor = true;
			this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
			// 
			// PauseButton
			// 
			this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PauseButton.Image = global::FindText.Properties.Resources.start;
			this.PauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.PauseButton.Location = new System.Drawing.Point(690, 12);
			this.PauseButton.Name = "PauseButton";
			this.PauseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PauseButton.Size = new System.Drawing.Size(82, 30);
			this.PauseButton.TabIndex = 7;
			this.PauseButton.Text = "Pause";
			this.PauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.PauseButton.UseVisualStyleBackColor = true;
			this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
			// 
			// ResumeButton
			// 
			this.ResumeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ResumeButton.Image = global::FindText.Properties.Resources.start;
			this.ResumeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ResumeButton.Location = new System.Drawing.Point(675, 12);
			this.ResumeButton.Name = "ResumeButton";
			this.ResumeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ResumeButton.Size = new System.Drawing.Size(97, 30);
			this.ResumeButton.TabIndex = 8;
			this.ResumeButton.Text = "Resume";
			this.ResumeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ResumeButton.UseVisualStyleBackColor = true;
			this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
			// 
			// PathLabel
			// 
			this.PathLabel.AutoSize = true;
			this.PathLabel.Location = new System.Drawing.Point(17, 15);
			this.PathLabel.Name = "PathLabel";
			this.PathLabel.Size = new System.Drawing.Size(111, 13);
			this.PathLabel.TabIndex = 9;
			this.PathLabel.Text = "Путь начала поиска:";
			// 
			// FindLabel
			// 
			this.FindLabel.AutoSize = true;
			this.FindLabel.Location = new System.Drawing.Point(28, 41);
			this.FindLabel.Name = "FindLabel";
			this.FindLabel.Size = new System.Drawing.Size(100, 13);
			this.FindLabel.TabIndex = 10;
			this.FindLabel.Text = "Текст для поиска:";
			// 
			// CurrentFileLabel
			// 
			this.CurrentFileLabel.AutoSize = true;
			this.CurrentFileLabel.Location = new System.Drawing.Point(12, 111);
			this.CurrentFileLabel.Name = "CurrentFileLabel";
			this.CurrentFileLabel.Size = new System.Drawing.Size(87, 13);
			this.CurrentFileLabel.TabIndex = 11;
			this.CurrentFileLabel.Text = "Текущий файл: ";
			// 
			// CountFileLabel
			// 
			this.CountFileLabel.AutoSize = true;
			this.CountFileLabel.Location = new System.Drawing.Point(12, 140);
			this.CountFileLabel.Name = "CountFileLabel";
			this.CountFileLabel.Size = new System.Drawing.Size(65, 13);
			this.CountFileLabel.TabIndex = 12;
			this.CountFileLabel.Text = "0/0 файлов";
			// 
			// WorkingTimeLabel
			// 
			this.WorkingTimeLabel.AutoSize = true;
			this.WorkingTimeLabel.Location = new System.Drawing.Point(622, 140);
			this.WorkingTimeLabel.Name = "WorkingTimeLabel";
			this.WorkingTimeLabel.Size = new System.Drawing.Size(150, 13);
			this.WorkingTimeLabel.TabIndex = 14;
			this.WorkingTimeLabel.Text = "Прошедшее время: 00:00:00";
			// 
			// TemplateNameTextBox
			// 
			this.TemplateNameTextBox.Location = new System.Drawing.Point(134, 64);
			this.TemplateNameTextBox.Name = "TemplateNameTextBox";
			this.TemplateNameTextBox.Size = new System.Drawing.Size(405, 20);
			this.TemplateNameTextBox.TabIndex = 15;
			this.TemplateNameTextBox.TextChanged += new System.EventHandler(this.TemplateNameTextBox_TextChanged);
			// 
			// TemplateNameLabel
			// 
			this.TemplateNameLabel.AutoSize = true;
			this.TemplateNameLabel.Location = new System.Drawing.Point(9, 67);
			this.TemplateNameLabel.Name = "TemplateNameLabel";
			this.TemplateNameLabel.Size = new System.Drawing.Size(119, 13);
			this.TemplateNameLabel.TabIndex = 16;
			this.TemplateNameLabel.Text = "Шаблон имени файла:";
			// 
			// InFileCheckBox
			// 
			this.InFileCheckBox.AutoSize = true;
			this.InFileCheckBox.Location = new System.Drawing.Point(550, 66);
			this.InFileCheckBox.Name = "InFileCheckBox";
			this.InFileCheckBox.Size = new System.Drawing.Size(107, 17);
			this.InFileCheckBox.TabIndex = 6;
			this.InFileCheckBox.Text = "Поиск в файлах";
			this.InFileCheckBox.UseVisualStyleBackColor = true;
			this.InFileCheckBox.CheckedChanged += new System.EventHandler(this.InFileCheckBox_CheckedChanged);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(143, 135);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(463, 23);
			this.ProgressBar.TabIndex = 17;
			// 
			// WorkingTime
			// 
			this.WorkingTime.Interval = 1000;
			this.WorkingTime.Tick += new System.EventHandler(this.WorkingTime_Tick);
			// 
			// Author
			// 
			this.Author.AutoSize = true;
			this.Author.Location = new System.Drawing.Point(550, 41);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(100, 13);
			this.Author.TabIndex = 18;
			this.Author.Text = "Автор MrMegaVolk";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Author);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.TemplateNameLabel);
			this.Controls.Add(this.TemplateNameTextBox);
			this.Controls.Add(this.WorkingTimeLabel);
			this.Controls.Add(this.CountFileLabel);
			this.Controls.Add(this.CurrentFileLabel);
			this.Controls.Add(this.FindLabel);
			this.Controls.Add(this.PathLabel);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.PauseButton);
			this.Controls.Add(this.ResumeButton);
			this.Controls.Add(this.InFileCheckBox);
			this.Controls.Add(this.PathButton);
			this.Controls.Add(this.FindTextBox);
			this.Controls.Add(this.PathTextBox);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.OutTree);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Поиск текста по каталогам и файлам";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView OutTree;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.TextBox PathTextBox;
		private System.Windows.Forms.TextBox FindTextBox;
		private System.Windows.Forms.FolderBrowserDialog FolderDialog;
		private System.Windows.Forms.Button PathButton;
		private System.Windows.Forms.Button PauseButton;
		private System.Windows.Forms.Button ResumeButton;
		private System.Windows.Forms.Label PathLabel;
		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.Label CurrentFileLabel;
		private System.Windows.Forms.Label CountFileLabel;
		private System.Windows.Forms.Label WorkingTimeLabel;
		private System.Windows.Forms.TextBox TemplateNameTextBox;
		private System.Windows.Forms.Label TemplateNameLabel;
		private System.Windows.Forms.CheckBox InFileCheckBox;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Timer WorkingTime;
		private System.Windows.Forms.Label Author;
	}
}

