using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Runtime.InteropServices;

namespace Airis {
    public partial class AiMainWindow : Form {

        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        Methods methods = new Methods();

        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int NextTrack = 0xB0;
        public const int PauseTrack = 0xB3;
        public const int PreviousTrack = 0xB1;

     

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);



        public AiMainWindow() {
            InitializeComponent();

            speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            InitializeComponent();


            Choices choices = new Choices();
            Dictionary<string, string> list = methods.programmList();

            string[] text = File.ReadAllLines(Environment.CurrentDirectory + "/resources/grammar.txt");
            List<string> liste = new List<string>();


            foreach (string line in list.Keys) {
                liste.Add("Öffne " + line);
            }
            string[] programmList = liste.ToArray();


            choices.Add(programmList);
            choices.Add(text);
            Grammar grammer = new Grammar(new GrammarBuilder(choices));
            recEngine.LoadGrammar(grammer);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeechRecognized);

            speech.SelectVoiceByHints(VoiceGender.Female);
        }

        private void AiWindow_Load(object sender, EventArgs e) {

        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {


            string plInput = e.Result.Text;
            string aiOutput = string.Empty;

            Dictionary<string, string> list = methods.programmList();
            foreach (KeyValuePair<string, string> kv in list) {
                if (plInput.Equals("Öffne " + kv.Key)) {
                    System.Diagnostics.Process.Start(kv.Value);
                    aiOutput = kv.Key + " wird geöffnet";
                }
            }

            switch (plInput) {
                case ("Hallo"):
                    aiOutput = "Hallo, mein Name ist Maria ";
                    break;

                case ("Pause"):
                    aiOutput = "";
                    keybd_event(PauseTrack, 1, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;

                case ("Leiser"):
                    aiOutput = "";
                    keybd_event(PauseTrack, 1, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;

                case ("Nächstes"):
                    aiOutput = "";
                    keybd_event(NextTrack, 1, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;

                case ("Weiter"):
                    aiOutput = "";
                    keybd_event(NextTrack, 1, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;

                case ("Zurück"):
                    aiOutput = "";
                    keybd_event(PreviousTrack, 1, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;
            }
            speech.SpeakAsync(aiOutput);
            txtBoxAiOutput.Text = aiOutput;
        }

        private void button1_Click(object sender, EventArgs e) {
            AIAddNewWindow aIAddNewWindow = new AIAddNewWindow();
            aIAddNewWindow.Show();
        }
    }
}
