using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using Timer = System.Windows.Forms.Timer;

namespace Karaoke
{
    public partial class Form1 : Form
    {
        private readonly List<(double time, string lyric)> lyrics = new();
        private int currentLine;
        private readonly Timer lyricTimer = new() { Interval = 100 };

        public Form1()
        {
            InitializeComponent();
            lyricTimer.Tick += LyricTimer_Tick;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "Audio Files|*.mp3;*.wav" };
            if (ofd.ShowDialog() == DialogResult.OK && axWindowsMediaPlayer1 != null)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                currentLine = 0;
                lbllyric.Text = lyrics.Count > 0 ? lyrics[0].lyric : "";
                lyricTimer.Start();
            }
            else
            {
                MessageBox.Show("Lỗi: Trình phát nhạc chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLyricsFromFile(string fileName)
        {
            lyrics.Clear();

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy file lyric!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbllyric.Text = "Không có lời";
                return;
            }

            foreach (string line in File.ReadAllLines(fileName))
            {
                Match match = Regex.Match(line, @"\[(\d+):(\d+\.\d+)\](.*)");
                if (match.Success)
                {
                    string lyricText = match.Groups[3].Value.Trim();
                    if (!string.IsNullOrEmpty(lyricText))
                    {
                        lyrics.Add((int.Parse(match.Groups[1].Value) * 60 + double.Parse(match.Groups[2].Value), lyricText));
                    }
                }
            }
            lyrics.Sort((a, b) => a.time.CompareTo(b.time));
            currentLine = 0;
            lbllyric.Text = lyrics.Count > 0 ? lyrics[0].lyric : "Không có lời";
        }

        private void LyricTimer_Tick(object sender, EventArgs e)
        {
            if (lyrics.Count == 0 || axWindowsMediaPlayer1?.playState != WMPPlayState.wmppsPlaying)
            {
                return;
            }

            double currentTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            while (currentLine < lyrics.Count - 1 && currentTime >= lyrics[currentLine + 1].time)
            {
                currentLine++;
                lbllyric.Text = lyrics[currentLine].lyric;
                lbllyric.ForeColor = Color.Orange;
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState is 8 or 1)
            {
                lyricTimer.Stop();
                lbllyric.Text = " ";
            }
        }

        private void btnexit_Click(object sender, EventArgs e) => Application.Exit();

        private void buttonLoi_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialogLyric = new() { Filter = "Lyric Files (*.lrc)|*.lrc|All Files (*.*)|*.*", Title = "Chọn file lời bài hát" };
            if (openFileDialogLyric.ShowDialog() == DialogResult.OK)
            {
                LoadLyricsFromFile(openFileDialogLyric.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}