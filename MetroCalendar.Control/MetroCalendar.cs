using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace MetroCalendar.Control
{
    public partial class MetroCalendar : UserControl
    {
        MetroTile tileDays;
        DateTime time;

        int x, y = 0, ndays;
        int dia_atual, mes_atual, ano_atual;

        string Dayofweek, CurrentCulture;

        public MetroCalendar()
        {
            InitializeComponent();
        }

        private void MetroCalendar_Load(object sender, EventArgs e)
        {
            dia_atual = DateTime.Now.Day;
            mes_atual = DateTime.Now.Month;
            ano_atual = DateTime.Now.Year;

            time = DateTime.Now;

            CurrentCulture = Application.CurrentCulture.Name;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br"); //Altera a cultura para evitar data incorreta.

            lbl_mes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(mes_atual);

            //Obtém o número de dias do mês e ano selecionado.
            int dayz = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            verificarDia(); //Verifica o dias...

            for (int i = 1; i <= dayz; i++)
            {
                ndays += 1;

                tileDays = new MetroTile();
                tileDays.Name = "Day" + i;
                tileDays.Text = i.ToString();

                if (i == DateTime.Now.Day)
                {
                    tileDays.Style = MetroColorStyle.Green;
                }
                else if (ndays == 01)
                {
                    tileDays.Style = MetroColorStyle.Yellow;
                }
                else
                {
                    tileDays.Style = MetroColorStyle.Red;
                }

                tileDays.SetBounds(x, y, 47, 47);

                x += 48;

                if (ndays == 7)
                {
                    x = 0;
                    ndays = 0;
                    y += 48;
                }

                pnl_dias.Controls.Add(tileDays);
            }

            //Return all values to default.
            x = 0;
            ndays = 0;
            y = 0;
        }

        private void lnk_anterior_Click(object sender, EventArgs e)
        {
            if (mes_atual == 1)
            {
                ano_atual -= 1;
                mes_atual = 12;
            }
            else
            {
                mes_atual -= 1;
            }

            pnl_dias.Controls.Clear();

            Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture);

            //Mostra o nome do mês selecionado.
            lbl_mes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(mes_atual);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");

            int dayz = DateTime.DaysInMonth(ano_atual, mes_atual);

            verificarDia();

            for (int i = 1; i <= dayz; i++)
            {
                ndays += 1;

                tileDays = new MetroTile();
                tileDays.Text = i.ToString();

                int mon = mes_atual;
                int yea = ano_atual;

                if ((i == dia_atual) && (mon == DateTime.Now.Month) && (yea == DateTime.Now.Year))
                {
                    tileDays.Style = MetroColorStyle.Green;
                }
                else if (ndays == 01)
                {
                    tileDays.Style = MetroColorStyle.Yellow;
                }
                else
                {
                    tileDays.Style = MetroColorStyle.Red;
                }

                tileDays.SetBounds(x, y, 47, 47);

                x += 48;

                if (ndays == 7)
                {
                    x = 0;
                    ndays = 0;
                    y += 48;
                }

                pnl_dias.Controls.Add(tileDays);
            }

            x = 0;
            ndays = 0;
            y = 0;
        }

        private void lnk_posterior_Click(object sender, EventArgs e)
        {
            if (mes_atual == 12)
            {
                ano_atual += 1;
                mes_atual = 1;
            }
            else
            {
                mes_atual += 1;
            }

            pnl_dias.Controls.Clear(); //Remove todos os controles adicionados do panel.

            Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture);

            //Exibe o nome completo do mês selecionado.
            lbl_mes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(mes_atual);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");

            int dayz = DateTime.DaysInMonth(ano_atual, mes_atual);

            verificarDia(); //Verifica os dias...

            for (int i = 1; i <= dayz; i++)
            {
                ndays += 1;

                tileDays = new MetroTile();
                tileDays.Text = i.ToString();

                int mon = mes_atual;
                int yea = ano_atual;

                if ((i == dia_atual) && (mon == DateTime.Now.Month) && (yea == DateTime.Now.Year))
                {
                    tileDays.Style = MetroColorStyle.Green;
                }
                else if (ndays == 01)
                {
                    tileDays.Style = MetroColorStyle.Yellow;
                }
                else
                {
                    tileDays.Style = MetroColorStyle.Red;
                }

                tileDays.SetBounds(x, y, 47, 47);

                x += 48;

                if (ndays == 7)
                {
                    x = 0;
                    ndays = 0;
                    y += 48;
                }

                pnl_dias.Controls.Add(tileDays);
            }

            x = 0;
            ndays = 0;
            y = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_dataCompleta.Text = DateTime.Now.ToLongDateString();
        }

        private int verificarDia()
        {
            time = Convert.ToDateTime(mes_atual + "/01/" + ano_atual);

            //Pega o dia de início da semana para data informada.
            Dayofweek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString();

            if (Dayofweek == "Sunday")
            {
                x = 0;
            }
            else if (Dayofweek == "Monday")
            {
                x = 0 + 48;
                ndays = 1;
            }
            else if (Dayofweek == "Tuesday")
            {
                x = 0 + 96;
                ndays = 2;
            }
            else if (Dayofweek == "Wednesday")
            {
                x = 0 + 96 + 48;
                ndays = 3;
            }
            else if (Dayofweek == "Thursday")
            {
                x = 0 + 96 + 96;
                ndays = 4;
            }
            else if (Dayofweek == "Friday")
            {
                x = 0 + 96 + 96 + 48;
                ndays = 5;
            }
            else if (Dayofweek == "Saturday")
            {
                x = 0 + 96 + 96 + 96;
                ndays = 6;
            }

            return x;
        }
    }
}
