using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Гороскопп
{
    /// <summary>
    /// Логика взаимодействия для Signn.xaml
    /// </summary>
    public partial class Signn : Window
    {
        public Signn()
        {
            InitializeComponent();
        }
        public string StarSign { get; set; }
        public string Text()
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 11))// Тут я представляю что я астролог и делаю невероятно точный прогноз для выбранного знака зодиака
            {
                case 0:
                    StarSign = "Сегодня, если ты будешь доброжелателен и приветлив, на протяжении дня тебя будут ждать только улыбающиеся люди и… один очень настойчивый продавец пылесосов. Будь готов к неожиданным демонстрациям!";
                    break;
                case 1:
                    StarSign = "Если ты сегодня решишь поесть что-то необычное, то твой обед станет настоящим кулинарным шедевром. Однако будь осторожен: твой кот может попытаться присвоить себе лавры шеф-повара.";
                    break;
                case 2:
                    StarSign = "Сегодня, если ты будешь много говорить, то твои слова могут случайно превратиться в песню. Готовься, возможно, тебе предстоит записать хит и стать звездой TikTok, но сначала не забудь найти рифму к слову «пирог».";
                    break;
                case 3:
                    StarSign = "Если сегодня ты решишь остаться дома и устроить себе уютный вечер, то твои растения могут начать вести с тобой философские беседы. Не бойся, они просто хотят обсудить последние новости из мира горшков.";
                    break;
                case 4:
                    StarSign = "Сегодня, если ты будешь вести себя как король (или королева), то окружающие будут следовать за тобой… в магазин за мороженым. Не забудь взять с собой свою золотую ложку для истинного королевского наслаждения!";
                    break;
                case 5:
                    StarSign = "Если ты сегодня решишь все организовать, то твоя жизнь станет идеальной и упорядоченной… до тех пор, пока кто-то не решит перемешать твои носки. Будь готов к экстренному разбору полетов!";
                    break;
                case 6:
                    StarSign = "Если сегодня ты найдешь время для выбора между двумя одинаковыми пирожками, то это может занять весь день. Но не переживай: в конце концов ты всё равно выберешь третий, который неожиданно появится!";
                    break;
                case 7:
                    StarSign = "Если сегодня ты решишь отправиться в приключение, то, возможно, окажешься в поисках идеального места для селфи. Но помни: лучшее место может оказаться прямо у твоего холодильника!";
                    break;
                case 8:
                    StarSign = "Если ты сегодня будешь работать усердно, то в конце дня тебя ждет награда — пакет чипсов. Не забудь проверить, не притаился ли в нем приз в виде игрушки из 90-х!";
                    break;
                case 9:
                    StarSign = "Если сегодня ты проявишь свою креативность, то сможешь создать что-то совершенно уникальное… например, новый способ завязывать шнурки. Будь готов к тому, что твои друзья могут захотеть записать об этом видео!";
                    break;
                case 10:
                    StarSign = "Сегодня, если ты решишь быть загадочным, то окружающие будут пытаться разгадать твою тайну. Но будь осторожен: твоя тайна может оказаться просто тем, что ты забыл выключить утюг.";
                    break;
                case 11:
                    StarSign = "Если сегодня ты погрузишься в свои мечты, то можешь неожиданно обнаружить, что твой диван — это корабль в открытом море. Не забудь запастись попкорном на случай встречи с воображаемыми морскими чудовищами!";
                    break;

            }
            return StarSign;
        }
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Овен: Этот знак — вечный гонщик в супермаркете. Всегда первым на распродаже, но забывает, что ему нужно не только взять, но и заплатить.");
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Телец: Настоящий гурман, который может устроить пикник из чипсов и колы на диване. У него есть неофициальный титул «Король Лени», но он предпочитает, чтобы его звали «Мастером Удовольствий».");
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Близнецы: Два человека в одном теле, которые постоянно спорят о том, что смотреть по телевизору. Один из них всегда хочет комедию, а другой — документалку о жизни улиток.");
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рак: Этот знак — эмоциональный моллюск. Он всегда носит с собой запасной плед и может расплакаться даже из-за того, что у него закончился шоколад.");
        }
        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лев: Главный актер в собственном мюзикле, который ставит каждую сцену в своем воображении. У него есть золотая корона из фольги, которую он носит с гордостью.");
        }

        private void ListViewItem_Selected_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дева: Педант с суперспособностями к организации. Может за 5 минут составить план по уборке всего мира, но при этом потеряет свои ключи.");
        }

        private void ListViewItem_Selected_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Весы: Постоянно взвешивают все решения на весах справедливости, но в итоге выбирают пиццу вместо салата. Их девиз: «Почему бы не оба?»");
        }

        private void ListViewItem_Selected_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Скорпион: Мастер шпионских игр, который всегда знает, где кто оставил свои носки. Его хобби — разгадывать загадки и строить теории заговора о том, почему его кактус не цветет.");
        }

        private void ListViewItem_Selected_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Стрелец: Путешественник без паспорта, который всегда мечтает о приключениях, но чаще всего оказывается на диване с книжкой о путешествиях.");
        }

        private void ListViewItem_Selected_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Козерог: Работяга с амбициями, который строит карьеру с помощью блокнота и чашки кофе. Его мечта — стать CEO своей собственной компании по производству пончиков.");
        }

        private void ListViewItem_Selected_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Водолей: Экспериментатор и изобретатель, который однажды решил создать машину времени из тостера и микроволновки. В итоге просто поджарил хлеб.");
        }

        private void ListViewItem_Selected_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рыбы: Художник, который рисует мир в своих мечтах и иногда забывает, что нужно выходить на улицу. Их любимое занятие — сочинять песни о том, как сложно найти свои носки.");
        }

        private void Aries_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Овен - "+StarSign);
        }
        private void Taurus_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Телец - " + StarSign);
        }
        private void Gemini_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Близнецы - " + StarSign);
        }
        private void Cancer_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Рак - " + StarSign);
        }
        private void Leo_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Лев - " + StarSign);

        }
        private void Virgo_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Дева - " + StarSign);
        }
        private void Libra_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Весы - " + StarSign);
        }
        private void Scorpio_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Скорпион - " + StarSign);
        }
        private void Sagittarius_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Стрелец - " + StarSign);
        }
        private void Capricorn_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Козерог - " + StarSign);
        }
        private void Aquarius_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Водолей - " + StarSign);
        }
        private void Fish_Click(object sender, RoutedEventArgs e)
        {
            Text();
            MessageBox.Show("Рыбы - " + StarSign);
        }
        private void btnOtvet_Click(object sender, RoutedEventArgs e)
        {
            SignDate window = new SignDate();
            window.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

