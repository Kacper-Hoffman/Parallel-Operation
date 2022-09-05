using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Tran_2020
{
	public partial class MainForm : Form
	{
		int iT, iTmax, idSmin, idSmax, currentColumn;
		double[,] dT;
		double[] So, dS;
		double dSmin, dSmax, Smax, Szad, sumaSnUk, sumaSzn, sumaPj, sumaPo;
		string nl, tmpPath, dataError;
		string[] library;
		bool[] activeOrder;
		StreamReader reader;
		StringBuilder resultexport;
		public MainForm()
		{
			InitializeComponent();
			init();
		}
		void init()
		{
			iT=2;
			iTmax=10;
			dSmin=0;
			dSmax=0;
			idSmin=1;
			idSmax=1;
			Smax=0;
			Szad=0;
			currentColumn=0;
			nl=System.Environment.NewLine;
			tmpPath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\tmp.txt";
			dataError="";
			library=File.ReadAllLines(Application.StartupPath+"\\transformatory.txt");
			toolTip.SetToolTip(labelTitle,@"Autor: Kacper Hoffman
Praca Inzynierska 2020");
			System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
			customCulture.NumberFormat.NumberDecimalSeparator = ".";
			System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
			buttonCopy.Enabled=false;
			buttonSave.Enabled=false;
			buttonExport.Enabled=false;
			buttonPrint.Enabled=false;
			saveDialog.Filter="Plik Tekstowy |*txt";
			saveDialog.Title="Zapisz wyniki obliczen...";
			saveDialog.FileName="Wyniki_Tekst.txt";
			saveDialog.OverwritePrompt=true;
			exportDialog.Filter="Plik Tekstowy |*txt";
			exportDialog.Title="Eksportuj wyniki obliczen...";
			exportDialog.FileName="Wyniki_Eksport.txt";
			exportDialog.OverwritePrompt=true;
			resultexport=new StringBuilder();
			numericTransformers.Value=iT;
			numericTransformers.Maximum=iTmax;
			dataTransformers.RowCount=7;
			for(int i=0;i<7;i++)
			{
				dataTransformers.Rows[i].Height=dataTransformers.Height/7;
			}
			initContext();
			updateData(iT);
		}
		void initContext()
		{
			for(int i=1;i<library.Length;i++)
			{
				if(library[i-1].Contains("Transformator"))
				{
					try
					{
						var transformer=new ToolStripMenuItem(library[i]);
						transformer.Name=library[i];
						transformer.Click+=new EventHandler(MenuItemClick);
						contextMenuStrip.Items.Add(transformer);
					}
					catch
					{
						MessageBox.Show("Zly format biblioteki!","Blad biblioteki",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
		}
		void updateData(int n)
		{
			dataTransformers.ColumnCount=n;
			for(int i=0;i<iT;i++)
			{
				dataTransformers.Columns[i].Width=dataTransformers.Width/n;
			}
		}
		void insertData()
		{
			dT=new double[iTmax,8];
			So=new double[iT];
			activeOrder=new bool[iT];
			for(int i=0;i<iT;i++)
			{
				for(int j=0;j<6;j++)
				{
					dT[i,j]=0;
				}
				So[i]=0;
			}
			try
			{
				Szad=double.Parse(textBoxLoad.Text);
			}
			catch
			{
				MessageBox.Show("Podaj prawidlowe obciazenie sieci","Zle obciazenie",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			for(int i=0;i<iT;i++)
			{
				if(!tryInsertData(i)) break;
			}
			Smax=dT[0,0];
			for(int i=1;i<iT;i++)
			{
				Smax+=dT[i,0];
			}
		}
		void calculate()
		{
			labelState.Text="Obliczanie strat...";
			sumaSnUk=0;
			for(int i=0;i<iT;i++)
			{
				// disable CompareOfFloatsByEqualityOperator
				if(dT[i,7]==1)
				{
					sumaSnUk+=dT[i,0]/dT[i,3];
				}
			}
			for(int i=0;i<iT;i++)
			{
				if(dT[i,7]==1)
				{
					So[i]=Szad*dT[i,0]/(dT[i,3]*sumaSnUk);
				}
			}
			dS=new double[(int)Math.Pow(2,iT)];
			for(int i=0;i<Math.Pow(2,iT);i++)
			{
				dS[i]=0;
			}
			for(int i=1;i<=Math.Pow(2,iT)-1;i++)
			{
				sumaSzn=0;
				sumaPj=0;
				sumaPo=0;
				activeOrder=getOrder(i);
				for(int j=0;j<iT;j++)
				{
					if(activeOrder[j])
					{
						sumaSzn+=dT[j,0];
						sumaPj+=dT[j,1];
						sumaPo+=dT[j,2];
					}
				}
				dS[i]=sumaPj+sumaPo*Math.Pow(Szad/sumaSzn,2);
				if(i==1)
				{
					dSmin=dS[i];
					dSmax=dS[i];
				}
				if(dS[i]<dSmin)
				{
					dSmin=dS[i];
					idSmin=i;
				}
				if(dS[i]>dSmax)
				{
					dSmax=dS[i];
					idSmax=i;
				}
			}
		}
		void showResultsText()
		{
			buttonCopy.Enabled=true;
			buttonSave.Enabled=true;
			buttonExport.Enabled=true;
			buttonPrint.Enabled=true;
			labelState.Text="Obliczenia zakonczone...";
			textResults.Text=@"--------------------------------------
   Praca Rownolegla Transformatorow
--------------------------------------

--------------------------
   Dane Transformatorow
--------------------------

                                |";
			textInsert1("------");
			textResults.Text+="|"+nl+"                                |";
			for(int i=0;i<iT;i++)
			{
				if(dT[i,7]==1)
				{
					textResults.Text+=("Tr #"+(i+1)).PadRight(6,' ');
				}
			}
			
			textResults.Text+="|"+nl+"|-------------------------------|";
			textInsert1("------");
			textResults.Text+="|"+nl;
			textInsert2("Moc Znamionowa [kVA]",0);
			textInsert2("Straty Jalowe [kW]",1);
			textInsert2("Straty Obciazeniowe [kW]",2);
			textInsert2("Napiecie Zwarcia [%]",3);
			textInsert2("Napiecie Strony Pierwotnej [kV]",4);
			textInsert2("Napiecie Strony Wtornej [kV]",5);
			textInsert2("Grupa Polaczen [-]",6);
			textResults.Text+="|-------------------------------|";
			textInsert1("------");
			textResults.Text+="|"+nl+nl;
			textResults.Text+="       |-----------------------------------------------------------------|"+nl;
			textResults.Text+="       |Moc Znamionowa [kVA] Moc Obciazenia [kVA] Obciazenie Zadane [kVA]|"+nl;
			textResults.Text+="|------|-----------------------------------------------------------------|"+nl;
			for(int i=0;i<iT;i++)
			{
				if(dT[i,7]==1)
				{
					textResults.Text+=("|Tr #"+(i+1)).PadRight(7,' ');
					textResults.Text+="|"+dT[i,0].ToString().PadLeft(10,' ').PadRight(21,' ');
					textResults.Text+=Math.Round(So[i],2).ToString().PadLeft(10,' ');
					textResults.Text+=Szad.ToString().PadLeft(24,' ')+"          |";
					if(dT[i,0]<So[i])
					{
						textResults.Text+=" <- Przeciazenie";
					}
					textResults.Text+=nl;
				}
			}
			textResults.Text+="|------|-----------------------------------------------------------------|"+nl+nl;
			textResults.Text+=@"-----------------------
   Straty Kombinacji
-----------------------"+nl+nl;
			textResults.Text+="|----------------------------------------------------------|"+nl;
			textResults.Text+="|   Kombinacja [-]    Moc Kombinacji [kVA] Straty Mocy [kW]|"+nl;
			textResults.Text+="|----------------------------------------------------------|"+nl;
			for(int i=1;i<Math.Pow(2,iT);i++)
			{
				textInsert3(i);
			}
			textResults.Text+="|----------------------------------------------------------|";
		}
		void textInsert1(string t)
		{
			for(int j=0;j<iTmax;j++)
			{
				if(dT[j,7]==1)
				{
					textResults.Text+=t;
				}
			}
		}
		void textInsert2(string s,int j)
		{
			textResults.Text+="|"+s.PadRight(31,' ')+"|";
			for(int i=0;i<iT;i++)
			{
				if(j!=6)
				{
					if(dT[i,7]==1)
					{
						textResults.Text+=Math.Round(dT[i,j],2).ToString().PadLeft(4,' ').PadRight(6,' ');
					}
				}
				else
				{
					string groupText="";
					switch(dT[i,6].ToString().Substring(0,1))
					{
						case "1":
							groupText="Yy";
							break;
						case "2":
							groupText="Yd";
							break;
						case "3":
							groupText="Dy";
							break;
						case "4":
							groupText="Dd";
							break;
						case "5":
							groupText="Yz";
							break;
						case "6":
							groupText="Dz";
							break;
					}
					textResults.Text+=(groupText+dT[i,6].ToString().Substring(1).TrimStart('0')).PadLeft(4,' ').PadRight(6,' ');
				}
			}
			textResults.Text+="|"+nl;
		}
		void textInsert3(int i)
		{
			sumaSzn=0;
			textResults.Text+="|";
			activeOrder=getOrder(i);
			for(int j=0;j<iT;j++)
			{
				if(activeOrder[j])
				{
					sumaSzn+=dT[j,0];
					textResults.Text+=(j+1).ToString().PadRight(2,' ');
				}
				else
				{
					textResults.Text+="  ";
				}
			}
			for(int j=iT;j<iTmax;j++)
			{
				textResults.Text+="  ";
			}
			textResults.Text+=sumaSzn.ToString().PadLeft(10,' ').PadRight(21,' ');
			textResults.Text+=Math.Round(dS[i],2).ToString().PadLeft(8,' ').PadRight(17,' ')+"|";
			if(i==idSmin)
			{
				textResults.Text+=" <- Min";
			}
			if(i==idSmax)
			{
				textResults.Text+=" <- Max";
			}
			textResults.Text+=nl;
		}
		void textInsert4(string s,int j)
		{
			resultexport.Append(nl+s+"*");
			for(int i=0;i<iT;i++)
			{
				if(j!=6)
				{
					if(dT[i,7]==1)
					{
						resultexport.Append(Math.Round(dT[i,j],2)+"*");
					}
				}
				else
				{
					string groupText="";
					switch(dT[i,6].ToString().Substring(0,1))
					{
						case "1":
							groupText="Yy";
							break;
						case "2":
							groupText="Yd";
							break;
						case "3":
							groupText="Dy";
							break;
						case "4":
							groupText="Dd";
							break;
						case "5":
							groupText="Yz";
							break;
						case "6":
							groupText="Dz";
							break;
					}
					resultexport.Append(groupText+dT[i,6].ToString().Substring(1).TrimStart('0')+"*");
				}
			}
		}
		bool tryInsertData(int i)
		{
			for(int j=0;j<6;j++)
			{
				try
				{
					dT[i,j]=double.Parse(dataTransformers[i,j].Value.ToString());
					switch(dataTransformers[i,6].Value.ToString().Substring(0,2))
					{
						case "Yy":
							dT[i,6]=100;
							break;
						case "Yd":
							dT[i,6]=200;
							break;
						case "Dy":
							dT[i,6]=300;
							break;
						case "Dd":
							dT[i,6]=400;
							break;
						case "Yz":
							dT[i,6]=500;
							break;
						case "Dz":
							dT[i,6]=600;
							break;
					}
					dT[i,6]+=int.Parse(dataTransformers[i,6].Value.ToString().Substring(2));
					dT[i,7]=1;
				}
				catch
				{
					MessageBox.Show("Wypelnij wszystkie pola prawidlowymi wartosciami!","Zle dane",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}
		bool checkData()
		{
			if(Szad<=0)
			{
				dataError="Obciazenie ujemne/zerowe!";
				return false;
			}
			if(Szad>Smax)
			{
				dataError="Obciazenie wieksze od maksymalnego!";
				return false;
			}
			for(int i=0;i<iT;i++)
			{
				for(int j=i+1;j<iT;j++)
				{
					if(dT[i,7]==1)
					{
						if(Math.Abs(dT[i,4]-dT[j,4])/dT[i,4]>0.005)
						{
							dataError="Odchylka napiec pierwotnych wieksza niz 0.5%!";
							return false;
						}
						if(Math.Abs(dT[i,5]-dT[j,5])/dT[i,5]>0.005)
						{
							dataError="Odchylka napiec wtornych wieksza niz 0.5%!";
							return false;
						}
						if(Math.Abs(dT[i,3]-dT[j,3])/dT[i,3]>0.1)
						{
							MessageBox.Show("Warunki pracy rownoległej niespelnione! Odchylka napiec zwarcia wieksza niz 10%!","Zle warunki",MessageBoxButtons.OK,MessageBoxIcon.Warning);
							return true;
						}
						if(dT[i,0]/dT[j,0]>3)
						{
							dataError="Stosunek mocy znamionowych wiekszy niz 3!";
							return false;
						}
						if(dT[j,0]/dT[i,0]>3)
						{
							dataError="Stosunek mocy znamionowych mniejszy niz 1/3!";
							return false;
						}
						if(dT[i,6]!=dT[j,6])
						{
							dataError="Grupy polaczen niezgodne!";
							return false;
						}
					}
				}
			}
			return true;
		}
		bool[] getOrder(int i)
		{
			string orderString="";
			var orderBool=new bool[iT];
			orderString=Convert.ToString(i,2).PadLeft(iT,'0');
			for(int j=0;j<iT;j++)
			{
				orderBool[j]=orderString[iT-j-1]=='1';
			}
			return orderBool;
		}
		
		void MenuItemClick(object sender, EventArgs e)
		{
			for(int i=0;i<library.Length;i++)
			{
				var item=(ToolStripMenuItem)sender;
				if(library[i]==item.Name)
				{
					for(int j=1;j<8;j++)
					{
						dataTransformers[currentColumn,j-1].Value=library[i+j];
					}
				}
			}
		}
		void NumericTransformersValueChanged(object sender, EventArgs e)
		{
			iT=(int)numericTransformers.Value;
			labelState.Text="Wpisz dane transformatorow...";
			updateData(iT);
		}
		void DataTransformersCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			labelState.Text="Wpisz dane transformatorow...";
		}
		void DataTransformersKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control&&(e.KeyCode==Keys.C))
			{
				Clipboard.SetText(dataTransformers.CurrentCell.Value.ToString());
			}
			if(e.Control&&(e.KeyCode==Keys.V))
			{
				dataTransformers.CurrentCell.Value=Clipboard.GetText();
			}
			if((e.KeyCode==Keys.Back)||(e.KeyCode==Keys.Delete))
			{
				dataTransformers.CurrentCell.Value="";
			}
		}
		void DataTransformersMouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button==System.Windows.Forms.MouseButtons.Right)
			{
				currentColumn=dataTransformers.HitTest(e.X,e.Y).ColumnIndex;
				contextMenuStrip.Show(dataTransformers,new Point(e.X,e.Y));
			}
		}
		void ButtonCalcClick(object sender, EventArgs e)
		{
			insertData();
			if(checkData())
			{
				calculate();
				showResultsText();
			}
			else
			{
				MessageBox.Show("Warunki pracy rownoległej niespelnione! "+dataError,"Zle warunki",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void ButtonCopyClick(object sender, EventArgs e)
		{
			Clipboard.SetText(textResults.Text);
			MessageBox.Show("Skopiowano do schowka","Kopiowanie",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		void ButtonSaveClick(object sender, EventArgs e)
		{
			saveDialog.FileName="Wyniki_Tekst.txt";
			saveDialog.ShowDialog();
		}
		void ButtonExportClick(object sender, EventArgs e)
		{
			exportDialog.FileName="Wyniki_Eksport.txt";
			exportDialog.ShowDialog();
		}
		void ButtonPrintClick(object sender, EventArgs e)
		{
			File.WriteAllText(tmpPath,textResults.Text);
			if(printDialog.ShowDialog()==DialogResult.OK)
			{
				try
    	    	{
    	    	    reader=new StreamReader(tmpPath);
    	    	    try
    	    	    {
    	    	        var pd=new PrintDocument();
    	    	        pd.PrintPage+=new PrintPageEventHandler(this.pd_PrintPage);
    	    	        pd.Print();
    	    	    }
    	    	    finally
    	    	    {
    	    	        reader.Close();
    	    	    }
    	    	}
    	    	catch (Exception ex)
        		{
            		MessageBox.Show(ex.Message);
        		}
			}
			File.Delete(tmpPath);
		}
		void SaveDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			File.WriteAllText(saveDialog.FileName,textResults.Text);
			MessageBox.Show("Zapis udany","Zapis",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		void ExportDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			resultexport=new StringBuilder();
			resultexport.Append("Praca Rownolegla Transformatorow"+nl+nl);
			resultexport.Append("Dane Transformatorow"+nl+"*");
			for(int i=0;i<iT;i++)
			{
				if(dT[i,7]==1)
				{
					resultexport.Append(("Tr #"+(i+1)).PadLeft(6,' ')+"*");
				}
			}
			textInsert4("Moc Znamionowa [kVA]",0);
			textInsert4("Straty Jalowe [kW]",1);
			textInsert4("Straty Obciazeniowe [kW]",2);
			textInsert4("Napiecie Zwarcia [%]",3);
			textInsert4("Napiecie Strony Pierwotnej [kV]",4);
			textInsert4("Napiecie Strony Wtornej [kV]",5);
			textInsert4("Grupa Polaczen [-]",6);
			resultexport.Append(nl+nl+"*Moc Znamionowa [kVA]*Moc Obciazenia [kVA]*Obciazenie Zadane [kVA]"+nl);
			for(int i=0;i<iT;i++)
			{
				resultexport.Append("Tr #"+(i+1)+"*"+Math.Round(dT[i,0],2)+"*"+Math.Round(So[i],2)+"*"+Szad+nl);
			}
			resultexport.Append(nl+nl+"Straty Kombinacji"+nl+"Kombinacja [-]*Moc Kombinacji [kVA]*Straty Mocy [kW]"+nl);
			for(int i=1;i<Math.Pow(2,iT);i++)
			{
				sumaSzn=0;
				activeOrder=getOrder(i);
				for(int j=0;j<iT;j++)
				{
					if(activeOrder[j])
					{
						sumaSzn+=dT[j,0];
						resultexport.Append(j+1);
					}
					else
					{
						resultexport.Append(" ");
					}
				}
				resultexport.Append("*"+Math.Round(sumaSzn,2)+"*"+Math.Round(dS[i],2));
				if(i==idSmax)
				{
					resultexport.Append("*<-Max");
				}
				if(i==idSmin)
				{
					resultexport.Append("*<-Min");
				}
				resultexport.Append(nl);
			}
			File.WriteAllText(exportDialog.FileName,resultexport.ToString());
			MessageBox.Show("Eksport udany. Plik moze zostac importowany do arkusza obliczeniowego przy odgraniczeniu znakiem *","Eksport",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		void pd_PrintPage(object sender, PrintPageEventArgs e)
    	{
			float linesPerPage=0;
     	   	float y=0;
     	   	int index=0;
     	    float leftMargin=e.MarginBounds.Left;
     		float topMargin=e.MarginBounds.Top;
     	    string line=null;
    	    var font=new Font("Courier New", 11);
     	    linesPerPage = e.MarginBounds.Height/font.GetHeight(e.Graphics);
			while (index<linesPerPage &&((line=reader.ReadLine()) != null))
     	    {
				y=topMargin+(index*font.GetHeight(e.Graphics));
     	        e.Graphics.DrawString(line,font,Brushes.Black,leftMargin,y,new StringFormat());
     	        index++;
     	    }
			e.HasMorePages=line!=null;
    	}
	}
}