/*
 * Created by SharpDevelop.
 * User: LAB-02
 * Date: 11/11/2021
 * Time: 09:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_9
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button btn_iniciar;
		private System.Windows.Forms.Button btn_detener;
		private System.Windows.Forms.Button btn_reiniciar;
		private System.Windows.Forms.Label lbl_horas;
		private System.Windows.Forms.Label lbl_minutos;
		private System.Windows.Forms.Label lbl_segundos;
		
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.btn_iniciar = new System.Windows.Forms.Button();
			this.btn_detener = new System.Windows.Forms.Button();
			this.btn_reiniciar = new System.Windows.Forms.Button();
			this.lbl_horas = new System.Windows.Forms.Label();
			this.lbl_minutos = new System.Windows.Forms.Label();
			this.lbl_segundos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.Location = new System.Drawing.Point(12, 57);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
			this.btn_iniciar.TabIndex = 0;
			this.btn_iniciar.Text = "Iniciar";
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.Btn_iniciarClick);
			// 
			// btn_detener
			// 
			this.btn_detener.Location = new System.Drawing.Point(93, 57);
			this.btn_detener.Name = "btn_detener";
			this.btn_detener.Size = new System.Drawing.Size(75, 23);
			this.btn_detener.TabIndex = 1;
			this.btn_detener.Text = "Detener";
			this.btn_detener.UseVisualStyleBackColor = true;
			this.btn_detener.Click += new System.EventHandler(this.Btn_detenerClick);
			// 
			// btn_reiniciar
			// 
			this.btn_reiniciar.Location = new System.Drawing.Point(174, 57);
			this.btn_reiniciar.Name = "btn_reiniciar";
			this.btn_reiniciar.Size = new System.Drawing.Size(75, 23);
			this.btn_reiniciar.TabIndex = 2;
			this.btn_reiniciar.Text = "Reiniciar";
			this.btn_reiniciar.UseVisualStyleBackColor = true;
			this.btn_reiniciar.Click += new System.EventHandler(this.Btn_reiniciarClick);
			// 
			// lbl_horas
			// 
			this.lbl_horas.Location = new System.Drawing.Point(12, 21);
			this.lbl_horas.Name = "lbl_horas";
			this.lbl_horas.Size = new System.Drawing.Size(75, 33);
			this.lbl_horas.TabIndex = 3;
			this.lbl_horas.Text = "00";
			this.lbl_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_minutos
			// 
			this.lbl_minutos.Location = new System.Drawing.Point(93, 21);
			this.lbl_minutos.Name = "lbl_minutos";
			this.lbl_minutos.Size = new System.Drawing.Size(75, 33);
			this.lbl_minutos.TabIndex = 4;
			this.lbl_minutos.Text = "00";
			this.lbl_minutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_segundos
			// 
			this.lbl_segundos.Location = new System.Drawing.Point(174, 21);
			this.lbl_segundos.Name = "lbl_segundos";
			this.lbl_segundos.Size = new System.Drawing.Size(75, 33);
			this.lbl_segundos.TabIndex = 5;
			this.lbl_segundos.Text = "00";
			this.lbl_segundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 115);
			this.Controls.Add(this.lbl_segundos);
			this.Controls.Add(this.lbl_minutos);
			this.Controls.Add(this.lbl_horas);
			this.Controls.Add(this.btn_reiniciar);
			this.Controls.Add(this.btn_detener);
			this.Controls.Add(this.btn_iniciar);
			this.Name = "MainForm";
			this.Text = "Ejercicio 9";
			this.ResumeLayout(false);

		}
	}
}
