namespace MetroCalendar.Control
{
    partial class MetroCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroCalendar));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_dia7 = new MetroFramework.Controls.MetroLabel();
            this.lbl_dia6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_dia5 = new MetroFramework.Controls.MetroLabel();
            this.lbl_dia4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_dia3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_dia2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_dia1 = new MetroFramework.Controls.MetroLabel();
            this.lnk_posterior = new MetroFramework.Controls.MetroLink();
            this.separator = new MetroFramework.Controls.MetroProgressBar();
            this.lnk_anterior = new MetroFramework.Controls.MetroLink();
            this.pnl_dias = new MetroFramework.Controls.MetroPanel();
            this.lbl_dataCompleta = new MetroFramework.Controls.MetroLabel();
            this.lbl_mes = new MetroFramework.Controls.MetroLabel();
            this.lbl_hora = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_dia7
            // 
            this.lbl_dia7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia7.Location = new System.Drawing.Point(295, 65);
            this.lbl_dia7.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia7.Name = "lbl_dia7";
            this.lbl_dia7.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia7.TabIndex = 27;
            this.lbl_dia7.Text = "Sáb";
            this.lbl_dia7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_dia6
            // 
            this.lbl_dia6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia6.Location = new System.Drawing.Point(247, 65);
            this.lbl_dia6.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia6.Name = "lbl_dia6";
            this.lbl_dia6.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia6.TabIndex = 26;
            this.lbl_dia6.Text = "Sex";
            this.lbl_dia6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_dia5
            // 
            this.lbl_dia5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia5.Location = new System.Drawing.Point(199, 65);
            this.lbl_dia5.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia5.Name = "lbl_dia5";
            this.lbl_dia5.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia5.TabIndex = 25;
            this.lbl_dia5.Text = "Qui";
            this.lbl_dia5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_dia4
            // 
            this.lbl_dia4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia4.Location = new System.Drawing.Point(151, 65);
            this.lbl_dia4.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia4.Name = "lbl_dia4";
            this.lbl_dia4.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia4.TabIndex = 24;
            this.lbl_dia4.Text = "Qua";
            this.lbl_dia4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_dia3
            // 
            this.lbl_dia3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia3.Location = new System.Drawing.Point(103, 65);
            this.lbl_dia3.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia3.Name = "lbl_dia3";
            this.lbl_dia3.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia3.TabIndex = 23;
            this.lbl_dia3.Text = "Ter";
            this.lbl_dia3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_dia2
            // 
            this.lbl_dia2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia2.Location = new System.Drawing.Point(55, 65);
            this.lbl_dia2.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia2.Name = "lbl_dia2";
            this.lbl_dia2.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia2.TabIndex = 22;
            this.lbl_dia2.Text = "Seg";
            this.lbl_dia2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_dia1
            // 
            this.lbl_dia1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_dia1.Location = new System.Drawing.Point(7, 65);
            this.lbl_dia1.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lbl_dia1.Name = "lbl_dia1";
            this.lbl_dia1.Size = new System.Drawing.Size(45, 25);
            this.lbl_dia1.TabIndex = 21;
            this.lbl_dia1.Text = "Dom";
            this.lbl_dia1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dia1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lnk_posterior
            // 
            this.lnk_posterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnk_posterior.Image = ((System.Drawing.Image)(resources.GetObject("lnk_posterior.Image")));
            this.lnk_posterior.ImageSize = 24;
            this.lnk_posterior.Location = new System.Drawing.Point(319, 31);
            this.lnk_posterior.Name = "lnk_posterior";
            this.lnk_posterior.Size = new System.Drawing.Size(27, 27);
            this.lnk_posterior.TabIndex = 20;
            this.lnk_posterior.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnk_posterior.UseSelectable = true;
            this.lnk_posterior.Click += new System.EventHandler(this.lnk_posterior_Click);
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.Location = new System.Drawing.Point(5, 61);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(342, 1);
            this.separator.Style = MetroFramework.MetroColorStyle.Red;
            this.separator.TabIndex = 16;
            this.separator.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.separator.Value = 100;
            // 
            // lnk_anterior
            // 
            this.lnk_anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnk_anterior.Image = ((System.Drawing.Image)(resources.GetObject("lnk_anterior.Image")));
            this.lnk_anterior.ImageSize = 24;
            this.lnk_anterior.Location = new System.Drawing.Point(286, 31);
            this.lnk_anterior.Name = "lnk_anterior";
            this.lnk_anterior.Size = new System.Drawing.Size(27, 27);
            this.lnk_anterior.TabIndex = 19;
            this.lnk_anterior.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnk_anterior.UseSelectable = true;
            this.lnk_anterior.Click += new System.EventHandler(this.lnk_anterior_Click);
            // 
            // pnl_dias
            // 
            this.pnl_dias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_dias.HorizontalScrollbarBarColor = true;
            this.pnl_dias.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_dias.HorizontalScrollbarSize = 10;
            this.pnl_dias.Location = new System.Drawing.Point(6, 95);
            this.pnl_dias.Name = "pnl_dias";
            this.pnl_dias.Padding = new System.Windows.Forms.Padding(1);
            this.pnl_dias.Size = new System.Drawing.Size(342, 292);
            this.pnl_dias.TabIndex = 18;
            this.pnl_dias.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnl_dias.VerticalScrollbarBarColor = true;
            this.pnl_dias.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_dias.VerticalScrollbarSize = 10;
            // 
            // lbl_dataCompleta
            // 
            this.lbl_dataCompleta.Location = new System.Drawing.Point(5, 35);
            this.lbl_dataCompleta.Name = "lbl_dataCompleta";
            this.lbl_dataCompleta.Size = new System.Drawing.Size(240, 20);
            this.lbl_dataCompleta.TabIndex = 17;
            this.lbl_dataCompleta.Text = "quinta-feira, 9 de março de 2017";
            this.lbl_dataCompleta.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_mes
            // 
            this.lbl_mes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_mes.Location = new System.Drawing.Point(197, 5);
            this.lbl_mes.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(150, 25);
            this.lbl_mes.TabIndex = 15;
            this.lbl_mes.Text = "Janeiro";
            this.lbl_mes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_mes.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_hora
            // 
            this.lbl_hora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_hora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_hora.Location = new System.Drawing.Point(5, 5);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(150, 25);
            this.lbl_hora.TabIndex = 14;
            this.lbl_hora.Text = "00:00:00";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_hora.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lbl_dia7);
            this.Controls.Add(this.lbl_dia6);
            this.Controls.Add(this.lbl_dia5);
            this.Controls.Add(this.lbl_dia4);
            this.Controls.Add(this.lbl_dia3);
            this.Controls.Add(this.lbl_dia2);
            this.Controls.Add(this.lbl_dia1);
            this.Controls.Add(this.lnk_posterior);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lnk_anterior);
            this.Controls.Add(this.pnl_dias);
            this.Controls.Add(this.lbl_dataCompleta);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.lbl_hora);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(352, 392);
            this.MinimumSize = new System.Drawing.Size(352, 392);
            this.Name = "MetroCalendar";
            this.Size = new System.Drawing.Size(352, 392);
            this.Load += new System.EventHandler(this.MetroCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel lbl_dia7;
        private MetroFramework.Controls.MetroLabel lbl_dia6;
        private MetroFramework.Controls.MetroLabel lbl_dia5;
        private MetroFramework.Controls.MetroLabel lbl_dia4;
        private MetroFramework.Controls.MetroLabel lbl_dia3;
        private MetroFramework.Controls.MetroLabel lbl_dia2;
        private MetroFramework.Controls.MetroLabel lbl_dia1;
        private MetroFramework.Controls.MetroLink lnk_posterior;
        private MetroFramework.Controls.MetroProgressBar separator;
        private MetroFramework.Controls.MetroLink lnk_anterior;
        private MetroFramework.Controls.MetroPanel pnl_dias;
        private MetroFramework.Controls.MetroLabel lbl_dataCompleta;
        private MetroFramework.Controls.MetroLabel lbl_mes;
        private MetroFramework.Controls.MetroLabel lbl_hora;
    }
}
