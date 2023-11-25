using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horoskoop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoroskopPage : ContentPage
    {
        Label resultLabel;
        Image zodiacImage;
        Label zodiacDescriptionLabel;

        public HoroskopPage()
        {
            //initialize elements inside constructor
            var datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now
            };

            var nameLabel = new Label
            {
                Text = "Enter your name:"
            };

            var nameEntry = new Entry
            {
                Placeholder = "Your Name"
            };
            //make new instance of the button
            //lambda expression defining an anonymous method, capture Date with the help of datepicker and text with the help of the entry
            var submitButton = new Button
            {
                Text = "Submit",
                Command = new Command(() => ShowHoroscope(datePicker.Date, nameEntry.Text))

            };

            resultLabel = new Label();
            zodiacImage = new Image();
            zodiacDescriptionLabel = new Label();

            //Main content
            Content = new StackLayout
            {
                //sets a margin of 20 units
                Margin = new Thickness(20),

                // Children is a collection property that holds the child elements
                Children =
            {
                //organize UI elements
                new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        new Label { Text = "Select your birthdate:" },
                        datePicker
                    }
                },
                nameLabel,
                nameEntry,
                submitButton,
                resultLabel,
                zodiacImage,
                zodiacDescriptionLabel
            }
            };
        }

        private void ShowHoroscope(DateTime birthdate, string name)
        {
            // Get the zodiac sign based on the provided birthdate
            string zodiacSign = GetZodiacSign(birthdate);

            // Display the result in the resultLabel
            resultLabel.Text = $"{name}, your zodiac sign is {zodiacSign}.";

            // Display zodiac-related information using the DisplayZodiacInfo method
            DisplayZodiacInfo(zodiacSign);

            // Set the font size of the zodiacDescriptionLabel to medium
            zodiacDescriptionLabel.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
        }


        private string GetZodiacSign(DateTime birthdate)
        {
            if ((birthdate.Month == 3 && birthdate.Day >= 21) || (birthdate.Month == 4 && birthdate.Day <= 19))
            {
                return "Aries";
            }
            else if ((birthdate.Month == 4 && birthdate.Day >= 20) || (birthdate.Month == 5 && birthdate.Day <= 20))
            {
                return "Taurus";
            }
            else if ((birthdate.Month == 5 && birthdate.Day >= 21) || (birthdate.Month == 6 && birthdate.Day <= 20))
            {
                return "Gemini";
            }
            else if ((birthdate.Month == 6 && birthdate.Day >= 21) || (birthdate.Month == 7 && birthdate.Day <= 22))
            {
                return "Cancer";
            }
            else if ((birthdate.Month == 7 && birthdate.Day >= 23) || (birthdate.Month == 8 && birthdate.Day <= 22))
            {
                return "Leo";
            }
            else if ((birthdate.Month == 8 && birthdate.Day >= 23) || (birthdate.Month == 9 && birthdate.Day <= 22))
            {
                return "Virgo";
            }
            else if ((birthdate.Month == 9 && birthdate.Day >= 23) || (birthdate.Month == 10 && birthdate.Day <= 22))
            {
                return "Libra";
            }
            else if ((birthdate.Month == 10 && birthdate.Day >= 23) || (birthdate.Month == 11 && birthdate.Day <= 21))
            {
                return "Scorpio";
            }
            else if ((birthdate.Month == 11 && birthdate.Day >= 22) || (birthdate.Month == 12 && birthdate.Day <= 21))
            {
                return "Sagittarius";
            }
            else if ((birthdate.Month == 12 && birthdate.Day >= 22) || (birthdate.Month == 1 && birthdate.Day <= 19))
            {
                return "Capricorn";
            }
            else if ((birthdate.Month == 1 && birthdate.Day >= 20) || (birthdate.Month == 2 && birthdate.Day <= 18))
            {
                return "Aquarius";
            }
            else if ((birthdate.Month == 2 && birthdate.Day >= 19) || (birthdate.Month == 3 && birthdate.Day <= 20))
            {
                return "Pisces";
            }

            return "Unknown";
        }
        private void DisplayZodiacInfo(string zodiacSign)
        {

            switch (zodiacSign.ToLower())
            {
                case "aries":
                    zodiacImage.Source = "Aries.jfif";
                    zodiacDescriptionLabel.Text = "Овен — первый знак зодиака и типичный представитель стихии огня под " +
                        "покровительством Марса, а потому представители этого знака — люди амбициозные, активные, " +
                        "импульсивные, честолюбивые и отличающиеся незаурядной энергией";
                    break;
                case "taurus":
                    zodiacImage.Source = "Taurus,jfif";
                    zodiacDescriptionLabel.Text = "Телец (лат. Taurus) — типичный представитель стихии Земля — теплый, страстный, " +
                        "женский знак, более других ощущающий вибрации Венеры. Все земные удовольствия имеют для Тельца" +
                        " первостепенное значение — неисправимые гедонисты, они являются ценителями хорошего вина, лучших " +
                        "сигар, вкусной еды";
                    break;
                case "gemini":
                    zodiacImage.Source = "Germini.jfif";
                    zodiacDescriptionLabel.Text = "Близнецы — третий из знаков зодиакального круга. Их главные отличительные" +
                        " черты — непредсказуемый и противоречивый характер, оптимизм и безграничная коммуникабельность. Близнецы " +
                        "способны добиться успеха там, где их ждут приключения, новые впечатления и общение с людьми.";
                    break;
                case "cancer":
                    zodiacImage.Source = "Cancer.jfif";
                    zodiacDescriptionLabel.Text = "Рак — самый чувствительный знак зодиака, обладающий сильной интуицией." +
                        " Представители этого зодиакального созвездия болезненно воспринимают критику, не стремятся к публичности и" +
                        " являются эмоционально уязвимыми людьми.";
                    break;
                case "leo":
                    zodiacImage.Source = "leo.jpg";
                    zodiacDescriptionLabel.Text = "Лев (лат. Leo) — пятый знак, стихия которого — огонь, планета — Солнце. Представители " +
                        "этого знака зодиака — самые колоритные и яркие люди, которыми правят амбиции, гордость и зачастую граничащее с " +
                        "патологическим состоянием самолюбие. Именно Львы чаще других знаков стремятся к власти, признанию, богатству и роскоши.";
                    break;
                case "virgo":
                    zodiacImage.Source = "Virgo.jfif";
                    zodiacDescriptionLabel.Text = "Девы очень дисциплинированны, организованны и трудолюбивы. Они не прощают ошибок и " +
                        "оплошностей не только себе, но и другим людям. Девы, как правило, не любят публичность, они редко " +
                        "становятся центром всеобщего внимания. Их сложно встретить на шумной вечеринке.";
                    break;
                case "libro":
                    zodiacImage.Source = "Libra.jfif";
                    zodiacDescriptionLabel.Text = "Весы - самый воспитанный из всех знаков Зодиака. Это чуткий человек, который ценит " +
                        "хорошие манеры, никого не задевающее остроумие, любит принимать и развлекать гостей. Весы обладают тонким " +
                        "чувством такта, взвешенными эмоциями, интуитивным пониманием искусства и всего прекрасного..";
                    break;
                case "scorpio":
                    zodiacImage.Source = "Scorpio.jfif";
                    zodiacDescriptionLabel.Text = "Скорпион (лат. Scorpius) — восьмой знак зодиака, соответствующий сектору эклиптики от " +
                        "210° до 240°, считая от точки весеннего равноденствия; постоянный знак тригона Вода. В западной астрологии считается," +
                        " что Солнце находится в знаке Скорпиона приблизительно с 23 октября по 21 ноября.";
                    break;

                case "sagittarius":
                    zodiacImage.Source = "Sagittarius.jfif";
                    zodiacDescriptionLabel.Text = "Главными качествами представителей этого созвездия являются любознательность, " +
                        "активность и стремление к новым впечатлениям. Стрельцы никогда не сидят на месте, они деятельны и предприимчивы," +
                        " любят приключения и путешествия, легки на подъем и склонны к риску.";
                    break;
                case "capricorn":
                    zodiacImage.Source = "capricon.png";
                    zodiacDescriptionLabel.Text = "Будучи знаком Земли, Козерог – практичный и житейский человек, живущий не в мире" +
                        " призрачных иллюзий, но называющий вещи своими именами и требующий того же от других. Это очень целеустремленный" +
                        " человек, жесткий аналитик, безукоризненно умеющий подчинить эмоции голосу разума.";
                    break;
                case "aquarius":
                    zodiacImage.Source = "Aquarius.jfif";
                    zodiacDescriptionLabel.Text = "Люди, рожденные под знаком Водолея, отличаются особенной чувствительностью и ранимостью." +
                        " Они могут быть окружены знакомыми, но редко имеют близких друзей, которым могут довериться. Интересно, что Водолеи" +
                        " как магнитом притягивают к себе неуравновешенных людей, склонных к опрометчивым поступкам.";
                    break;
                case "pisces":
                    zodiacImage.Source = "Pisces.jfif";
                    zodiacDescriptionLabel.Text = "Рыбы — мечтатели, живущие в мире собственных иллюзий. Они тонко чувствуют музыку, " +
                        "способны к самопожертвованию и часто действуют интуитивно. Не чувствуя любви и поддержки, Рыбы впадают в уныние, " +
                        "уходят в себя и способны оказаться в состоянии тяжелейшей затяжной депрессии.";
                    break;

                   


                default:
                    zodiacImage.Source = null;
                    zodiacDescriptionLabel.Text = "No information available for this zodiac sign.";
                    
                    break;
            }
        }
    }


}


    

