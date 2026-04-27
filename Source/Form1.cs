/////////////////////////////////////////////////////////////////////////////////////
//  File:   Form1.cs                                                10 Feb 26 PHR
/////////////////////////////////////////////////////////////////////////////////////

namespace TextToSpeechBuilder;

using System.Diagnostics;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;

public partial class Form1 : Form
{
    private int m_PrependMilliSeconds = 0;
    private string m_Text = string.Empty;
    private int m_AppendMilliSeconds = 0;
    private string m_FilePath = string.Empty;
    private int m_SampleRate = 8000;
    private VoiceGender m_VoiceGender = VoiceGender.Female;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        string strVer = System.Reflection.Assembly.GetEntryAssembly()!.GetName()!.Version!.ToString();
        Text += $" -- Version: {strVer}";

        PrependSilenceMilliSecondsTb.Text = m_PrependMilliSeconds.ToString();
        AppendSilenceMilliSecondsTb.Text = m_AppendMilliSeconds.ToString();
        SampleRateCombo.SelectedIndex = 0;      // Selects 8000 samples/second
        VoiceCombo.SelectedIndex = 0;           // Selects Female
    }

    private void Browse_Click(object sender, EventArgs e)
    {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = "WAV files (*.wav)|*.wav";
        DialogResult result = sfd.ShowDialog();
        if (result == DialogResult.OK)
            FileTb.Text = sfd.FileName;
    }

    private bool GetSettings()
    {
        if (int.TryParse(PrependSilenceMilliSecondsTb.Text, out m_PrependMilliSeconds) == false ||
            m_PrependMilliSeconds < 0)
        {
            MessageBox.Show("The Prepend Silence setting must be an integer greater than or equal to 0 and less than " +
                $"{int.MaxValue}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            PrependSilenceMilliSecondsTb.Focus();
            return false;
        }

        if (int.TryParse(AppendSilenceMilliSecondsTb.Text, out m_AppendMilliSeconds) == false ||
            m_AppendMilliSeconds < 0)
        {
            MessageBox.Show("The Append Silence setting must be an integer greater than or equal to 0 and less than " +
                $"{int.MaxValue}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AppendSilenceMilliSecondsTb.Focus();
            return false;
        }

        if (string.IsNullOrEmpty(SpeechTextTb.Text) == true)
        {
            MessageBox.Show("No text provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SpeechTextTb.Focus();
            return false;
        }

        m_Text = SpeechTextTb.Text;

        if (string.IsNullOrEmpty(FileTb.Text) == true)
        {
            MessageBox.Show("A *.wav file name must be specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        switch (SampleRateCombo.SelectedIndex)
        {
            case 0:
                m_SampleRate = 8000;
                break;
            case 1:
                m_SampleRate = 16000;
                break;
            default:
                m_SampleRate = 8000;
                break;
        }

        switch (VoiceCombo.SelectedIndex)
        {
            case 0:
                m_VoiceGender = VoiceGender.Female;
                break;
            case 1:
                m_VoiceGender = VoiceGender.Male;
                break;
            default:
                m_VoiceGender = VoiceGender.Female;
                break;
        }

        m_FilePath = FileTb.Text;

        return true;
    }

    private void CreateBtn_Click(object sender, EventArgs e)
    {
        if (GetSettings() == false)
            return;     // Error message displayed

        CreateSpeechFile(m_PrependMilliSeconds, m_Text, m_AppendMilliSeconds, m_SampleRate, m_VoiceGender,
            m_FilePath);
    }

    private void CreateSpeechFile(int PrependMilliseconds, string Text, int AppendMilliseconds,
        int SampleRate, VoiceGender VoiceGender, string FilePath)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        try
        {
            synth.SetOutputToWaveFile(FilePath,
                new SpeechAudioFormatInfo(SampleRate, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
            synth.SelectVoiceByHints(VoiceGender);

            PromptBuilder builder = new PromptBuilder();
            builder.AppendBreak(TimeSpan.FromMilliseconds(PrependMilliseconds));

            builder.AppendText(Text);
            builder.AppendBreak(TimeSpan.FromMilliseconds(AppendMilliseconds));

            // Speak the prompt into the file.
            synth.Speak(builder);

            MessageBox.Show("Speech file successfully created", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while creating the speech file. Error Message:\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            synth.Dispose();
        }
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void HelpBtn_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new ProcessStartInfo("https://phrsite.github.io/TextToSpeechBuilder")
        {
            UseShellExecute = true
        };

        Process.Start(psi);
    }
}
