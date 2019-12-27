using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BalanceDP;
using System.Reflection;

namespace BalanceDP
{
    public partial class frmDiagramma : Form
    {
        // Создать главный объект, который включает в себя все нужные объекты
        public BalanceDPDll.MathLib _bdp = new BalanceDPDll.MathLib();

        public frmDiagramma() { }

        public frmDiagramma(BalanceDPDll.MathLib bdp)
        {
            InitializeComponent();
            CenterToScreen();
            _bdp = bdp;
        }

        private void DrawGraph()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            //Количество параметров
            int itemscount = 10;

            // Подписи параметров
            string[] names = new string[itemscount];

            // Размер 
            double[] values = new double[itemscount];

            // Заполним данные
            for (int i = 0; i < itemscount; i++)
            {
                names[0] = string.Format("кДж/кг чугуна");
                names[1] = string.Format("кДж/кг чугуна");
                names[2] = string.Format("кДж/кг чугуна");
                names[3] = string.Format("кДж/кг чугуна");
                names[4] = string.Format("кДж/кг чугуна");


                values[0] = _bdp.get_RashodTeplanaPryamoeVosstFeO();
                values[1] = _bdp.get_RashodTeplanaPryamoeVosstChugun();
                values[2] = _bdp.get_RashodTeplanaDesfularaz();
                values[3] = _bdp.get_RashodTeplanaVosstVodorodom();
                values[4] = _bdp.get_RashodTeplananAGREVjIDCHUGUN();

                
            }
             //Круговая диаграмма с выбором цвета
            pane.AddPieSlice(values[0], Color.Tan, 0F, names[0]);
            pane.AddPieSlice(values[1], Color.PeachPuff, 0F, names[1]);
            pane.AddPieSlice(values[2], Color.Peru, 0F, names[2]);
            pane.AddPieSlice(values[3], Color.Aqua, 0F, names[3]);
            pane.AddPieSlice(values[4], Color.Brown, 0F, names[4]);

            


            pane.AddPieSlices(values, names); // цвет устанавливается автоматически
            pane.Legend.IsVisible = false;
            foreach (var x in pane.CurveList.OfType<PieItem>())
                x.LabelType = PieLabelType.Name_Percent;

            // Изменим текст заголовка графика
            pane.Title.Text = "Результат расчета теплового баланса доменной печи,расходные статьи";

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void btnDiagramma_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void btnExitDiagramma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiagramma_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
