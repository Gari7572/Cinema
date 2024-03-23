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
    public partial class CinemaBooking : Form
    {
        public static string passingTitle;
        public static string passingDescription;
        public CinemaBooking()
        {
            InitializeComponent();
        }

        private void ButtonBook1_Click(object sender, EventArgs e)
        {
            passingTitle = "Джокер";
            passingDescription = "Ґотем, 80-ті роки минулого століття. Перед нами Артур Флек – комік, який живе сам зі своєю хворою матір'ю. Він за нею доглядає, а та його вчить, що цього світу потрібно дарувати посмішки та позитив, і тоді всі люди так же будуть ставитися до тебе. " +
                "Довгі роки Артур так і намагався, але кожен раз тільки стикався з людською жорстокістю. Суспільство не прийняло чоловіка, тому він вирішив, що може змінювати це суспільство так, як йому захочеться. " +
                "Яскраві костюми, грим і посмішка, яку неможливо забути – такий тепер постійний образ Артура, який почав себе іменувати Джокером. Це саме той веселун, якого його світ заслужив.";
            OrderingForm orderingForm = new OrderingForm("Джокер");
            orderingForm.Show();
            this.Hide();
        }

        private void ButtonBook2_Click(object sender, EventArgs e)
        {
            passingTitle = "Їжак Сонік 2";
            passingDescription = "Після того, як Сонік вирішив стати жителем Грін Хілз, йому доводиться доводити городянам, що у нього є все, чим володіють справжні супергерої. Незабаром нове супергеройське завдання постукало у двері. " +
                "Справа в тому, що від підступного доктора Роботніка посипалися численні підступи. Цього разу він завів собі помічника Наклза. Злочинний тандем розпочав пошук дорогоцінного каменю. Сила смарагду переходить до власника скарбу " +
                "та здатна зруйнувати цілі світи. Герою фільму «Їжак Сонік 2» доводиться шукати союзника для боротьби зі злом. Сонік зупиняє вибір на лисенятку Тейлзі, після чого вони вирушають у подорож навколо світу. Метою героїв стає пошук смарагду. " +
                "Вони хочуть заволодіти ним до того, як це зроблять погані хлопці. Попереду на них чекають захоплюючі пригоди та цікаві випробування. Чи зможуть друзі запобігти перемозі зла та руйнації світу?";
            OrderingForm orderingForm = new OrderingForm("Їжак Сонік 2");
            orderingForm.Show();
            this.Hide();
        }

        private void ButtonBook3_Click(object sender, EventArgs e)
        {
            passingTitle = "Швидкісний поїзд";
            passingDescription = "Події розгортаються у швидкісному поїзді, що мчить між японськими містами. Серед пасажирів є п’ятеро професійних найманих вбивць. Кожен із них має унікальне завдання. Крок за кроком, вони з’ясовують, що усі ці завдання пов’язані між собою.\r\n\r\nУ основі сюжету – роман японського письменника Котаро Ісаки, який вийшов друком у 2010 році. На сьогоднішній день він написав 24 романи, усі вони – детективи та фантастика. Даний фільм є 14-м, який знято за творами Ісаки. Для роботи над проектом підібрали зірковий акторський склад.";
            OrderingForm orderingForm = new OrderingForm("Швидкісний поїзд");
            orderingForm.Show();
            this.Hide();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            TypeOfArt typeOfArt = new TypeOfArt();
            typeOfArt.Show();
            this.Hide();
        }
    }
}
