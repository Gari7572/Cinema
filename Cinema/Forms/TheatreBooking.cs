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
    public partial class TheatreBooking : Form
    {
        public static string passingTitle;
        public static string passingDescription;

        public TheatreBooking()
        {
            InitializeComponent();
        }

        private void ButtonBook1_Click(object sender, EventArgs e)
        {
            passingTitle = "Кайдашева сім'я";
            passingDescription = "Іван Нечуй-Левицький\r\nСюжет “Кайдашевої сім'ї” охоплює події, що відбулися у великий сільській родині Кайдашів. " +
                "Ми зустрічаємося з героями: Кайдашем, його дружиною Марусею та двома їх синами Карпом і Лавріном у переламний момент існування сім'ї, " +
                "коли дорослішають діти, обирають собі пари і починається інше життя. У цій виставі сміх лунає крізь сльози й навпаки. Комічні і " +
                "драматичні ситуації, у які потрапляють персонажі, взяті з самого життя.";
            OrderingForm orderingForm = new OrderingForm("Кайдашева сім'я");
            orderingForm.Show();
            this.Hide();
        }

        private void ButtonBook2_Click(object sender, EventArgs e)
        {
            passingTitle = "Моя професія - синьйор з вищого світу";
            passingDescription = "Джуліо Скарначчі, Ренцо Тарабузі\r\nСьогодні італійська комедія знову повертається на сцену нашого театру." +
                "В легкій і невибагливій комедії положень звучить тема родинних відносин, збереження дому та порятунку сім'ї як головної опори в житті кожної людини." +
                "\r\n\r\nГлаві великої італійської родини Леоніда Папагатто, можна вибачити все: і дрібні крадіжки продуктів на званих обідах і вечерях, і створення " +
                "міфічного благодійного фонду підтримки бідних родин, тому що весь цей калейдоскоп подій затіяний ним заради однієї мети –добробуту своїх близьких. " +
                "Щаслива розв'язка – заслужена нагорода артистичному і чарівному шахраєві.";
            OrderingForm orderingForm = new OrderingForm("Моя професія - синьйор з вищого світу");
            orderingForm.Show();
            this.Hide();
        }

        private void ButtonBook3_Click(object sender, EventArgs e)
        {
            passingTitle = "Три товариші";
            passingDescription = "За мотивами однойменного роману Е. М. Ремарка\r\nОсновною темою його романів є історія «втраченого покоління», соціально-політичні проблеми, " +
                "якими жила Європа між двома Світовими війнами, а прообразами героїв ставали друзі та рідні з близького оточення. \r\nСюжет роману «Три товариші» (1936), який " +
                "продовжує тему «втраченого покоління», розгортається в Німеччині у 1928 році. Троє друзів, які пройшли Першу світову війну - Роберт Локамп, Отто Кестер і Ґотфрід Ленц - тримають невеличку," +
                " малоприбуткову автомайстерню. Перипетії їхнього життя, кохання Роберта до молодої Патриції Хольман, спогади, від яких не можуть отямитися головні герої, власне, всі події роману пов'язані та" +
                " розгортаються на фоні економічної, політичної кризи в міжвоєнній Німеччині.";
            OrderingForm orderingForm = new OrderingForm("Три товариші");
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
