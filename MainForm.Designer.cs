
namespace Tran_2020
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.NumericUpDown numericTransformers;
		private System.Windows.Forms.Label labelDataTitle;
		private System.Windows.Forms.DataGridView dataTransformers;
		private System.Windows.Forms.Label labelData1;
		private System.Windows.Forms.Label labelData2;
		private System.Windows.Forms.Label labelData3;
		private System.Windows.Forms.Label labelData4;
		private System.Windows.Forms.Label labelData5;
		private System.Windows.Forms.Label labelData6;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.Label labelLoad;
		private System.Windows.Forms.TextBox textBoxLoad;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label labelState;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textResults;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl2;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Windows.Forms.Label labelData7;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.SaveFileDialog exportDialog;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.numericTransformers = new System.Windows.Forms.NumericUpDown();
			this.labelDataTitle = new System.Windows.Forms.Label();
			this.dataTransformers = new System.Windows.Forms.DataGridView();
			this.labelData1 = new System.Windows.Forms.Label();
			this.labelData2 = new System.Windows.Forms.Label();
			this.labelData3 = new System.Windows.Forms.Label();
			this.labelData4 = new System.Windows.Forms.Label();
			this.labelData5 = new System.Windows.Forms.Label();
			this.labelData6 = new System.Windows.Forms.Label();
			this.buttonCalc = new System.Windows.Forms.Button();
			this.labelLoad = new System.Windows.Forms.Label();
			this.textBoxLoad = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.labelData7 = new System.Windows.Forms.Label();
			this.labelState = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.buttonExport = new System.Windows.Forms.Button();
			this.textResults = new System.Windows.Forms.TextBox();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.printPreviewControl2 = new System.Windows.Forms.PrintPreviewControl();
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exportDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.numericTransformers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTransformers)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Liberation Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTitle.Location = new System.Drawing.Point(4, 4);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(890, 34);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Planowanie Pracy Rownoleglej Transformatorow";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNumber
			// 
			this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumber.Location = new System.Drawing.Point(618, 41);
			this.labelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(182, 30);
			this.labelNumber.TabIndex = 1;
			this.labelNumber.Text = "Ilosc transformatorow:";
			this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericTransformers
			// 
			this.numericTransformers.BackColor = System.Drawing.Color.WhiteSmoke;
			this.numericTransformers.Location = new System.Drawing.Point(805, 50);
			this.numericTransformers.Margin = new System.Windows.Forms.Padding(2);
			this.numericTransformers.Maximum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericTransformers.Minimum = new decimal(new int[] {
			2,
			0,
			0,
			0});
			this.numericTransformers.Name = "numericTransformers";
			this.numericTransformers.ReadOnly = true;
			this.numericTransformers.Size = new System.Drawing.Size(90, 20);
			this.numericTransformers.TabIndex = 10;
			this.numericTransformers.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			this.numericTransformers.ValueChanged += new System.EventHandler(this.NumericTransformersValueChanged);
			// 
			// labelDataTitle
			// 
			this.labelDataTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDataTitle.Location = new System.Drawing.Point(238, 41);
			this.labelDataTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDataTitle.Name = "labelDataTitle";
			this.labelDataTitle.Size = new System.Drawing.Size(206, 58);
			this.labelDataTitle.TabIndex = 3;
			this.labelDataTitle.Text = "Dane transformatorow:";
			this.labelDataTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataTransformers
			// 
			this.dataTransformers.AllowUserToAddRows = false;
			this.dataTransformers.AllowUserToDeleteRows = false;
			this.dataTransformers.AllowUserToResizeColumns = false;
			this.dataTransformers.AllowUserToResizeRows = false;
			this.dataTransformers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dataTransformers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataTransformers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataTransformers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTransformers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataTransformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTransformers.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataTransformers.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataTransformers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.dataTransformers.EnableHeadersVisualStyles = false;
			this.dataTransformers.GridColor = System.Drawing.Color.WhiteSmoke;
			this.dataTransformers.Location = new System.Drawing.Point(238, 102);
			this.dataTransformers.Margin = new System.Windows.Forms.Padding(2);
			this.dataTransformers.Name = "dataTransformers";
			this.dataTransformers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTransformers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataTransformers.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataTransformers.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataTransformers.RowTemplate.Height = 24;
			this.dataTransformers.Size = new System.Drawing.Size(657, 324);
			this.dataTransformers.TabIndex = 4;
			this.dataTransformers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransformersCellValueChanged);
			this.dataTransformers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataTransformersKeyDown);
			this.dataTransformers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataTransformersMouseDown);
			// 
			// labelData1
			// 
			this.labelData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData1.Location = new System.Drawing.Point(2, 118);
			this.labelData1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData1.Name = "labelData1";
			this.labelData1.Size = new System.Drawing.Size(232, 23);
			this.labelData1.TabIndex = 5;
			this.labelData1.Text = "Moc Znamionowa [kVA]";
			this.labelData1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelData2
			// 
			this.labelData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData2.Location = new System.Drawing.Point(2, 164);
			this.labelData2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData2.Name = "labelData2";
			this.labelData2.Size = new System.Drawing.Size(232, 23);
			this.labelData2.TabIndex = 6;
			this.labelData2.Text = "Straty Jalowe [kW]";
			this.labelData2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelData3
			// 
			this.labelData3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData3.Location = new System.Drawing.Point(2, 210);
			this.labelData3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData3.Name = "labelData3";
			this.labelData3.Size = new System.Drawing.Size(232, 24);
			this.labelData3.TabIndex = 7;
			this.labelData3.Text = "Straty Obciazeniowe [kW]";
			this.labelData3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelData4
			// 
			this.labelData4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData4.Location = new System.Drawing.Point(4, 251);
			this.labelData4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData4.Name = "labelData4";
			this.labelData4.Size = new System.Drawing.Size(229, 24);
			this.labelData4.TabIndex = 8;
			this.labelData4.Text = "Napiecie Zwarcia [%]";
			this.labelData4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelData5
			// 
			this.labelData5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData5.Location = new System.Drawing.Point(2, 297);
			this.labelData5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData5.Name = "labelData5";
			this.labelData5.Size = new System.Drawing.Size(232, 24);
			this.labelData5.TabIndex = 9;
			this.labelData5.Text = "Napiecie Strony Pierwotnej [kV]";
			this.labelData5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelData6
			// 
			this.labelData6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData6.Location = new System.Drawing.Point(4, 343);
			this.labelData6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData6.Name = "labelData6";
			this.labelData6.Size = new System.Drawing.Size(229, 24);
			this.labelData6.TabIndex = 10;
			this.labelData6.Text = "Napiecie Strony Wtornej [kV]";
			this.labelData6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonCalc
			// 
			this.buttonCalc.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCalc.Location = new System.Drawing.Point(2, 68);
			this.buttonCalc.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(232, 31);
			this.buttonCalc.TabIndex = 11;
			this.buttonCalc.Text = "Oblicz";
			this.buttonCalc.UseVisualStyleBackColor = false;
			this.buttonCalc.Click += new System.EventHandler(this.ButtonCalcClick);
			// 
			// labelLoad
			// 
			this.labelLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLoad.Location = new System.Drawing.Point(619, 71);
			this.labelLoad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLoad.Name = "labelLoad";
			this.labelLoad.Size = new System.Drawing.Size(182, 28);
			this.labelLoad.TabIndex = 12;
			this.labelLoad.Text = "Obciazenie sieci [kVA]:";
			this.labelLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxLoad
			// 
			this.textBoxLoad.Location = new System.Drawing.Point(806, 79);
			this.textBoxLoad.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxLoad.Name = "textBoxLoad";
			this.textBoxLoad.Size = new System.Drawing.Size(91, 20);
			this.textBoxLoad.TabIndex = 13;
			this.textBoxLoad.Text = "0";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(2, 1);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(906, 460);
			this.tabControl.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage1.Controls.Add(this.labelData7);
			this.tabPage1.Controls.Add(this.labelState);
			this.tabPage1.Controls.Add(this.dataTransformers);
			this.tabPage1.Controls.Add(this.textBoxLoad);
			this.tabPage1.Controls.Add(this.labelTitle);
			this.tabPage1.Controls.Add(this.labelLoad);
			this.tabPage1.Controls.Add(this.labelNumber);
			this.tabPage1.Controls.Add(this.buttonCalc);
			this.tabPage1.Controls.Add(this.numericTransformers);
			this.tabPage1.Controls.Add(this.labelDataTitle);
			this.tabPage1.Controls.Add(this.labelData6);
			this.tabPage1.Controls.Add(this.labelData1);
			this.tabPage1.Controls.Add(this.labelData5);
			this.tabPage1.Controls.Add(this.labelData2);
			this.tabPage1.Controls.Add(this.labelData4);
			this.tabPage1.Controls.Add(this.labelData3);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(898, 434);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Wpisywanie Danych";
			// 
			// labelData7
			// 
			this.labelData7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelData7.Location = new System.Drawing.Point(4, 383);
			this.labelData7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelData7.Name = "labelData7";
			this.labelData7.Size = new System.Drawing.Size(229, 24);
			this.labelData7.TabIndex = 15;
			this.labelData7.Text = "Grupa Polaczen [-]";
			this.labelData7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelState
			// 
			this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelState.Location = new System.Drawing.Point(4, 41);
			this.labelState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(229, 27);
			this.labelState.TabIndex = 14;
			this.labelState.Text = "Wpisz dane transformatorow...";
			this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage2.Controls.Add(this.buttonExport);
			this.tabPage2.Controls.Add(this.textResults);
			this.tabPage2.Controls.Add(this.buttonPrint);
			this.tabPage2.Controls.Add(this.buttonSave);
			this.tabPage2.Controls.Add(this.buttonCopy);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(898, 434);
			this.tabPage2.TabIndex = 2;
			this.tabPage2.Text = "Wyniki Obliczen";
			// 
			// buttonExport
			// 
			this.buttonExport.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExport.Location = new System.Drawing.Point(452, 2);
			this.buttonExport.Margin = new System.Windows.Forms.Padding(2);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(219, 34);
			this.buttonExport.TabIndex = 5;
			this.buttonExport.Text = "Eksportuj";
			this.buttonExport.UseVisualStyleBackColor = false;
			this.buttonExport.Click += new System.EventHandler(this.ButtonExportClick);
			// 
			// textResults
			// 
			this.textResults.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textResults.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textResults.Location = new System.Drawing.Point(5, 41);
			this.textResults.Margin = new System.Windows.Forms.Padding(2);
			this.textResults.Multiline = true;
			this.textResults.Name = "textResults";
			this.textResults.ReadOnly = true;
			this.textResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textResults.Size = new System.Drawing.Size(890, 386);
			this.textResults.TabIndex = 4;
			// 
			// buttonPrint
			// 
			this.buttonPrint.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPrint.Location = new System.Drawing.Point(675, 2);
			this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(219, 34);
			this.buttonPrint.TabIndex = 3;
			this.buttonPrint.Text = "Drukuj";
			this.buttonPrint.UseVisualStyleBackColor = false;
			this.buttonPrint.Click += new System.EventHandler(this.ButtonPrintClick);
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(228, 2);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(219, 34);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Zapisz";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonCopy
			// 
			this.buttonCopy.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCopy.Location = new System.Drawing.Point(5, 2);
			this.buttonCopy.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(218, 34);
			this.buttonCopy.TabIndex = 1;
			this.buttonCopy.Text = "Kopiuj";
			this.buttonCopy.UseVisualStyleBackColor = false;
			this.buttonCopy.Click += new System.EventHandler(this.ButtonCopyClick);
			// 
			// saveDialog
			// 
			this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveDialogFileOk);
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.Location = new System.Drawing.Point(0, 0);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(100, 100);
			this.printPreviewControl1.TabIndex = 0;
			// 
			// printPreviewControl2
			// 
			this.printPreviewControl2.Location = new System.Drawing.Point(0, 0);
			this.printPreviewControl2.Name = "printPreviewControl2";
			this.printPreviewControl2.Size = new System.Drawing.Size(100, 100);
			this.printPreviewControl2.TabIndex = 0;
			// 
			// printDialog
			// 
			this.printDialog.UseEXDialog = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
			// 
			// exportDialog
			// 
			this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportDialogFileOk);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(908, 461);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Tran 2020";
			((System.ComponentModel.ISupportInitialize)(this.numericTransformers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTransformers)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
