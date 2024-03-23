using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class ConcertBooking : Form
    {
        public static string passingTitle;
        public static string passingDescription;
        public ConcertBooking()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            TypeOfArt typeOfArt = new TypeOfArt();
            typeOfArt.Show();
            this.Hide();
        }

        private void ButtonBook1_Click(object sender, EventArgs e)
        {
            passingTitle = "DOROFEEVA";
            passingDescription = "2 грудня на сцені Stereo Plaza – ніжна і чуттєва DOROFEEVA! Вперше – жодних гучних шоу, натомість – атмосферна зустріч і відчуття родинного затишку." +
                "\r\nЗ першого дня війни соціально активна співачка робить багато для підтримки українців, що постраждали від військових дій – втратили житло, вимушені були виїхати за кордон. " +
                "DOROFEEVA бере участь у багатьох благодійних проєктах і цього разу кошти від концерту перерахує волонтерському рухові «Добробат», котрий займається відбудовою зруйнованих домівок.";
            OrderingForm orderingForm = new OrderingForm("DOROFEEVA");
            orderingForm.Show();
            this.Hide();
        }

        private void ButtonBook2_Click(object sender, EventArgs e)
        {
            passingTitle = "Артем Пивоваров";
            passingDescription = "17 грудня у Stereo Plaza відбудеться великий сольний концерт стильного, талановитого й популярного Артема Пивоварова! " +
                "Самобутній артист вражає творчою активністю і безмежною музичною фантазією. Його роботи – одночасно виклик і тренд. Виступи Артема – завжди " +
                "особлива подія для публіки. І цього разу також буде незабутньо!";
            OrderingForm orderingForm = new OrderingForm("Артем Пивоваров");
            orderingForm.Show();
            this.Hide();
        }

        private void ButtonBook3_Click(object sender, EventArgs e)
        {
            passingTitle = "Степан Гіга";
            passingDescription = "6 грудня на сцені Київського МЦКМ з концертом на підтримку ЗСУ виступить Народний артист України, талановитий музикант і композитор, " +
                "улюбленець українських жінок Степан Гіга.\r\n\r\nАртист з бендом презентує своїм шанувальникам нову музичну програму \"Золоті шлягери України\"!Тільки найкращі хіти!" +
                "\r\n\r\nСтепан Гіга обіцяє яскравий музичний вечір під акорди улюблених пісень.";
            OrderingForm orderingForm = new OrderingForm("Степан Гіга");
            orderingForm.Show();
            this.Hide();
        }
    }
}
