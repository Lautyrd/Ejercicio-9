using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_9
{
	
	public partial class MainForm : Form
	{
		int segundos,minutos,horas;
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Btn_iniciarClick(object sender, EventArgs e)
		{
			timer.Start();
		}
		
		void TimerTick(object sender, EventArgs e)
		{
			segundos++;
			lbl_segundos.Text = Convert.ToString(segundos);
			if(segundos == 60){
				minutos++;
				segundos=0;
				lbl_minutos.Text = Convert.ToString(minutos);
			}
			if(minutos==60){
				horas++;
				minutos=0;
				lbl_horas.Text = Convert.ToString(horas);
			}	
		}
		
		void Btn_detenerClick(object sender, EventArgs e)
		{	
			timer.Stop();
		}
		void Btn_reiniciarClick(object sender, EventArgs e)
		{
			segundos=0;
			minutos=0;
			horas=0;
		}	
	}
}
