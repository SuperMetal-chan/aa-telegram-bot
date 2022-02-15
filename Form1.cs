using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Args;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using DotNetEnv;


namespace TelegramBotForms
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw;

        public Form1()
        {
            InitializeComponent();

            this.bw = new BackgroundWorker();
            this.bw.DoWork += this.bwDoWork;
        }

        async void bwDoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var key = e.Argument as String;

            try
            {
                var bot = new Telegram.Bot.TelegramBotClient(key);
                await bot.SetWebhookAsync("");

                int offset = 0;

                while (true)
                {
                    var updates = await bot.GetUpdatesAsync(offset);

                    foreach (var update in updates)
                    {
                        var message = update.Message;
                        try
                        {
                            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                            {
                                String[] arr = {"Привет", "Hi", "Hello", "Привіт"};
                                String[] arrBad = {"Пошёл нахер", "Fuck you"};
                                String[] arrJojo =
                                {
                                    "https://moe.shikimori.org/system/screenshots/original/" +
                                    "ffc7ee259012362533e8dd045609b1ea4ecb1ecf.jpg",
                                    "https://dere.shikimori.org/system/screenshots/original/" +
                                    "bc56d7ad4c587532f3791a62ec250fcf00a6c515.jpg",
                                    "https://nyaa.shikimori.org/system/screenshots/original/" +
                                    "e33d8eab8c79e02f0cf577aa6a5424bbf521c594.jpg",
                                    "https://dere.shikimori.org/system/screenshots/original/" +
                                    "8f0e7dd26a001928edf07519926d1cd0b01d5ca4.jpg",
                                    "https://kawai.shikimori.org/system/screenshots/original/" +
                                    "b156d5e23a2aa41fa7b0fd0a83654237117068c6.jpg",
                                    "https://nyaa.shikimori.org/system/screenshots/original/" +
                                    "f2720e88218a33d11ac1320804073c44fa09a465.jpg",
                                    "https://moe.shikimori.org/system/screenshots/original/" +
                                    "42424d318bbcd4c6a0eaf80c103ab2921730d874.jpg"
                                };
                                String[] arrDio =
                                {
                                    "https://kawai.shikimori.org/system/screenshots/original/" +
                                    "04ce4d6fb0c3cfec010884e4631d9ed18a992275.jpg",
                                    "https://desu.shikimori.org/system/screenshots/original/" +
                                    "6a6024a2669e8abc7e176da9f38b656262706e0e.jpg",
                                    "https://moe.shikimori.org/system/screenshots/original/" +
                                    "d94a5a68cc01e804db48f46059b47082505a6ed3.jpg"
                                };
                                String[] arrSticker =
                                {
                                    "CAADAgADQgADZ8D7GMf5qASBFOPMAg", "CAADAgADQwADZ8D7GNC6GkAJ79w4Ag",
                                    "CAADAgADOwADZ8D7GIG_EG1agCuXAg", "CAADAgADRAADZ8D7GJ9RcJSzwSbRAg",
                                    "CAADAgADRQADZ8D7GI8Gv-vqny__Ag",
                                    "CAADAgADRgADZ8D7GBvc7ySXtJnxAg", "CAADAgADRwADZ8D7GHPS_64W7gOuAg",
                                    "CAADAgADSAADZ8D7GOR4SE4BIfaBAg",
                                    "CAADAgADSQADZ8D7GOOY3mDOShYrAg", "CAADAgADSgADZ8D7GJ4w8G0WRo1gAg",
                                    "CAADAgADSwADZ8D7GGD0j_6g2zfaAg",
                                    "CAADAgADTAADZ8D7GI0H8YIyFbrWAg", "CAADAgADTQADZ8D7GEka7OW5UqvWAg"
                                };
                                Random rand = new Random();
                                if (message.Text == "Hello" || message.Text == "Hi"
                                                            || message.Text == "Привет" || message.Text == "Привіт")
                                {
                                    int temp69 = rand.Next(69);
                                    if (temp69 == 2)
                                    {
                                        int temp2 = rand.Next(arrBad.Length);
                                        await bot.SendTextMessageAsync(message.Chat.Id, arrBad[temp2],
                                            replyToMessageId: message.MessageId);
                                    }
                                    else
                                    {
                                        int temp4 = rand.Next(arr.Length);
                                        await bot.SendTextMessageAsync(message.Chat.Id, arr[temp4],
                                            replyToMessageId: message.MessageId);
                                    }
                                }
                                else if (message.Text == "/send_jojo_photo"
                                         || message.Text == "/send_jojo_photo@ActuallyAdequateBot")
                                {
                                    try
                                    {
                                        int temp13 = rand.Next(13);
                                        if (temp13 == 2)
                                        {
                                            int temp3 = rand.Next(arrDio.Length);
                                            await bot.SendPhotoAsync(message.Chat.Id, arrDio[temp3],
                                                replyToMessageId: message.MessageId);
                                        }
                                        else
                                        {
                                            int temp7 = rand.Next(arrJojo.Length);
                                            await bot.SendPhotoAsync(message.Chat.Id, arrJojo[temp7]);
                                        }
                                    }
                                    catch (Exception exc)
                                    {
                                        Console.WriteLine(exc);
                                    }
                                }
                                else if (message.Text == "/send_rzhomba_sticker" ||
                                         message.Text == "/send_rzhomba_sticker@ActuallyAdequateBot")
                                {
                                    int temp40 = rand.Next(40);
                                    if (temp40 == 2)
                                    {
                                        await bot.SendStickerAsync(message.Chat.Id, "CAADAgADiAAD2kJgEdKj_iknDAHkAg",
                                            replyToMessageId: message.MessageId);
                                    }
                                    else
                                    {
                                        int tempM = rand.Next(arrSticker.Length);
                                        await bot.SendStickerAsync(message.Chat.Id, arrSticker[tempM]);
                                    }
                                }
                                else if (message.Text.Contains("/roll") ||
                                         message.Text.Contains("/roll@ActuallyAdequateBot"))
                                {
                                    try
                                    {
                                        char[] arrCh = message.Text.ToCharArray();
                                        String num1 = "", num2 = "", all = "", critical = "", numPlus = "";
                                        int sum = 0, sumNum = 0;
                                        bool sw = false, zp = false, testD = false, test2 = false, testPlus = false;
                                        for (int i = 6; i < arrCh.Length; i++)
                                        {
                                            if (arrCh[i] == '+' && test2)
                                            {
                                                sumNum++;
                                                testPlus = true;
                                            }
                                            else if (Char.IsDigit(arrCh[i]) && testD)
                                            {
                                                sumNum++;
                                                test2 = true;
                                            }
                                            else if (Char.IsDigit(arrCh[i]))
                                                sumNum++;
                                            else if (arrCh[i] == 'd' && !testD)
                                            {
                                                sumNum++;
                                                testD = true;
                                            }
                                        }

                                        if ((sumNum == arrCh.Length - 6) && (test2 == true))
                                        {
                                            testPlus = false;
                                            for (int i = 6; i < arrCh.Length; i++)
                                            {
                                                if (arrCh[i] == '+')
                                                {
                                                    testPlus = true;
                                                    continue;
                                                }

                                                if (testPlus)
                                                {
                                                    numPlus += arrCh[i];
                                                    continue;
                                                }

                                                if (sw)
                                                    num2 += arrCh[i];
                                                if (arrCh[i] == 'd')
                                                    sw = true;
                                                if (!sw)
                                                    num1 += arrCh[i];
                                            }

                                            if (num1 == "")
                                                num1 = "1";
                                            if (numPlus == "")
                                                numPlus = "0";

                                            if (Convert.ToInt32(num1) > 500 || Convert.ToInt32(num2) > 500 ||
                                                Convert.ToInt32(numPlus) > 1000000000)
                                            {
                                                await bot.SendTextMessageAsync(message.Chat.Id,
                                                    "Invalid output: maximum numbers are 500 for dice and 1 billion for bonus number",
                                                    replyToMessageId: message.MessageId);
                                            }
                                            else
                                            {
                                                for (int i = 0; i < Convert.ToInt32(num1); i++)
                                                {
                                                    int temp = rand.Next(Convert.ToInt32(num2)) + 1;
                                                    if (!zp)
                                                    {
                                                        all += "(" + temp.ToString() + ")";
                                                        zp = true;
                                                    }
                                                    else
                                                        all += ", (" + temp.ToString() + ")";

                                                    sum += temp;
                                                }

                                                if (testPlus)
                                                    all += ", [" + numPlus + "]";
                                                sum += Convert.ToInt32(numPlus);
                                                if (Convert.ToInt32(num2) > 5)
                                                {
                                                    if (sum == ((Convert.ToInt32(num1) * Convert.ToInt32(num2)) +
                                                                Convert.ToInt32(numPlus)))
                                                        critical += " - Critical Hit!";
                                                    else if (sum == 1 + Convert.ToInt32(numPlus))
                                                        critical += " - Critical Miss!";
                                                }

                                                await bot.SendTextMessageAsync(message.Chat.Id,
                                                    all + "\n🎲 Your result is " + sum.ToString() + " 🎲" + critical,
                                                    replyToMessageId: message.MessageId);
                                            }
                                        }
                                        else
                                        {
                                            await bot.SendTextMessageAsync(message.Chat.Id,
                                                "Invalid input: correct input is ({number})d{number}(+{number})",
                                                replyToMessageId: message.MessageId);
                                        }
                                    }
                                    catch (Exception exc)
                                    {
                                        Console.WriteLine(exc);
                                    }
                                }
                            }
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc);
                        }

                        offset = update.Id + 1;
                    }
                }
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (button1.Text == "Enable")
            //    button1.Text = "Disable";
            //else
            //    button1.Text = "Enable";

            var text = textBox1.Text;

            if (!this.bw.IsBusy && text != null)
                this.bw.RunWorkerAsync(text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}